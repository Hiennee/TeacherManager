using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherManager
{
    public partial class FormQLHK : UserControl
    {
        public FormQLHK()
        {
            InitializeComponent();
            Size = MainForm.PanelControlSize;
        }

        private void ShowAddSemesterForm(object sender, EventArgs e)
        {
            new FormCreateSemester().ShowDialog();
        }
    }
}
