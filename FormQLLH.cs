using MongoDB.Bson;
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

        private bool isDescendingSort = true;
        private string classesToFind = "";
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
            InitializeComboBoxSort();
            InitializeClasses();
        }
        private void InitializeComboBoxSort()
        {
            cbSort.DataSource = new List<string>
            {
                "Từ Aa-Zz",
                "Từ Zz-Aa",
            };
        }
        private void OnSortChange(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
            {
                isDescendingSort = false;
                InitializeClasses();
                return;
            }
            isDescendingSort = true;
            InitializeClasses();
        }
        private void UpdateNameClassesToFind(object sender, EventArgs e)
        {
            classesToFind = txtBoxClassNameToFind.Texts;
            InitializeClasses();
        }
        private void GetClassesToDisplay()
        {
            SortDefinition<Class> sortClass;
            var filterClass = Account.Role == "Admin" ?
                              Builders<Class>.Filter.Empty :
                              Builders<Class>.Filter.Eq(c => c.TeacherId, Teacher.AccountId);
            var filterClassWithName = txtBoxClassNameToFind.Texts.Equals("") ?
                                      Builders<Class>.Filter.Empty :
                                      Builders<Class>.Filter.Regex(c => c.Name, new BsonRegularExpression($".*{classesToFind}.*", "i")) |
                                      Builders<Class>.Filter.Regex(c => c.ClassId, new BsonRegularExpression($".*{classesToFind}.*", "i"));
            sortClass = isDescendingSort ?
                        Builders<Class>.Sort.Descending(c => c.Name) :
                        Builders<Class>.Sort.Ascending(c => c.Name);
            var result = Classes.Find(filterClass & filterClassWithName).Sort(sortClass);
            ClassesToDisplay = result.ToList();
        }
        private void ReloadClasses(object sender, EventArgs e)
        {
            InitializeClasses();
        }
        void InitializeClasses()
        {
            GetClassesToDisplay();
            panelClasses.Controls.Clear();
            if (ClassesToDisplay.Count <= 0)
            {
                return;
            }
            foreach (var c in ClassesToDisplay)
            {
                panelClasses.Controls.Add(new ClassDisplayControl(c));
            }
        }
    }
}
