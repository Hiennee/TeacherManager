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
        private bool isMale;
        public FormEditAccount(Account account)
        {
            InitializeComponent();
            Accounts = Login.Accounts;
            this.account = account;
            Base64Image = account.Avatar ?? "";
            InitializeComboBoxRoles();
            InitializeComboBoxStatus();
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
        private void InitializeComboBoxStatus()
        {
            cbStatus.DataSource = new List<string>
            {
                "Đang hoạt động",
                "Ngừng hoạt động",
            };
        }
        private void LoadAccountDetails()
        {
            if (account != null)
            {
                txtBoxName.Texts = account.Name;
                txtBoxEmail.Texts = account.Email;
                cbRole.Texts = account.Role.Equals("Admin") ?
                               "Quản trị viên" :
                               account.Role.Equals("Teacher") ?
                               "Giảng viên" :
                               "Sinh viên";
                txtBoxPhone.Texts = account.Phone;
                if (account.Gender.Equals("M"))
                {
                    isMale = true;
                    genderIcon.Image = Properties.Resources.male_icon;
                }
                else if (account.Gender.Equals("F"))
                {
                    isMale = false;
                    genderIcon.Image = Properties.Resources.female_icon;
                }
                pictureAvt.Image = account.Avatar == null ?
                                   Properties.Resources.default_avatar_icon :
                                   MainForm.Base64ToImage(account.Avatar);
                cbStatus.Texts = account.Status.Equals("Active") ?
                                 "Đang hoạt động" :
                                 "Ngừng hoạt động";
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
        private void OnGenderChange(object sender, EventArgs e)
        {
            isMale = !isMale;
            if (isMale)
            {
                genderIcon.Image = Properties.Resources.male_icon;
                return;
            }
            genderIcon.Image= Properties.Resources.female_icon;
        }
        private void SaveChanges(object sender, EventArgs e)
        {
            string role = cbRole.Texts.Equals("Quản trị viên") ?
                          "Admin" :
                          cbRole.Texts.Equals("Giảng viên") ?
                          "Teacher" :
                          "Student";
            string status = cbStatus.Texts.Equals("Đang hoạt động") ?
                            "Active" :
                            "Inactive";
            string gender = isMale ? "M" : "F";
            var filterAccountToUpdate = Builders<Account>.Filter.Eq(a => a.AccountId, account.AccountId);
            var update = Builders<Account>.Update
                                          .Set(a => a.Name, txtBoxName.Texts)
                                          .Set(a => a.Gender, gender)
                                          .Set(a => a.Email, txtBoxEmail.Texts)
                                          .Set(a => a.Role, role)
                                          .Set(a => a.Phone, txtBoxPhone.Texts)
                                          .Set(a => a.Avatar, Base64Image)
                                          .Set(a => a.Status, status);
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
