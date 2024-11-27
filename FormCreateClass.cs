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
        Semester semester;

        private string semesterType;
        public FormCreateClass(Semester s)
        {
            InitializeComponent();
            Accounts = Login.Accounts;
            Students = Login.Students;
            Teachers = Login.Teachers;
            Classes = Login.Classes;
            semester = s;
            semesterType = s.Type;
            numericGradeWeight1.Value = 20;
            numericGradeWeight2.Value = 20;
            numericGradeWeight3.Value = 20;
            numericGradeWeight4.Value = 40;
            txtBoxSemesterId.Texts = semester.SemesterId;
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
        public void CheckAddStudentButtonAvailable(object sender, EventArgs e)
        {
            if (txtBoxClassId.Texts == "" || txtBoxSemesterId.Texts == "" ||
                txtBoxTeacherId.Texts == "" || txtBoxClassName.Texts == "" ||
                cbDayOfWeek.Texts == "" || txtBoxRoom.Texts == "")
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
            if (txtBoxClassId.Texts == "")
            {
                MessageBox.Show("Mã học phần không được để trống", "Thông báo");
                return;
            }
            if (txtBoxClassName.Texts == "")
            {
                MessageBox.Show("Tên học phần không được để trống", "Thông báo");
                return;
            }
            if (txtBoxRoom.Texts == "")
            {
                MessageBox.Show("Số phòng không được để trống", "Thông báo");
                return;
            }
            var ClassIdFilter = Builders<Class>.Filter.Eq(c => c.ClassId, txtBoxClassId.Texts) &
                                Builders<Class>.Filter.Eq(c => c.SemesterId, semester.SemesterId);
            var ClassIdExist = Classes.Find(ClassIdFilter).Any();
            if (ClassIdExist)
            {
                MessageBox.Show($"Số hiệu lớp đã tồn tại trong học kì {semester.SemesterId}", "Thông báo");
                return;
            }
            var TeacherIdFilter = Builders<Teacher>.Filter.Eq(t => t.AccountId, txtBoxTeacherId.Texts);
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
            Class c = new Class
            {
                ClassId = txtBoxClassId.Texts,
                SemesterId = semester.SemesterId,
                TeacherId = txtBoxTeacherId.Texts,
                DayOfWeek = cbDayOfWeek.Texts.Replace("Thứ hai", "Mon").Replace("2", "Mon")
                                             .Replace("Thứ ba", "Tue").Replace("3", "Tue")
                                             .Replace("Thứ tư", "Wed").Replace("4", "Wed")
                                             .Replace("Thứ năm", "Thu").Replace("5", "Thu")
                                             .Replace("Thứ sáu", "Fri").Replace("6", "Fri")
                                             .Replace("Thứ bảy", "Sat").Replace("7", "Sat"),
                From = from,
                To = to,
                Name = txtBoxClassName.Texts,
                Room = txtBoxRoom.Texts,
                Grade01_weight = grade01_weight,
                Grade02_weight = grade02_weight,
                Grade03_weight = grade03_weight,
                Grade04_weight = grade04_weight,
            };
            Classes.InsertOne(c);
            this.DialogResult = DialogResult.OK;
            Close();
        }
        private string GenerateStringHour(int hour, int minute)
        {
            return (hour < 10 ? "0" + hour.ToString() : hour.ToString()) 
                + ":" +
                (minute < 10 ? "0" + minute.ToString() : minute.ToString());
        }
    }
}
