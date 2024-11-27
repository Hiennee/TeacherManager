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
            panelSchedule = new FlowLayoutPanel();
            reloadIcon = new PictureBox();
            lblFindTeacher = new Label();
            panelFindTeacher = new Panel();
            pictureBox1 = new PictureBox();
            cbTeacherResult = new CustomControls.CustomComboBox();
            txtBoxTeacherName = new CustomControls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)dataViewDaysOfMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPrevMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnNextMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reloadIcon).BeginInit();
            panelFindTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            lblSemester.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemester.Location = new Point(82, 154);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(136, 31);
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
            txtBoxSemesterId.Location = new Point(255, 146);
            txtBoxSemesterId.MinimumSize = new Size(50, 30);
            txtBoxSemesterId.Name = "txtBoxSemesterId";
            txtBoxSemesterId.Padding = new Padding(2);
            txtBoxSemesterId.Size = new Size(275, 39);
            txtBoxSemesterId.TabIndex = 2;
            txtBoxSemesterId.Texts = "";
            txtBoxSemesterId.OnSelectedIndexChanged += LoadSemesterInfo;
            // 
            // lblHeaderMonth
            // 
            lblHeaderMonth.AutoSize = true;
            lblHeaderMonth.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeaderMonth.ForeColor = Color.Coral;
            lblHeaderMonth.Location = new Point(461, 206);
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
            lblMonth.Location = new Point(594, 206);
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
            lblSlash.Location = new Point(649, 189);
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
            lblYear.Location = new Point(679, 206);
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
            dataViewDaysOfMonth.Location = new Point(82, 287);
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
            btnPrevMonth.Cursor = Cursors.Hand;
            btnPrevMonth.Image = Properties.Resources.left_icon;
            btnPrevMonth.Location = new Point(381, 206);
            btnPrevMonth.Name = "btnPrevMonth";
            btnPrevMonth.Size = new Size(60, 55);
            btnPrevMonth.SizeMode = PictureBoxSizeMode.Zoom;
            btnPrevMonth.TabIndex = 8;
            btnPrevMonth.TabStop = false;
            btnPrevMonth.Click += ToPreviousMonth;
            // 
            // bnNextMonth
            // 
            bnNextMonth.Cursor = Cursors.Hand;
            bnNextMonth.Image = Properties.Resources.right_icon;
            bnNextMonth.Location = new Point(801, 206);
            bnNextMonth.Name = "bnNextMonth";
            bnNextMonth.Size = new Size(60, 55);
            bnNextMonth.SizeMode = PictureBoxSizeMode.Zoom;
            bnNextMonth.TabIndex = 9;
            bnNextMonth.TabStop = false;
            bnNextMonth.Click += ToNextMonth;
            // 
            // panelSchedule
            // 
            panelSchedule.AutoScroll = true;
            panelSchedule.FlowDirection = FlowDirection.TopDown;
            panelSchedule.Location = new Point(1119, 287);
            panelSchedule.Name = "panelSchedule";
            panelSchedule.Size = new Size(437, 440);
            panelSchedule.TabIndex = 10;
            // 
            // reloadIcon
            // 
            reloadIcon.Image = Properties.Resources.reload_icon;
            reloadIcon.Location = new Point(1052, 146);
            reloadIcon.Name = "reloadIcon";
            reloadIcon.Size = new Size(39, 35);
            reloadIcon.SizeMode = PictureBoxSizeMode.Zoom;
            reloadIcon.TabIndex = 14;
            reloadIcon.TabStop = false;
            reloadIcon.Click += ReloadSemesters;
            // 
            // lblFindTeacher
            // 
            lblFindTeacher.AutoSize = true;
            lblFindTeacher.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFindTeacher.Location = new Point(9, 27);
            lblFindTeacher.Name = "lblFindTeacher";
            lblFindTeacher.Size = new Size(167, 31);
            lblFindTeacher.TabIndex = 15;
            lblFindTeacher.Text = "Tìm giảng viên";
            // 
            // panelFindTeacher
            // 
            panelFindTeacher.Controls.Add(pictureBox1);
            panelFindTeacher.Controls.Add(cbTeacherResult);
            panelFindTeacher.Controls.Add(txtBoxTeacherName);
            panelFindTeacher.Controls.Add(lblFindTeacher);
            panelFindTeacher.Location = new Point(73, 49);
            panelFindTeacher.Name = "panelFindTeacher";
            panelFindTeacher.Size = new Size(1018, 91);
            panelFindTeacher.TabIndex = 17;
            panelFindTeacher.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search_icon;
            pictureBox1.Location = new Point(490, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += FindTeacherByNameOrMSGV;
            // 
            // cbTeacherResult
            // 
            cbTeacherResult.BackColor = Color.White;
            cbTeacherResult.BorderColor = Color.MediumSlateBlue;
            cbTeacherResult.BorderSize = 2;
            cbTeacherResult.DropDownStyle = ComboBoxStyle.DropDown;
            cbTeacherResult.Font = new Font("Segoe UI", 10F);
            cbTeacherResult.ForeColor = Color.DimGray;
            cbTeacherResult.IconColor = Color.MediumSlateBlue;
            cbTeacherResult.ListBackColor = Color.FromArgb(230, 228, 245);
            cbTeacherResult.ListTextColor = Color.DimGray;
            cbTeacherResult.Location = new Point(728, 23);
            cbTeacherResult.MinimumSize = new Size(50, 30);
            cbTeacherResult.Name = "cbTeacherResult";
            cbTeacherResult.Padding = new Padding(2);
            cbTeacherResult.Size = new Size(250, 38);
            cbTeacherResult.TabIndex = 18;
            cbTeacherResult.Texts = "";
            cbTeacherResult.OnSelectedIndexChanged += OnChooseTeacherToViewSchedule;
            // 
            // txtBoxTeacherName
            // 
            txtBoxTeacherName.BackColor = SystemColors.Window;
            txtBoxTeacherName.BorderColor = Color.MediumSlateBlue;
            txtBoxTeacherName.BorderFocusColor = Color.HotPink;
            txtBoxTeacherName.BorderRadius = 0;
            txtBoxTeacherName.BorderSize = 2;
            txtBoxTeacherName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTeacherName.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxTeacherName.Location = new Point(182, 23);
            txtBoxTeacherName.Margin = new Padding(4);
            txtBoxTeacherName.Multiline = false;
            txtBoxTeacherName.Name = "txtBoxTeacherName";
            txtBoxTeacherName.Padding = new Padding(10, 7, 10, 7);
            txtBoxTeacherName.PasswordChar = false;
            txtBoxTeacherName.PlaceholderColor = Color.DarkGray;
            txtBoxTeacherName.PlaceholderText = "";
            txtBoxTeacherName.Size = new Size(275, 35);
            txtBoxTeacherName.TabIndex = 18;
            txtBoxTeacherName.Texts = "";
            txtBoxTeacherName.UnderlinedStyle = false;
            // 
            // FormLGD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelFindTeacher);
            Controls.Add(reloadIcon);
            Controls.Add(panelSchedule);
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
            Size = new Size(1572, 899);
            ((System.ComponentModel.ISupportInitialize)dataViewDaysOfMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPrevMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnNextMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)reloadIcon).EndInit();
            panelFindTeacher.ResumeLayout(false);
            panelFindTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private FlowLayoutPanel panelSchedule;
        private PictureBox reloadIcon;
        private Label lblFindTeacher;
        private Panel panelFindTeacher;
        private CustomControls.CustomTextBox txtBoxTeacherName;
        private CustomControls.CustomComboBox cbTeacherResult;
        private PictureBox pictureBox1;
    }
}
