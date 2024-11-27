using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManager.Models;

namespace TeacherManager
{
    public partial class FormTestingGround : UserControl
    {
        IMongoCollection<Account> Accounts;
        IMongoCollection<Student> Students;
        public FormTestingGround()
        {
            Accounts = Login.Accounts;
            Students = Login.Students;
            InitializeComponent();
        }
        private void OnFindStudent(object sender, EventArgs e)
        {
            txtBoxResult.Texts = "";
            if (txtBoxName.Texts.Equals(""))
            {
                return;
            }
            var filterAccounts = Builders<Account>.Filter.Empty;
            var resultAccounts = Accounts.Find(filterAccounts).ToList();
            var queryResult = from account in resultAccounts
                              where account.Name.Contains(txtBoxName.Texts)
                              select account;
            //var queryResult = resultAccounts.Where(a => Regex.IsMatch(a.Name, $"{txtBoxName.Texts}", RegexOptions.IgnoreCase)).ToList();
            foreach (var r in queryResult)
            {
                txtBoxResult.Texts += r.Name + Environment.NewLine;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.Database.GetCollection<Account>("Account").DeleteMany(
                                                Builders<Account>.Filter.Nin(a => a.Email, new List<string>
                                                { "chanhien55@gmail.com"}));
            Login.Database.GetCollection<Class>("Class").DeleteMany(Builders<Class>.Filter.Empty);
            Login.Database.GetCollection<Teacher>("Teacher").DeleteMany(Builders<Teacher>.Filter.Empty);
            Login.Database.GetCollection<Student>("Student").DeleteMany(Builders<Student>.Filter.Empty);
            Login.Database.GetCollection<Student_Class_Detail>("StudentClasses").DeleteMany(Builders<Student_Class_Detail>.Filter.Empty);
            Login.Database.GetCollection<Semester>("Semester").DeleteMany(Builders<Semester>.Filter.Empty);
        }
    }
}
