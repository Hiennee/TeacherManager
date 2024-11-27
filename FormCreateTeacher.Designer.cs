namespace TeacherManager
{
    partial class FormCreateTeacher
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
            lblAccountName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            txtBoxMSGV = new CustomControls.CustomTextBox();
            txtBoxTeacherName = new CustomControls.CustomTextBox();
            txtBoxEmail = new CustomControls.CustomTextBox();
            txtBoxPhone = new CustomControls.CustomTextBox();
            btnAddTeacher = new CustomControls.CustomButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblHeader = new Label();
            cbGender = new CustomControls.CustomComboBox();
            lblGender = new Label();
            lblBirthDate = new Label();
            dtpBirth = new CustomControls.CustomDateTimePicker();
            lblPhoneWarning = new Label();
            lblBirthWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(209, 109);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(162, 31);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Tên giảng viên";
            // 
            // lblAccountName
            // 
            lblAccountName.AutoSize = true;
            lblAccountName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccountName.Location = new Point(209, 202);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(189, 31);
            lblAccountName.TabIndex = 1;
            lblAccountName.Text = "Mã số giảng viên";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(535, 202);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(79, 31);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(535, 287);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(148, 31);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Số điện thoại";
            // 
            // txtBoxMSGV
            // 
            txtBoxMSGV.BackColor = SystemColors.Window;
            txtBoxMSGV.BorderColor = Color.MediumSlateBlue;
            txtBoxMSGV.BorderFocusColor = Color.HotPink;
            txtBoxMSGV.BorderRadius = 0;
            txtBoxMSGV.BorderSize = 2;
            txtBoxMSGV.Font = new Font("Segoe UI", 9.5F);
            txtBoxMSGV.ForeColor = Color.DimGray;
            txtBoxMSGV.Location = new Point(209, 236);
            txtBoxMSGV.Margin = new Padding(4);
            txtBoxMSGV.Multiline = false;
            txtBoxMSGV.Name = "txtBoxMSGV";
            txtBoxMSGV.Padding = new Padding(7);
            txtBoxMSGV.PasswordChar = false;
            txtBoxMSGV.PlaceholderColor = Color.DarkGray;
            txtBoxMSGV.PlaceholderText = "";
            txtBoxMSGV.Size = new Size(297, 36);
            txtBoxMSGV.TabIndex = 2;
            txtBoxMSGV.Texts = "";
            txtBoxMSGV.UnderlinedStyle = false;
            txtBoxMSGV._TextChanged += GenerateEmailBasedOnMSGV;
            // 
            // txtBoxTeacherName
            // 
            txtBoxTeacherName.BackColor = SystemColors.Window;
            txtBoxTeacherName.BorderColor = Color.MediumSlateBlue;
            txtBoxTeacherName.BorderFocusColor = Color.HotPink;
            txtBoxTeacherName.BorderRadius = 0;
            txtBoxTeacherName.BorderSize = 2;
            txtBoxTeacherName.Font = new Font("Segoe UI", 9.5F);
            txtBoxTeacherName.ForeColor = Color.DimGray;
            txtBoxTeacherName.Location = new Point(209, 143);
            txtBoxTeacherName.Margin = new Padding(4);
            txtBoxTeacherName.Multiline = false;
            txtBoxTeacherName.Name = "txtBoxTeacherName";
            txtBoxTeacherName.Padding = new Padding(7);
            txtBoxTeacherName.PasswordChar = false;
            txtBoxTeacherName.PlaceholderColor = Color.DarkGray;
            txtBoxTeacherName.PlaceholderText = "";
            txtBoxTeacherName.Size = new Size(297, 36);
            txtBoxTeacherName.TabIndex = 1;
            txtBoxTeacherName.Texts = "";
            txtBoxTeacherName.UnderlinedStyle = false;
            txtBoxTeacherName._TextChanged += CheckAddTeacherButtonAvailable;
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
            txtBoxEmail.Location = new Point(535, 236);
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
            txtBoxEmail._TextChanged += CheckAddTeacherButtonAvailable;
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
            txtBoxPhone.Location = new Point(535, 321);
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
            // btnAddTeacher
            // 
            btnAddTeacher.BackColor = Color.MediumSlateBlue;
            btnAddTeacher.BackgroundColor = Color.MediumSlateBlue;
            btnAddTeacher.BorderColor = Color.PaleVioletRed;
            btnAddTeacher.BorderRadius = 20;
            btnAddTeacher.BorderSize = 0;
            btnAddTeacher.Cursor = Cursors.Hand;
            btnAddTeacher.FlatAppearance.BorderSize = 0;
            btnAddTeacher.FlatStyle = FlatStyle.Flat;
            btnAddTeacher.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTeacher.ForeColor = Color.White;
            btnAddTeacher.Location = new Point(418, 427);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(206, 44);
            btnAddTeacher.TabIndex = 6;
            btnAddTeacher.Text = "Thêm giảng viên";
            btnAddTeacher.TextColor = Color.White;
            btnAddTeacher.UseVisualStyleBackColor = false;
            btnAddTeacher.Click += AddTeacher;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.minus_icon;
            pictureBox1.Location = new Point(924, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.x_icon;
            pictureBox2.Location = new Point(1007, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += CloseForm;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(12, 25);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(206, 31);
            lblHeader.TabIndex = 12;
            lblHeader.Text = "THÊM GIẢNG VIÊN";
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
            cbGender.Location = new Point(209, 321);
            cbGender.MinimumSize = new Size(50, 30);
            cbGender.Name = "cbGender";
            cbGender.Padding = new Padding(2);
            cbGender.Size = new Size(297, 38);
            cbGender.TabIndex = 3;
            cbGender.Texts = "";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(209, 287);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(102, 31);
            lblGender.TabIndex = 16;
            lblGender.Text = "Giới tính";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthDate.Location = new Point(535, 109);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(116, 31);
            lblBirthDate.TabIndex = 17;
            lblBirthDate.Text = "Ngày sinh";
            // 
            // dtpBirth
            // 
            dtpBirth.BorderColor = Color.MediumSlateBlue;
            dtpBirth.BorderSize = 2;
            dtpBirth.CustomFormat = "dd/MM/yyyy";
            dtpBirth.Font = new Font("Segoe UI", 9.5F);
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.Location = new Point(535, 143);
            dtpBirth.MinimumSize = new Size(0, 35);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(297, 35);
            dtpBirth.SkinColor = Color.White;
            dtpBirth.TabIndex = 18;
            dtpBirth.TextColor = Color.DimGray;
            dtpBirth.ValueChanged += ValidateBirthDate;
            // 
            // lblPhoneWarning
            // 
            lblPhoneWarning.AutoSize = true;
            lblPhoneWarning.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblPhoneWarning.ForeColor = Color.Red;
            lblPhoneWarning.Location = new Point(628, 361);
            lblPhoneWarning.Name = "lblPhoneWarning";
            lblPhoneWarning.Size = new Size(204, 23);
            lblPhoneWarning.TabIndex = 38;
            lblPhoneWarning.Text = "Số điện thoại không hợp lệ";
            lblPhoneWarning.Visible = false;
            // 
            // lblBirthWarning
            // 
            lblBirthWarning.AutoSize = true;
            lblBirthWarning.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblBirthWarning.ForeColor = Color.Red;
            lblBirthWarning.Location = new Point(649, 181);
            lblBirthWarning.Name = "lblBirthWarning";
            lblBirthWarning.Size = new Size(183, 23);
            lblBirthWarning.TabIndex = 39;
            lblBirthWarning.Text = "Ngày sinh không hợp lệ";
            lblBirthWarning.Visible = false;
            // 
            // FormCreateTeacher
            // 
            AcceptButton = btnAddTeacher;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 514);
            Controls.Add(lblBirthWarning);
            Controls.Add(lblPhoneWarning);
            Controls.Add(dtpBirth);
            Controls.Add(lblBirthDate);
            Controls.Add(cbGender);
            Controls.Add(lblGender);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddTeacher);
            Controls.Add(txtBoxPhone);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxTeacherName);
            Controls.Add(txtBoxMSGV);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblAccountName);
            Controls.Add(lblStudentName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCreateTeacher";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm giảng viên mới";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentName;
        private Label lblAccountName;
        private Label lblEmail;
        private Label lblPhone;
        private TeacherManager.CustomControls.CustomTextBox txtBoxMSGV;
        private TeacherManager.CustomControls.CustomTextBox txtBoxTeacherName;
        private TeacherManager.CustomControls.CustomTextBox txtBoxEmail;
        private TeacherManager.CustomControls.CustomTextBox txtBoxPhone;
        private TeacherManager.CustomControls.CustomButton btnAddTeacher;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblHeader;
        private CustomControls.CustomComboBox cbGender;
        private Label lblGender;
        private Label lblBirthDate;
        private CustomControls.CustomDateTimePicker dtpBirth;
        private Label lblPhoneWarning;
        private Label lblBirthWarning;
    }
}