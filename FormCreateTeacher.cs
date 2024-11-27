using MongoDB.Bson.Serialization.Attributes;
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
    public partial class FormCreateTeacher : Form
    {
        IMongoCollection<Account> Accounts;
        IMongoCollection<Teacher> Teachers;
        public FormCreateTeacher()
        {
            InitializeComponent();
            InitializeComboBoxGender();
            InitializeBirthDateFirstValue();
            Accounts = Login.Accounts;
            Teachers = Login.Teachers;
        }
        private void InitializeComboBoxGender()
        {
            cbGender.DataSource = new List<string>
            {
                "Nam",
                "Nữ"
            };
        }
        private void InitializeBirthDateFirstValue()
        {
            dtpBirth.Value = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
        }
        private void CheckAddTeacherButtonAvailable(object sender, EventArgs e)
        {
            if (txtBoxMSGV.Texts.Equals("")        ||
                txtBoxTeacherName.Texts.Equals("") ||
                txtBoxEmail.Texts.Equals("")       ||
                cbGender.Texts.Equals("")          ||
                lblPhoneWarning.Visible == true    ||
                lblBirthWarning.Visible == true)      
                 
            {
                btnAddTeacher.Enabled = false;
            }
            else
            {
                btnAddTeacher.Enabled = true;
            }
        }
        private void OnPhoneNumberChanged(object sender, EventArgs e)
        {
            CheckAddTeacherButtonAvailable(sender, e);
            if (FormQLTK.ValidatePhoneNumber(txtBoxPhone.Texts))
            {
                lblPhoneWarning.Visible = false;
                return;
            }
            lblPhoneWarning.Visible = true;
        }
        private void ValidateBirthDate(object sender, EventArgs e)
        {
            CheckAddTeacherButtonAvailable(sender, e);
            if (FormQLTK.ValidateBirthDate(dtpBirth.Value))
            {
                lblBirthWarning.Visible = false;
                return;
            }
            lblBirthWarning.Visible = true;
        }
        private void GenerateEmailBasedOnMSGV(object sender, EventArgs e)
        {
            CheckAddTeacherButtonAvailable(sender, e);
            if (txtBoxMSGV.Texts.Equals(""))
            {
                txtBoxEmail.Texts = "";
                return;
            }
            txtBoxEmail.Texts = txtBoxMSGV.Texts + "@safumi.edu.vn";
        }
        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void AddTeacher(object sender, EventArgs e)
        {
            var IDEmailPhoneFilter = Builders<Account>.Filter.Eq(a => a.AccountId, txtBoxMSGV.Texts) |
                                     Builders<Account>.Filter.Eq(a => a.Email, txtBoxEmail.Texts) |
                                     Builders<Account>.Filter.Eq(a => a.Phone, txtBoxPhone.Texts);
            //var MSNVFilter = Builders<Teacher>.Filter.Eq(t => t.AccountId, txtBoxMSGV.Texts);
            var IDEmailExist = Accounts.Find(IDEmailPhoneFilter).Any();
            //var MSSVExist = Teachers.Find(MSNVFilter).Any();
            if (IDEmailExist)
            {
                MessageBox.Show("Mã số giảng viên, E-mail hoặc số điện thoại đã tồn tại", "Thông báo");
                return;
            }
            Account a = new Account
            {
                AccountId = txtBoxMSGV.Texts.Trim(),
                Name = txtBoxTeacherName.Texts.Trim(),
                Password = "123",
                Avatar = null,
                Email = txtBoxEmail.Texts.Trim(),
                Gender = cbGender.Texts.Equals("Nam") ? "M" : "F",
                Phone = txtBoxPhone.Texts.Trim(),
                Role = "Teacher",
                DOB = dtpBirth.Value,
                Status = "Active",
            };
            Teacher s = new Teacher
            {
                AccountId = txtBoxMSGV.Texts,
                MailTemplate = "Default",
            };
            Accounts.InsertOne(a);
            Teachers.InsertOne(s);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
