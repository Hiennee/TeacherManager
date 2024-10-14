using ClosedXML.Excel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        IMongoCollection<Student_Class_Detail> StudentClasses;
        IMongoCollection<Account> Accounts;
        
        public FormClassDescription(Class c)
        {
            InitializeComponent();
            Class = c;
            StudentClasses = Login.StudentClasses;
            Accounts = Login.Accounts;

            lblClassName.Text = Class.Name;
            lblSemesterId.Text = "Học kỳ " + Class.SemesterId;

            var filter = Builders<Account>.Filter.Empty;
            var src = Login.Accounts.Find(filter);

            InitializeDataGridView();
            ShowCheckBoxHeader();
            InitializeStudentsData();
            //dataViewStudents.DataSource = src.ToList();
        }

        private void ExitClassDescriptionForm(object sender, EventArgs e)
        {
            Close();
        }

        private void AddStudentIntoClass(object sender, EventArgs e)
        {
            if (new FormCreateStudentClasses().ShowDialog() == DialogResult.OK)
            {
                InitializeStudentsData();
            }
        }
        private void InitializeDataGridView()
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
            dataViewStudents.Columns["columnEmail"].ReadOnly = true;
            dataViewStudents.Columns["columnGrade_total"].ReadOnly = true;
            dataViewStudents.Columns["columnGrade01"].ReadOnly = false;
            dataViewStudents.Columns["columnGrade02"].ReadOnly = false;
            dataViewStudents.Columns["columnGrade03"].ReadOnly = false;
            dataViewStudents.Columns["columnGrade04"].ReadOnly = false;

            dataViewStudents.Columns["columnCheckBox"].Width -= 40;
            dataViewStudents.Columns["columnMinus"].Width -= 20;
            //dataViewStudents.Columns["columnFullName"].Width += 50;
            dataViewStudents.Columns["columnEmail"].Width += 100;
            //dataViewStudents.Columns["columnBonus"].Width += 20;
            dataViewStudents.Columns["columnGrade_total"].Width += 20;
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
                    var filterAccount = Builders<Account>.Filter.Eq(a => a.AccountId, r.StudentId);
                    var accountResult = Accounts.Find(filterAccount);
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
                            dataViewStudents.Rows[rowIndex].Cells["columnEmail"].Value = a.Email;
                            dataViewStudents.Rows[rowIndex].Cells["columnAbsences"].Value = r.Absences;
                            dataViewStudents.Rows[rowIndex].Cells["columnGrade01"].Value = r.Grade01;
                            dataViewStudents.Rows[rowIndex].Cells["columnGrade02"].Value = r.Grade02;
                            dataViewStudents.Rows[rowIndex].Cells["columnGrade03"].Value = r.Grade03;
                            dataViewStudents.Rows[rowIndex].Cells["columnGrade04"].Value = r.Grade04;

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
                                    e.ColumnIndex == dataViewStudents.Columns["columnBonus"].Index ||
                                    e.ColumnIndex == dataViewStudents.Columns["columnMinus"].Index))
            {
                double grade01 = 0, grade02 = 0, grade03 = 0, grade04 = 0,
                       bonus = 0, minus = 0;
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
                    MessageBox.Show("Điểm số không hợp lệ", "Thông báo");
                    return;
                }
                if (grade01 < 0 || grade01 > 10 ||
                    grade02 < 0 || grade02 > 10 ||
                    grade03 < 0 || grade03 > 10 ||
                    grade04 < 0 || grade04 > 10 ||
                    bonus < 0 || bonus > 10 ||
                    minus < 0 || minus > 10)
                {
                    MessageBox.Show("Điểm số không hợp lệ", "Thông báo");
                    if (grade01 < 0 || grade01 > 10)
                    {
                        dataViewStudents.Rows[e.RowIndex].Cells["columnGrade01"].Value = 0;
                        dataViewStudents.Refresh();
                    }
                    return;
                }
                CalculateGradeTotal(grade01, grade02, grade03, grade04, bonus, minus, e.RowIndex, MSSV);
            }

        }
        private void CalculateGradeTotal(double grade01, double grade02, double grade03, double grade04,
                                        double bonus, double minus, int rowIndex, string MSSV)
        {
            double grade_total = 0;
            double calculatedGrade01 = 0, calculatedGrade02 = 0, calculatedGrade03 = 0, calculatedGrade04 = 0;
            if (bonus - minus != 0)
            {
                int minGradeWeight = GetLowestGradeWeight(Class.Grade01_weight, Class.Grade02_weight, Class.Grade03_weight);
                if (Class.Grade01_weight == minGradeWeight)
                {
                    calculatedGrade01 += bonus - minus;
                }
                else if (Class.Grade02_weight == minGradeWeight)
                {
                    calculatedGrade02 += bonus - minus;
                }
                else if (Class.Grade03_weight == minGradeWeight)
                {
                    calculatedGrade03 += bonus - minus;
                }
                else if (Class.Grade04_weight == minGradeWeight)
                {
                    calculatedGrade04 += bonus - minus;
                }

            }
            if (Class.Grade01_weight > 0)
            {
                calculatedGrade01 += grade01 * (Class.Grade01_weight / 100F);
                if (calculatedGrade01 > Class.Grade01_weight / 10F) calculatedGrade01 = Class.Grade01_weight / 10F;
            }
            if (Class.Grade02_weight > 0)
            {
                calculatedGrade02 += grade02 * (Class.Grade02_weight / 100F);
                if (calculatedGrade02 > Class.Grade02_weight / 10F) calculatedGrade02 = Class.Grade02_weight / 10F;
            }
            if (Class.Grade03_weight > 0)
            {
                calculatedGrade03 += grade03 * (Class.Grade03_weight / 100F);
                if (calculatedGrade03 > Class.Grade03_weight / 10F) calculatedGrade03 = Class.Grade03_weight / 10F;
            }
            if (Class.Grade04_weight > 0)
            {
                calculatedGrade04 += grade04 * (Class.Grade04_weight / 100F);
            }
            grade_total = Math.Round(calculatedGrade01 + calculatedGrade02 + calculatedGrade03 + calculatedGrade04, 2);
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

        private void AccountChecked(object sender, EventArgs e)
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
            for (int i = 0; i < dataViewStudents.RowCount; i++)
            {
                dataViewStudents.Rows[i].Cells["columnCheckBox"].Selected = true;
                dataViewStudents.EndEdit();
                dataViewStudents.Rows[i].Cells["columnCheckBox"].Value = headerBox.Checked;
            }
            dataViewStudents.Refresh();
        }
    }
}
