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
    public partial class ClassDisplayControl : UserControl
    {
        Class Class;
        public ClassDisplayControl(Class Class)
        {
            this.Class = Class;
            
            InitializeComponent();
            lblClassName.Text = Class.Name;
            lblSemester.Text = Class.SemesterId;
        }

        private void ClassDisplayControl_Load(object sender, EventArgs e)
        {
            BorderWidth = 10;
            BorderColor = Color.Orange;
            BringToFront();
        }
    }
}
