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
            lblAccountName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            txtBoxAccountName = new TeacherManager.CustomControls.CustomTextBox();
            txtBoxStudentName = new TeacherManager.CustomControls.CustomTextBox();
            txtBoxEmail = new TeacherManager.CustomControls.CustomTextBox();
            txtBoxPhone = new TeacherManager.CustomControls.CustomTextBox();
            btnAddStudent = new TeacherManager.CustomControls.CustomButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtBoxMSSV = new TeacherManager.CustomControls.CustomTextBox();
            lblMSSV = new Label();
            lblHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(209, 167);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(145, 31);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Tên sinh viên";
            // 
            // lblAccountName
            // 
            lblAccountName.AutoSize = true;
            lblAccountName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccountName.Location = new Point(209, 81);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(166, 31);
            lblAccountName.TabIndex = 1;
            lblAccountName.Text = "Tên đăng nhập";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(209, 343);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(79, 31);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(209, 425);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(148, 31);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Số điện thoại";
            // 
            // txtBoxAccountName
            // 
            txtBoxAccountName.BackColor = SystemColors.Window;
            txtBoxAccountName.BorderColor = Color.MediumSlateBlue;
            txtBoxAccountName.BorderFocusColor = Color.HotPink;
            txtBoxAccountName.BorderRadius = 0;
            txtBoxAccountName.BorderSize = 2;
            txtBoxAccountName.Font = new Font("Segoe UI", 9.5F);
            txtBoxAccountName.ForeColor = Color.DimGray;
            txtBoxAccountName.Location = new Point(209, 115);
            txtBoxAccountName.Margin = new Padding(4);
            txtBoxAccountName.Multiline = false;
            txtBoxAccountName.Name = "txtBoxAccountName";
            txtBoxAccountName.Padding = new Padding(7);
            txtBoxAccountName.PasswordChar = false;
            txtBoxAccountName.PlaceholderColor = Color.DarkGray;
            txtBoxAccountName.PlaceholderText = "";
            txtBoxAccountName.Size = new Size(252, 36);
            txtBoxAccountName.TabIndex = 4;
            txtBoxAccountName.Texts = "";
            txtBoxAccountName.UnderlinedStyle = false;
            txtBoxAccountName._TextChanged += CheckAddStudentButtonAvailable;
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
            txtBoxStudentName.Location = new Point(209, 201);
            txtBoxStudentName.Margin = new Padding(4);
            txtBoxStudentName.Multiline = false;
            txtBoxStudentName.Name = "txtBoxStudentName";
            txtBoxStudentName.Padding = new Padding(7);
            txtBoxStudentName.PasswordChar = false;
            txtBoxStudentName.PlaceholderColor = Color.DarkGray;
            txtBoxStudentName.PlaceholderText = "";
            txtBoxStudentName.Size = new Size(252, 36);
            txtBoxStudentName.TabIndex = 5;
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
            txtBoxEmail.Font = new Font("Segoe UI", 9.5F);
            txtBoxEmail.ForeColor = Color.DimGray;
            txtBoxEmail.Location = new Point(209, 377);
            txtBoxEmail.Margin = new Padding(4);
            txtBoxEmail.Multiline = false;
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Padding = new Padding(7);
            txtBoxEmail.PasswordChar = false;
            txtBoxEmail.PlaceholderColor = Color.DarkGray;
            txtBoxEmail.PlaceholderText = "";
            txtBoxEmail.Size = new Size(252, 36);
            txtBoxEmail.TabIndex = 7;
            txtBoxEmail.Texts = "";
            txtBoxEmail.UnderlinedStyle = false;
            txtBoxEmail._TextChanged += CheckAddStudentButtonAvailable;
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
            txtBoxPhone.Location = new Point(209, 460);
            txtBoxPhone.Margin = new Padding(4);
            txtBoxPhone.Multiline = false;
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Padding = new Padding(7);
            txtBoxPhone.PasswordChar = false;
            txtBoxPhone.PlaceholderColor = Color.DarkGray;
            txtBoxPhone.PlaceholderText = "";
            txtBoxPhone.Size = new Size(252, 36);
            txtBoxPhone.TabIndex = 8;
            txtBoxPhone.Texts = "";
            txtBoxPhone.UnderlinedStyle = false;
            txtBoxPhone._TextChanged += CheckAddStudentButtonAvailable;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.MediumSlateBlue;
            btnAddStudent.BackgroundColor = Color.MediumSlateBlue;
            btnAddStudent.BorderColor = Color.PaleVioletRed;
            btnAddStudent.BorderRadius = 20;
            btnAddStudent.BorderSize = 0;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(233, 550);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(206, 44);
            btnAddStudent.TabIndex = 9;
            btnAddStudent.Text = "Thêm sinh viên";
            btnAddStudent.TextColor = Color.White;
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += AddStudent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.minus_icon;
            pictureBox1.Location = new Point(524, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.x_icon;
            pictureBox2.Location = new Point(607, 12);
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
            txtBoxMSSV.Location = new Point(209, 289);
            txtBoxMSSV.Margin = new Padding(4);
            txtBoxMSSV.Multiline = false;
            txtBoxMSSV.Name = "txtBoxMSSV";
            txtBoxMSSV.Padding = new Padding(7);
            txtBoxMSSV.PasswordChar = false;
            txtBoxMSSV.PlaceholderColor = Color.DarkGray;
            txtBoxMSSV.PlaceholderText = "";
            txtBoxMSSV.Size = new Size(252, 36);
            txtBoxMSSV.TabIndex = 6;
            txtBoxMSSV.Texts = "";
            txtBoxMSSV.UnderlinedStyle = false;
            txtBoxMSSV._TextChanged += CheckAddStudentButtonAvailable;
            // 
            // lblMSSV
            // 
            lblMSSV.AutoSize = true;
            lblMSSV.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMSSV.Location = new Point(209, 255);
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
            // FormCreateStudent
            // 
            AcceptButton = btnAddStudent;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 615);
            Controls.Add(lblHeader);
            Controls.Add(txtBoxMSSV);
            Controls.Add(lblMSSV);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddStudent);
            Controls.Add(txtBoxPhone);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxStudentName);
            Controls.Add(txtBoxAccountName);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblAccountName);
            Controls.Add(lblStudentName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCreateStudent";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCreateStudent";
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
        private TeacherManager.CustomControls.CustomTextBox txtBoxAccountName;
        private TeacherManager.CustomControls.CustomTextBox txtBoxStudentName;
        private TeacherManager.CustomControls.CustomTextBox txtBoxEmail;
        private TeacherManager.CustomControls.CustomTextBox txtBoxPhone;
        private TeacherManager.CustomControls.CustomButton btnAddStudent;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TeacherManager.CustomControls.CustomTextBox txtBoxMSSV;
        private Label lblMSSV;
        private Label lblHeader;
    }
}