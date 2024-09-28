using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherManager.Models
{
    public class Navigator
    {
        List<UserControl> controls;
        Panel panel;
        public Navigator(List<UserControl> controls, Panel panel)
        {
            this.controls = controls;
            this.panel = panel;
            foreach (UserControl ctrl in controls)
            {
                ctrl.Dock = DockStyle.Fill;
                panel.Controls.Add(ctrl);
            }
        }
        public void Display(int index)
        {
            controls[index].BringToFront();
        }
    }
}
