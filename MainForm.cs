using CustomControls.CustomControls;
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

namespace TeacherManager
{
    public partial class MainForm : Form
    {
        public static Size PanelControlSize;

        List<UserControl> UserControls;
        List<CustomButton> NavigateButtons;
        Navigator Navigator;
        Account Account;
        Teacher? Teacher;
        IMongoCollection<Teacher> teachers;
        public MainForm(Account account)
        { 
            this.Account = account;
            
            InitializeComponent();
            InitializeCollections();
            IdentifyTeacher();
            InitializeNavigator();
            PanelControlSize = panelControl.Size;
        }
        void InitializeCollections()
        {
            teachers = Login.Database.GetCollection<Teacher>("Teacher");
        }
        void IdentifyTeacher()
        {
            var filter = Builders<Teacher>.Filter.Eq("email", Account.Email);
            Teacher = teachers.Find(filter).FirstOrDefault() ?? null;
            label1.Text = "Xin chào " + Teacher.Name;
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
        private void NavigateWithButton()
        {

        }
        private void LoadClassManagerForm(object sender, EventArgs e)
        {

        }

        private void btnLHK_Click(object sender, EventArgs e)
        {

        }
    }
}
