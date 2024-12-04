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
    public partial class FormQLBM : UserControl
    {
        IMongoCollection<Account> Accounts;
        IMongoCollection<Semester> Semesters;
        IMongoCollection<Class> Classes;
        IMongoCollection<Faculty> Faculties;

        ICollection<Semester> SemestersToDisplay;

        private Account account;

        bool isDescendingSort = true;
        public FormQLBM()
        {
            Accounts = Login.Accounts;
            Semesters = Login.Semesters;
            Classes = Login.Classes;
            Faculties = Login.Faculties;
            account = Login.Account;
            InitializeComponent();
            CheckButtonAddFacultyVisible();
            InitializeFacultiesDataGridView();
            InitializeFacultiesData();
            InitializeComboBoxSort();
            Size = MainForm.PanelControlSize;
        }
        private void CheckButtonAddFacultyVisible()
        {
            if (!account.Role.Equals("Admin"))
            {
                btnAddFaculty.Visible = false;
            }
        }
        private void InitializeComboBoxSort()
        {
            cbSort.DataSource = new List<string>
            {
                "Aa-Zz",
                "Zz-Aa",
            };
        }
        private void OnSortChange(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
            {
                isDescendingSort = false;
                InitializeFacultiesData();
                return;
            }
            isDescendingSort = true;
            InitializeFacultiesData();
        }
        private void InitializeFacultiesDataGridView()
        {
            dataViewFaculties.Columns.Clear();

            dataViewFaculties.Columns.Add("columnFacultyId", "Mã bộ môn");
            dataViewFaculties.Columns.Add("columnFacultyName", "Tên bộ môn");
            dataViewFaculties.Columns.Add("columnHeadTeacherId", "Trưởng bộ môn");
            dataViewFaculties.Columns.Add("columnHeadTeacherName", "Tên giảng viên");

            dataViewFaculties.Columns["columnFacultyId"].Width += 50;
            dataViewFaculties.Columns["columnFacultyName"].Width += 200;
            dataViewFaculties.Columns["columnHeadTeacherId"].Width += 50;
            dataViewFaculties.Columns["columnHeadTeacherName"].Width += 100;

            foreach (DataGridViewColumn column in dataViewFaculties.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void InitializeFacultiesData()
        {
            SortDefinition<Faculty> sortDef;
            sortDef = isDescendingSort ?
                      Builders<Faculty>.Sort.Descending(f => f.Name) :
                      Builders<Faculty>.Sort.Ascending(f => f.Name);
            var resultFaculties = Faculties.Find(Builders<Faculty>.Filter.Empty)
                                           .Sort(sortDef)
                                           .ToList();

            dataViewFaculties.Rows.Clear();

            foreach (var f in resultFaculties)
            {
                int rowIndex = dataViewFaculties.Rows.Add();
                var resultAccount = Accounts.Find(Builders<Account>.Filter.Eq(a => a.AccountId, f.HeadTeacher)).FirstOrDefault();

                dataViewFaculties.Rows[rowIndex].Cells["columnFacultyId"].Value = f.FacultyId;
                dataViewFaculties.Rows[rowIndex].Cells["columnFacultyName"].Value = f.Name;
                dataViewFaculties.Rows[rowIndex].Cells["columnHeadTeacherId"].Value = resultAccount.AccountId;
                dataViewFaculties.Rows[rowIndex].Cells["columnHeadTeacherName"].Value = resultAccount.Name;
            }
        }
        private void ShowAddFacultyForm(object sender, EventArgs e)
        {
            if (new FormCreateFaculty().ShowDialog() == DialogResult.OK)
            {
                InitializeFacultiesData();
            }
        }
    }
}
