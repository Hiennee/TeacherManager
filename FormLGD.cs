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
        //List<List<KeyValuePair<string, DateTime>>> ScheduleOfClasses;

        private Semester Semester;

        private int CurrentMonth;
        private int CurrentYear;
        public FormLGD()
        {
            Semesters = Login.Semesters;
            Teachers = Login.Teachers;
            Classes = Login.Classes;

            InitializeComponent();
            LoadMonthAndYearLabel();
            LoadComboBoxAndInitFirstSemester();
            //InitializeDataDaysOfMonthView(SemesterStartMonth, SemesterStartYear);

            Size = MainForm.PanelControlSize;
        }
        private void LoadMonthAndYearLabel()
        {
            lblMonth.Text = CurrentMonth.ToString();
            lblYear.Text = CurrentYear.ToString();
        }
        private void LoadComboBoxAndInitFirstSemester()
        {
            var filterSemester = Builders<Semester>.Filter.Empty;
            var resultSemester = Semesters.Find(filterSemester).ToList();
            if (resultSemester != null)
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
            //var sem = ((Semester)txtBoxSemesterId.SelectedItem).SemesterId;
            var filterSemester = Builders<Semester>.Filter.Eq(s => s.SemesterId, ((Semester)txtBoxSemesterId.SelectedItem).SemesterId);
            var resultSemester = Semesters.Find(filterSemester).FirstOrDefault();
            if (resultSemester != null)
            {
                Semester = resultSemester;
                CurrentMonth = Semester.StartDate.Month;
                CurrentYear = Semester.StartDate.Year;
                LoadMonthAndYearLabel();
                var filterClasses = Builders<Class>.Filter.Eq(c => c.SemesterId, Semester.SemesterId);
                ClassesOnThisSemester = Classes.Find(filterClasses).ToList();
                foreach (var c in ClassesOnThisSemester)
                {
                    GetAllDaysOfClassInSemester(c);
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
                        //MessageBox.Show(dayToShow.ToShortDateString());
                        dataViewDaysOfMonth.Rows[rowIndex].Cells[columnIndex].Style.ForeColor = Color.Coral;
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
            string dayToShow = $"{dataViewDaysOfMonth.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()}/{CurrentMonth}/{CurrentYear}";
            //if ()
            MessageBox.Show(dayToShow);
                            
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
            DayOfWeek classSchedule = TranslateDayOfWeek(c.DayOfWeek);
            for (DateTime from = Semester.StartDate; from <= Semester.EndDate; from = from.AddDays(1))
            {
                if (from.DayOfWeek == classSchedule)
                {
                    var a = new DateTime(from.Year, from.Month, from.Day);
                    days.Add(a);
                }
            }
            return days;
        }
        private static DayOfWeek TranslateDayOfWeek(string dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case "Thứ hai":
                    return DayOfWeek.Monday;
                case "Thứ ba":
                    return DayOfWeek.Tuesday;
                case "Thứ tư":
                    return DayOfWeek.Wednesday;
                case "Thứ năm":
                    return DayOfWeek.Thursday;
                case "Thứ sáu":
                    return DayOfWeek.Friday;
                case "Thứ bảy":
                    return DayOfWeek.Saturday;
                case "Chủ nhật":
                    return DayOfWeek.Sunday;
                default:
                    return DayOfWeek.Sunday;
            }
        }
    }
}
