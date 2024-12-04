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
    public partial class FormWeekOfClassDescription : Form
    {
        private IMongoCollection<Student_Class_Detail> StudentClasses;
        private IMongoCollection<Account> Accounts;
        private Class Class;
        private List<Student_Class_Detail> StudentsInThisClass;

        private int weekNo;
        private bool status;
        public FormWeekOfClassDescription(Class c, List<Student_Class_Detail> sc, int weekNo)
        {
            StudentClasses = Login.StudentClasses;
            Accounts = Login.Accounts;
            Class = c;
            StudentsInThisClass = sc;
            this.weekNo = weekNo;
            status = IsWeekActive();
            InitializeComponent();
            
            InitializeDataGridView();
            InitializeComboBoxStatus();
            InitializeWeekData();

            InitializeLabelsHeader();
        }
        private void InitializeLabelsHeader()
        {
            lblClassName.Text = Class.Name;
            lblWeekNo.Text = $"Danh sách sinh viên tuần {weekNo}";
        }
        private void InitializeComboBoxStatus()
        {
            cbStatus.DataSource = new List<string>
            {
                "Chưa mở",
                "Đã mở"
            };
            if (status)
            {
                cbStatus.Enabled = false;
                cbStatus.Texts = "Đã mở";
            }
        }
        private void OnChangeWeekStatus(object sender, EventArgs e)
        {
            if (cbStatus.Texts.Equals("Đã mở"))
            {
                if (IsWeekActive(weekNo - 1))
                {
                    UpdateCheckInStatusToAllStudent();
                    status = true;
                    cbStatus.Enabled = false;

                    dataViewWeek.ReadOnly = false;
                    dataViewWeek.RefreshEdit();

                    return;
                }
                MessageBox.Show("Tuần trước chưa điểm danh, không thể mở tuần kế", "Thông báo");
                //InitializeComboBoxStatus();
            }
        }
        private void UpdateCheckInStatusToAllStudent()
        {
            var filterStudentsInClass = Builders<Student_Class_Detail>.Filter.Eq(sc => sc.ClassId, Class.ClassId);
            var resultStudentsInClass = StudentClasses.Find(filterStudentsInClass).ToList();
            foreach (var studentDetail in resultStudentsInClass)
            {
                string[] strList = studentDetail.CheckedIn.Split(", ");
                strList[weekNo - 1] = "0";
                string newCheckedIn = string.Join(", ", strList);
                var filterStudent = filterStudentsInClass &
                                    Builders<Student_Class_Detail>.Filter.Eq(sc => sc.StudentId, studentDetail.StudentId);
                var updateStudentCheckIn = Builders<Student_Class_Detail>.Update.Set(sc => sc.CheckedIn, newCheckedIn);
                StudentClasses.UpdateOne(filterStudent, updateStudentCheckIn);
            }
            
        }
        private bool IsWeekActive()
        {
            var filterStudentsInClass = Builders<Student_Class_Detail>.Filter.Eq(sc => sc.ClassId, Class.ClassId);
            var resultStudentInClass = StudentClasses.Find(filterStudentsInClass).FirstOrDefault();
            return !resultStudentInClass.CheckedIn.Split(", ")[weekNo - 1].Equals("null");
        }
        private bool IsWeekActive(int weekNo)
        {
            if (weekNo == 0)
            {
                return true;
            }
            var filterStudentsInClass = Builders<Student_Class_Detail>.Filter.Eq(sc => sc.ClassId, Class.ClassId);
            var resultStudentInClass = StudentClasses.Find(filterStudentsInClass).FirstOrDefault();
            return !resultStudentInClass.CheckedIn.Split(", ")[weekNo - 1].Equals("null");
        }
        private void ExitSemesterDescriptionForm(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
        private void InitializeDataGridView()
        {
            dataViewWeek.Columns.Clear();

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn()
            {
                Name = "columnCheckIn",
                HeaderText = "Điểm danh",
                
            };

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn()
            {
                Name = "columnLateCheckIn",
                HeaderText = "Đi trễ",
            };
            checkBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            comboBoxColumn.DataSource = new List<string>
            {
                "",
                "Đi trễ",
            };

            dataViewWeek.Columns.Add("columnStudentName", "Họ tên sinh viên");
            dataViewWeek.Columns.Add("columnMSSV", "MSSV");
            dataViewWeek.Columns.Add(checkBoxColumn);
            dataViewWeek.Columns.Add(comboBoxColumn);

            dataViewWeek.Columns["columnStudentName"].Width += 100;
            dataViewWeek.Columns["columnMSSV"].Width += 80;
            dataViewWeek.Columns["columnCheckIn"].Width += 100;
            dataViewWeek.Columns["columnLateCheckIn"].Width += 100;

            dataViewWeek.Columns["columnStudentName"].ReadOnly = true;
            dataViewWeek.Columns["columnMSSV"].ReadOnly = true;

            if (status)
            {
                dataViewWeek.ReadOnly = false;
                dataViewWeek.RefreshEdit();
            }
            else
            {
                dataViewWeek.ReadOnly = true;
                dataViewWeek.RefreshEdit();
            }

            foreach (DataGridViewColumn column in dataViewWeek.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void InitializeWeekData()
        {
            dataViewWeek.Rows.Clear();
            foreach (var sc in StudentsInThisClass)
            {
                int rowIndex = dataViewWeek.Rows.Add();
                string[] checkInStatusList = sc.CheckedIn.Split(", ");
                var atWeekNo = checkInStatusList[weekNo - 1];
                bool checkInStatusWeek = atWeekNo == "null" ? 
                                         false :
                                         Convert.ToBoolean(Convert.ToInt16(atWeekNo));
                var filterStudent = Builders<Account>.Filter.Eq(a => a.AccountId, sc.StudentId);
                var resultStudent = Accounts.Find(filterStudent).First();
                
                dataViewWeek.Rows[rowIndex].Cells["columnStudentName"].Value = resultStudent.Name;
                dataViewWeek.Rows[rowIndex].Cells["columnMSSV"].Value = sc.StudentId;
                dataViewWeek.Rows[rowIndex].Cells["columnCheckIn"].Value = checkInStatusWeek;
            }
        }
        private void ExportSemesterDataToExcel(object sender, EventArgs e)
        {
            if (dataViewWeek.RowCount == 0)
            {
                MessageBox.Show("Không đủ dữ liệu để xuất file Excel", "Thông báo");
                return;
            }
            XLWorkbook workbook = new XLWorkbook();
            var dataTable = DataGridViewToDataTable(dataViewWeek);
            var asd = dataViewWeek;
            workbook.Worksheets.Add(dataTable, "Sheet1");


            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Lưu file Excel",
                FileName = $"{Class.Name}_{Class.ClassId}_DSSV_Tuan{weekNo}",
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
        private void CheckInForStudent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dataViewWeek.Columns["columnCheckIn"].Index)
            {
                if (!status)
                {
                    //MessageBox.Show("Chưa thể điểm danh", "Thông báo");
                    lblNote.Text = "Chưa thể điểm danh";
                    noteTimer.Start();
                    return;
                }
                string MSSV = dataViewWeek.Rows[e.RowIndex].Cells["columnMSSV"].Value.ToString() ?? "";
                string studentName = dataViewWeek.Rows[e.RowIndex].Cells["columnStudentName"].Value.ToString() ?? "";
                var filterStudentToCheckIn = Builders<Student_Class_Detail>.Filter.Eq(sc => sc.StudentId, MSSV) &
                                             Builders<Student_Class_Detail>.Filter.Eq(sc => sc.ClassId, Class.ClassId);
                var studentIsUpdatingCheckIn = FindStudentInClass(MSSV);
                string[] checkInStatusString = studentIsUpdatingCheckIn.CheckedIn.Split(", ");

                bool getCheckInStatusAtWeekNo;
                if (checkInStatusString[weekNo - 1].Equals("null"))
                {
                    getCheckInStatusAtWeekNo = false;
                }
                else
                {
                    getCheckInStatusAtWeekNo = Convert.ToBoolean(Convert.ToInt16(checkInStatusString[weekNo - 1]));
                }
                bool updateCheckIn = !getCheckInStatusAtWeekNo;
                switch (updateCheckIn)
                {
                    case true:
                        checkInStatusString[weekNo - 1] = "1";
                        break;
                    default:
                        checkInStatusString[weekNo - 1] = "0";
                        break;
                }
                var updateCheckInStudent = Builders<Student_Class_Detail>.Update.Set(sc => sc.CheckedIn, string.Join(", ", checkInStatusString));
                StudentClasses.UpdateOne(filterStudentToCheckIn, updateCheckInStudent);
                
                lblNote.Text = $"Sửa điểm danh tuần {weekNo} cho sinh viên {studentName} thành công";
                noteTimer.Start();
            }
        }
        private void NoteClear(object sender, EventArgs e)
        {
            lblNote.Text = "";
            noteTimer.Stop();
        }
        private Student_Class_Detail FindStudentInClass(string MSSV)
        {
            return StudentsInThisClass.Where(sc => sc.StudentId == MSSV).FirstOrDefault() ?? new Student_Class_Detail();
        }
    }
}
