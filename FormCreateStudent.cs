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
        public FormCreateStudent()
        {
            InitializeComponent();
            Accounts = Login.Accounts;
            Students = Login.Students;
        }
        public void CheckAddStudentButtonAvailable(object sender, EventArgs e)
        {
            if (txtBoxStudentName.Texts == "" ||
                txtBoxMSSV.Texts == "" ||
                txtBoxEmail.Texts == "" ||
                txtBoxPhone.Texts == "")
            {
                btnAddStudent.Enabled = false;
            }
            else
            {
                btnAddStudent.Enabled = true;
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void AddStudent(object sender, EventArgs e)
        {
            var IDEmailPhoneFilter = Builders<Account>.Filter.Eq(a => a.Email, txtBoxEmail.Texts) |
                                     Builders<Account>.Filter.Eq(a => a.Phone, txtBoxPhone.Texts);
            var MSSVFilter = Builders<Student>.Filter.Eq(s => s.accountId, txtBoxMSSV.Texts);
            var IDEmailExist = Accounts.Find(IDEmailPhoneFilter).Any();
            var MSSVExist = Students.Find(MSSVFilter).Any();
            if (IDEmailExist || MSSVExist)
            {
                MessageBox.Show("E-mail hoặc số điện thoại, MSSV đã tồn tại", "Thông báo");
                return;
            }
            Account a = new Account
            {
                AccountId = txtBoxMSSV.Texts,
                Name = txtBoxStudentName.Texts,
                Password = "123",
                Email = txtBoxEmail.Texts,
                Role = "Student",
                Phone = txtBoxPhone.Texts,
                Avatar = null,
                DOB = DateTime.Now.Date,
            };
            Student s = new Student
            {
                accountId = txtBoxMSSV.Texts,
            };
            Accounts.InsertOne(a);
            Students.InsertOne(s);
            if (MessageBox.Show("Tạo sinh viên mới thành công", "Thông báo") == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            Close();
        }
    }
}
