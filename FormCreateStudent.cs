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
    public partial class FormCreateStudent : Form
    {
        IMongoCollection<Account> Accounts;
        IMongoCollection<Student> Students;
        IMongoCollection<Faculty> Faculties;
        public FormCreateStudent()
        {
            Accounts = Login.Accounts;
            Students = Login.Students;
            Faculties = Login.Faculties;
            InitializeComponent();
            InitializeBirthDateFirstValue();
            InitializeComboBoxGender();
            InitializeComboBoxFaculty();
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
        private void OnPhoneNumberChanged(object sender, EventArgs e)
        {
            CheckAddStudentButtonAvailable(sender, e);
            if (FormQLTK.ValidatePhoneNumber(txtBoxPhone.Texts))
            {
                lblPhoneWarning.Visible = false;
                return;
            }
            lblPhoneWarning.Visible = true;
        }
        private void ValidateBirthDate(object sender, EventArgs e)
        {
            CheckAddStudentButtonAvailable(sender, e);
            if (FormQLTK.ValidateBirthDate(dtpBirth.Value))
            {
                lblBirthWarning.Visible = false;
                return;
            }
            lblBirthWarning.Visible = true;
        }
        private void CheckAddStudentButtonAvailable(object sender, EventArgs e)
        {
            if (txtBoxStudentName.Texts.Equals("") ||
                txtBoxMSSV.Texts.Equals("")        ||
                cbGender.Texts.Equals("")          ||
                txtBoxEmail.Texts.Equals("")       ||
                txtBoxPhone.Texts.Equals("")       ||
                lblPhoneWarning.Visible == true    ||
                lblBirthWarning.Visible == true)
            {
                btnAddStudent.Enabled = false;
            }
            else
            {
                btnAddStudent.Enabled = true;
            }
        }
        private void GenerateEmailBasedOnMSSV(object sender, EventArgs e)
        {
            CheckAddStudentButtonAvailable(sender, e);
            if (txtBoxMSSV.Texts.Equals(""))
            {
                txtBoxEmail.Texts = "";
                return;
            }
            txtBoxEmail.Texts = txtBoxMSSV.Texts + "@sinhvien.safumi.edu.vn";
        }
        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
        private void AddStudent(object sender, EventArgs e)
        {
            if (txtBoxMSSV.Texts.Equals("") || txtBoxEmail.Texts.Equals("") ||
                txtBoxPhone.Texts.Equals("") || txtBoxStudentName.Texts.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Thông báo");
                return;
            }
            if (CheckAvailableAndAddStudent(new Account
            {
                AccountId = txtBoxMSSV.Texts,
                Name = txtBoxStudentName.Texts,
                Password = "123456",
                Email = txtBoxEmail.Texts,
                Gender = cbGender.Texts.Equals("Nam") ? "M" : "F",
                Role = "Student",
                Phone = txtBoxPhone.Texts,
                Avatar = null,
                DOB = dtpBirth.Value,
                Status = "Active",
            }, cbFaculty.Texts))
            {
                this.DialogResult = DialogResult.OK;
                Close();
                return;
            }
            MessageBox.Show("E-mail hoặc số điện thoại, MSSV đã tồn tại", "Thông báo");
        }
        public static bool CheckAvailableAndAddStudent(Account studentAccount, string faculty)
        {
            IMongoCollection<Account> Accounts = Login.Database.GetCollection<Account>("Account");
            IMongoCollection<Student> Students = Login.Database.GetCollection<Student>("Student");
            var IDEmailPhoneFilter = Builders<Account>.Filter.Eq(a => a.Email, studentAccount.Email) |
                                     Builders<Account>.Filter.Eq(a => a.Phone, studentAccount.Phone) |
                                     Builders<Account>.Filter.Eq(a => a.AccountId, studentAccount.AccountId);
            var MSSVFilter = Builders<Student>.Filter.Eq(s => s.accountId, studentAccount.AccountId);
            bool IDEmailPhoneExist = Accounts.Find(IDEmailPhoneFilter).Any();
            bool MSSVExist = Students.Find(MSSVFilter).Any();
            if (IDEmailPhoneExist)
            {
                throw new Exception("001");
            }
            if (MSSVExist)
            {
                throw new Exception("002");
            }

            Account a = new Account
            {
                AccountId = studentAccount.AccountId,
                Name = studentAccount.Name,
                Password = "123456",
                Email = studentAccount.Email,
                Gender = studentAccount.Gender,
                Role = "Student",
                Phone = studentAccount.Phone,
                Avatar = null,
                DOB = studentAccount.DOB,
                Status = "Active",
            };
            Student s = new Student
            {
                accountId = studentAccount.AccountId,
                FacultyId = faculty.Equals("") ?
                            null :
                            faculty.Split(" - ")[0],
            };
            try
            {
                Accounts.InsertOne(a);
                Students.InsertOne(s);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
