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
    public partial class FormQLLH : UserControl
    {
        IMongoCollection<Class> Classes = Login.Database.GetCollection<Class>("Class");
        IMongoCollection<Account> Accounts;
        IMongoCollection<Teacher> Teachers;
        IMongoCollection<Student> Students;
        ICollection<Class> ClassesToDisplay;
        Account Account;
        Teacher Teacher;
        Navigator Navigator;
        
        public FormQLLH()
        {
            Size = MainForm.PanelControlSize;
            Classes = Login.Classes;
            Accounts = Login.Accounts;
            Teachers = Login.Teachers;
            Students = Login.Students;
            Account = Login.Account;
            Teacher = Login.Teacher;
            InitializeComponent();
            GetClassesOfTeacher();
            InitializeClasses();
        }
        private void GetClassesOfTeacher()
        {
            var filter = Account.Role == "Admin" ?
                         Builders<Class>.Filter.Empty : 
                         Builders<Class>.Filter.Eq(c => c.TeacherId, Teacher.accountId);
            var result = Classes.Find(filter);
            ClassesToDisplay = result.ToList();
        }
        private void ShowAddClassForm(object sender, EventArgs e)
        {
            if (new FormCreateClass().ShowDialog() == DialogResult.OK)
            {
                GetClassesOfTeacher();
            }
        }
        void InitializeClasses()
        {
            if (ClassesToDisplay == null)
            {
                return;
            }
            foreach(var c in ClassesToDisplay)
            {
                panelClasses.Controls.Add(new ClassDisplayControl(c, this));
            }
        }
    }
}
