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
        public FormQLHK()
        {
            Semesters = Login.Semesters;
            Classes = Login.Classes;
            InitializeComponent();
            InitializeSemesters();
            Size = MainForm.PanelControlSize;
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
            var semesterFilter = Builders<Semester>.Filter.Empty;
            SemestersToDisplay = Semesters.Find(semesterFilter).ToList();
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
