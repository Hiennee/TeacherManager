﻿using System;
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
            lblSemester.Text = "Học kỳ " + Class.SemesterId;
            lblClassId.Text = Class.ClassId;
        }
        private void ClassDisplayControl_Load(object sender, EventArgs e)
        {
            BorderWidth = 10;
            BorderColor = Color.FromArgb(55, 28, 191);
            BringToFront();
        }
        private void ShowClassDescriptionForm(object sender, EventArgs e)
        {
            //Parent.panelClasses.Visible = false;
            new FormClassDescription(Class).Show();
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
