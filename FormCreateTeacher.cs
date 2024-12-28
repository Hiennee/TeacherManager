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
        IMongoCollection<Faculty> Faculties;
        public FormCreateTeacher()
        {
            Accounts = Login.Accounts;
            Teachers = Login.Teachers;
            Faculties = Login.Faculties;
            InitializeComponent();
            InitializeComboBoxGender();
            InitializeComboBoxFaculty();
            InitializeBirthDateFirstValue();
        }
        private void InitializeComboBoxGender()
        {
            cbGender.DataSource = new List<string>
            {
                "Nam",
                "Nữ"
            };
        }
        private void InitializeComboBoxFaculty()
        {
            List<Faculty> faculties = new List<Faculty>();
            List<string> cbData = new List<string>() { "" };
            var resultFaculties = Faculties.Find(Builders<Faculty>.Filter.Empty).ToList();
            foreach (Faculty f in resultFaculties)
            {
                faculties.Add(f);
                cbData.Add(f.FacultyId + " - " + f.Name);
            }
            cbFaculty.DataSource = cbData;
        }
        private void InitializeBirthDateFirstValue()
        {
            dtpBirth.Value = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
        }
        private void CheckAddTeacherButtonAvailable(object sender, EventArgs e)
        {
            if (txtBoxTeacherName.Texts.Equals("") ||
                txtBoxPhone.Texts.Equals("")       ||
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
        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void AddTeacher(object sender, EventArgs e)
        {
            if (txtBoxPhone.Texts.Equals("") ||
                txtBoxTeacherName.Texts.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Thông báo");
                return;
            }
            if (!FormQLTK.ValidatePhoneNumber(txtBoxPhone.Texts))
            {
                return;
            }
            var IDEmailPhoneFilter = Builders<Account>.Filter.Eq(a => a.Phone, txtBoxPhone.Texts);
            //var MSNVFilter = Builders<Teacher>.Filter.Eq(t => t.AccountId, txtBoxMSGV.Texts);
            var IDEmailExist = Accounts.Find(IDEmailPhoneFilter).Any();
            //var MSSVExist = Teachers.Find(MSNVFilter).Any();
            if (IDEmailExist)
            {
                MessageBox.Show("Mã số giảng viên, E-mail hoặc số điện thoại đã tồn tại", "Thông báo");
                return;
            }
            var teacherId = MainForm.GenerateAccountId("Teacher");
            Account a = new Account
            {
                AccountId = teacherId,
                Name = txtBoxTeacherName.Texts.Trim(),
                Password = "123456",
                Avatar = null,
                Email = teacherId + "@safumi.edu.vn",
                Gender = cbGender.Texts.Equals("Nam") ? "M" : "F",
                Phone = txtBoxPhone.Texts.Trim(),
                Role = "Teacher",
                DOB = dtpBirth.Value,
                Status = "Active",
            };
            Teacher s = new Teacher
            {
                AccountId = teacherId,
                FacultyId = cbFaculty.Texts.Equals("") ?
                            null :
                            cbFaculty.Texts.Split(" - ")[0],
                MailTemplate = "Default",
            };
            Accounts.InsertOne(a);
            Teachers.InsertOne(s);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
