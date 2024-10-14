namespace TeacherManager
{
    partial class SemesterDisplayControl
    {
        private int borderWidth = 5;  // Default border width
        private Color borderColor = Color.Black;  // Default border color

        public int BorderWidth
        {
            get => borderWidth;
            set
            {
                borderWidth = value;
                Invalidate();  // Redraw control when border width is updated
            }
        }

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();  // Redraw control when border color is updated
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Get the Graphics object for drawing
            Graphics g = e.Graphics;
            // Draw the border
            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                g.DrawRectangle(borderPen, borderWidth / 2, borderWidth / 2,
                                Width - borderWidth, Height - borderWidth);
            }
        }
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSemester = new Label();
            pictureSemester = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureSemester).BeginInit();
            SuspendLayout();
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemester.Location = new Point(17, 293);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(110, 28);
            lblSemester.TabIndex = 1;
            lblSemester.Text = "Mã học kỳ";
            // 
            // pictureSemester
            // 
            pictureSemester.Image = Properties.Resources.courses_class_whiteboard_1;
            pictureSemester.Location = new Point(17, 16);
            pictureSemester.Name = "pictureSemester";
            pictureSemester.Size = new Size(479, 263);
            pictureSemester.SizeMode = PictureBoxSizeMode.Zoom;
            pictureSemester.TabIndex = 3;
            pictureSemester.TabStop = false;
            pictureSemester.Click += ShowSemesterDescriptionForm;
            // 
            // SemesterDisplayControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(pictureSemester);
            Controls.Add(lblSemester);
            Cursor = Cursors.Hand;
            Margin = new Padding(150, 100, 3, 3);
            Name = "SemesterDisplayControl";
            Size = new Size(513, 346);
            Click += ShowSemesterDescriptionForm;
            MouseEnter += Hover;
            MouseLeave += EndHover;
            ((System.ComponentModel.ISupportInitialize)pictureSemester).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSemester;
        private PictureBox pictureSemester;
    }
}
