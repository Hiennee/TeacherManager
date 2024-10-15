using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Net;
using System.Net.Mail;
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
        public static SmtpClient smtpClient;
        public static MailAddress mailSender;

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


            mailSender = new MailAddress("<your_email_address>", "Mã Chấn Hiền");
            smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(mailSender.Address, "<your_email_password>")
            };
        }
        public void OnLoginAttempt(object sender, EventArgs e)
        {
            var filter = Builders<Account>.Filter.Eq("email", txbID.Text) &
                         Builders<Account>.Filter.Eq("password", txbPassword.Text);
            Account = Accounts.Find(filter).FirstOrDefault();
            if (Account == null)
            {
                MessageBox.Show("Sai tên người dùng hoặc mật khẩu",
                                "Thông báo",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Error);
                return;
            }
            if (Account.Role == "Student")
            {
                MessageBox.Show("Ứng dụng quản lý giành cho Giảng viên, nhân viên\n" +
                                "Học sinh vui lòng vào App",
                                "Thông báo", 
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information);
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
