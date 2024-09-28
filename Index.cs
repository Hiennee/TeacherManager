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
    public partial class Index : UserControl
    {
        public Index()
        {
            InitializeComponent();
        }

        private void BtnAddClass_MouseLeave(object? sender, EventArgs e)
        {
            btnAddClass.BackgroundColor = Color.MediumSlateBlue;
        }

        private void BtnAddClass_MouseHover(object? sender, EventArgs e)
        {
            btnAddClass.BackgroundColor = Color.Orange;
        }
    }
}
