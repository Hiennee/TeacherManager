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
            lblHeader = new Label();
            panelSemesters = new FlowLayoutPanel();
            lblSort = new Label();
            cbSort = new CustomControls.CustomComboBox();
            btnAddSemester = new CustomControls.CustomButton();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(22, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(203, 31);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "QUẢN LÝ HỌC KỲ";
            // 
            // panelSemesters
            // 
            panelSemesters.AutoScroll = true;
            panelSemesters.Location = new Point(41, 137);
            panelSemesters.Name = "panelSemesters";
            panelSemesters.RightToLeft = RightToLeft.No;
            panelSemesters.Size = new Size(1486, 683);
            panelSemesters.TabIndex = 5;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Font = new Font("Segoe UI", 13.8F);
            lblSort.Location = new Point(41, 94);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(147, 31);
            lblSort.TabIndex = 6;
            lblSort.Text = "Sắp xếp theo";
            // 
            // cbSort
            // 
            cbSort.BackColor = Color.White;
            cbSort.BorderColor = Color.MediumSlateBlue;
            cbSort.BorderSize = 2;
            cbSort.DropDownStyle = ComboBoxStyle.DropDown;
            cbSort.Font = new Font("Segoe UI", 10F);
            cbSort.ForeColor = Color.DimGray;
            cbSort.IconColor = Color.MediumSlateBlue;
            cbSort.ListBackColor = Color.FromArgb(230, 228, 245);
            cbSort.ListTextColor = Color.DimGray;
            cbSort.Location = new Point(194, 93);
            cbSort.MinimumSize = new Size(50, 30);
            cbSort.Name = "cbSort";
            cbSort.Padding = new Padding(2);
            cbSort.Size = new Size(141, 38);
            cbSort.TabIndex = 7;
            cbSort.Texts = "";
            cbSort.OnSelectedIndexChanged += OnSortChange;
            // 
            // btnAddSemester
            // 
            btnAddSemester.BackColor = Color.MediumSlateBlue;
            btnAddSemester.BackgroundColor = Color.MediumSlateBlue;
            btnAddSemester.BorderColor = Color.PaleVioletRed;
            btnAddSemester.BorderRadius = 10;
            btnAddSemester.BorderSize = 0;
            btnAddSemester.Cursor = Cursors.Hand;
            btnAddSemester.FlatAppearance.BorderSize = 0;
            btnAddSemester.FlatStyle = FlatStyle.Flat;
            btnAddSemester.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSemester.ForeColor = Color.White;
            btnAddSemester.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddSemester.Location = new Point(1326, 15);
            btnAddSemester.Name = "btnAddSemester";
            btnAddSemester.Size = new Size(201, 43);
            btnAddSemester.TabIndex = 17;
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
            Controls.Add(cbSort);
            Controls.Add(lblSort);
            Controls.Add(panelSemesters);
            Controls.Add(lblHeader);
            Name = "FormQLHK";
            Size = new Size(1572, 899);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TeacherManager.CustomControls.CustomButton btnAddSemester;
        private Label lblHeader;
        private FlowLayoutPanel panelSemesters;
        private Label lblSort;
        private CustomControls.CustomComboBox cbSort;
    }
}
