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
        private IMongoCollection<Class> Classes;
        private IMongoCollection<Teacher> Teachers;
        private IMongoCollection<Account> Accounts;
        private IMongoCollection<Student_Class_Detail> StudentClasses;
        public FormSemesterDescription(Semester s)
        {
            semester = s;
            Classes = Login.Classes;
            Accounts = Login.Accounts;
            Teachers = Login.Teachers;
            StudentClasses = Login.StudentClasses;
            InitializeComponent();
            InitializeDataGridView();
            InitializeSemestersData();
        }

        private void ExitSemesterDescriptionForm(object sender, EventArgs e)
        {
            Close();
        }
        private void InitializeDataGridView()
        {
            dataViewSemester.Columns.Clear();

            dataViewSemester.Columns.Add("columnClassId", "Mã HP");
            dataViewSemester.Columns.Add("columnClassName", "Tên HP");
            dataViewSemester.Columns.Add("columnTeacherName", "Giảng viên");
            dataViewSemester.Columns.Add("columnStudentNumber", "Sĩ số");
            dataViewSemester.Columns.Add("columnDayOfWeek", "TKB");
            dataViewSemester.Columns.Add("columnRoom", "Phòng");

            //dataViewSemester.Columns["columnAvt"].ReadOnly = true;
            //dataViewSemester.Columns["columnMSSV"].ReadOnly = true;
            //dataViewSemester.Columns["columnFullName"].ReadOnly = true;
            //dataViewSemester.Columns["columnEmail"].ReadOnly = true;
            //dataViewSemester.Columns["columnGrade_total"].ReadOnly = true;
            //dataViewSemester.Columns["columnGrade01"].ReadOnly = false;
            //dataViewSemester.Columns["columnGrade02"].ReadOnly = false;
            //dataViewSemester.Columns["columnGrade03"].ReadOnly = false;
            //dataViewSemester.Columns["columnGrade04"].ReadOnly = false;

            //dataViewSemester.Columns["columnFullName"].Width += 50;
            //dataViewSemester.Columns["columnEmail"].Width += 50;
            //dataViewSemester.Columns["columnBonus"].Width += 20;
            //dataViewSemester.Columns["columnGrade_total"].Width += 20;
        }
        private void InitializeSemestersData()
        {
            dataViewSemester.Rows.Clear();

            var filterClassesInSemester = Builders<Class>.Filter.Eq(c => c.SemesterId, semester.SemesterId);
            var resultClassesInSemester = Classes.Find(filterClassesInSemester).ToList();
            if (resultClassesInSemester.Any())
            {
                foreach (var c in resultClassesInSemester)
                {
                    int rowIndex = dataViewSemester.Rows.Add();
                    var filterTeacherName = Builders<Account>.Filter.Eq(a => a.AccountId, c.TeacherId);
                    var resultTeacher = Accounts.Find(filterTeacherName).FirstOrDefault();
                    var filterStudentsInClass = Builders<Student_Class_Detail>.Filter.Eq(scd => scd.ClassId, c.ClassId);
                    int resultStudentsInClass = StudentClasses.Find(filterStudentsInClass).ToList().Count;
                    if (resultTeacher != null)
                    {
                        dataViewSemester.Rows[rowIndex].Cells["columnClassId"].Value = c.ClassId;
                        dataViewSemester.Rows[rowIndex].Cells["columnClassName"].Value = c.Name;
                        dataViewSemester.Rows[rowIndex].Cells["columnTeacherName"].Value = resultTeacher.Name;
                        dataViewSemester.Rows[rowIndex].Cells["columnStudentNumber"].Value = resultStudentsInClass;
                        dataViewSemester.Rows[rowIndex].Cells["columnDayOfWeek"].Value = c.DayOfWeek;
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
    }
}
