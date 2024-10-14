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
    public partial class FormCreateAccount : Form
    {
        private IMongoCollection<Account> Accounts;

        public FormCreateAccount()
        {
            InitializeComponent();
            Accounts = Login.Accounts;

        }
        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAvatar.ImageLocation = openFileDialog.FileName;
                txtAvatar.Text = openFileDialog.FileName; 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountId.Text) || string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtRole.Text) || string.IsNullOrEmpty(txtAvatar.Text) ||
                string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            Account newAccount = new Account
            {
                AccountId = txtAccountId.Text,
                Name = txtName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Role = txtRole.Text,
                Avatar = txtAvatar.Text, 
                DOB = dtpDOB.Value,
                Phone = txtPhone.Text
            };

            Accounts.InsertOne(newAccount);
            MessageBox.Show("Tài khoản đã được thêm thành công!");

            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
