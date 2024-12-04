using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManager.Models;

namespace TeacherManager
{
    public partial class FormCreateClass : Form
    {
        IMongoCollection<Account> Accounts;
        IMongoCollection<Student> Students;
        IMongoCollection<Teacher> Teachers;
        IMongoCollection<Class> Classes;
        IMongoCollection<Faculty> Faculties;

        Semester semester;

        private string semesterType;
        public FormCreateClass(Semester s)
        {
            InitializeComponent();
            Accounts = Login.Accounts;
            Students = Login.Students;
            Teachers = Login.Teachers;
            Classes = Login.Classes;
            Faculties = Login.Faculties;
            semester = s;
            semesterType = s.Type;
            numericGradeWeight1.Value = 20;
            numericGradeWeight2.Value = 20;
            numericGradeWeight3.Value = 20;
            numericGradeWeight4.Value = 40;
            txtBoxSemesterId.Texts = semester.SemesterId;
            InitializeComboBoxFaculty();
            InitializeComboBoxRoom();
            LoadDayOfWeeksComboBox();
        }
        private void LoadDayOfWeeksComboBox()
        {
            cbDayOfWeek.DataSource = semesterType.Equals("main") ?
                                     new List<string>()
                                     {
                                         "Thứ hai",
                                         "Thứ ba",
                                         "Thứ tư",
                                         "Thứ năm",
                                         "Thứ sáu",
                                         "Thứ bảy",
                                     } :
                                     new List<string>()
                                     {
                                         "2, 4, 6",
                                         "3, 5, 7",
                                     };
        }
        private void InitializeComboBoxFaculty()
        {
            List<Faculty> faculties = new List<Faculty>();
            List<string> cbData = new List<string>() { "" };
            var resultFaculties = Faculties.Find(Builders<Faculty>.Filter.Empty).ToList();
            foreach (Faculty f in resultFaculties)
            {
                faculties.Add(f);
                cbData.Add(f.FacultyId + " - " + f.Name);
            }
            cbFaculty.DataSource = cbData;
        }
        private void OnFacultyChange(object sender, EventArgs e)
        {
            CheckAddClassButtonAvailable(sender, e);
            txtBoxPrefix.Texts = cbFaculty.Texts.Split(" - ")[0];
            InitializeComboBoxTeacher();
        }
        private void InitializeComboBoxTeacher()
        {
            List<Teacher> teachers = new List<Teacher>();
            List<string> cbData = new List<string> { "" };
            var resultTeachers = Teachers.Find(Builders<Teacher>.Filter.Eq(
                                 t => t.FacultyId, cbFaculty.Texts.Split(" - ")[0])).ToList();
            foreach (Teacher t in resultTeachers)
            {
                var teacher = Accounts.Find(Builders<Account>.Filter.Eq(a => a.AccountId, t.AccountId))
                                          .FirstOrDefault();
                cbData.Add(t.AccountId + " - " + teacher.Name);
            }
            cbTeacher.DataSource = cbData;
        }
        private void InitializeComboBoxRoom()
        {
            List<int> rooms = new List<int>();
            for (int i = 1; i <= 30; i++)
            {
                rooms.Add(i);
            }
            cbRoom.DataSource = rooms;
        }
        public void CheckAddClassButtonAvailable(object sender, EventArgs e)
        {
            if (txtBoxClassId.Texts.Equals("") || txtBoxSemesterId.Texts.Equals("") ||
                cbTeacher.Texts.Equals("") || txtBoxClassName.Texts.Equals("") ||
                cbFaculty.Texts.Equals("") || cbDayOfWeek.Texts.Equals("") ||
                cbRoom.Texts.Equals(""))
            {
                btnAddStudent.Enabled = false;
            }
            else
            {
                btnAddStudent.Enabled = true;
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void AddClass(object sender, EventArgs e)
        {
            if (txtBoxClassId.Texts.Equals(""))
            {
                MessageBox.Show("Mã học phần không được để trống", "Thông báo");
                return;
            }
            if (txtBoxClassName.Texts.Equals(""))
            {
                MessageBox.Show("Tên học phần không được để trống", "Thông báo");
                return;
            }
            if (cbFaculty.Texts.Equals(""))
            {
                MessageBox.Show("Bộ môn không được để trống", "Thông báo");
                return;
            }
            if (cbRoom.Texts.Equals(""))
            {
                MessageBox.Show("Số phòng không được để trống", "Thông báo");
                return;
            }
            string classId = txtBoxPrefix.Texts + txtBoxClassId.Texts;
            var ClassIdFilter = Builders<Class>.Filter.Eq(c => c.ClassId, classId) &
                                Builders<Class>.Filter.Eq(c => c.SemesterId, semester.SemesterId);
            var ClassIdExist = Classes.Find(ClassIdFilter).Any();
            if (ClassIdExist)
            {
                MessageBox.Show($"Số hiệu lớp đã tồn tại trong học kì {semester.SemesterId}", "Thông báo");
                return;
            }
            var TeacherIdFilter = Builders<Teacher>.Filter.Eq(t => t.AccountId, cbTeacher.Texts.Split(" - ")[0]);
            var TeacherIdExist = Teachers.Find(TeacherIdFilter).Any();
            if (!TeacherIdExist)
            {
                MessageBox.Show("Mã số giảng viên không hợp lệ", "Thông báo");
                return;
            }
            int grade01_weight = Convert.ToInt32(numericGradeWeight1.Value);
            int grade02_weight = Convert.ToInt32(numericGradeWeight2.Value);
            int grade03_weight = Convert.ToInt32(numericGradeWeight3.Value);
            int grade04_weight = Convert.ToInt32(numericGradeWeight4.Value);
            if (grade01_weight + grade02_weight + grade03_weight + grade04_weight != 100)
            {
                MessageBox.Show("Điểm thành phần không hợp lệ", "Thông báo");
                return;
            }
            int fromHour = Convert.ToInt32(numericFromHour.Value);
            int fromMinute = Convert.ToInt32(numericFromMinute.Value);
            int toHour = Convert.ToInt32(numericToHour.Value);
            int toMinute = Convert.ToInt32(numericToMinute.Value);
            if ((toHour == fromHour && toMinute <= fromMinute) || toHour - fromHour <= 0)
            {
                MessageBox.Show("Thời gian không hợp lệ", "Thông báo");
                return;
            }
            
            string from = GenerateStringHour(fromHour, fromMinute);
            string to = GenerateStringHour(toHour, toMinute);
            if (IsConflictClassSchedule(txtBoxSemesterId.Texts, cbRoom.Texts, from, to, cbDayOfWeek.Texts))
            {
                MessageBox.Show("Thời gian trùng với lớp khác", "Thông báo");
                return;
            }
            Class c = new Class
            {
                ClassId = classId,
                SemesterId = semester.SemesterId,
                TeacherId = cbTeacher.Texts.Split(" - ")[0],
                FacultyId = cbFaculty.Texts.Split(" - ")[0],
                DayOfWeek = cbDayOfWeek.Texts.Replace("Thứ hai", "Mon").Replace("2", "Mon")
                                             .Replace("Thứ ba", "Tue").Replace("3", "Tue")
                                             .Replace("Thứ tư", "Wed").Replace("4", "Wed")
                                             .Replace("Thứ năm", "Thu").Replace("5", "Thu")
                                             .Replace("Thứ sáu", "Fri").Replace("6", "Fri")
                                             .Replace("Thứ bảy", "Sat").Replace("7", "Sat"),
                From = from,
                To = to,
                Name = txtBoxClassName.Texts,
                Room = cbRoom.Texts,
                Grade01_weight = grade01_weight,
                Grade02_weight = grade02_weight,
                Grade03_weight = grade03_weight,
                Grade04_weight = grade04_weight,
            };
            Classes.InsertOne(c);
            this.DialogResult = DialogResult.OK;
            Close();
        }
        private bool IsConflictClassSchedule(string semesterId, string room, string from, string to, string dow)
        {
            bool IsConflictHour(string from1, string to1, string from2, string to2)
            {
                double ParseTime(string time)
                {
                    var parts = time.Split(":");
                    int hours = Convert.ToInt32(parts[0]);
                    int minutes = Convert.ToInt32(parts[1]);
                    return hours + (minutes / 60.0);
                }
                double start1 = ParseTime(from1);
                double end1 = ParseTime(to1);
                double start2 = ParseTime(from2);
                double end2 = ParseTime(to2);

                return start1 < end2 && start2 < end1;
            }

            DayOfWeek dayOfWeek = FormLGD.TranslateDayOfWeek(dow);
            var classConflictFilter = Builders<Class>.Filter.Eq(c => c.DayOfWeek, dayOfWeek.ToString().Substring(0, 3)) &
                                      Builders<Class>.Filter.Eq(c => c.Room, room)     &
                                      Builders<Class>.Filter.Eq(c => c.SemesterId, semesterId);
            var classConflictResult = Classes.Find(classConflictFilter).FirstOrDefault();

            if (classConflictResult == null)
            {
                return false;
            }
            return IsConflictHour(GenerateStringHour(Convert.ToInt16(numericFromHour.Value), Convert.ToInt16(numericFromMinute.Value)),
                                  GenerateStringHour(Convert.ToInt16(numericToHour.Value), Convert.ToInt16(numericToMinute.Value)),
                                  classConflictResult.From, classConflictResult.To);
            // true: conflict; false: 0 conflict
        }
        
        public static string GenerateStringHour(int hour, int minute)
        {
            return (hour < 10 ? "0" + hour.ToString() : hour.ToString()) 
                + ":" +
                (minute < 10 ? "0" + minute.ToString() : minute.ToString());
        }
    }
}
