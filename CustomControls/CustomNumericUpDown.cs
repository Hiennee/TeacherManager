using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherManager.CustomControls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class CustomNumericUpDown : NumericUpDown
    {
        private Color borderColor = Color.Black;  // Default border color

        // Property to change the border color
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();  // Redraw the control to apply the new border color
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_PAINT = 0x000F;
            base.WndProc(ref m);

            // Hide the up-down buttons by adjusting their width to 0
            if (m.Msg == WM_PAINT)
            {
                if (Controls.Count > 0)
                {
                    Controls[0].Width = 0; // Set the width of the up-down button to 0 to hide it completely
                }
            }
        }

        // Override OnPaint to draw a custom border
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw a custom border
            using (Pen borderPen = new Pen(borderColor, 2))  // Use the borderColor property
            {
                // Adjust the rectangle so the border fits perfectly within the control
                Rectangle borderRect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
                e.Graphics.DrawRectangle(borderPen, borderRect);
            }
        }
    }
}
