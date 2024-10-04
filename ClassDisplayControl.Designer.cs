namespace TeacherManager
{
    partial class ClassDisplayControl
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
            lblClassName = new Label();
            lblSemester = new Label();
            pictureClass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureClass).BeginInit();
            SuspendLayout();
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(17, 273);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(70, 28);
            lblClassName.TabIndex = 1;
            lblClassName.Text = "label1";
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Location = new Point(17, 313);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(50, 20);
            lblSemester.TabIndex = 2;
            lblSemester.Text = "label2";
            // 
            // pictureClass
            // 
            pictureClass.Image = Properties.Resources.courses_class_whiteboard_1;
            pictureClass.Location = new Point(-53, -23);
            pictureClass.Name = "pictureClass";
            pictureClass.Size = new Size(625, 281);
            pictureClass.SizeMode = PictureBoxSizeMode.Zoom;
            pictureClass.TabIndex = 3;
            pictureClass.TabStop = false;
            // 
            // ClassDisplayControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(pictureClass);
            Controls.Add(lblSemester);
            Controls.Add(lblClassName);
            Margin = new Padding(150, 100, 3, 3);
            Name = "ClassDisplayControl";
            Size = new Size(513, 346);
            Load += ClassDisplayControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblClassName;
        private Label lblSemester;
        private PictureBox pictureClass;
    }
}
