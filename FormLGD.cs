using MongoDB.Bson;
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
    public partial class FormLGD : UserControl
    {
        IMongoCollection<Semester> Semesters;
        IMongoCollection<Teacher> Teachers;
        IMongoCollection<Class> Classes;
        ICollection<Class> ClassesOnThisSemester;

        List<KeyValuePair<string, List<DateTime>>> ListOfDaysOfClasses;

        private Semester Semester;
        private Account Account;
        private int CurrentMonth;
        private int CurrentYear;

        private string regexTeacherIdName = "";
        private string currentTeacherId = "";
        public FormLGD()
        {
            Semesters = Login.Semesters;
            Teachers = Login.Teachers;
            Classes = Login.Classes;
            Account = Login.Account;
            ListOfDaysOfClasses = new List<KeyValuePair<string, List<DateTime>>>();
            InitializeComponent();
            InitializePanelFindTeacherForAdmin();
            LoadMonthAndYearLabel();
            LoadComboBoxAndFirstSemester();

            Size = MainForm.PanelControlSize;
        }
        private void InitializePanelFindTeacherForAdmin()
        {
            if (Account.Role.Equals("Admin"))
            {
                panelFindTeacher.Visible = true;
            }
        }
        private void FindTeacherByNameOrMSGV(object sender, EventArgs e)
        {
            FilterDefinition<Account> filterAccount;
            filterAccount = regexTeacherIdName.All(char.IsDigit) ?
                            Builders<Account>.Filter
                            .Regex(t => t.AccountId, new BsonRegularExpression($".*{regexTeacherIdName}.*", "i")) :
                            Builders<Account>.Filter
                            .Regex(t => t.Name, new BsonRegularExpression($".*{regexTeacherIdName}.*", "i"));
            var resultAccount = Login.Accounts.Find(filterAccount).ToList();
            List<string> foundTeachers = new List<string>();
            foreach (var account in resultAccount)
            {
                var filterTeacher = Builders<Teacher>.Filter.Eq(t => t.AccountId, account.AccountId);
                var resultTeacher = Teachers.Find(filterTeacher).FirstOrDefault();
                if (resultTeacher != null)
                {
                    foundTeachers.Add($"{resultTeacher.AccountId} - {account.Name}");
                }
            }
            cbTeacherResult.DataSource = foundTeachers;
        }
        private void OnChooseTeacherToViewSchedule(object sender, EventArgs e)
        {
            currentTeacherId = cbTeacherResult.Texts.Split(" - ")[0];
            LoadSemesterInfo(sender, e);
        }
        private void LoadMonthAndYearLabel()
        {
            lblMonth.Text = CurrentMonth.ToString();
            lblYear.Text = CurrentYear.ToString();
        }
        private void ReloadSemesters(object sender, EventArgs e)
        {
            LoadComboBoxAndFirstSemester();
        }
        private void LoadComboBoxAndFirstSemester()
        {
            var filterSemester = Builders<Semester>.Filter.Empty;
            var resultSemester = Semesters.Find(filterSemester).ToList();
            if (resultSemester.Count > 0)
            {
                txtBoxSemesterId.DataSource = resultSemester;
                txtBoxSemesterId.DisplayMember = "SemesterId";
                txtBoxSemesterId.ValueMember = "SemesterId";
                Semester = resultSemester.FirstOrDefault();
                CurrentMonth = Semester.StartDate.Month;
                CurrentYear = Semester.StartDate.Year;
                LoadMonthAndYearLabel();
                InitializeDataDaysOfMonthView(CurrentMonth, CurrentYear);
                txtBoxSemesterId.Texts = Semester.SemesterId;
            }
        }
        private void LoadSemesterInfo(object sender, EventArgs e)
        {
            var filterSemester = Builders<Semester>.Filter.Eq(s => s.SemesterId, ((Semester)txtBoxSemesterId.SelectedItem).SemesterId);
            var resultSemester = Semesters.Find(filterSemester).FirstOrDefault();
            if (resultSemester != null)
            {
                Semester = resultSemester;
                CurrentMonth = Semester.StartDate.Month;
                CurrentYear = Semester.StartDate.Year;
                LoadMonthAndYearLabel();

                FilterDefinition<Class> filterClasses;
                filterClasses = Account.Role.Equals("Admin")                                        ?
                                cbTeacherResult.Texts.Equals("")                                    ?
                                Builders<Class>.Filter.Eq(c => c.SemesterId, Semester.SemesterId)   :
                                Builders<Class>.Filter.Eq(c => c.SemesterId, Semester.SemesterId)   &
                                Builders<Class>.Filter.Eq(c => c.TeacherId, currentTeacherId)       :
                                Builders<Class>.Filter.Eq(c => c.SemesterId, Semester.SemesterId)   &
                                Builders<Class>.Filter.Eq(c => c.TeacherId, Account.AccountId);
                ClassesOnThisSemester = Classes.Find(filterClasses).ToList();
                if (ClassesOnThisSemester != null)
                {
                    ListOfDaysOfClasses = new List<KeyValuePair<string, List<DateTime>>>();
                    foreach (var c in ClassesOnThisSemester)
                    {
                        var classDays = GetAllDaysOfClassInSemester(c);
                        if (classDays.Count != 0)
                        {
                            ListOfDaysOfClasses.Add(new KeyValuePair<string, List<DateTime>>(c.ClassId, classDays));
                        }
                    }
                }
                InitializeDataDaysOfMonthView(Semester.StartDate.Month, Semester.StartDate.Year);
            }
        }
        private void InitializeDataDaysOfMonthView(int month, int year)
        {
            dataViewDaysOfMonth.Rows.Clear();
            dataViewDaysOfMonth.Columns.Clear();
            dataViewDaysOfMonth.Refresh();
            dataViewDaysOfMonth.Columns.Add("columnMonday", "Thứ hai");
            dataViewDaysOfMonth.Columns.Add("columnTuesday", "Thứ ba");
            dataViewDaysOfMonth.Columns.Add("columnWednesday", "Thứ tư");
            dataViewDaysOfMonth.Columns.Add("columnThursday", "Thứ năm");
            dataViewDaysOfMonth.Columns.Add("columnFriday", "Thứ sáu");
            dataViewDaysOfMonth.Columns.Add("columnSaturday", "Thứ bảy");
            dataViewDaysOfMonth.Columns.Add("columnSunday", "CN");

            DateTime firstDay = new DateTime(year, month, 1);
            DayOfWeek firstDateOfMonth = firstDay.DayOfWeek;

            int maxDays = DateTime.DaysInMonth(year, month);
            int columnIndex = 0;
            if (firstDateOfMonth == DayOfWeek.Sunday)
                columnIndex = 6;
            else
                columnIndex = (int)firstDateOfMonth - 1;
            int rowIndex = dataViewDaysOfMonth.Rows.Add();
            for (int i = 1; i <= maxDays; i++)
            {
                //string dayToShow = $"{i.ToString()}/{CurrentMonth}/{CurrentYear}";
                DateTime dayToShow = new DateTime(CurrentYear, CurrentMonth, i);
                foreach (Class c in ClassesOnThisSemester)
                {
                    if (GetAllDaysOfClassInSemester(c).Contains(dayToShow))
                    {
                        Color color = new Color();
                        if (columnIndex == 0 || columnIndex == 3)
                        {
                            color = Color.Coral;
                        }
                        else if (columnIndex == 1 || columnIndex == 4)
                        {
                            color = ColorTranslator.FromHtml("#D32F2F");
                        }
                        else if (columnIndex == 2 || columnIndex == 5)
                        {
                            color = ColorTranslator.FromHtml("#228B22");
                        }
                        dataViewDaysOfMonth.Rows[rowIndex].Cells[columnIndex].Style.ForeColor = color;
                    }
                }
                dataViewDaysOfMonth.Rows[rowIndex].Cells[columnIndex].Value = i.ToString();
                columnIndex++;
                if (columnIndex == 7)
                {
                    columnIndex = 0;
                    rowIndex = dataViewDaysOfMonth.Rows.Add();
                }
            }
            // Xóa (bỏ background color) của các cell có gt null
            foreach (DataGridViewRow row in dataViewDaysOfMonth.Rows)
            {
                row.Height += 20;
                foreach (DataGridViewColumn column in dataViewDaysOfMonth.Columns)
                {
                    if (dataViewDaysOfMonth.Rows[row.Index].Cells[column.Index].Value == null)
                    {
                        dataViewDaysOfMonth.Rows[row.Index].Cells[column.Index].Style.BackColor = Color.FromArgb(224, 224, 224);
                    }
                }
            }
            // Disable sort
            foreach (DataGridViewColumn column in dataViewDaysOfMonth.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void ChooseDayToViewSchedule(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewDaysOfMonth.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                //dataViewDaysOfMonth.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Coral;
                return;
            }
            if (e.RowIndex < 0)
            {
                return;
            }
            //string dayToShow = $"{dataViewDaysOfMonth.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()}/{CurrentMonth}/{CurrentYear}";
            //MessageBox.Show(dayToShow);
            DateTime dayToView = new DateTime(CurrentYear, CurrentMonth, Convert.ToInt32(dataViewDaysOfMonth.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
            panelSchedule.Controls.Clear();
            foreach (var d in ListOfDaysOfClasses)
            {
                if (d.Value.Contains(dayToView))
                {
                    var filterClassToShowSchedule = Builders<Class>.Filter.Eq(c => c.ClassId, d.Key);
                    var resultClass = Classes.Find(filterClassToShowSchedule).FirstOrDefault();
                    panelSchedule.Controls.Add(new ScheduleDisplay(resultClass.Name, resultClass.From, resultClass.To, resultClass.Room));
                    continue;
                }
            }

        }

        private void ToNextMonth(object sender, EventArgs e)
        {
            if (CurrentMonth >= 12)
            {
                CurrentMonth = 1;
                CurrentYear++;
                LoadMonthAndYearLabel();
                InitializeDataDaysOfMonthView(CurrentMonth, CurrentYear);
                return;
            }
            if (CurrentMonth + 1 > Semester.EndDate.Month && CurrentYear == Semester.EndDate.Year)
            {
                return;
            }
            CurrentMonth++;
            LoadMonthAndYearLabel();
            InitializeDataDaysOfMonthView(CurrentMonth, CurrentYear);
        }
        private void ToPreviousMonth(object sender, EventArgs e)
        {
            if (CurrentMonth <= 1)
            {
                CurrentMonth = 12;
                CurrentYear--;

                LoadMonthAndYearLabel();
                InitializeDataDaysOfMonthView(CurrentMonth, CurrentYear);
                return;
            }
            if (CurrentMonth - 1 < Semester.StartDate.Month && CurrentYear == Semester.StartDate.Year)
            {
                return;
            }
            CurrentMonth--;
            LoadMonthAndYearLabel();
            InitializeDataDaysOfMonthView(CurrentMonth, CurrentYear);
        }
        private List<DateTime> GetAllDaysOfClassInSemester(Class c)
        {
            List<DateTime> days = new List<DateTime>();
            if (Semester.Type.Equals("sub"))
            {
                List<DayOfWeek> classSchedules = new List<DayOfWeek>();
                foreach (string dow in c.DayOfWeek.Split(", "))
                {
                    classSchedules.Add(TranslateDayOfWeek(dow));
                }
                for (DateTime from = Semester.StartDate; from <= Semester.EndDate; from = from.AddDays(1))
                {
                    if (classSchedules.Contains(from.DayOfWeek))
                    {
                        var d = new DateTime(from.Year, from.Month, from.Day);
                        days.Add(d);
                    }
                }
                return days;
            }

            DayOfWeek classSchedule = TranslateDayOfWeek(c.DayOfWeek);
            for (DateTime from = Semester.StartDate; from <= Semester.EndDate; from = from.AddDays(1))
            {
                if (from.DayOfWeek == classSchedule)
                {
                    var d = new DateTime(from.Year, from.Month, from.Day);
                    days.Add(d);
                }
            }
            return days;
        }
        public static DayOfWeek TranslateDayOfWeek(string dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case "Mon":
                    return DayOfWeek.Monday;
                case "Tue":
                    return DayOfWeek.Tuesday;
                case "Wed":
                    return DayOfWeek.Wednesday;
                case "Thu":
                    return DayOfWeek.Thursday;
                case "Fri":
                    return DayOfWeek.Friday;
                case "Sat":
                    return DayOfWeek.Saturday;
                case "Sun":
                    return DayOfWeek.Sunday;
                default:
                    return DayOfWeek.Sunday;
            }
        }
    }
}
