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
    public partial class FormEditAccount : Form
    {
        private IMongoCollection<Account> Accounts;
        private Account account;
        private string Base64Image;

        public FormEditAccount(Account account)
        {
            InitializeComponent();
            Accounts = Login.Accounts;
            this.account = account;
            Base64Image = account.Avatar ?? "";
            InitializeComboBoxRoles();
            LoadAccountDetails();
        }
        private void InitializeComboBoxRoles()
        {
            cbRole.DataSource = new List<string>
            {
                "Quản trị viên",
                "Giảng viên",
                "Sinh viên",
            };
            //cbRole.Texts = "Sinh viên";
        }
        private void LoadAccountDetails()
        {
            if (account != null)
            {
                txtBoxName.Texts = account.Name;
                txtBoxEmail.Texts = account.Email;
                cbRole.Texts = account.Role;
                txtBoxPhone.Texts = account.Phone;
                pictureAvt.Image = account.Avatar == null ?
                                   Properties.Resources.default_avatar_icon :
                                   MainForm.Base64ToImage(account.Avatar);
            }
        }
        private void LoadAvatar()
        {
            if (Base64Image == "")
            {
                pictureAvt.Image = Properties.Resources.default_avatar_icon;
                return;
            }
            pictureAvt.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAvt.Image = MainForm.Base64ToImage(Base64Image);
        }
        private void SaveChanges(object sender, EventArgs e)
        {
            var filterAccountToUpdate = Builders<Account>.Filter.Eq(a => a.AccountId, account.AccountId);
            var update = Builders<Account>.Update
                                          .Set(a => a.Name, txtBoxName.Texts)
                                          .Set(a => a.Email, txtBoxEmail.Texts)
                                          .Set(a => a.Role, cbRole.Texts)
                                          .Set(a => a.Phone, txtBoxPhone.Texts)
                                          .Set(a => a.Avatar, Base64Image);

            Accounts.UpdateOne(filterAccountToUpdate, update);
            if (MessageBox.Show("Cập nhật tài khoản thành công!") == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            LoadAvatar();
        }
        private void ChangeAvatar(object sender, EventArgs e)
        {
            string avtPath = "";
            ChooseAvtDialog.Filter = "Image Files (*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (ChooseAvtDialog.ShowDialog() == DialogResult.OK)
            {
                avtPath = ChooseAvtDialog.FileName;
                byte[] imageArray = System.IO.File.ReadAllBytes(avtPath);
                Base64Image = Convert.ToBase64String(imageArray);
            }
            var accountToUpdateAvatar = Builders<Account>.Filter.Eq(a => a.AccountId, account.AccountId);
            var avatarToUpdate = Builders<Account>.Update.Set("avatar", Base64Image);
            Accounts.UpdateOne(accountToUpdateAvatar, avatarToUpdate);
            MessageBox.Show("Thay đổi ảnh đại diện thành công", "Thông báo");
            LoadAvatar();
        }
        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
