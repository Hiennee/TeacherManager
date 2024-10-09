using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherManager.CustomControls
{
    public partial class DividerControl : UserControl
    {
        // Private fields for properties
        private Color dividerColor = Color.Gray;
        private int thickness = 2;
        private bool isVertical = false;

        // Property to set Divider Color
        public Color DividerColor
        {
            get { return dividerColor; }
            set
            {
                dividerColor = value;
                this.Invalidate(); // Redraw when the property changes
            }
        }

        // Property to set Thickness
        public int Thickness
        {
            get { return thickness; }
            set
            {
                thickness = value;
                this.Invalidate(); // Redraw when the property changes
            }
        }

        // Property to set Orientation (Horizontal or Vertical)
        public bool IsVertical
        {
            get { return isVertical; }
            set
            {
                isVertical = value;
                this.Invalidate(); // Redraw when the property changes
            }
        }

        // Enable auto resizing of the control based on orientation and thickness
        public DividerControl()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true; // Prevents flickering
            this.SizeChanged += DividerControl_SizeChanged;
        }

        // Handles resizing based on orientation
        private void DividerControl_SizeChanged(object sender, EventArgs e)
        {
            if (isVertical)
            {
                // Make sure the width follows the thickness in vertical orientation
                this.Width = thickness;
            }
            else
            {
                // Make sure the height follows the thickness in horizontal orientation
                this.Height = thickness;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a pen with the specified color and thickness
            using (Pen dividerPen = new Pen(dividerColor, thickness))
            {
                Graphics g = e.Graphics;

                // Set up anti-aliasing for smoother lines
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Draw either a horizontal or vertical divider
                if (isVertical)
                {
                    // Vertical divider (draw from top to bottom)
                    g.DrawLine(dividerPen, this.Width / 2, 0, this.Width / 2, this.Height);
                }
                else
                {
                    // Horizontal divider (draw from left to right)
                    g.DrawLine(dividerPen, 0, this.Height / 2, this.Width, this.Height / 2);
                }
            }
        }
    }

}