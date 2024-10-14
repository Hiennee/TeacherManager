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
            Accounts = Login.Accounts;
            Teachers = Login.Teachers;
        }
        public void CheckAddStudentButtonAvailable(object sender, EventArgs e)
        {
            if (txtBoxAccountId.Texts == "" ||
                txtBoxTeacherName.Texts == "" ||
                //txtBoxMSGV.Texts == "" ||
                txtBoxEmail.Texts == "" ||
                txtBoxPhone.Texts == "")
            {
                btnAddTeacher.Enabled = false;
            }
            else
            {
                btnAddTeacher.Enabled = true;
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void AddTeacher(object sender, EventArgs e)
        {
            var IDEmailPhoneFilter = Builders<Account>.Filter.Eq(a => a.AccountId, txtBoxAccountId.Texts) |
                                     Builders<Account>.Filter.Eq(a => a.Email, txtBoxEmail.Texts) |
                                     Builders<Account>.Filter.Eq(a => a.Phone, txtBoxPhone.Texts);
            //var MSNVFilter = Builders<Teacher>.Filter.Eq(t => t.accountId, txtBoxMSGV.Texts);
            var IDEmailExist = Accounts.Find(IDEmailPhoneFilter).Any();
            //var MSSVExist = Teachers.Find(MSNVFilter).Any();
            if (IDEmailExist)
            {
                MessageBox.Show("Mã số giảng viên, E-mail hoặc số điện thoại đã tồn tại", "Thông báo");
                return;
            }
            Account a = new Account
            {
                AccountId = txtBoxAccountId.Texts,
                Name = txtBoxTeacherName.Texts,
                Password = "123",
                Avatar = null,
                Email = txtBoxEmail.Texts,
                Phone = txtBoxPhone.Texts,
                Role = "Teacher",
                DOB = DateTime.Now.Date,
            };
            Teacher s = new Teacher
            {
                accountId = txtBoxAccountId.Texts,
            };
            Accounts.InsertOne(a);
            Teachers.InsertOne(s);
            if (MessageBox.Show("Tạo giảng viên mới thành công", "Thông báo") == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            Close();
        }
    }
}
