using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManager.Models;

namespace TeacherManager
{
    public partial class FormQLTK : UserControl
    {
        IMongoCollection<Account> Accounts;
        Account account;

        bool passwordVisible = false;
        bool isMale;

        public FormQLTK()
        {
            InitializeComponent();
            Size = new Size(1200, 500);

            Accounts = Login.Accounts;
            account = Login.Account;
            lblViewAccounts.Visible = account.Role == "Admin";
            InitializeAccountData();
        }
        public static bool ValidatePhoneNumber(string phone)
        {
            return phone.All(char.IsDigit) &&
                   (phone.Length == 9 || phone.Length == 10) &&
                   phone.StartsWith('0');
        }
        public static bool ValidatePassword(string password)
        {
            return password.Length >= 6;
        }
        public static bool ValidateStudentEmail(string email)
        {
            return email.Contains("@sinhvien.safumi.edu.vn");
        }
        public static bool ValidateTeacherEmail(string email)
        {
            return email.Contains("@safumi.edu.vn");
        }
        public static bool ValidateBirthDate(DateTime birthDate)
        {
            return birthDate.AddYears(18) <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
                   &&
                   birthDate.Year > 1920;
        }
        private void InitializeAccountData()
        {
            dtpBirth.SkinColor = Color.FromArgb(240, 240, 240);
            var accountFilter = Builders<Account>.Filter.Eq(a => a.AccountId, account.AccountId);
            account = Accounts.Find(accountFilter).FirstOrDefault();

            lblChangeMailTemplate.Visible = account.Role.Equals("Teacher") ? true : false;
            isMale = account.Gender.Equals("M") ? true : false;
            pictureBoxAvatar.Image = account.Avatar == null ?
                                     Properties.Resources.default_avatar_icon :
                                     MainForm.Base64ToImage(account.Avatar);
            genderIcon.Image = isMale ?
                               Properties.Resources.male_icon :
                               Properties.Resources.female_icon;
            dtpBirth.Value = account.DOB;
            lblName.Text = account.Name;
            lblAccountId.Text = account.AccountId;
            txtBoxEmail.Texts = account.Email;
            txtBoxPhone.Texts = account.Phone;
            txtBoxRole.Texts = account.Role.Equals("Admin") ?
                               "Quản trị viên" :
                               account.Role.Equals("Teacher") ?
                               "Giảng viên" :
                               "Sinh viên";
            txtBoxPassword.Texts = "**************";
        }
        private void OnBirthDateChanged(object sender, EventArgs e)
        {
            CheckEnableSaveButton(sender, e);
            if (ValidateBirthDate(dtpBirth.Value))
            {
                lblBirthWarning.Visible = false;
                return;
            }
            lblBirthWarning.Visible = true;
        }
        private void OnPhoneNumberChanged(object sender, EventArgs e)
        {
            CheckEnableSaveButton(sender, e);
            if (txtBoxPhone.Texts.Equals(account.Phone))
            {
                lblPhoneWarning.Visible = false;
                return;
            }
            if (ValidatePhoneNumber(txtBoxPhone.Texts))
            {
                lblPhoneWarning.Visible = false;
                btnSaveChanges.Visible = true;
                return;
            }
            lblPhoneWarning.Visible = true;
            btnSaveChanges.Visible = false;
        }
        private void CheckEnableSaveButton(object sender, EventArgs e)
        {
            if ((!txtBoxEmail.Texts.Equals(account.Email) ||
                !txtBoxPhone.Texts.Equals(account.Phone) ||
                !dtpBirth.Value.Equals(account.DOB)) ||
                isMale != account.Gender.Equals("M") &&
                (!lblBirthWarning.Visible && !lblPasswordWarning.Visible && !lblPhoneWarning.Visible))
            {
                {
                    btnSaveChanges.Visible = true;
                    return;
                }
            }
            btnSaveChanges.Visible = false;
        }
        private void ShowAccountsDescriptionForm(object sender, EventArgs e)
        {
            if (new FormAccountsDescription().ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void EnableChangeBirthDate(object sender, EventArgs e)
        {
            dtpBirth.Enabled = !dtpBirth.Enabled;
            if (!dtpBirth.Enabled)
            {
                dtpBirth.SkinColor = Color.FromArgb(240, 240, 240);
                return;
            }
            dtpBirth.SkinColor = Color.White;
        }

        private void EnableChangePhone(object sender, EventArgs e)
        {
            txtBoxPhone.Enabled = !txtBoxPhone.Enabled;
        }

        private void TogglePasswordVisible(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            pictureEye.Image = passwordVisible ?
                               Properties.Resources.eye_icon :
                               Properties.Resources.eye_close_icon;
            txtBoxOldPassword.PasswordChar = txtBoxOldPassword.PasswordChar == true ?
                                          txtBoxOldPassword.PasswordChar = false :
                                          txtBoxOldPassword.PasswordChar = true;
            txtBoxNewPassword.PasswordChar = txtBoxNewPassword.PasswordChar == true ?
                                          txtBoxNewPassword.PasswordChar = false :
                                          txtBoxNewPassword.PasswordChar = true;
        }
        private void SaveChanges(object sender, EventArgs e)
        {
            if (panelChangePassword.Visible == true)
            {
                if (txtBoxOldPassword.Texts.Equals("") || txtBoxNewPassword.Texts.Equals(""))
                {
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                }
            }
            if (txtBoxEmail.Texts.Equals("") || txtBoxPhone.Texts.Equals(""))
            {
                MessageBox.Show("Thông tin không hợp lệ", "Thông báo");
                return;
            }

            var accountFilter = Builders<Account>.Filter.Eq(a => a.AccountId, account.AccountId);
            var update = Builders<Account>.Update.Set(a => a.Email, txtBoxEmail.Texts)
                                                 .Set(a => a.DOB, dtpBirth.Value)
                                                 .Set(a => a.Phone, txtBoxPhone.Texts)
                                                 .Set(a => a.Password, txtBoxNewPassword.Texts)
                                                 .Set(a => a.Gender, isMale ? "M" : "F");
            if (Accounts.UpdateOne(accountFilter, update).ModifiedCount > 0)
            {
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                InitializeAccountData();
                txtBoxEmail.Enabled = false;
                txtBoxPhone.Enabled = false;
                panelChangePassword.Visible = false;
                btnSaveChanges.Visible = false;
                return;
            }
            MessageBox.Show("Có lỗi khi cập nhật thông tin cá nhân", "Thông báo");
        }
        private void EditPassword(object sender, EventArgs e)
        {
            if (panelChangePassword.Visible == true)
            {
                if (txtBoxOldPassword.Texts.Equals(account.Password))
                {
                    if (!txtBoxNewPassword.Texts.Equals(account.Password))
                    {
                        if (ValidatePassword(txtBoxNewPassword.Texts))
                        {
                            lblPasswordWarning.Visible = false;
                            btnSaveChanges.Visible = true;
                            btnSaveChanges.Enabled = true;
                        }
                        else
                        {
                            lblPasswordWarning.Text = "Mật khẩu mới phải dài từ 6 ký tự";
                            lblPasswordWarning.Visible = true;
                        }
                    }
                    else
                    {
                        lblPasswordWarning.Text = "Mật khẩu mới trùng với mật khẩu hiện tại";
                        lblPasswordWarning.Visible = true;
                        btnSaveChanges.Enabled = false;
                    }
                }
                else
                {
                    lblPasswordWarning.Text = "Mật khẩu cũ không trùng khớp";
                    lblPasswordWarning.Visible = true;
                    btnSaveChanges.Enabled = false;
                }
            }
        }
        private void ShowPanelChangePaassword(object sender, EventArgs e)
        {
            panelChangePassword.Visible = !panelChangePassword.Visible;
        }
        public void LoadAvatar()
        {
            account = Accounts.Find(Builders<Account>.Filter.Eq(a => a.AccountId, account.AccountId)).FirstOrDefault();
            pictureBoxAvatar.Image = MainForm.Base64ToImage(account.Avatar);
        }
        private void OnGenderChange(object sender, EventArgs e)
        {
            isMale = !isMale;
            CheckEnableSaveButton(sender, e);
            if (isMale)
            {
                genderIcon.Image = Properties.Resources.male_icon;
                return;
            }
            genderIcon.Image = Properties.Resources.female_icon;
        }
        private void ShowChangeGradeEmailTemplateForm(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (new FormChangeGradeEmailTemplate().ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
