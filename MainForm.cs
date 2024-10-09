using TeacherManager.CustomControls;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManager.Models;
using Amazon.Auth.AccessControlPolicy;

namespace TeacherManager
{
    public partial class MainForm : Form
    {
        public static Size PanelControlSize;
        private string Base64Image;

        List<UserControl> UserControls;
        List<CustomButton> NavigateButtons;
        Navigator Navigator;
        Account Account;
        Teacher? Teacher;
        Login LoginForm;

        IMongoCollection<Teacher> Teachers;
        IMongoCollection<Account> Accounts;
        IMongoCollection<Class> Classes;
        IMongoCollection<Semester> Semesters;
        IMongoCollection<Student_Class_Detail> StudentClasses;
        public MainForm(Login loginForm)
        {
            this.Account = Login.Account;
            LoginForm = loginForm;
            Base64Image = Account.Avatar ?? "";
            LoginForm = new Login();
            InitializeComponent();
            InitializeCollections();
            IdentifyTeacher();
            InitializeNavigator();
            LoadAvatar();
            PanelControlSize = panelControl.Size;
            //BackColor = ColorTranslator.FromHtml("#212121");
            //panelControl.BackColor = ColorTranslator.FromHtml("#424242");
            //panelNavigate.BackColor = ColorTranslator.FromHtml("#800000");
        }
        void InitializeCollections()
        {
            Teachers = Login.Teachers;
            Accounts = Login.Accounts;
            Classes = Login.Classes;
            Semesters = Login.Semesters;
            StudentClasses = Login.StudentClasses;
        }
        void IdentifyTeacher()
        {
            var filter = Builders<Teacher>.Filter.Eq("MSGV", Account.AccountId);
            Teacher = Teachers.Find(filter).FirstOrDefault() ?? null;
            lblName.Text = Account.Name;
        }
        void InitializeNavigator()
        {
            NavigateButtons = new List<CustomButton>()
            {
                btnQLLH,
                btnQLTK,
                btnLGD,
                btnQLHK,
                btnLogOut,
            };
            UserControls = new List<UserControl>()
            {
                new Index(),
                new FormQLLH(),
                new FormQLTK(),
                new FormQLHK(),
                new FormLGD(),
            };
            Navigator = new Navigator(UserControls, panelControl);
            Navigator.Display(0);
        }
        private void LoadAvatar()
        {
            if (Base64Image == "")
            {
                pictureAvt.Image = Properties.Resources.default_avatar_icon;
                return;
            }
            pictureAvt.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAvt.Image = Base64ToImage(Base64Image);
        }
        private void CheckNavigateButton(Control ctrl)
        {
            ctrl.BackColor = Color.Navy;
        }
        private void UncheckNavigateButton(Control ctrl)
        {
            ctrl.BackColor = Color.CornflowerBlue;
        }
        public void OnButtonNavigateClick(object sender, EventArgs e)
        {
            Control btn = (Control)sender;

            switch (btn.Name)
            {
                case "customButton1":
                    CheckNavigateButton(btn);
                    Navigator.Display(0);
                    foreach (CustomButton customButton in NavigateButtons)
                    {
                        if (customButton.Name == "customButton1")
                            continue;
                        UncheckNavigateButton(customButton);
                    }
                    break;
                case "btnQLLH":
                    CheckNavigateButton(btn);
                    Navigator.Display(1);
                    foreach (CustomButton customButton in NavigateButtons)
                    {
                        if (customButton.Name == "btnQLLH")
                            continue;
                        UncheckNavigateButton(customButton);
                    }
                    break;
                case "btnQLTK":
                    CheckNavigateButton(btn);
                    Navigator.Display(2);
                    foreach (CustomButton customButton in NavigateButtons)
                    {
                        if (customButton.Name == "btnQLTK")
                            continue;
                        UncheckNavigateButton(customButton);
                    }
                    break;
                case "btnQLHK":
                    CheckNavigateButton(btn);
                    Navigator.Display(3);
                    foreach (CustomButton customButton in NavigateButtons)
                    {
                        if (customButton.Name == "btnQLHK")
                            continue;
                        UncheckNavigateButton(customButton);
                    }
                    break;
                case "btnLGD":
                    CheckNavigateButton(btn);
                    Navigator.Display(4);
                    foreach (CustomButton customButton in NavigateButtons)
                    {
                        if (customButton.Name == "btnLGD")
                            continue;
                        UncheckNavigateButton(customButton);
                    }
                    break;
                case "btnLogOut":
                    CheckNavigateButton(btn);
                    foreach (CustomButton customButton in NavigateButtons)
                    {
                        if (customButton.Name == "btnLogOut")
                            continue;
                        UncheckNavigateButton(customButton);
                    }
                    break;
                default:
                    break;
            }
        }
        public void LogOut(object sender, EventArgs e)
        {
            Close();
            LoginForm.Show();
        }
        private void ChangeAvatar(object sender, EventArgs e)
        {
            string avtPath = "";
            ChooseAvtDialog.Filter = "Image Files (*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (ChooseAvtDialog.ShowDialog() == DialogResult.OK)
            {
                avtPath = ChooseAvtDialog.FileName;
                byte[] imageArray = System.IO.File.ReadAllBytes(avtPath);
                Base64Image = Convert.ToBase64String(imageArray);
            }
            var accountToUpdateAvatar = Builders<Account>.Filter.Eq(a => a.AccountId, Account.AccountId);
            var avatarToUpdate = Builders<Account>.Update.Set("avatar", Base64Image);
            Accounts.UpdateOne(accountToUpdateAvatar, avatarToUpdate);
            MessageBox.Show("Thay đổi ảnh đại diện thành công", "Thông báo");
            LoadAvatar();
        }
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        private void MainForm_Leave(object sender, EventArgs e)
        {
            LoginForm.Close();
        }
    }
}
