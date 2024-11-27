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
    public partial class FormQLHK : UserControl
    {
        IMongoCollection<Semester> Semesters;
        IMongoCollection<Class> Classes;
        ICollection<Semester> SemestersToDisplay;

        private Account account;

        bool isDescendingSort = true;
        public FormQLHK()
        {
            Semesters = Login.Semesters;
            Classes = Login.Classes;
            account = Login.Account;
            InitializeComponent();
            CheckButtonAddSemesterVisible();
            InitializeSemesters();
            InitializeComboBoxSort();
            Size = MainForm.PanelControlSize;
        }
        private void CheckButtonAddSemesterVisible()
        {
            if (!account.Role.Equals("Admin"))
            {
                btnAddSemester.Visible = false;
            }
        }
        private void InitializeComboBoxSort()
        {
            cbSort.DataSource = new List<string>
            {
                "Tăng dần",
                "Giảm dần",
            };
        }
        private void OnSortChange(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
            {
                isDescendingSort = false;
                InitializeSemesters();
                return;
            }
            isDescendingSort = true;
            InitializeSemesters();
        }
        private void ShowAddSemesterForm(object sender, EventArgs e)
        {
            if (new FormCreateSemester().ShowDialog() == DialogResult.OK)
            {
                InitializeSemesters();
            }
        }
        private void InitializeSemesters()
        {
            panelSemesters.Controls.Clear();

            SortDefinition<Semester> semesterSortFilter;
            var semesterFilter = Builders<Semester>.Filter.Empty;
            semesterSortFilter = isDescendingSort ?
                                 Builders<Semester>.Sort.Descending(s => s.SemesterId) :
                                 Builders<Semester>.Sort.Ascending(s => s.SemesterId);
            SemestersToDisplay = Semesters.Find(semesterFilter).Sort(semesterSortFilter).ToList();
            if (SemestersToDisplay.Count > 0)
            {
                foreach (Semester s in  SemestersToDisplay)
                {
                    panelSemesters.Controls.Add(new SemesterDisplayControl(s));
                }
            }
        }
    }
}
