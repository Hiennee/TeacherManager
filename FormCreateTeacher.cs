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
            if (txtBoxAccountName.Texts == "" ||
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
            var IDEmailPhoneFilter = Builders<Account>.Filter.Eq(a => a.AccountId, txtBoxAccountName.Texts) |
                                     Builders<Account>.Filter.Eq(a => a.Email, txtBoxEmail.Texts) |
                                     Builders<Account>.Filter.Eq(a => a.Phone, txtBoxPhone.Texts);
            //var MSNVFilter = Builders<Teacher>.Filter.Eq(t => t.accountId, txtBoxMSGV.Texts);
            var IDEmailExist = Accounts.Find(IDEmailPhoneFilter).Any();
            //var MSSVExist = Teachers.Find(MSNVFilter).Any();
            if (IDEmailExist)
            {
                MessageBox.Show("Tên đăng nhập, E-mail hoặc số điện thoại đã tồn tại", "Thông báo");
                return;
            }
            Account a = new Account
            {
                AccountId = txtBoxAccountName.Texts,
                Name = txtBoxTeacherName.Texts,
                Password = "123",
                Email = txtBoxEmail.Texts,
                Role = "Teacher",
                Phone = txtBoxPhone.Texts,
            };
            Teacher s = new Teacher
            {
                accountId = txtBoxAccountName.Texts,
            };
            Accounts.InsertOne(a);
            Teachers.InsertOne(s);
            MessageBox.Show("Tạo giảng viên viên mới thành công", "Thông báo");
            Close();
        }
    }
}
