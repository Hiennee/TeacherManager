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
            btnAddSemester = new CustomControls.CustomButton();
            lblHeader = new Label();
            panelSemesters = new FlowLayoutPanel();
            SuspendLayout();
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
            btnAddSemester.Location = new Point(1193, 15);
            btnAddSemester.Name = "btnAddSemester";
            btnAddSemester.Size = new Size(201, 43);
            btnAddSemester.TabIndex = 3;
            btnAddSemester.Text = "Thêm học kỳ";
            btnAddSemester.TextColor = Color.White;
            btnAddSemester.UseVisualStyleBackColor = false;
            btnAddSemester.Click += ShowAddSemesterForm;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(22, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(218, 31);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // panelSemesters
            // 
            panelSemesters.AutoScroll = true;
            panelSemesters.Location = new Point(41, 81);
            panelSemesters.Name = "panelSemesters";
            panelSemesters.RightToLeft = RightToLeft.No;
            panelSemesters.Size = new Size(1486, 794);
            panelSemesters.TabIndex = 5;
            // 
            // FormQLHK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSemesters);
            Controls.Add(lblHeader);
            Controls.Add(btnAddSemester);
            Name = "FormQLHK";
            Size = new Size(1572, 899);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TeacherManager.CustomControls.CustomButton btnAddSemester;
        private Label lblHeader;
        private FlowLayoutPanel panelSemesters;
    }
}
