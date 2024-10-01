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
            btnAddClass = new CustomControls.CustomControls.CustomButton();
            textBox2 = new TextBox();
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
            btnAddClass.Text = "Thêm lớp";
            btnAddClass.TextColor = Color.White;
            btnAddClass.UseVisualStyleBackColor = false;
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
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(btnAddClass);
            Controls.Add(textBox1);
            Name = "Index";
            Size = new Size(1492, 589);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private CustomControls.CustomControls.CustomButton btnAddClass;
        private TextBox textBox2;
    }
}
