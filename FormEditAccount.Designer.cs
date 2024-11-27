namespace TeacherManager
{
    partial class FormEditAccount
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
            lblName = new Label();
            lblEmail = new Label();
            lblRole = new Label();
            lblPhone = new Label();
            txtBoxEmail = new CustomControls.CustomTextBox();
            txtBoxName = new CustomControls.CustomTextBox();
            txtBoxPhone = new CustomControls.CustomTextBox();
            btnSaveChanges = new CustomControls.CustomButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblHeader = new Label();
            ChooseAvtDialog = new OpenFileDialog();
            pictureAvt = new CustomControls.CustomPictureBox();
            cbRole = new CustomControls.CustomComboBox();
            cbStatus = new CustomControls.CustomComboBox();
            genderIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureAvt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genderIcon).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(345, 125);
            lblName.Name = "lblName";
            lblName.Size = new Size(82, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Họ tên";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(345, 218);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(79, 31);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(345, 306);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(79, 31);
            lblRole.TabIndex = 2;
            lblRole.Text = "Vai trò";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(345, 406);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(148, 31);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Số điện thoại";
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
            txtBoxEmail.Location = new Point(345, 252);
            txtBoxEmail.Margin = new Padding(4);
            txtBoxEmail.Multiline = false;
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Padding = new Padding(7);
            txtBoxEmail.PasswordChar = false;
            txtBoxEmail.PlaceholderColor = Color.DarkGray;
            txtBoxEmail.PlaceholderText = "";
            txtBoxEmail.Size = new Size(252, 36);
            txtBoxEmail.TabIndex = 2;
            txtBoxEmail.Texts = "";
            txtBoxEmail.UnderlinedStyle = false;
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = SystemColors.Window;
            txtBoxName.BorderColor = Color.MediumSlateBlue;
            txtBoxName.BorderFocusColor = Color.HotPink;
            txtBoxName.BorderRadius = 0;
            txtBoxName.BorderSize = 2;
            txtBoxName.Font = new Font("Segoe UI", 9.5F);
            txtBoxName.ForeColor = Color.DimGray;
            txtBoxName.Location = new Point(345, 159);
            txtBoxName.Margin = new Padding(4);
            txtBoxName.Multiline = false;
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Padding = new Padding(7);
            txtBoxName.PasswordChar = false;
            txtBoxName.PlaceholderColor = Color.DarkGray;
            txtBoxName.PlaceholderText = "";
            txtBoxName.Size = new Size(252, 36);
            txtBoxName.TabIndex = 1;
            txtBoxName.Texts = "";
            txtBoxName.UnderlinedStyle = false;
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
            txtBoxPhone.Location = new Point(345, 441);
            txtBoxPhone.Margin = new Padding(4);
            txtBoxPhone.Multiline = false;
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Padding = new Padding(7);
            txtBoxPhone.PasswordChar = false;
            txtBoxPhone.PlaceholderColor = Color.DarkGray;
            txtBoxPhone.PlaceholderText = "";
            txtBoxPhone.Size = new Size(252, 36);
            txtBoxPhone.TabIndex = 5;
            txtBoxPhone.Texts = "";
            txtBoxPhone.UnderlinedStyle = false;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.MediumSlateBlue;
            btnSaveChanges.BackgroundColor = Color.MediumSlateBlue;
            btnSaveChanges.BorderColor = Color.PaleVioletRed;
            btnSaveChanges.BorderRadius = 20;
            btnSaveChanges.BorderSize = 0;
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(50, 433);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(215, 44);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Text = "Lưu thay đổi";
            btnSaveChanges.TextColor = Color.White;
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += SaveChanges;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.minus_icon;
            pictureBox1.Location = new Point(656, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.x_icon;
            pictureBox2.Location = new Point(739, 12);
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
            lblHeader.Size = new Size(253, 31);
            lblHeader.TabIndex = 12;
            lblHeader.Text = "CHỈNH SỬA TÀI KHOẢN";
            // 
            // ChooseAvtDialog
            // 
            ChooseAvtDialog.FileName = "openFileDialog1";
            // 
            // pictureAvt
            // 
            pictureAvt.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pictureAvt.BorderColor = Color.RoyalBlue;
            pictureAvt.BorderColor2 = Color.HotPink;
            pictureAvt.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pictureAvt.BorderSize = 2;
            pictureAvt.GradientAngle = 50F;
            pictureAvt.Location = new Point(79, 140);
            pictureAvt.Name = "pictureAvt";
            pictureAvt.Size = new Size(148, 148);
            pictureAvt.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureAvt.TabIndex = 13;
            pictureAvt.TabStop = false;
            pictureAvt.Click += ChangeAvatar;
            // 
            // cbRole
            // 
            cbRole.BackColor = Color.WhiteSmoke;
            cbRole.BorderColor = Color.MediumSlateBlue;
            cbRole.BorderSize = 2;
            cbRole.DropDownStyle = ComboBoxStyle.DropDown;
            cbRole.Font = new Font("Segoe UI", 10F);
            cbRole.ForeColor = Color.DimGray;
            cbRole.IconColor = Color.MediumSlateBlue;
            cbRole.ListBackColor = Color.FromArgb(230, 228, 245);
            cbRole.ListTextColor = Color.DimGray;
            cbRole.Location = new Point(345, 347);
            cbRole.MinimumSize = new Size(50, 30);
            cbRole.Name = "cbRole";
            cbRole.Padding = new Padding(2);
            cbRole.Size = new Size(252, 38);
            cbRole.TabIndex = 4;
            cbRole.Texts = "";
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.WhiteSmoke;
            cbStatus.BorderColor = Color.MediumSlateBlue;
            cbStatus.BorderSize = 2;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDown;
            cbStatus.Font = new Font("Segoe UI", 10F);
            cbStatus.ForeColor = Color.DimGray;
            cbStatus.IconColor = Color.MediumSlateBlue;
            cbStatus.ListBackColor = Color.FromArgb(230, 228, 245);
            cbStatus.ListTextColor = Color.DimGray;
            cbStatus.Location = new Point(50, 347);
            cbStatus.MinimumSize = new Size(50, 30);
            cbStatus.Name = "cbStatus";
            cbStatus.Padding = new Padding(2);
            cbStatus.Size = new Size(215, 38);
            cbStatus.TabIndex = 3;
            cbStatus.Texts = "";
            // 
            // genderIcon
            // 
            genderIcon.Image = Properties.Resources.male_icon;
            genderIcon.Location = new Point(227, 118);
            genderIcon.Name = "genderIcon";
            genderIcon.Size = new Size(38, 38);
            genderIcon.SizeMode = PictureBoxSizeMode.Zoom;
            genderIcon.TabIndex = 40;
            genderIcon.TabStop = false;
            genderIcon.Click += OnGenderChange;
            // 
            // FormEditAccount
            // 
            AcceptButton = btnSaveChanges;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 575);
            Controls.Add(genderIcon);
            Controls.Add(cbStatus);
            Controls.Add(cbRole);
            Controls.Add(pictureAvt);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtBoxPhone);
            Controls.Add(txtBoxName);
            Controls.Add(txtBoxEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblRole);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditAccount";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chỉnh sửa tài khoản";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureAvt).EndInit();
            ((System.ComponentModel.ISupportInitialize)genderIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblEmail;
        private Label lblRole;
        private Label lblPhone;
        private TeacherManager.CustomControls.CustomTextBox txtBoxEmail;
        private TeacherManager.CustomControls.CustomTextBox txtBoxName;
        private TeacherManager.CustomControls.CustomTextBox txtBoxPhone;
        private TeacherManager.CustomControls.CustomButton btnSaveChanges;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblHeader;
        private OpenFileDialog ChooseAvtDialog;
        private CustomControls.CustomPictureBox pictureAvt;
        private CustomControls.CustomComboBox cbRole;
        private CustomControls.CustomComboBox cbStatus;
        private PictureBox genderIcon;
    }
}