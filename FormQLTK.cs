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
    public partial class FormQLTK : UserControl
    {
        IMongoCollection<Account> Accounts;
        List<UserControl> controls;
        Navigator navigator;
        Account account;

        public FormQLTK()
        {
            InitializeComponent();
            Size = new Size(1200, 500);

            Accounts = Login.Accounts;
            account = Login.Account;
        }
        private void ShowAccountsDescriptionForm(object sender, EventArgs e)
        {
            new FormAccountsDescription().Show();
        }
    }
}
