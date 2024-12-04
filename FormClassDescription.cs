using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManager.Models;

namespace TeacherManager
{
    public partial class FormClassDescription : Form
    {
        public static Class Class;
        IMongoCollection<Semester> Semesters;
        IMongoCollection<Student_Class_Detail> StudentClasses;
        IMongoCollection<Account> Accounts;
        
        List<Student_Class_Detail> StudentsInThisClass;

        private Account Account;
        private MailAddress mailSender;
        private SmtpClient smtpClient;
        private Semester Semester;
        private Teacher Teacher;

        private bool isViewingGrade = true;
        private string nameToFind = "";

        public FormClassDescription(Class c)
        {
            InitializeComponent();
            InitializeToolTips();
            Class = c;
            Account = Login.Account;
            mailSender = Login.mailSender;
            smtpClient = Login.smtpClient;
            Semesters = Login.Semesters;
            StudentClasses = Login.StudentClasses;
            Accounts = Login.Accounts;
            Teacher = Login.Teacher;

            lblClassName.Text = Class.Name;
            lblSemesterId.Text = "Học kỳ " + Class.SemesterId;

            var filterSemester = Builders<Semester>.Filter.Eq(s => s.SemesterId, Class.SemesterId);
            Semester = Semesters.Find(filterSemester).First();
            
            InitializeDataStudentsInThisClass();
            InitializeStudentsDataGridView();
            InitializeAdminOrTeacherView();
            ShowCheckBoxHeader();
            InitializeStudentsData();
            GenerateDataViewAndControls();

            InitializeWeeksDataGridView();
            InitializeWeeksData();

            lblStudentNumbers.Text = StudentsInThisClass.Count.ToString();
        }
        private void InitializeAdminOrTeacherView()
        {
            if (Account.Role.Equals("Admin"))
            {
                mailGradeIcon.Visible = false;
                return;
            }
        }
        private void InitializeToolTips()
        {
            ttSendGrade.SetToolTip(mailGradeIcon, "Gửi điểm cho sinh viên");
            ttSendEmail.SetToolTip(mailIcon, "Gửi E-mail cho sinh viên");
            ttExportExcel.SetToolTip(excelIcon, "Xuất dữ liệu sinh viên ra file Excel");

            ttSendGrade.InitialDelay = 100;
            ttSendEmail.InitialDelay = 100;
            ttExportExcel.InitialDelay = 100;
        }
        private void CheckTimerTyping(object sender, EventArgs e)
        {
            timerNameTyped.Stop();
            timerNameTyped.Start();
        }
        private void TypingTimer_Tick(object sender, EventArgs e)
        {
            timerNameTyped.Stop();
            ChangeNameToFind();
        }
        
        private void AddStudentIntoClass(object sender, EventArgs e)
        {
            if (new FormCreateStudentClasses().ShowDialog() == DialogResult.OK)
            {
                InitializeStudentsData();
            }
        }
        private void ChangeNameToFind()
        {
            nameToFind = txtBoxNameToFind.Texts;
            InitializeStudentsDataGridView();
            InitializeStudentsData();
        }
        private void InitializeDataStudentsInThisClass()
        {
            var filterStudentsInThisClass = Builders<Student_Class_Detail>.Filter.Eq(sc => sc.ClassId, Class.ClassId);
            StudentsInThisClass = StudentClasses.Find(filterStudentsInThisClass).ToList();
        }
        private void InitializeStudentsDataGridView()
        {
            dataViewStudents.Columns.Clear();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "columnCheckBox",
                HeaderText = "",
            };
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
            {
                Name = "columnAvt",
                HeaderText = "Ảnh",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
            };

            //DataGridViewTextBoxColumn grade01column = new DataGridViewTextBoxColumn();
            //grade01column.DefaultCellStyle.BackColor = Color.Orange;
            //grade01column.DefaultCellStyle.ForeColor = Color.Pink;
            //dataViewStudents.Columns.Add(grade01column);

            dataViewStudents.Columns.Add(checkBoxColumn);
            dataViewStudents.Columns.Add(imgColumn);
            dataViewStudents.Columns.Add("columnMSSV", "MSSV");
            dataViewStudents.Columns.Add("columnFullName", "Họ tên");
            dataViewStudents.Columns.Add("columnGender", "Giới tính");
            dataViewStudents.Columns.Add("columnEmail", "Email");
            dataViewStudents.Columns.Add("columnAbsences", "Số buổi vắng");
            dataViewStudents.Columns.Add("columnGrade01", $"Điểm 1 ({Class.Grade01_weight}%)");
            dataViewStudents.Columns.Add("columnGrade02", $"Điểm 2 ({Class.Grade02_weight}%)");
            dataViewStudents.Columns.Add("columnGrade03", $"Điểm 3 ({Class.Grade03_weight}%)");
            dataViewStudents.Columns.Add("columnGrade04", $"Điểm 4 ({Class.Grade04_weight}%)");
            dataViewStudents.Columns.Add("columnBonus", "Điểm cộng");
            dataViewStudents.Columns.Add("columnMinus", "Điểm trừ");
            dataViewStudents.Columns.Add("columnGrade_total", $"Điểm tổng (100%)");
            //dataViewStudents.Columns["columnGrade01"].DefaultCellStyle.BackColor = Color.Orange;

            dataViewStudents.Columns["columnAvt"].ReadOnly = true;
            dataViewStudents.Columns["columnMSSV"].ReadOnly = true;
            dataViewStudents.Columns["columnFullName"].ReadOnly = true;
            dataViewStudents.Columns["columnGender"].ReadOnly = true;
            dataViewStudents.Columns["columnEmail"].ReadOnly = true;
            dataViewStudents.Columns["columnAbsences"].ReadOnly = true;
            dataViewStudents.Columns["columnGrade_total"].ReadOnly = true;
            dataViewStudents.Columns["columnGrade01"].ReadOnly = false;
            dataViewStudents.Columns["columnGrade02"].ReadOnly = false;
            dataViewStudents.Columns["columnGrade03"].ReadOnly = false;
            dataViewStudents.Columns["columnGrade04"].ReadOnly = false;

            dataViewStudents.Columns["columnCheckBox"].Width -= 40;
            
            //dataViewStudents.Columns["columnFullName"].Width += 50;
            dataViewStudents.Columns["columnEmail"].Width += 100;
            dataViewStudents.Columns["columnBonus"].Width -= 30;
            dataViewStudents.Columns["columnMinus"].Width -= 30;
            dataViewStudents.Columns["columnGrade_total"].Width += 20;

            foreach (DataGridViewColumn column in dataViewStudents.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void InitializeStudentsData()
        {

            dataViewStudents.Rows.Clear();
            var filterStudentInClass = Builders<Student_Class_Detail>.Filter.Eq(sc => sc.ClassId, Class.ClassId);
            var studentInClassResult = StudentClasses.Find(filterStudentInClass);

            if (studentInClassResult.Any())
            {
                foreach (var r in studentInClassResult.ToList())
                {
                    FilterDefinition<Account> filterStudentsName;
                    filterStudentsName = nameToFind.Equals("") ?
                                         Builders<Account>.Filter.Empty :
                                         Builders<Account>.Filter.Regex(a => a.Name, new BsonRegularExpression($".*{nameToFind}.*", "i"));
                    var filterStudentsInClass = Builders<Account>.Filter.Eq(a => a.AccountId, r.StudentId);
                    var sortStudents = Builders<Account>.Sort.Ascending(a => a.Name);
                    var accountResult = Accounts.Find(filterStudentsInClass & filterStudentsName).Sort(sortStudents);
                    if (accountResult.Any())
                    {
                        foreach (var a in accountResult.ToList())
                        {
                            int rowIndex = dataViewStudents.Rows.Add();
                            dataViewStudents.Rows[rowIndex].Cells["columnAvt"].Value = a.Avatar == null ?
                                                                                          Properties.Resources.default_avatar_icon :
                                                                                          MainForm.Base64ToImage(a.Avatar);
                            dataViewStudents.Rows[rowIndex].Cells["columnMSSV"].Value = a.AccountId;
                            dataViewStudents.Rows[rowIndex].Cells["columnFullName"].Value = a.Name;
                            dataViewStudents.Rows[rowIndex].Cells["columnGender"].Value = a.Gender.Equals("M") ?
                                                                                          "Nam" : "Nữ";
                            dataViewStudents.Rows[rowIndex].Cells["columnEmail"].Value = a.Email;
                            dataViewStudents.Rows[rowIndex].Cells["columnAbsences"].Value = r.CheckedIn
                                                                                             .Split(", ")
                                                                                             .Count(s => s == "0");
                            dataViewStudents.Rows[rowIndex].Cells["columnGrade01"].Value = r.Grade01;
                            dataViewStudents.Rows[rowIndex].Cells["columnGrade02"].Value = r.Grade02;
                            dataViewStudents.Rows[rowIndex].Cells["columnGrade03"].Value = r.Grade03;
                            dataViewStudents.Rows[rowIndex].Cells["columnGrade04"].Value = r.Grade04;
                            dataViewStudents.Rows[rowIndex].Cells["columnBonus"].Value = r.Bonus;

                            double grade01 = Convert.ToDouble(dataViewStudents.Rows[rowIndex].Cells["columnGrade01"].Value);
                            double grade02 = Convert.ToDouble(dataViewStudents.Rows[rowIndex].Cells["columnGrade02"].Value);
                            double grade03 = Convert.ToDouble(dataViewStudents.Rows[rowIndex].Cells["columnGrade03"].Value);
                            double grade04 = Convert.ToDouble(dataViewStudents.Rows[rowIndex].Cells["columnGrade04"].Value);
                            double bonus = Convert.ToDouble(dataViewStudents.Rows[rowIndex].Cells["columnBonus"].Value);
                            dataViewStudents.Rows[rowIndex].Cells["columnBonus"].Value = r.Bonus;
                            dataViewStudents.Rows[rowIndex].Cells["columnMinus"].Value = r.Minus;
                            dataViewStudents.Rows[rowIndex].Cells["columnGrade_total"].Value = r.Grade_total;
                            //dataViewStudents.Rows[rowIndex].
                        }
                    }
                }
            }
        }

        private void UpdateStudentGrade(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataViewStudents.Columns["columnGrade01"].Index ||
                                    e.ColumnIndex == dataViewStudents.Columns["columnGrade02"].Index ||
                                    e.ColumnIndex == dataViewStudents.Columns["columnGrade03"].Index ||
                                    e.ColumnIndex == dataViewStudents.Columns["columnGrade04"].Index ||
                                    e.ColumnIndex == dataViewStudents.Columns["columnBonus"].Index   ||
                                    e.ColumnIndex == dataViewStudents.Columns["columnMinus"].Index))
            {
                double grade01 = 0, grade02 = 0, grade03 = 0, grade04 = 0,
                       bonus = 0, minus = 0;
                //double oldGrade01 = Convert.ToDouble(dataViewStudents.Rows[e.RowIndex].Cells["columnGrade01"].Value);
                string MSSV = Convert.ToString(dataViewStudents.Rows[e.RowIndex].Cells["ColumnMSSV"].Value) ?? "";
                try
                {
                    grade01 = Convert.ToDouble(dataViewStudents.Rows[e.RowIndex].Cells["columnGrade01"].Value);
                    grade02 = Convert.ToDouble(dataViewStudents.Rows[e.RowIndex].Cells["columnGrade02"].Value);
                    grade03 = Convert.ToDouble(dataViewStudents.Rows[e.RowIndex].Cells["columnGrade03"].Value);
                    grade04 = Convert.ToDouble(dataViewStudents.Rows[e.RowIndex].Cells["columnGrade04"].Value);
                    bonus = Convert.ToDouble(dataViewStudents.Rows[e.RowIndex].Cells["columnBonus"].Value);
                    minus = Convert.ToDouble(dataViewStudents.Rows[e.RowIndex].Cells["columnMinus"].Value);
                }
                catch
                {
                    InitializeStudentsData();
                    MessageBox.Show("Điểm số không hợp lệ", "Thông báo");
                    return;
                }
                if (!IsValidGrade(grade01) || !IsValidGrade(grade02) ||
                    !IsValidGrade(grade03) || !IsValidGrade(grade04) ||
                    !IsValidGrade(bonus) || !IsValidGrade(minus))
                {
                    InitializeStudentsData();
                    MessageBox.Show("Điểm số không hợp lệ", "Thông báo");
                    return;
                }
                CalculateGradeTotal(grade01, grade02, grade03, grade04, bonus, minus, e.RowIndex, MSSV);
            }

        }
        private static bool IsValidGrade(double grade)
        {
            return !(grade < 0 || grade > 10);
        }
        private void CalculateGradeTotal(double grade01, double grade02, double grade03, double grade04,
                                        double bonus, double minus, int rowIndex, string MSSV)
        {
            double grade_total = 0;
            double shadow_grade01 = grade01, shadow_grade02 = grade02, shadow_grade03 = grade03;
            double calculatedGrade01 = 0, calculatedGrade02 = 0, calculatedGrade03 = 0, calculatedGrade04 = 0;
            double gradeToModify = bonus - minus;
            if (gradeToModify != 0)
            {
                int minGradeWeight = GetLowestGradeWeight(Class.Grade01_weight, Class.Grade02_weight, Class.Grade03_weight);
                double bonusRemain = 0;
                if (Class.Grade01_weight == minGradeWeight)
                {
                    shadow_grade01 += gradeToModify;
                    if (shadow_grade01 > 10)
                    {
                        bonusRemain = grade01 + gradeToModify - 10;
                        shadow_grade01 = 10;
                        if (bonusRemain > 0)
                        {
                            int anotherMinGradeWeight = GetLowestGradeWeight(0, Class.Grade02_weight, Class.Grade03_weight);
                            if (anotherMinGradeWeight == Class.Grade02_weight)
                            {
                                shadow_grade02 += bonusRemain;
                                if (shadow_grade02 > 10)
                                {
                                    bonusRemain = grade02 + bonusRemain - 10;
                                    shadow_grade02 = 10;
                                    if (bonusRemain > 0)
                                    {
                                        shadow_grade03 += bonusRemain;
                                        //bonusRemain = 0;
                                        if (shadow_grade03 > 10)
                                        {
                                            shadow_grade03 = 10;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                shadow_grade03 += bonusRemain;
                                if (shadow_grade03 > 10)
                                {
                                    bonusRemain = grade03 + bonusRemain - 10;
                                    shadow_grade03 = 10;
                                    if (bonusRemain > 0)
                                    {
                                        shadow_grade02 += bonusRemain;
                                        if (shadow_grade02 > 10)
                                        {
                                            shadow_grade02 = 10;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (Class.Grade02_weight == minGradeWeight)
                {
                    shadow_grade02 += gradeToModify;
                    if (shadow_grade02 > 10)
                    {
                        bonusRemain = grade02 + gradeToModify - 10;
                        shadow_grade02 = 10;
                        if (bonusRemain > 0)
                        {
                            int anotherMinGradeWeight = GetLowestGradeWeight(Class.Grade01_weight, 0, Class.Grade03_weight);
                            if (anotherMinGradeWeight == Class.Grade01_weight)
                            {
                                shadow_grade01 += bonusRemain;
                                if (shadow_grade01 > 10)
                                {
                                    shadow_grade01 = 10;
                                    bonusRemain = grade01 + bonusRemain - 10;
                                    if (bonusRemain > 0)
                                    {
                                        shadow_grade02 += bonusRemain;
                                        if (shadow_grade02 > 10)
                                        {
                                            shadow_grade02 = 10;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                shadow_grade03 += bonusRemain;
                                if (shadow_grade03 > 10)
                                {
                                    shadow_grade03 = 10;
                                    bonusRemain = grade03 + bonusRemain - 10;
                                    if (bonusRemain > 0)
                                    {
                                        shadow_grade01 += bonusRemain;
                                        if (shadow_grade01 > 10)
                                        {
                                            shadow_grade01 = 10;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (Class.Grade03_weight == minGradeWeight)
                {
                    shadow_grade03 += gradeToModify;
                    if (shadow_grade03 > 10)
                    {
                        bonusRemain = grade03 + gradeToModify - 10;
                        shadow_grade03 = 10;
                        if (bonusRemain > 0)
                        {
                            int anotherMinGradeWeight = GetLowestGradeWeight(Class.Grade01_weight, Class.Grade02_weight, 0);
                            if (anotherMinGradeWeight == Class.Grade01_weight)
                            {
                                shadow_grade01 += bonusRemain;
                                if (shadow_grade01 > 10)
                                {
                                    shadow_grade01 = 10;
                                    bonusRemain = grade01 + bonusRemain - 10;
                                    if (bonusRemain > 0)
                                    {
                                        shadow_grade02 += bonusRemain;
                                        if (shadow_grade02 > 10)
                                        {
                                            shadow_grade02 = 10;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                shadow_grade02 += bonusRemain;
                                if (shadow_grade02 > 10)
                                {
                                    shadow_grade02 = 10;
                                    bonusRemain = grade02 + bonusRemain - 10;
                                    if (bonusRemain > 0)
                                    {
                                        shadow_grade01 += bonusRemain;
                                        if (shadow_grade01 > 10)
                                        {
                                            shadow_grade01 = 10;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (Class.Grade01_weight > 0)
            {
                calculatedGrade01 = shadow_grade01 * (Class.Grade01_weight / 100F);
                if (calculatedGrade01 > Class.Grade01_weight / 10F)
                    calculatedGrade01 = Class.Grade01_weight / 10F;
            }
            if (Class.Grade02_weight > 0)
            {
                calculatedGrade02 += shadow_grade02 * (Class.Grade02_weight / 100F);
                if (calculatedGrade02 > Class.Grade02_weight / 10F)
                    calculatedGrade02 = Class.Grade02_weight / 10F;
            }
            if (Class.Grade03_weight > 0)
            {
                calculatedGrade03 += shadow_grade03 * (Class.Grade03_weight / 100F);
                if (calculatedGrade03 > Class.Grade03_weight / 10F)
                    calculatedGrade03 = Class.Grade03_weight / 10F;
            }
            if (Class.Grade04_weight > 0)
            {
                calculatedGrade04 += grade04 * (Class.Grade04_weight / 100F);
            }
            grade_total = Math.Round(calculatedGrade01 + calculatedGrade02 + calculatedGrade03 + calculatedGrade04, 2);
            if (grade_total < 0)
            {
                grade_total = 0;
            }

            dataViewStudents.Rows[rowIndex].Cells["columnGrade_total"].Value = grade_total.ToString("F1");
            var filterStudentToUpdateGrades = Builders<Student_Class_Detail>.Filter.Eq(sc => sc.StudentId, MSSV);
            var updateStudentGrades = Builders<Student_Class_Detail>.Update.Set(sc => sc.Grade01, grade01)
                                                                           .Set(sc => sc.Grade02, grade02)
                                                                           .Set(sc => sc.Grade03, grade03)
                                                                           .Set(sc => sc.Grade04, grade04)
                                                                           .Set(sc => sc.Bonus, bonus)
                                                                           .Set(sc => sc.Minus, minus)
                                                                           .Set(sc => sc.Grade_total, grade_total);
            StudentClasses.UpdateOne(filterStudentToUpdateGrades, updateStudentGrades);
            //MessageBox.Show("Sửa điểm của sinh viên " + MSSV + " thành công", "Thông báo");
        }
        public int GetLowestGradeWeight(int grade01_weight, int grade02_weight, int grade03_weight)
        {
            var gradeWeights = new Dictionary<string, int>
            {
                { "Grade01", grade01_weight },
                { "Grade02", grade02_weight },
                { "Grade03", grade03_weight },
            };
            var validWeights = gradeWeights.Where(g => g.Value > 0);
            if (!validWeights.Any())
            {
                return 0;
            }
            var minGradeWeight = validWeights.OrderBy(g => g.Value).First().Value;
            return minGradeWeight;
        }

        private void ExportStudentClassesDataToExcel(object sender, EventArgs e)
        {
            if (dataViewStudents.RowCount == 0)
            {
                MessageBox.Show("Không đủ dữ liệu để xuất file Excel", "Thông báo");
                return;
            }
            XLWorkbook workbook = new XLWorkbook();
            var dataTable = DataGridViewToDataTable(dataViewStudents);
            var asd = dataViewStudents;
            workbook.Worksheets.Add(dataTable, "Sheet1");


            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Lưu file Excel",
                FileName = $"{Class.SemesterId}_{Class.ClassId}_{Class.Name}_BangDiemSinhVien.xlsx",
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
            }
        }
        private DataTable DataGridViewToDataTable(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText, typeof(string));
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
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

        private void SendEmail(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsChose = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataViewStudents.Rows)
            {
                if (Convert.ToBoolean(dataViewStudents.Rows[row.Index].Cells["columnCheckBox"].Value) == true)
                {
                    rowsChose.Add(row);
                }
            }
            if (rowsChose.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất một sinh viên để gửi mail", "Thông báo");
                return;
            }
            new FormSendEmail(rowsChose).Show();
        }
        private void ShowCheckBoxHeader()
        {
            Rectangle rect = dataViewStudents.GetCellDisplayRectangle(0, -1, true);
            // set checkbox header to center of header cell. +1 pixel to position 
            rect.Y = 3;
            rect.X = rect.Location.X + (rect.Width / 4);
            CheckBox checkboxHeader = new CheckBox();
            checkboxHeader.Name = "checkboxHeader";

            checkboxHeader.Size = new Size(18, 18);
            checkboxHeader.Location = rect.Location;
            checkboxHeader.CheckedChanged += SelectAll;
            dataViewStudents.Controls.Add(checkboxHeader);
            dataViewStudents.Refresh();
        }
        private void StateChanged(object sender, EventArgs e)
        {
            if (dataViewStudents.CurrentCell is DataGridViewCheckBoxCell)
            {
                dataViewStudents.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void SelectAll(object sender, EventArgs e)
        {
            //if (dataViewAccounts.CurrentCell != null && dataViewAccounts.IsCurrentCellDirty)
            //{
            //    dataViewAccounts.EndEdit();
            //}
            CheckBox headerBox = (CheckBox)sender;
            for (int i = dataViewStudents.RowCount - 1; i >= 0; i--)
            {
                dataViewStudents.Rows[i].Cells[0].Selected = true;
                dataViewStudents.EndEdit();
                dataViewStudents.Rows[i].Cells[0].Value = headerBox.Checked;
            }
            dataViewStudents.RefreshEdit();
        }
        private void SendGradeEmail(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsChose = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataViewStudents.Rows)
            {
                if (Convert.ToBoolean(dataViewStudents.Rows[row.Index].Cells["columnCheckBox"].Value) == true)
                {
                    rowsChose.Add(row);
                }
            }
            if (rowsChose.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất một sinh viên để gửi thông tin điểm", "Thông báo");
                return;
            }
            foreach (DataGridViewRow row in rowsChose)
            {
                var message = new MailMessage(mailSender, new MailAddress(row.Cells["columnEmail"].Value.ToString() ?? ""));
                message.IsBodyHtml = true;

                message.Subject = "Điểm thành phần môn {className} - {classId}, Học kỳ {semesterId}";
                message.Body = Teacher.MailTemplate.Equals("Default") ?
                               ("<h2>Chào các bạn sinh viên trong lớp {className}, học kỳ {semesterId}</h2>" +
                               "\n\n" +
                               "<p>Thầy/Cô xin gửi điểm thành phần môn học {className} cho các bạn:</p>\n" +
                               "Sinh viên {studentName}:\n" +
                               "Điểm 1 ({%1}%): {1}, " +
                               "Điểm 2 ({%2}%): {2}, " +
                               "Điểm 3 ({%3}%): {3}, " +
                               "Điểm 4 ({%4}%): {4}, " +
                               "Điểm cộng tích lũy: {bonus},\n" +
                               "Điểm tổng (100%): {total}" +
                               "<p>Nếu có vấn đề gì hay thắc mắc vui lòng email lại Thầy/Cô trong thời gian sớm nhất.</p>\n\n\n" +
                               "<p>Thân mến,</p>\n" +
                               "<p>{teacherName}.</p>")
                               .Replace("{className}", Class.Name)
                               .Replace("{classId}", Class.ClassId)
                               .Replace("{semesterId}", Semester.SemesterId)
                               .Replace("{%1}", Class.Grade01_weight.ToString())
                               .Replace("{%2}", Class.Grade02_weight.ToString())
                               .Replace("{%3}", Class.Grade03_weight.ToString())
                               .Replace("{%4}", Class.Grade04_weight.ToString())
                               .Replace("{1}", row.Cells["columnGrade01"].Value.ToString())
                               .Replace("{2}", row.Cells["columnGrade02"].Value.ToString())
                               .Replace("{3}", row.Cells["columnGrade03"].Value.ToString())
                               .Replace("{4}", row.Cells["columnGrade04"].Value.ToString())
                               .Replace("{bonus}", row.Cells["columnBonus"].Value.ToString())
                               .Replace("{total}", row.Cells["columnGrade_total"].Value.ToString())
                               .Replace("{studentName}", row.Cells["columnFullName"].Value.ToString())
                               .Replace("{teacherName}", Account.Name)
                               :
                               Teacher.MailTemplate
                               .Replace("{className}", Class.Name)
                               .Replace("{classId}", Class.ClassId)
                               .Replace("{semesterId}", Semester.SemesterId)
                               .Replace("{%1}", Class.Grade01_weight.ToString())
                               .Replace("{%2}", Class.Grade02_weight.ToString())
                               .Replace("{%3}", Class.Grade03_weight.ToString())
                               .Replace("{%4}", Class.Grade04_weight.ToString())
                               .Replace("{1}", row.Cells["columnGrade01"].Value.ToString())
                               .Replace("{2}", row.Cells["columnGrade02"].Value.ToString())
                               .Replace("{3}", row.Cells["columnGrade03"].Value.ToString())
                               .Replace("{4}", row.Cells["columnGrade04"].Value.ToString())
                               .Replace("{bonus}", row.Cells["columnBonus"].Value.ToString())
                               .Replace("{total}", row.Cells["columnGrade_total"].Value.ToString())
                               .Replace("{studentName}", row.Cells["columnFullName"].Value.ToString())
                               .Replace("{teacherName}", Account.Name);
                smtpClient.Send(message);
            }
            if (MessageBox.Show("Gửi thông tin điểm cho sinh viên trong lớp thành công", "Thông báo") == DialogResult.OK)
            {

            }
        }
        private List<DateTime> GetAllDaysOfClass(Class c)
        {
            List<DateTime> days = new List<DateTime>();
            if (Semester.Type.Equals("sub"))
            {
                List<DayOfWeek> classSchedules = new List<DayOfWeek>();
                foreach (string dow in c.DayOfWeek.Split(", "))
                {
                    classSchedules.Add(FormLGD.TranslateDayOfWeek(dow));
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
            DayOfWeek classSchedule = FormLGD.TranslateDayOfWeek(c.DayOfWeek);
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
        private void SwitchBetweenGradeOrWeekView(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isViewingGrade = !isViewingGrade;
            GenerateDataViewAndControls();
        }
        private void InitializeWeeksDataGridView()
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
            {
                Name = "columnButtonDetail",
                HeaderText = "Chi tiết",
                Text = "Xem chi tiết",
                UseColumnTextForButtonValue = true,
            };
            dataViewWeeks.Columns.Add("columnWeekNo", "Tuần");
            dataViewWeeks.Columns.Add("columnDays", "Ngày tháng");
            dataViewWeeks.Columns.Add("columnStatus", "Trạng thái");
            dataViewWeeks.Columns.Add("columnStudentsNo", "Sĩ số");
            dataViewWeeks.Columns.Add("columnPresent", "Hiện diện");
            dataViewWeeks.Columns.Add("columnAbsences", "Vắng");
            dataViewWeeks.Columns.Add(btnColumn);

            dataViewWeeks.Columns["columnDays"].Width += 50;
            dataViewWeeks.Columns["columnStudentsNo"].Width += 30;

            foreach (DataGridViewColumn column in dataViewWeeks.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;   
            }
        }
        private void InitializeWeeksData()
        {
            dataViewWeeks.Rows.Clear();
            int no = 0;
            
            foreach (var d in GetAllDaysOfClass(Class))
            {
                bool isWeekActive = IsWeekActive(no);
                int rowIndex = dataViewWeeks.Rows.Add();
                int absencesNo = isWeekActive ? GetNumberOfAbsencesOfWeek(no) : 0;
                dataViewWeeks.Rows[rowIndex].Cells["columnWeekNo"].Value = (no + 1).ToString();
                dataViewWeeks.Rows[rowIndex].Cells["columnDays"].Value = d.ToShortDateString();
                dataViewWeeks.Rows[rowIndex].Cells["columnStatus"].Value = isWeekActive ? "Đã mở" : "Chưa mở";
                dataViewWeeks.Rows[rowIndex].Cells["columnStudentsNo"].Value = StudentsInThisClass.Count;
                dataViewWeeks.Rows[rowIndex].Cells["columnPresent"].Value = isWeekActive ? StudentsInThisClass.Count - absencesNo : "-";
                dataViewWeeks.Rows[rowIndex].Cells["columnAbsences"].Value = isWeekActive ? absencesNo : "-";
                no++;
            }
        }
        private bool IsWeekActive(int week)
        {
            var filterStudentsInClass = Builders<Student_Class_Detail>.Filter.Eq(sc => sc.ClassId, Class.ClassId);
            var resultStudentsInClass = StudentClasses.Find(filterStudentsInClass).FirstOrDefault();
            if (resultStudentsInClass == null)
            {
                return false;
            }
            return !resultStudentsInClass.CheckedIn.Split(", ")[week].Equals("null");
        }
        private int GetNumberOfAbsencesOfWeek(int week)
        {
            int result = 0;
            var filterStudentsInClass = Builders<Student_Class_Detail>.Filter.Eq(sc => sc.ClassId, Class.ClassId);
            var resultStudentsInClass = StudentClasses.Find(filterStudentsInClass).ToList();
            foreach (var student in resultStudentsInClass)
            {
                if (student.CheckedIn.Split(", ")[week].Equals("0"))
                {
                    result++;
                }
            }
            return result;
        }
        private void GenerateDataViewAndControls()
        {
            if (!isViewingGrade)
            {
                panelButtons.Visible = false;
                panelStudentNo.Visible = false;
                panelFindName.Visible = false;
                lblSwitchView.Text = "Chuyển sang bảng điểm";
                dataViewStudents.Visible = false;
                dataViewWeeks.Visible = true;
                dataViewStudents.Refresh();
                return;
            }
            panelButtons.Visible = true;
            panelStudentNo.Visible = true;
            panelFindName.Visible = true;
            lblSwitchView.Text = "Chuyển sang biểu đồ tuần";
            dataViewStudents.Visible = true;
            dataViewWeeks.Visible = false;
            dataViewStudents.Refresh();
        }
        private void HandleGridViewButtons(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataViewWeeks.Columns["columnButtonDetail"].Index)
            {
                if (new FormWeekOfClassDescription(Class, StudentsInThisClass, e.RowIndex + 1).ShowDialog() == DialogResult.OK)
                {
                    InitializeDataStudentsInThisClass();
                    InitializeWeeksData();
                    InitializeStudentsData();
                    return;
                }
            }
        }
        private void ExitClassDescriptionForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
