using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherManager.Models
{
    public partial class ScheduleDisplay : UserControl
    {
        public ScheduleDisplay(string className, string from, string to, string room)
        {
            InitializeComponent();
            lblClassName.Text = className;
            lblSchedule.Text = $"{from} - {to}";
            lblRoom.Text = "Phòng " + room;
        }
    }
}
