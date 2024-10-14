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
    public partial class SemesterDisplayControl : UserControl
    {
        Semester semester;
        public SemesterDisplayControl(Semester semester)
        {
            this.semester = semester;
            InitializeComponent();
            lblSemester.Text = "Học kỳ " + semester.SemesterId;
        }

        private void ClassDisplayControl_Load(object sender, EventArgs e)
        {
            BorderWidth = 10;
            BorderColor = Color.FromArgb(55, 28, 191);
            BringToFront();
        }

        private void ShowSemesterDescriptionForm(object sender, EventArgs e)
        {
            new FormSemesterDescription(semester).Show();
        }

        private void Hover(object sender, EventArgs e)
        {
            BackColor = ControlPaint.Dark(BackColor, 0.05F);
        }
        private void EndHover(object sender, EventArgs e)
        {
            BackColor = SystemColors.Window;
        }
    }
}
