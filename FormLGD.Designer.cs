namespace TeacherManager
{
    partial class FormLGD
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblHeader = new Label();
            lblSemester = new Label();
            txtBoxSemesterId = new CustomControls.CustomComboBox();
            lblHeaderMonth = new Label();
            lblMonth = new Label();
            lblSlash = new Label();
            lblYear = new Label();
            dataViewDaysOfMonth = new DataGridView();
            btnPrevMonth = new PictureBox();
            bnNextMonth = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataViewDaysOfMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPrevMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnNextMonth).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblHeader.Location = new Point(22, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(197, 31);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "LỊCH GIẢNG DẠY";
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSemester.Location = new Point(82, 128);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(148, 32);
            lblSemester.TabIndex = 1;
            lblSemester.Text = "Chọn học kì";
            // 
            // txtBoxSemesterId
            // 
            txtBoxSemesterId.BackColor = Color.White;
            txtBoxSemesterId.BorderColor = Color.MediumSlateBlue;
            txtBoxSemesterId.BorderSize = 2;
            txtBoxSemesterId.DropDownStyle = ComboBoxStyle.DropDown;
            txtBoxSemesterId.Font = new Font("Segoe UI", 10F);
            txtBoxSemesterId.ForeColor = Color.Black;
            txtBoxSemesterId.IconColor = Color.MediumSlateBlue;
            txtBoxSemesterId.ListBackColor = Color.White;
            txtBoxSemesterId.ListTextColor = Color.Black;
            txtBoxSemesterId.Location = new Point(246, 121);
            txtBoxSemesterId.MinimumSize = new Size(50, 30);
            txtBoxSemesterId.Name = "txtBoxSemesterId";
            txtBoxSemesterId.Padding = new Padding(2);
            txtBoxSemesterId.Size = new Size(228, 39);
            txtBoxSemesterId.TabIndex = 2;
            txtBoxSemesterId.Texts = "";
            txtBoxSemesterId.OnSelectedIndexChanged += LoadSemesterInfo;
            // 
            // lblHeaderMonth
            // 
            lblHeaderMonth.AutoSize = true;
            lblHeaderMonth.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeaderMonth.ForeColor = Color.Coral;
            lblHeaderMonth.Location = new Point(571, 199);
            lblHeaderMonth.Name = "lblHeaderMonth";
            lblHeaderMonth.Size = new Size(141, 46);
            lblHeaderMonth.TabIndex = 3;
            lblHeaderMonth.Text = "THÁNG";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMonth.ForeColor = Color.Coral;
            lblMonth.Location = new Point(704, 199);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(60, 46);
            lblMonth.TabIndex = 4;
            lblMonth.Text = "12";
            // 
            // lblSlash
            // 
            lblSlash.AutoSize = true;
            lblSlash.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSlash.ForeColor = Color.Coral;
            lblSlash.Location = new Point(759, 182);
            lblSlash.Name = "lblSlash";
            lblSlash.Size = new Size(34, 46);
            lblSlash.TabIndex = 5;
            lblSlash.Text = "_";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblYear.ForeColor = Color.Coral;
            lblYear.Location = new Point(789, 199);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(100, 46);
            lblYear.TabIndex = 6;
            lblYear.Text = "2024";
            // 
            // dataViewDaysOfMonth
            // 
            dataViewDaysOfMonth.AllowUserToAddRows = false;
            dataViewDaysOfMonth.AllowUserToDeleteRows = false;
            dataViewDaysOfMonth.AllowUserToResizeColumns = false;
            dataViewDaysOfMonth.AllowUserToResizeRows = false;
            dataViewDaysOfMonth.BackgroundColor = SystemColors.ControlLight;
            dataViewDaysOfMonth.BorderStyle = BorderStyle.None;
            dataViewDaysOfMonth.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataViewDaysOfMonth.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataViewDaysOfMonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataViewDaysOfMonth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataViewDaysOfMonth.DefaultCellStyle = dataGridViewCellStyle2;
            dataViewDaysOfMonth.EnableHeadersVisualStyles = false;
            dataViewDaysOfMonth.Location = new Point(246, 298);
            dataViewDaysOfMonth.MultiSelect = false;
            dataViewDaysOfMonth.Name = "dataViewDaysOfMonth";
            dataViewDaysOfMonth.ReadOnly = true;
            dataViewDaysOfMonth.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataViewDaysOfMonth.RowHeadersVisible = false;
            dataViewDaysOfMonth.RowHeadersWidth = 51;
            dataViewDaysOfMonth.ScrollBars = ScrollBars.None;
            dataViewDaysOfMonth.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataViewDaysOfMonth.Size = new Size(1009, 440);
            dataViewDaysOfMonth.TabIndex = 7;
            dataViewDaysOfMonth.CellClick += ChooseDayToViewSchedule;
            // 
            // btnPrevMonth
            // 
            btnPrevMonth.Image = Properties.Resources.left_icon;
            btnPrevMonth.Location = new Point(491, 199);
            btnPrevMonth.Name = "btnPrevMonth";
            btnPrevMonth.Size = new Size(60, 55);
            btnPrevMonth.SizeMode = PictureBoxSizeMode.Zoom;
            btnPrevMonth.TabIndex = 8;
            btnPrevMonth.TabStop = false;
            btnPrevMonth.Click += ToPreviousMonth;
            // 
            // bnNextMonth
            // 
            bnNextMonth.Image = Properties.Resources.right_icon;
            bnNextMonth.Location = new Point(911, 199);
            bnNextMonth.Name = "bnNextMonth";
            bnNextMonth.Size = new Size(60, 55);
            bnNextMonth.SizeMode = PictureBoxSizeMode.Zoom;
            bnNextMonth.TabIndex = 9;
            bnNextMonth.TabStop = false;
            bnNextMonth.Click += ToNextMonth;
            // 
            // FormLGD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bnNextMonth);
            Controls.Add(btnPrevMonth);
            Controls.Add(dataViewDaysOfMonth);
            Controls.Add(lblYear);
            Controls.Add(lblSlash);
            Controls.Add(lblMonth);
            Controls.Add(lblHeaderMonth);
            Controls.Add(txtBoxSemesterId);
            Controls.Add(lblSemester);
            Controls.Add(lblHeader);
            Name = "FormLGD";
            Size = new Size(1492, 791);
            ((System.ComponentModel.ISupportInitialize)dataViewDaysOfMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPrevMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnNextMonth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblSemester;
        private CustomControls.CustomComboBox txtBoxSemesterId;
        private Label lblHeaderMonth;
        private Label lblMonth;
        private Label lblSlash;
        private Label lblYear;
        private DataGridView dataViewDaysOfMonth;
        private PictureBox btnPrevMonth;
        private PictureBox bnNextMonth;
    }
}
