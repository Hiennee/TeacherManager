namespace TeacherManager
{
    partial class FormCreateStudent
    {
        private int borderWidth = 5;  // Width of the custom border
        private Color borderColor = Color.MediumSlateBlue;  // Border color
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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the custom border
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

        //// Allow the form to be moved by dragging
        //protected override void WndProc(ref Message m)
        //{
        //    const int WM_NCHITTEST = 0x84;
        //    const int HTCLIENT = 1;
        //    const int HTCAPTION = 2;

        //    if (m.Msg == WM_NCHITTEST)
        //    {
        //        base.WndProc(ref m);
        //        if ((int)m.Result == HTCLIENT)
        //        {
        //            m.Result = (IntPtr)HTCAPTION;
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            txtBoxStudentName = new CustomControls.CustomTextBox();
            txtBoxEmail = new CustomControls.CustomTextBox();
            txtBoxPhone = new CustomControls.CustomTextBox();
            btnAddStudent = new CustomControls.CustomButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtBoxMSSV = new CustomControls.CustomTextBox();
            lblMSSV = new Label();
            lblHeader = new Label();
            lblGender = new Label();
            cbGender = new CustomControls.CustomComboBox();
            lblBirthWarning = new Label();
            dtpBirth = new CustomControls.CustomDateTimePicker();
            lblBirthDate = new Label();
            lblPhoneWarning = new Label();
            cbFaculty = new CustomControls.CustomComboBox();
            lblFaculty = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(202, 99);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(145, 31);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Tên sinh viên";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(551, 187);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(79, 31);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(551, 269);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(148, 31);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Số điện thoại";
            // 
            // txtBoxStudentName
            // 
            txtBoxStudentName.BackColor = SystemColors.Window;
            txtBoxStudentName.BorderColor = Color.MediumSlateBlue;
            txtBoxStudentName.BorderFocusColor = Color.HotPink;
            txtBoxStudentName.BorderRadius = 0;
            txtBoxStudentName.BorderSize = 2;
            txtBoxStudentName.Font = new Font("Segoe UI", 9.5F);
            txtBoxStudentName.ForeColor = Color.DimGray;
            txtBoxStudentName.Location = new Point(202, 133);
            txtBoxStudentName.Margin = new Padding(4);
            txtBoxStudentName.Multiline = false;
            txtBoxStudentName.Name = "txtBoxStudentName";
            txtBoxStudentName.Padding = new Padding(7);
            txtBoxStudentName.PasswordChar = false;
            txtBoxStudentName.PlaceholderColor = Color.DarkGray;
            txtBoxStudentName.PlaceholderText = "";
            txtBoxStudentName.Size = new Size(297, 36);
            txtBoxStudentName.TabIndex = 1;
            txtBoxStudentName.Texts = "";
            txtBoxStudentName.UnderlinedStyle = false;
            txtBoxStudentName._TextChanged += CheckAddStudentButtonAvailable;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.BackColor = SystemColors.Window;
            txtBoxEmail.BorderColor = Color.MediumSlateBlue;
            txtBoxEmail.BorderFocusColor = Color.HotPink;
            txtBoxEmail.BorderRadius = 0;
            txtBoxEmail.BorderSize = 2;
            txtBoxEmail.Enabled = false;
            txtBoxEmail.Font = new Font("Segoe UI", 9.5F);
            txtBoxEmail.ForeColor = Color.DimGray;
            txtBoxEmail.Location = new Point(551, 221);
            txtBoxEmail.Margin = new Padding(4);
            txtBoxEmail.Multiline = false;
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Padding = new Padding(7);
            txtBoxEmail.PasswordChar = false;
            txtBoxEmail.PlaceholderColor = Color.DarkGray;
            txtBoxEmail.PlaceholderText = "";
            txtBoxEmail.Size = new Size(297, 36);
            txtBoxEmail.TabIndex = 4;
            txtBoxEmail.Texts = "";
            txtBoxEmail.UnderlinedStyle = false;
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.BackColor = SystemColors.Window;
            txtBoxPhone.BorderColor = Color.MediumSlateBlue;
            txtBoxPhone.BorderFocusColor = Color.HotPink;
            txtBoxPhone.BorderRadius = 0;
            txtBoxPhone.BorderSize = 2;
            txtBoxPhone.Font = new Font("Segoe UI", 9.5F);
            txtBoxPhone.ForeColor = Color.DimGray;
            txtBoxPhone.Location = new Point(551, 305);
            txtBoxPhone.Margin = new Padding(4);
            txtBoxPhone.Multiline = false;
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Padding = new Padding(7);
            txtBoxPhone.PasswordChar = false;
            txtBoxPhone.PlaceholderColor = Color.DarkGray;
            txtBoxPhone.PlaceholderText = "";
            txtBoxPhone.Size = new Size(297, 36);
            txtBoxPhone.TabIndex = 5;
            txtBoxPhone.Texts = "";
            txtBoxPhone.UnderlinedStyle = false;
            txtBoxPhone._TextChanged += OnPhoneNumberChanged;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.MediumSlateBlue;
            btnAddStudent.BackgroundColor = Color.MediumSlateBlue;
            btnAddStudent.BorderColor = Color.PaleVioletRed;
            btnAddStudent.BorderRadius = 20;
            btnAddStudent.BorderSize = 0;
            btnAddStudent.Cursor = Cursors.Hand;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(403, 444);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(227, 48);
            btnAddStudent.TabIndex = 6;
            btnAddStudent.Text = "Thêm sinh viên";
            btnAddStudent.TextColor = Color.White;
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += AddStudent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.minus_icon;
            pictureBox1.Location = new Point(904, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.x_icon;
            pictureBox2.Location = new Point(987, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += CloseForm;
            // 
            // txtBoxMSSV
            // 
            txtBoxMSSV.BackColor = SystemColors.Window;
            txtBoxMSSV.BorderColor = Color.MediumSlateBlue;
            txtBoxMSSV.BorderFocusColor = Color.HotPink;
            txtBoxMSSV.BorderRadius = 0;
            txtBoxMSSV.BorderSize = 2;
            txtBoxMSSV.Font = new Font("Segoe UI", 9.5F);
            txtBoxMSSV.ForeColor = Color.DimGray;
            txtBoxMSSV.Location = new Point(202, 221);
            txtBoxMSSV.Margin = new Padding(4);
            txtBoxMSSV.Multiline = false;
            txtBoxMSSV.Name = "txtBoxMSSV";
            txtBoxMSSV.Padding = new Padding(7);
            txtBoxMSSV.PasswordChar = false;
            txtBoxMSSV.PlaceholderColor = Color.DarkGray;
            txtBoxMSSV.PlaceholderText = "";
            txtBoxMSSV.Size = new Size(297, 36);
            txtBoxMSSV.TabIndex = 2;
            txtBoxMSSV.Texts = "";
            txtBoxMSSV.UnderlinedStyle = false;
            txtBoxMSSV._TextChanged += GenerateEmailBasedOnMSSV;
            // 
            // lblMSSV
            // 
            lblMSSV.AutoSize = true;
            lblMSSV.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMSSV.Location = new Point(202, 187);
            lblMSSV.Name = "lblMSSV";
            lblMSSV.Size = new Size(172, 31);
            lblMSSV.TabIndex = 11;
            lblMSSV.Text = "Mã số sinh viên";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(27, 25);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(187, 31);
            lblHeader.TabIndex = 12;
            lblHeader.Text = "THÊM SINH VIÊN";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(202, 271);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(102, 31);
            lblGender.TabIndex = 14;
            lblGender.Text = "Giới tính";
            // 
            // cbGender
            // 
            cbGender.BackColor = Color.White;
            cbGender.BorderColor = Color.MediumSlateBlue;
            cbGender.BorderSize = 2;
            cbGender.DropDownStyle = ComboBoxStyle.DropDown;
            cbGender.Font = new Font("Segoe UI", 10F);
            cbGender.ForeColor = Color.DimGray;
            cbGender.IconColor = Color.MediumSlateBlue;
            cbGender.ListBackColor = Color.FromArgb(230, 228, 245);
            cbGender.ListTextColor = Color.DimGray;
            cbGender.Location = new Point(202, 305);
            cbGender.MinimumSize = new Size(50, 30);
            cbGender.Name = "cbGender";
            cbGender.Padding = new Padding(2);
            cbGender.Size = new Size(297, 38);
            cbGender.TabIndex = 3;
            cbGender.Texts = "";
            // 
            // lblBirthWarning
            // 
            lblBirthWarning.AutoSize = true;
            lblBirthWarning.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblBirthWarning.ForeColor = Color.Red;
            lblBirthWarning.Location = new Point(665, 171);
            lblBirthWarning.Name = "lblBirthWarning";
            lblBirthWarning.Size = new Size(183, 23);
            lblBirthWarning.TabIndex = 42;
            lblBirthWarning.Text = "Ngày sinh không hợp lệ";
            lblBirthWarning.Visible = false;
            // 
            // dtpBirth
            // 
            dtpBirth.BorderColor = Color.MediumSlateBlue;
            dtpBirth.BorderSize = 2;
            dtpBirth.CustomFormat = "dd/MM/yyyy";
            dtpBirth.Font = new Font("Segoe UI", 9.5F);
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.Location = new Point(551, 133);
            dtpBirth.MinimumSize = new Size(0, 35);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(297, 35);
            dtpBirth.SkinColor = Color.White;
            dtpBirth.TabIndex = 41;
            dtpBirth.TextColor = Color.DimGray;
            dtpBirth.ValueChanged += ValidateBirthDate;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthDate.Location = new Point(551, 99);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(116, 31);
            lblBirthDate.TabIndex = 40;
            lblBirthDate.Text = "Ngày sinh";
            // 
            // lblPhoneWarning
            // 
            lblPhoneWarning.AutoSize = true;
            lblPhoneWarning.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblPhoneWarning.ForeColor = Color.Red;
            lblPhoneWarning.Location = new Point(644, 345);
            lblPhoneWarning.Name = "lblPhoneWarning";
            lblPhoneWarning.Size = new Size(204, 23);
            lblPhoneWarning.TabIndex = 43;
            lblPhoneWarning.Text = "Số điện thoại không hợp lệ";
            lblPhoneWarning.Visible = false;
            // 
            // cbFaculty
            // 
            cbFaculty.BackColor = Color.White;
            cbFaculty.BorderColor = Color.MediumSlateBlue;
            cbFaculty.BorderSize = 2;
            cbFaculty.DropDownStyle = ComboBoxStyle.DropDown;
            cbFaculty.Font = new Font("Segoe UI", 10F);
            cbFaculty.ForeColor = Color.DimGray;
            cbFaculty.IconColor = Color.MediumSlateBlue;
            cbFaculty.ListBackColor = Color.FromArgb(230, 228, 245);
            cbFaculty.ListTextColor = Color.DimGray;
            cbFaculty.Location = new Point(202, 394);
            cbFaculty.MinimumSize = new Size(50, 30);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Padding = new Padding(2);
            cbFaculty.Size = new Size(297, 38);
            cbFaculty.TabIndex = 44;
            cbFaculty.Texts = "";
            // 
            // lblFaculty
            // 
            lblFaculty.AutoSize = true;
            lblFaculty.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFaculty.Location = new Point(202, 360);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(165, 31);
            lblFaculty.TabIndex = 45;
            lblFaculty.Text = "Khoa - bộ môn";
            // 
            // FormCreateStudent
            // 
            AcceptButton = btnAddStudent;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 514);
            Controls.Add(cbFaculty);
            Controls.Add(lblFaculty);
            Controls.Add(lblPhoneWarning);
            Controls.Add(lblBirthWarning);
            Controls.Add(dtpBirth);
            Controls.Add(lblBirthDate);
            Controls.Add(cbGender);
            Controls.Add(lblGender);
            Controls.Add(lblHeader);
            Controls.Add(txtBoxMSSV);
            Controls.Add(lblMSSV);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddStudent);
            Controls.Add(txtBoxPhone);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxStudentName);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblStudentName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCreateStudent";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm sinh viên mới";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentName;
        private Label lblEmail;
        private Label lblPhone;
        private TeacherManager.CustomControls.CustomTextBox txtBoxStudentName;
        private TeacherManager.CustomControls.CustomTextBox txtBoxEmail;
        private TeacherManager.CustomControls.CustomTextBox txtBoxPhone;
        private TeacherManager.CustomControls.CustomButton btnAddStudent;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TeacherManager.CustomControls.CustomTextBox txtBoxMSSV;
        private Label lblMSSV;
        private Label lblHeader;
        private Label lblGender;
        private CustomControls.CustomComboBox cbGender;
        private Label lblBirthWarning;
        private CustomControls.CustomDateTimePicker dtpBirth;
        private Label lblBirthDate;
        private Label lblPhoneWarning;
        private CustomControls.CustomComboBox cbFaculty;
        private Label lblFaculty;
    }
}