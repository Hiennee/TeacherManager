namespace TeacherManager
{
    partial class FormQLHK
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
            label1 = new Label();
            btnAddSemester = new CustomControls.CustomButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(719, 197);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Quản lý học kỳ";
            // 
            // btnAddSemester
            // 
            btnAddSemester.BackColor = Color.MediumSlateBlue;
            btnAddSemester.BackgroundColor = Color.MediumSlateBlue;
            btnAddSemester.BorderColor = Color.PaleVioletRed;
            btnAddSemester.BorderRadius = 10;
            btnAddSemester.BorderSize = 0;
            btnAddSemester.FlatAppearance.BorderSize = 0;
            btnAddSemester.FlatStyle = FlatStyle.Flat;
            btnAddSemester.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSemester.ForeColor = Color.White;
            btnAddSemester.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddSemester.Location = new Point(1155, 55);
            btnAddSemester.Name = "btnAddSemester";
            btnAddSemester.Size = new Size(201, 43);
            btnAddSemester.TabIndex = 3;
            btnAddSemester.Text = "Thêm học kỳ";
            btnAddSemester.TextColor = Color.White;
            btnAddSemester.UseVisualStyleBackColor = false;
            btnAddSemester.Click += ShowAddSemesterForm;
            // 
            // FormQLHK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddSemester);
            Controls.Add(label1);
            Name = "FormQLHK";
            Size = new Size(1572, 899);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TeacherManager.CustomControls.CustomButton btnAddSemester;
    }
}
