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
        public MongoClient Client;
        public static IMongoDatabase Database;
        public IMongoCollection<Account> Accounts;
        public PrivateFontCollection PrivateFonts = new PrivateFontCollection();
        public Font CustomFont;
        public Login()
        {
            string connectionString = Environment.GetEnvironmentVariable("MONGODB_ATLAS_CONNECTION_STRING") ?? "";
            InitializeComponent();
            Client = new MongoClient(connectionString);
            Database = Client.GetDatabase("TeacherManager");
            Accounts = Database.GetCollection<Account>("Account");
        }
        public void OnLoginAttempt(object sender, EventArgs e)
        {
            var filter = Builders<Account>.Filter.Eq("accountId", txbID.Text) &
                         Builders<Account>.Filter.Eq("password", txbPassword.Text);
            var result = Accounts.Find(filter).FirstOrDefault();
            Console.WriteLine(result);
            Console.WriteLine("hello");
            if (result == null)
            {
                MessageBox.Show("Sai tên người dùng hoặc mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            MainForm mainForm = new MainForm(result);
            mainForm.Show();
            this.Hide();
        }

        private void ToggleVisiblePassword(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = txbPassword.PasswordChar == '\0' ? '•' : '\0';
        }
    }
}
