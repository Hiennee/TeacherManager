using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;
using System.Drawing.Text;
using TeacherManager.Models;

namespace TeacherManager
{
    public partial class Login : Form
    {
        public static IMongoDatabase Database;
        public static IMongoCollection<Account> Accounts;
        public static IMongoCollection<Student> Students;
        public static IMongoCollection<Teacher> Teachers;
        public static IMongoCollection<Class> Classes;
        public static IMongoCollection<Semester> Semesters;
        public static IMongoCollection<Student_Class_Detail> StudentClasses;
        public static Account Account;
        public static Teacher Teacher;

        public MongoClient Client;
        public Login()
        {
            InitializeComponent();
            Client = new MongoClient("mongodb+srv://hienne:Hien123@clusterhehe.vjr23zx.mongodb.net/?retryWrites=true&w=majority&appName=Clusterhehe");
            Database = Client.GetDatabase("TeacherManager");
            Accounts = Database.GetCollection<Account>("Account");
            Students = Database.GetCollection<Student>("Student");
            Teachers = Database.GetCollection<Teacher>("Teacher");
            Classes = Database.GetCollection<Class>("Class");
            Semesters = Database.GetCollection<Semester>("Semester");
            StudentClasses = Database.GetCollection<Student_Class_Detail>("StudentClasses");
        }
        public void OnLoginAttempt(object sender, EventArgs e)
        {
            var filter = Builders<Account>.Filter.Eq("accountId", txbID.Text) &
                         Builders<Account>.Filter.Eq("password", txbPassword.Text);
            Account = Accounts.Find(filter).FirstOrDefault();
            if (Account == null)
            {
                MessageBox.Show("Sai tên người dùng hoặc mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            var teacherFilter = Builders<Teacher>.Filter.Eq(t => t.accountId, Account.AccountId);
            Teacher = Teachers.Find(teacherFilter).FirstOrDefault();
            //if (result.Role == "teacher")
            MainForm mainForm = new MainForm(this);
            mainForm.Show();
            this.Hide();
        }

        private void ToggleVisiblePassword(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = txbPassword.PasswordChar == '\0' ? '•' : '\0';
        }
    }
}
