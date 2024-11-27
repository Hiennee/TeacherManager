using ClosedXML.Excel;
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
    public partial class FormSemesterDescription : Form
    {
        private Semester semester;
        private Account account;
        private IMongoCollection<Class> Classes;
        private IMongoCollection<Teacher> Teachers;
        private IMongoCollection<Account> Accounts;
        private IMongoCollection<Student_Class_Detail> StudentClasses;

        public FormSemesterDescription(Semester s)
        {
            semester = s;
            account = Login.Account;
            Classes = Login.Classes;
            Accounts = Login.Accounts;
            Teachers = Login.Teachers;
            StudentClasses = Login.StudentClasses;
            InitializeComponent();
            InitializeLabels();
            CheckButtonAddClassVisible();
            InitializeDataGridView();
            InitializeSemestersData();
        }
        private void InitializeLabels()
        {
            lblSemester.Text = "Học kỳ " + semester.SemesterId;
        }
        private void CheckButtonAddClassVisible()
        {
            if (!account.Role.Equals("Admin"))
            {
                btnAddClass.Visible = false;
            }
        }
        private void ExitSemesterDescriptionForm(object sender, EventArgs e)
        {
            Close();
        }
        private void InitializeDataGridView()
        {
            dataViewSemester.Columns.Add("columnClassId", "Mã HP");
            dataViewSemester.Columns.Add("columnClassName", "Tên học phần");
            dataViewSemester.Columns.Add("columnTeacherName", "Giảng viên");
            dataViewSemester.Columns.Add("columnStudentNumber", "Sĩ số");
            dataViewSemester.Columns.Add("columnDayOfWeek", "TKB");
            dataViewSemester.Columns.Add("columnRoom", "Phòng");

            dataViewSemester.Columns["columnClassId"].Width += 50;
            dataViewSemester.Columns["columnClassName"].Width += 150;
            dataViewSemester.Columns["columnTeacherName"].Width += 70;
            dataViewSemester.Columns["columnDayOfWeek"].Width += 50;

            foreach (DataGridViewColumn column in dataViewSemester.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void InitializeSemestersData()
        {
            dataViewSemester.Rows.Clear();

            FilterDefinition<Class> filterClassesInSemester;
            filterClassesInSemester = Builders<Class>.Filter.Eq(c => c.SemesterId, semester.SemesterId);
            //filterClassesInSemester = account.Role.Equals("Admin") ?
            //                          Builders<Class>.Filter.Eq(c => c.SemesterId, semester.SemesterId) :
            //                          Builders<Class>.Filter.Eq(c => c.SemesterId, semester.SemesterId) &
            //                          Builders<Class>.Filter.Eq(c => c.TeacherId, account.AccountId);
            var resultClassesInSemester = Classes.Find(filterClassesInSemester).ToList();
            if (resultClassesInSemester.Any())
            {
                foreach (var c in resultClassesInSemester)
                {
                    int rowIndex = dataViewSemester.Rows.Add();
                    var filterTeacherName = Builders<Account>.Filter.Eq(a => a.AccountId, c.TeacherId);
                    //var filterTeacherName = account.Role.Equals("Admin") ? 
                    //                        Builders<Account>.Filter.Eq(a => a.AccountId, c.TeacherId) :
                    //                        Builders<Account>.Filter.Empty;
                    var resultTeacher = Accounts.Find(filterTeacherName).FirstOrDefault();
                    var filterStudentsInClass = Builders<Student_Class_Detail>.Filter.Eq(scd => scd.ClassId, c.ClassId);
                    int resultStudentsInClass = StudentClasses.Find(filterStudentsInClass).ToList().Count;
                    if (resultTeacher != null)
                    {
                        dataViewSemester.Rows[rowIndex].Cells["columnClassId"].Value = c.ClassId;
                        dataViewSemester.Rows[rowIndex].Cells["columnClassName"].Value = c.Name;
                        dataViewSemester.Rows[rowIndex].Cells["columnTeacherName"].Value = resultTeacher.Name;
                        dataViewSemester.Rows[rowIndex].Cells["columnStudentNumber"].Value = resultStudentsInClass;
                        dataViewSemester.Rows[rowIndex].Cells["columnDayOfWeek"].Value = c.DayOfWeek
                                                                                         .Replace("Mon, Wed, Fri", "Thứ 2, Thứ 4, Thứ 6")
                                                                                         .Replace("Tue, Thu, Sat", "Thứ 3, Thứ 5, Thứ 7")
                                                                                         .Replace("Mon", "Thứ hai")
                                                                                         .Replace("Tue", "Thứ ba")
                                                                                         .Replace("Wed", "Thứ tư")
                                                                                         .Replace("Thu", "Thứ năm")
                                                                                         .Replace("Fri", "Thứ sáu")
                                                                                         .Replace("Sat", "Thứ bảy")
                                                                                         .Replace("Sun", "Chủ nhật");
                        dataViewSemester.Rows[rowIndex].Cells["columnRoom"].Value = c.Room;
                    }
                }
            }
        }
        private void ExportSemesterDataToExcel(object sender, EventArgs e)
        {
            if (dataViewSemester.RowCount == 0)
            {
                MessageBox.Show("Không đủ dữ liệu để xuất file Excel", "Thông báo");
                return;
            }
            XLWorkbook workbook = new XLWorkbook();
            var dataTable = DataGridViewToDataTable(dataViewSemester);
            var asd = dataViewSemester;
            workbook.Worksheets.Add(dataTable, "Sheet1");


            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Lưu file Excel",
                FileName = $"{semester.SemesterId}_DSMH",
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
            }
        }
        private DataTable DataGridViewToDataTable(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            // Create columns in DataTable for each DataGridView column
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText, typeof(string));
            }

            // Loop through the DataGridView rows and add rows to DataTable
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow) // Ignore the last new row placeholder
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        dataRow[i] = row.Cells[i].Value?.ToString() ?? string.Empty;
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }
            return dataTable;
        }

        private void ShowAddClassForm(object sender, EventArgs e)
        {
            if (new FormCreateClass(semester).ShowDialog() == DialogResult.OK)
            {
                InitializeSemestersData();
            }
        }
    }
}
