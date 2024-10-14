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
        private string AccountId;

        public FormEditAccount(string accountId)
        {
            InitializeComponent();
            Accounts = Login.Accounts;
            AccountId = accountId;
            LoadAccountDetails();
        }
        private void LoadAccountDetails()
        {
            var account = Accounts.Find(Builders<Account>.Filter.Eq(a => a.AccountId, AccountId)).FirstOrDefault();
            if (account != null)
            {
                txtName.Text = account.Name;
                txtEmail.Text = account.Email;
                txtRole.Text = account.Role;
                txtPhone.Text = account.Phone;
                pictureBoxAvatar.ImageLocation = account.Avatar; 
            }
        }
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            var filter = Builders<Account>.Filter.Eq(a => a.AccountId, AccountId);
            var update = Builders<Account>.Update
                .Set(a => a.Name, txtName.Text)
                .Set(a => a.Email, txtEmail.Text)
                .Set(a => a.Role, txtRole.Text)
                .Set(a => a.Phone, txtPhone.Text)
                .Set(a => a.Avatar, pictureBoxAvatar.ImageLocation); 

            Accounts.UpdateOne(filter, update);
            MessageBox.Show("Cập nhật tài khoản thành công!");
            this.Close(); 
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
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
