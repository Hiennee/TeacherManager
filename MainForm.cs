using CustomControls.CustomControls;
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

namespace TeacherManager
{
    public partial class MainForm : Form
    {
        List<UserControl> userControls;
        List<CustomButton> navigateButtons;
        Navigator navigator;
        Account account;
        Teacher? teacher;
        IMongoCollection<Teacher> teachers;
        public MainForm(Account account)
        {
            this.account = account;
            InitializeComponent();
            InitializeCollections();
            IdentifyTeacher();
            InitializeNavigator();
        }
        void InitializeCollections()
        {
            teachers = Login.database.GetCollection<Teacher>("Teacher");
        }
        void IdentifyTeacher()
        {
            var filter = Builders<Teacher>.Filter.Eq("email", account.email);
            teacher = teachers.Find(filter).FirstOrDefault() ?? null;
            label1.Text = "Xin chào " + teacher.name;
        }
        void InitializeNavigator()
        {
            navigateButtons = new List<CustomButton>()
            {
                btnQLLH,
                btnQLTK,
                btnLGD,
                btnLHK,
                btnLogOut,
            };
            userControls = new List<UserControl>()
            {
                new Index()
            };
            navigator = new Navigator(userControls, panelControl);
            navigator.Display(0);
        }
        private void CheckNavigateButton(CustomButton btn)
        {
            btn.BackgroundColor = Color.DarkSlateBlue;
        }
        private void UncheckNavigateButton(CustomButton btn)
        {
            btn.BackgroundColor = Color.MediumSlateBlue;
        }
        public void OnButtonNavigateClick(object sender, EventArgs e)
        {
            CustomButton btn = (CustomButton)sender;
            switch (btn.Name)
            {
                case "btnQLLH":
                    CheckNavigateButton(btn);
                    foreach (CustomButton customButton in navigateButtons)
                    {
                        if (customButton.Name == "btnQLLH")
                            continue;
                        UncheckNavigateButton(customButton);
                    }
                    break;
                case "btnQLTK":
                    CheckNavigateButton(btn);
                    foreach (CustomButton customButton in navigateButtons)
                    {
                        if (customButton.Name == "btnQLTK")
                            continue;
                        UncheckNavigateButton(customButton);
                    }
                    break;
                case "btnLGD":
                    CheckNavigateButton(btn);
                    foreach (CustomButton customButton in navigateButtons)
                    {
                        if (customButton.Name == "btnLGD")
                            continue;
                        UncheckNavigateButton(customButton);
                    }
                    break;
                case "btnLHK":
                    CheckNavigateButton(btn);
                    foreach (CustomButton customButton in navigateButtons)
                    {
                        if (customButton.Name == "btnLHK")
                            continue;
                        UncheckNavigateButton(customButton);
                    }
                    break;
                case "btnLogOut":
                    CheckNavigateButton(btn);
                    foreach (CustomButton customButton in navigateButtons)
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
        private void NavigateWithButton()
        {

        }
        private void LoadClassManagerForm(object sender, EventArgs e)
        {

        }
    }
}
