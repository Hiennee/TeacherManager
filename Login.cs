using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;
using System.Drawing.Text;
using TeacherManager.Models;

namespace TeacherManager
{
    public partial class Login : Form
    {
        public MongoClient client;
        public static IMongoDatabase database;
        public IMongoCollection<Account> accounts;
        public PrivateFontCollection privateFonts = new PrivateFontCollection();
        public Font customFont;
        public Login()
        {
            InitializeComponent();
            client = new MongoClient("mongodb+srv://hienne:Hien123@clusterhehe.vjr23zx.mongodb.net/?retryWrites=true&w=majority&appName=Clusterhehe");
            database = client.GetDatabase("TeacherManager");
            accounts = database.GetCollection<Account>("Account");
        }
        public void OnLoginAttempt(object sender, EventArgs e)
        {
            var filter = Builders<Account>.Filter.Eq("accountId", txbID.Text) &
                         Builders<Account>.Filter.Eq("password", txbPassword.Text);
            var result = accounts.Find(filter).FirstOrDefault();
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
