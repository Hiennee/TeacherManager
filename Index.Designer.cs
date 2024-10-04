namespace TeacherManager
{
    partial class Index
    {
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
            textBox1 = new TextBox();
            btnAddClass = new CustomControls.CustomButton();
            textBox2 = new TextBox();
            btnAddStudent = new CustomControls.CustomButton();
            customButton1 = new CustomControls.CustomButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(372, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Trang chủ";
            // 
            // btnAddClass
            // 
            btnAddClass.BackColor = Color.MediumSlateBlue;
            btnAddClass.BackgroundColor = Color.MediumSlateBlue;
            btnAddClass.BorderColor = Color.PaleVioletRed;
            btnAddClass.BorderRadius = 10;
            btnAddClass.BorderSize = 0;
            btnAddClass.FlatAppearance.BorderSize = 0;
            btnAddClass.FlatStyle = FlatStyle.Flat;
            btnAddClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddClass.ForeColor = Color.White;
            btnAddClass.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddClass.Location = new Point(1204, 32);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(201, 43);
            btnAddClass.TabIndex = 1;
            btnAddClass.Text = "Thêm giảng viên";
            btnAddClass.TextColor = Color.White;
            btnAddClass.UseVisualStyleBackColor = false;
            btnAddClass.Click += CreateTeacher;
            btnAddClass.MouseLeave += BtnAddClass_MouseLeave;
            btnAddClass.MouseHover += BtnAddClass_MouseHover;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(734, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "Trang chủ";
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.MediumSlateBlue;
            btnAddStudent.BackgroundColor = Color.MediumSlateBlue;
            btnAddStudent.BorderColor = Color.PaleVioletRed;
            btnAddStudent.BorderRadius = 10;
            btnAddStudent.BorderSize = 0;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddStudent.Location = new Point(1204, 89);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(201, 43);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Thêm sinh viên";
            btnAddStudent.TextColor = Color.White;
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += CreateStudent;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.MediumSlateBlue;
            customButton1.BackgroundColor = Color.MediumSlateBlue;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 10;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.ImageAlign = ContentAlignment.MiddleLeft;
            customButton1.Location = new Point(1204, 190);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(201, 43);
            customButton1.TabIndex = 4;
            customButton1.Text = "Xóa tất cả SV";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += DeleteStudents;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customButton1);
            Controls.Add(btnAddStudent);
            Controls.Add(textBox2);
            Controls.Add(btnAddClass);
            Controls.Add(textBox1);
            Name = "Index";
            Size = new Size(1492, 589);
            Click += DeleteStudents;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TeacherManager.CustomControls.CustomButton btnAddClass;
        private TextBox textBox2;
        private TeacherManager.CustomControls.CustomButton btnAddStudent;
        private TeacherManager.CustomControls.CustomButton customButton1;
    }
}
