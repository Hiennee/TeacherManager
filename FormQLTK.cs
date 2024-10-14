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
    public partial class FormQLTK : UserControl
    {
        IMongoCollection<Account> Accounts;
        List<UserControl> controls;
        Navigator navigator;
        Account account;

        public FormQLTK()
        {
            InitializeComponent();
            Size = new Size(1200, 500);

            Accounts = Login.Accounts;
            account = Login.Account;
        }
        private void ShowAccountsDescriptionForm(object sender, EventArgs e)
        {
            new FormAccountsDescription().Show();
        }
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (dataViewAccounts.SelectedRows.Count > 0)
            {
                string accountId = dataViewAccounts.SelectedRows[0].Cells["columnAccountId"].Value.ToString();
                FormEditAccount formEditAccount = new FormEditAccount(accountId);
                formEditAccount.ShowDialog();
                //InitializeAccountsData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để chỉnh sửa.");
            }
        }
        private async void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dataViewAccounts.SelectedRows.Count > 0)
            {
                string accountId = dataViewAccounts.SelectedRows[0].Cells["columnAccountId"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var filter = Builders<Account>.Filter.Eq(a => a.AccountId, accountId);
                        var deleteResult = await Accounts.DeleteOneAsync(filter);

                        if (deleteResult.DeletedCount > 0)
                        {
                            MessageBox.Show("Tài khoản đã được xóa!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //InitializeAccountsData();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi xóa tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hành động xóa bị hủy.", "Hủy bỏ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            FormCreateAccount formCreateAccount = new FormCreateAccount();
            formCreateAccount.ShowDialog();
            //InitializeAccountsData();
        }
    }
}
