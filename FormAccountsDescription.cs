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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManager.Models;

namespace TeacherManager
{
    public partial class FormAccountsDescription : Form
    {
        IMongoCollection<Account> Accounts;
        private string role = "All";
        private string nameToFind = "";
        public FormAccountsDescription()
        {
            InitializeComponent();
            Accounts = Login.Accounts;

            InitializeToolTips();
            InitializeRoleComboBox();
            //InitializeStudentsDataGridView();
            ShowCheckBoxHeader();
            InitializeAccountsData();
        }
        private void InitializeToolTips()
        {
            ttEmail.SetToolTip(mailIcon, "Gửi e-mail cho sinh viên");
            ttExportExcel.SetToolTip(excelIcon, "Xuất dữ liệu bảng ra file Excel");
            ttEdit.SetToolTip(settingsIcon, "Chỉnh sửa một tài khoản");

            ttEmail.InitialDelay = 100;
            ttExportExcel.InitialDelay = 100;
            ttEdit.InitialDelay = 100;
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
        private void InitializeRoleComboBox()
        {
            cbRole.DataSource = new List<string>
            {
                "Tất cả",
                "Quản trị viên",
                "Giảng viên",
                "Sinh viên",
            };
        }
        private void ChangeAccountsRoleData(object sender, EventArgs e)
        {
            string selectedRole = cbRole.SelectedItem.ToString() ?? "All";
            if (selectedRole.Equals("Sinh viên"))
            {
                role = "Student";
            }
            else if (selectedRole.Equals("Giảng viên"))
            {
                role = "Teacher";
            }
            else if (selectedRole.Equals("Quản trị viên"))
            {
                role = "Admin";
            }
            else if (selectedRole.Equals("Tất cả"))
            {
                role = "All";
            }
            InitializeDataGridView();
            InitializeAccountsData();
        }
        private void ChangeNameToFind()
        {
            nameToFind = txtBoxNameToFind.Texts;
            InitializeDataGridView();
            InitializeAccountsData();
        }

        private void InitializeDataGridView()
        {
            dataViewAccounts.Columns.Clear();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "columnCheckBox",
                HeaderText = "",
            };
            //checkBoxColumn.
            DataGridViewImageColumn avtColumn = new DataGridViewImageColumn
            {
                Name = "columnAvatar",
                HeaderText = "Ảnh",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
            };
            dataViewAccounts.Columns.Add(checkBoxColumn);
            dataViewAccounts.Columns.Add(avtColumn);
            dataViewAccounts.Columns.Add("columnAccountId", "Mã tài khoản");
            dataViewAccounts.Columns.Add("columnName", "Tên");
            dataViewAccounts.Columns.Add("columnGender", "Giới tính");
            dataViewAccounts.Columns.Add("columnEmail", "Email");
            dataViewAccounts.Columns.Add("columnRole", "Vai trò");
            dataViewAccounts.Columns.Add("columnPhone", "Số điện thoại");
            dataViewAccounts.Columns.Add("columnDOB", "Ngày Sinh");
            dataViewAccounts.Columns.Add("columnStatus", "Tình trạng");

            dataViewAccounts.Columns["columnAccountId"].ReadOnly = true;
            dataViewAccounts.Columns["columnName"].ReadOnly = true;
            dataViewAccounts.Columns["columnGender"].ReadOnly = true;
            dataViewAccounts.Columns["columnEmail"].ReadOnly = true;
            dataViewAccounts.Columns["columnRole"].ReadOnly = true;
            dataViewAccounts.Columns["columnPhone"].ReadOnly = true;
            dataViewAccounts.Columns["columnDOB"].ReadOnly = true;
            dataViewAccounts.Columns["columnStatus"].ReadOnly = true;

            dataViewAccounts.Columns["columnCheckBox"].Width -= 50;
            dataViewAccounts.Columns["columnAccountId"].Width += 70;
            dataViewAccounts.Columns["columnEmail"].Width += 130;
            dataViewAccounts.Columns["columnPhone"].Width += 40;
            dataViewAccounts.Columns["columnDOB"].Width += 20;
            dataViewAccounts.Columns["columnStatus"].Width += 70;

            foreach (DataGridViewColumn column in dataViewAccounts.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void InitializeAccountsData()
        {
            FilterDefinition<Account> filterRoles, filterName;
            filterRoles = role.Equals("All") ?
                          filterRoles = Builders<Account>.Filter.Empty :
                          filterRoles = Builders<Account>.Filter.Eq(a => a.Role, role);
            filterName = nameToFind.Equals("") ?
                         filterName = Builders<Account>.Filter.Empty :
                         filterName = Builders<Account>.Filter.Regex(a => a.Name, new BsonRegularExpression($".*{nameToFind}.*", "i")) |
                                      Builders<Account>.Filter.Regex(a => a.AccountId, new BsonRegularExpression($".*{nameToFind}.*", "i"));
            var accountList = Accounts.Find(filterRoles & filterName).ToList();

            dataViewAccounts.Rows.Clear();

            lblAccountsNumber.Text = $"{accountList.Count.ToString()} kết quả";

            foreach (var account in accountList)
            {
                int rowIndex = dataViewAccounts.Rows.Add();

                dataViewAccounts.Rows[rowIndex].Cells["columnAvatar"].Value = account.Avatar == null ?
                                                                                  Properties.Resources.default_avatar_icon :
                                                                                  MainForm.Base64ToImage(account.Avatar);
                dataViewAccounts.Rows[rowIndex].Cells["columnAccountId"].Value = account.AccountId;
                dataViewAccounts.Rows[rowIndex].Cells["columnName"].Value = account.Name;
                dataViewAccounts.Rows[rowIndex].Cells["columnGender"].Value = account.Gender.Equals("M") ?
                                                                              "Nam" : "Nữ";
                dataViewAccounts.Rows[rowIndex].Cells["columnEmail"].Value = account.Email;
                dataViewAccounts.Rows[rowIndex].Cells["columnPhone"].Value = account.Phone;
                dataViewAccounts.Rows[rowIndex].Cells["columnRole"].Value = account.Role.Equals("Admin") ?
                                                                            "Ban quản trị" :
                                                                            account.Role.Equals("Teacher") ?
                                                                            "Giảng viên" :
                                                                            "Sinh viên";
                dataViewAccounts.Rows[rowIndex].Cells["columnDOB"].Value = account.DOB.ToShortDateString();
                dataViewAccounts.Rows[rowIndex].Cells["columnStatus"].Value = account.Status.Equals("Active") ?
                                                                              "Đang hoạt động" :
                                                                              "Ngừng hoạt động";
            }
        }
        private void ExportAccountsDataToExcel(object sender, EventArgs e)
        {
            if (dataViewAccounts.RowCount == 0)
            {
                MessageBox.Show("Không đủ dữ liệu để xuất file Excel", "Thông báo");
                return;
            }
            XLWorkbook workbook = new XLWorkbook();
            var dataTable = DataGridViewToDataTable(dataViewAccounts);
            workbook.Worksheets.Add(dataTable, "Sheet1");

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Lưu file Excel",
                FileName = $"{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_DSTK.xlsx",
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
        //private void GetCheckedRows(object sender, EventArgs e)
        //{
        //    foreach (DataGridViewRow row in dataViewAccounts.Rows)
        //    {
        //        if (row.Index == -1) continue;
        //        if (Convert.ToBoolean(dataViewAccounts.Rows[row.Index].Cells["columnCheckBox"].Value) == true)
        //        {
        //            rowsChose.Add(row);
        //        }
        //    }
        //}
        private void SendEmail(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsChose = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataViewAccounts.Rows)
            {
                if (row.Index == -1) continue;
                if (Convert.ToBoolean(dataViewAccounts.Rows[row.Index].Cells["columnCheckBox"].Value) == true)
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
        private void AdjustAccount(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsChose = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataViewAccounts.Rows)
            {
                if (row.Index == -1) continue;
                if (Convert.ToBoolean(dataViewAccounts.Rows[row.Index].Cells["columnCheckBox"].Value) == true)
                {
                    rowsChose.Add(row);
                }
            }
            if (rowsChose.Count == 0)
            {
                MessageBox.Show("Chọn một tài khoản để chỉnh sửa", "Thông báo");
                return;
            }
            var filterAccount = Builders<Account>.Filter.Eq(a => a.AccountId, rowsChose[0].Cells["columnAccountId"].Value.ToString());
            var resultAccount = Accounts.Find(filterAccount).FirstOrDefault();
            if (new FormEditAccount(resultAccount).ShowDialog() == DialogResult.OK)
            {
                InitializeAccountsData();
            }
        }
        private void StateChanged(object sender, EventArgs e)
        {
            if (dataViewAccounts.CurrentCell is DataGridViewCheckBoxCell)
            {
                dataViewAccounts.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void ShowCheckBoxHeader()
        {
            Rectangle rect = dataViewAccounts.GetCellDisplayRectangle(0, -1, true);
            // set checkbox header to center of header cell. +1 pixel to position 
            rect.Y = 3;
            rect.X = rect.Location.X + (rect.Width / 4);
            CheckBox checkboxHeader = new CheckBox();
            checkboxHeader.Name = "checkboxHeader";

            checkboxHeader.Size = new Size(18, 18);
            checkboxHeader.Location = rect.Location;
            checkboxHeader.CheckedChanged += SelectAll;
            dataViewAccounts.Controls.Add(checkboxHeader);
        }
        private void SelectAll(object sender, EventArgs e)
        {
            //if (dataViewAccounts.CurrentCell != null && dataViewAccounts.IsCurrentCellDirty)
            //{
            //    dataViewAccounts.EndEdit();
            //}
            CheckBox headerBox = (CheckBox)sender;
            for (int i = 0; i < dataViewAccounts.RowCount; i++)
            {
                dataViewAccounts.Rows[i].Cells[0].Selected = true;
                dataViewAccounts.EndEdit();
                dataViewAccounts.Rows[i].Cells[0].Value = headerBox.Checked;
            }
        }
        private void CreateStudent(object sender, EventArgs e)
        {
            if (new FormCreateStudent().ShowDialog() == DialogResult.OK)
            {
                InitializeAccountsData();
            }
        }
        private void AddStudentsFromExcel(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog()
            {
                Filter = "Excels file | *.xlsx",
                Title = "Thêm sinh viên từ file Excel"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                var Accounts = Login.Accounts;
                var Students = Login.Students;

                try
                {
                    XLWorkbook workBook = new XLWorkbook(file.FileName);
                    IXLWorksheet workSheet = workBook.Worksheet(1);
                    int maxRows = workSheet.LastRowUsed().RowNumber();
                    for (int i = 2; i <= maxRows; i++)
                    {
                        var rowData = workSheet.Row(i);
                        if (!rowData.IsEmpty())
                        {
                            try
                            {
                                var dob = rowData.Cell("F").GetValue<string>().Split("-");
                                FormCreateStudent.CheckAvailableAndAddStudent(new Account
                                {
                                    AccountId = rowData.Cell("A").GetValue<string>(),
                                    Name = rowData.Cell("B").GetValue<string>(),
                                    Password = "123456",
                                    Email = rowData.Cell("C").GetValue<string>(),
                                    Gender = rowData.Cell("D").GetValue<string>().Equals("Nam") ? "M" : "F",
                                    Role = "Student",
                                    Phone = rowData.Cell("E").GetValue<string>(),
                                    Avatar = null,
                                    DOB = new DateTime(Convert.ToInt16(dob[2]), Convert.ToInt16(dob[1]), Convert.ToInt16(dob[0])),
                                    Status = "Active",
                                });
                                MessageBox.Show($"Thêm {maxRows} sinh viên từ danh sách file Excel {file.FileName} thành công", "Thông báo");
                            }
                            catch (Exception ex)
                            {
                                if (ex.Message.Equals("001"))
                                {
                                    MessageBox.Show($"Dòng {i}: Số điện thoại đẫ tồn tại", "Thông báo",
                                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                    return;
                                }
                                else if (ex.Message.Equals("002"))
                                {
                                    MessageBox.Show($"Dòng {i}; MSSV đã tồn tại", "Thông báo",
                                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng tắt file Excel trước khi mở bằng ứng dụng này", "Thông báo");
                }
                finally
                {
                    InitializeAccountsData();
                }
            }
        }
        private void CreateTeacher(object sender, EventArgs e)
        {
            if (new FormCreateTeacher().ShowDialog() == DialogResult.OK)
            {
                InitializeAccountsData();
            }
        }
        private void ExitAccountsDescriptionForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
