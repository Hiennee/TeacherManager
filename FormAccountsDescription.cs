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
    public partial class FormAccountsDescription : Form
    {
        IMongoCollection<Account> Accounts;
        List<DataGridViewRow> rowsChose;
        private string role = "All";
        public FormAccountsDescription()
        {
            InitializeComponent();
            Accounts = Login.Accounts;
            rowsChose = new List<DataGridViewRow>();
            InitializeRoleComboBox();
            InitializeDataGridView();
            ShowCheckBoxHeader();
            InitializeAccountsData();
            //dataViewStudents.DataSource = src.ToList();
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
        private void ExitClassDescriptionForm(object sender, EventArgs e)
        {
            Close();
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
            dataViewAccounts.Columns.Add("columnEmail", "Email");
            dataViewAccounts.Columns.Add("columnRole", "Vai trò");
            dataViewAccounts.Columns.Add("columnPhone", "Số điện thoại");
            dataViewAccounts.Columns.Add("columnDOB", "Ngày Sinh");

            dataViewAccounts.Columns["columnAccountId"].ReadOnly = true;
            dataViewAccounts.Columns["columnName"].ReadOnly = true;
            dataViewAccounts.Columns["columnEmail"].ReadOnly = true;
            dataViewAccounts.Columns["columnRole"].ReadOnly = true;
            dataViewAccounts.Columns["columnPhone"].ReadOnly = true;
            dataViewAccounts.Columns["columnDOB"].ReadOnly = true;
        }
        private void InitializeAccountsData()
        {
            FilterDefinition<Account> filterAccounts;
            filterAccounts = role == "All" ?
                             filterAccounts = Builders<Account>.Filter.Empty :
                             filterAccounts = Builders<Account>.Filter.Eq(a => a.Role, role);
            var accountList = Accounts.Find(filterAccounts).ToList();
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
                dataViewAccounts.Rows[rowIndex].Cells["columnEmail"].Value = account.Email;
                dataViewAccounts.Rows[rowIndex].Cells["columnPhone"].Value = account.Phone;
                dataViewAccounts.Rows[rowIndex].Cells["columnRole"].Value = account.Role;
                dataViewAccounts.Rows[rowIndex].Cells["columnDOB"].Value = account.DOB.Value.ToShortDateString();
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
            var asd = dataViewAccounts;
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
            //List<DataGridViewRow> rowsChose = new List<DataGridViewRow>();
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
                MessageBox.Show("Chọn một sinh viên để chỉnh sửa", "Thông báo");
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
            dataViewAccounts.Refresh();
        }
    }
}
