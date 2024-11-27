namespace TeacherManager
{
    partial class FormQLTK
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


        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeader = new Label();
            pictureBoxAvatar = new CustomControls.CustomPictureBox();
            lblName = new Label();
            lblAccountId = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblPhone = new Label();
            lblRole = new Label();
            txtBoxEmail = new CustomControls.CustomTextBox();
            txtBoxPassword = new CustomControls.CustomTextBox();
            txtBoxPhone = new CustomControls.CustomTextBox();
            txtBoxRole = new CustomControls.CustomTextBox();
            btnSaveChanges = new CustomControls.CustomButton();
            pictureChangePhone = new PictureBox();
            pictureChangePassword = new PictureBox();
            txtBoxOldPassword = new CustomControls.CustomTextBox();
            lblOldPassword = new Label();
            lblNewPassword = new Label();
            txtBoxNewPassword = new CustomControls.CustomTextBox();
            pictureEye = new PictureBox();
            panelChangePassword = new Panel();
            lblPasswordWarning = new Label();
            lblPhoneWarning = new Label();
            lblViewAccounts = new LinkLabel();
            genderIcon = new PictureBox();
            dtpBirth = new CustomControls.CustomDateTimePicker();
            lblBirthWarning = new Label();
            pictureChangeDOB = new PictureBox();
            label1 = new Label();
            lblChangeMailTemplate = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureChangePhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureChangePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEye).BeginInit();
            panelChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)genderIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureChangeDOB).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblHeader.Location = new Point(22, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(244, 31);
            lblHeader.TabIndex = 15;
            lblHeader.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pictureBoxAvatar.BorderColor = Color.RoyalBlue;
            pictureBoxAvatar.BorderColor2 = Color.HotPink;
            pictureBoxAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pictureBoxAvatar.BorderSize = 2;
            pictureBoxAvatar.Cursor = Cursors.Hand;
            pictureBoxAvatar.GradientAngle = 50F;
            pictureBoxAvatar.Location = new Point(95, 194);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(240, 240);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar.TabIndex = 20;
            pictureBoxAvatar.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(95, 452);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 31);
            lblName.TabIndex = 21;
            lblName.Text = "Tên";
            // 
            // lblAccountId
            // 
            lblAccountId.AutoSize = true;
            lblAccountId.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountId.Location = new Point(95, 486);
            lblAccountId.Name = "lblAccountId";
            lblAccountId.Size = new Size(151, 31);
            lblAccountId.TabIndex = 22;
            lblAccountId.Text = "MSSV/MSGV";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(515, 194);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(70, 31);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(515, 483);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(111, 31);
            lblPassword.TabIndex = 24;
            lblPassword.Text = "Mật khẩu";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(515, 294);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(151, 31);
            lblPhone.TabIndex = 25;
            lblPhone.Text = "Số điện thoại";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(515, 384);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(82, 31);
            lblRole.TabIndex = 26;
            lblRole.Text = "Vai trò";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.BackColor = SystemColors.Window;
            txtBoxEmail.BorderColor = Color.MediumSlateBlue;
            txtBoxEmail.BorderFocusColor = Color.HotPink;
            txtBoxEmail.BorderRadius = 0;
            txtBoxEmail.BorderSize = 2;
            txtBoxEmail.Enabled = false;
            txtBoxEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxEmail.Location = new Point(515, 229);
            txtBoxEmail.Margin = new Padding(4);
            txtBoxEmail.Multiline = false;
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Padding = new Padding(10, 7, 10, 7);
            txtBoxEmail.PasswordChar = false;
            txtBoxEmail.PlaceholderColor = Color.DarkGray;
            txtBoxEmail.PlaceholderText = "";
            txtBoxEmail.Size = new Size(313, 35);
            txtBoxEmail.TabIndex = 1;
            txtBoxEmail.Texts = "";
            txtBoxEmail.UnderlinedStyle = false;
            txtBoxEmail._TextChanged += CheckEnableSaveButton;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = SystemColors.Window;
            txtBoxPassword.BorderColor = Color.MediumSlateBlue;
            txtBoxPassword.BorderFocusColor = Color.HotPink;
            txtBoxPassword.BorderRadius = 0;
            txtBoxPassword.BorderSize = 2;
            txtBoxPassword.Enabled = false;
            txtBoxPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxPassword.Location = new Point(515, 520);
            txtBoxPassword.Margin = new Padding(4);
            txtBoxPassword.Multiline = false;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Padding = new Padding(10, 7, 10, 7);
            txtBoxPassword.PasswordChar = true;
            txtBoxPassword.PlaceholderColor = Color.DarkGray;
            txtBoxPassword.PlaceholderText = "";
            txtBoxPassword.Size = new Size(313, 35);
            txtBoxPassword.TabIndex = 4;
            txtBoxPassword.Texts = "";
            txtBoxPassword.UnderlinedStyle = false;
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.BackColor = SystemColors.Window;
            txtBoxPhone.BorderColor = Color.MediumSlateBlue;
            txtBoxPhone.BorderFocusColor = Color.HotPink;
            txtBoxPhone.BorderRadius = 0;
            txtBoxPhone.BorderSize = 2;
            txtBoxPhone.Enabled = false;
            txtBoxPhone.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPhone.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxPhone.Location = new Point(515, 329);
            txtBoxPhone.Margin = new Padding(4);
            txtBoxPhone.Multiline = false;
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Padding = new Padding(10, 7, 10, 7);
            txtBoxPhone.PasswordChar = false;
            txtBoxPhone.PlaceholderColor = Color.DarkGray;
            txtBoxPhone.PlaceholderText = "";
            txtBoxPhone.Size = new Size(313, 35);
            txtBoxPhone.TabIndex = 2;
            txtBoxPhone.Texts = "";
            txtBoxPhone.UnderlinedStyle = false;
            txtBoxPhone._TextChanged += OnPhoneNumberChanged;
            // 
            // txtBoxRole
            // 
            txtBoxRole.BackColor = SystemColors.Window;
            txtBoxRole.BorderColor = Color.MediumSlateBlue;
            txtBoxRole.BorderFocusColor = Color.HotPink;
            txtBoxRole.BorderRadius = 0;
            txtBoxRole.BorderSize = 2;
            txtBoxRole.Enabled = false;
            txtBoxRole.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxRole.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxRole.Location = new Point(515, 419);
            txtBoxRole.Margin = new Padding(4);
            txtBoxRole.Multiline = false;
            txtBoxRole.Name = "txtBoxRole";
            txtBoxRole.Padding = new Padding(10, 7, 10, 7);
            txtBoxRole.PasswordChar = false;
            txtBoxRole.PlaceholderColor = Color.DarkGray;
            txtBoxRole.PlaceholderText = "";
            txtBoxRole.Size = new Size(313, 35);
            txtBoxRole.TabIndex = 3;
            txtBoxRole.Texts = "";
            txtBoxRole.UnderlinedStyle = false;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.MediumSlateBlue;
            btnSaveChanges.BackgroundColor = Color.MediumSlateBlue;
            btnSaveChanges.BorderColor = Color.PaleVioletRed;
            btnSaveChanges.BorderRadius = 15;
            btnSaveChanges.BorderSize = 0;
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(97, 695);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(169, 50);
            btnSaveChanges.TabIndex = 27;
            btnSaveChanges.Text = "Lưu thay đổi";
            btnSaveChanges.TextColor = Color.White;
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Visible = false;
            btnSaveChanges.Click += SaveChanges;
            // 
            // pictureChangePhone
            // 
            pictureChangePhone.Image = Properties.Resources.pencil_icon;
            pictureChangePhone.Location = new Point(793, 297);
            pictureChangePhone.Name = "pictureChangePhone";
            pictureChangePhone.Size = new Size(35, 28);
            pictureChangePhone.SizeMode = PictureBoxSizeMode.Zoom;
            pictureChangePhone.TabIndex = 29;
            pictureChangePhone.TabStop = false;
            pictureChangePhone.Click += EnableChangePhone;
            // 
            // pictureChangePassword
            // 
            pictureChangePassword.Image = Properties.Resources.pencil_icon;
            pictureChangePassword.Location = new Point(793, 486);
            pictureChangePassword.Name = "pictureChangePassword";
            pictureChangePassword.Size = new Size(35, 28);
            pictureChangePassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictureChangePassword.TabIndex = 30;
            pictureChangePassword.TabStop = false;
            pictureChangePassword.Click += ShowPanelChangePaassword;
            // 
            // txtBoxOldPassword
            // 
            txtBoxOldPassword.BackColor = SystemColors.Window;
            txtBoxOldPassword.BorderColor = Color.MediumSlateBlue;
            txtBoxOldPassword.BorderFocusColor = Color.HotPink;
            txtBoxOldPassword.BorderRadius = 0;
            txtBoxOldPassword.BorderSize = 2;
            txtBoxOldPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxOldPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxOldPassword.Location = new Point(68, 45);
            txtBoxOldPassword.Margin = new Padding(4);
            txtBoxOldPassword.Multiline = false;
            txtBoxOldPassword.Name = "txtBoxOldPassword";
            txtBoxOldPassword.Padding = new Padding(10, 7, 10, 7);
            txtBoxOldPassword.PasswordChar = true;
            txtBoxOldPassword.PlaceholderColor = Color.DarkGray;
            txtBoxOldPassword.PlaceholderText = "";
            txtBoxOldPassword.Size = new Size(312, 35);
            txtBoxOldPassword.TabIndex = 31;
            txtBoxOldPassword.Texts = "";
            txtBoxOldPassword.UnderlinedStyle = false;
            txtBoxOldPassword._TextChanged += EditPassword;
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOldPassword.Location = new Point(68, 10);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(136, 31);
            lblOldPassword.TabIndex = 32;
            lblOldPassword.Text = "Mật khẩu cũ";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(68, 98);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(152, 31);
            lblNewPassword.TabIndex = 34;
            lblNewPassword.Text = "Mật khẩu mới";
            // 
            // txtBoxNewPassword
            // 
            txtBoxNewPassword.BackColor = SystemColors.Window;
            txtBoxNewPassword.BorderColor = Color.MediumSlateBlue;
            txtBoxNewPassword.BorderFocusColor = Color.HotPink;
            txtBoxNewPassword.BorderRadius = 0;
            txtBoxNewPassword.BorderSize = 2;
            txtBoxNewPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxNewPassword.Location = new Point(68, 133);
            txtBoxNewPassword.Margin = new Padding(4);
            txtBoxNewPassword.Multiline = false;
            txtBoxNewPassword.Name = "txtBoxNewPassword";
            txtBoxNewPassword.Padding = new Padding(10, 7, 10, 7);
            txtBoxNewPassword.PasswordChar = true;
            txtBoxNewPassword.PlaceholderColor = Color.DarkGray;
            txtBoxNewPassword.PlaceholderText = "";
            txtBoxNewPassword.Size = new Size(312, 35);
            txtBoxNewPassword.TabIndex = 33;
            txtBoxNewPassword.Texts = "";
            txtBoxNewPassword.UnderlinedStyle = false;
            txtBoxNewPassword._TextChanged += EditPassword;
            // 
            // pictureEye
            // 
            pictureEye.Image = Properties.Resources.eye_close_icon;
            pictureEye.Location = new Point(345, 13);
            pictureEye.Name = "pictureEye";
            pictureEye.Size = new Size(35, 28);
            pictureEye.SizeMode = PictureBoxSizeMode.Zoom;
            pictureEye.TabIndex = 35;
            pictureEye.TabStop = false;
            pictureEye.Click += TogglePasswordVisible;
            // 
            // panelChangePassword
            // 
            panelChangePassword.Controls.Add(lblPasswordWarning);
            panelChangePassword.Controls.Add(lblOldPassword);
            panelChangePassword.Controls.Add(pictureEye);
            panelChangePassword.Controls.Add(txtBoxOldPassword);
            panelChangePassword.Controls.Add(lblNewPassword);
            panelChangePassword.Controls.Add(txtBoxNewPassword);
            panelChangePassword.Location = new Point(447, 562);
            panelChangePassword.Name = "panelChangePassword";
            panelChangePassword.Size = new Size(417, 233);
            panelChangePassword.TabIndex = 36;
            panelChangePassword.Visible = false;
            // 
            // lblPasswordWarning
            // 
            lblPasswordWarning.AutoSize = true;
            lblPasswordWarning.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblPasswordWarning.ForeColor = Color.Red;
            lblPasswordWarning.Location = new Point(68, 172);
            lblPasswordWarning.Name = "lblPasswordWarning";
            lblPasswordWarning.Size = new Size(178, 23);
            lblPasswordWarning.TabIndex = 40;
            lblPasswordWarning.Text = "Mật khẩu không hợp lệ";
            lblPasswordWarning.Visible = false;
            // 
            // lblPhoneWarning
            // 
            lblPhoneWarning.AutoSize = true;
            lblPhoneWarning.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblPhoneWarning.ForeColor = Color.Red;
            lblPhoneWarning.Location = new Point(624, 368);
            lblPhoneWarning.Name = "lblPhoneWarning";
            lblPhoneWarning.Size = new Size(204, 23);
            lblPhoneWarning.TabIndex = 37;
            lblPhoneWarning.Text = "Số điện thoại không hợp lệ";
            lblPhoneWarning.Visible = false;
            // 
            // lblViewAccounts
            // 
            lblViewAccounts.AutoSize = true;
            lblViewAccounts.Cursor = Cursors.Hand;
            lblViewAccounts.Location = new Point(22, 73);
            lblViewAccounts.Name = "lblViewAccounts";
            lblViewAccounts.Size = new Size(174, 20);
            lblViewAccounts.TabIndex = 38;
            lblViewAccounts.TabStop = true;
            lblViewAccounts.Text = "Xem danh sách tài khoản";
            lblViewAccounts.LinkClicked += ShowAccountsDescriptionForm;
            // 
            // genderIcon
            // 
            genderIcon.Cursor = Cursors.Hand;
            genderIcon.Image = Properties.Resources.male_icon;
            genderIcon.Location = new Point(312, 187);
            genderIcon.Name = "genderIcon";
            genderIcon.Size = new Size(38, 38);
            genderIcon.SizeMode = PictureBoxSizeMode.Zoom;
            genderIcon.TabIndex = 39;
            genderIcon.TabStop = false;
            genderIcon.Click += OnGenderChange;
            // 
            // dtpBirth
            // 
            dtpBirth.BorderColor = Color.MediumSlateBlue;
            dtpBirth.BorderSize = 2;
            dtpBirth.CustomFormat = "dd/MM/yyyy";
            dtpBirth.Enabled = false;
            dtpBirth.Font = new Font("Segoe UI", 9.5F);
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.Location = new Point(95, 602);
            dtpBirth.MinimumSize = new Size(0, 35);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(250, 35);
            dtpBirth.SkinColor = Color.White;
            dtpBirth.TabIndex = 40;
            dtpBirth.TextColor = Color.DimGray;
            dtpBirth.ValueChanged += OnBirthDateChanged;
            // 
            // lblBirthWarning
            // 
            lblBirthWarning.AutoSize = true;
            lblBirthWarning.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblBirthWarning.ForeColor = Color.Red;
            lblBirthWarning.Location = new Point(97, 640);
            lblBirthWarning.Name = "lblBirthWarning";
            lblBirthWarning.Size = new Size(183, 23);
            lblBirthWarning.TabIndex = 41;
            lblBirthWarning.Text = "Ngày sinh không hợp lệ";
            lblBirthWarning.Visible = false;
            // 
            // pictureChangeDOB
            // 
            pictureChangeDOB.Image = Properties.Resources.pencil_icon;
            pictureChangeDOB.Location = new Point(310, 568);
            pictureChangeDOB.Name = "pictureChangeDOB";
            pictureChangeDOB.Size = new Size(35, 28);
            pictureChangeDOB.SizeMode = PictureBoxSizeMode.Zoom;
            pictureChangeDOB.TabIndex = 42;
            pictureChangeDOB.TabStop = false;
            pictureChangeDOB.Click += EnableChangeBirthDate;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 565);
            label1.Name = "label1";
            label1.Size = new Size(118, 31);
            label1.TabIndex = 43;
            label1.Text = "Ngày sinh";
            // 
            // lblChangeMailTemplate
            // 
            lblChangeMailTemplate.AutoSize = true;
            lblChangeMailTemplate.Cursor = Cursors.Hand;
            lblChangeMailTemplate.Location = new Point(92, 775);
            lblChangeMailTemplate.Name = "lblChangeMailTemplate";
            lblChangeMailTemplate.Size = new Size(248, 20);
            lblChangeMailTemplate.TabIndex = 44;
            lblChangeMailTemplate.TabStop = true;
            lblChangeMailTemplate.Text = "Thay đổi định dạng e-mail gửi điểm";
            lblChangeMailTemplate.Visible = false;
            lblChangeMailTemplate.LinkClicked += ShowChangeGradeEmailTemplateForm;
            // 
            // FormQLTK
            // 
            Controls.Add(lblChangeMailTemplate);
            Controls.Add(label1);
            Controls.Add(pictureChangeDOB);
            Controls.Add(lblBirthWarning);
            Controls.Add(dtpBirth);
            Controls.Add(genderIcon);
            Controls.Add(lblViewAccounts);
            Controls.Add(lblPhoneWarning);
            Controls.Add(panelChangePassword);
            Controls.Add(pictureChangePassword);
            Controls.Add(pictureChangePhone);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtBoxRole);
            Controls.Add(txtBoxPhone);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxEmail);
            Controls.Add(lblRole);
            Controls.Add(lblPhone);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblAccountId);
            Controls.Add(lblName);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(lblHeader);
            Name = "FormQLTK";
            Size = new Size(1572, 899);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureChangePhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureChangePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEye).EndInit();
            panelChangePassword.ResumeLayout(false);
            panelChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)genderIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureChangeDOB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataViewAccounts;
        private Panel panel1;
        private Label lblHeader;
        private CustomControls.CustomPictureBox pictureBoxAvatar;
        private Label lblName;
        private Label lblAccountId;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblPhone;
        private Label lblRole;
        private CustomControls.CustomTextBox txtBoxEmail;
        private CustomControls.CustomTextBox txtBoxPassword;
        private CustomControls.CustomTextBox txtBoxPhone;
        private CustomControls.CustomTextBox txtBoxRole;
        private CustomControls.CustomButton btnSaveChanges;
        private PictureBox pictureChangeEmail;
        private PictureBox pictureChangePhone;
        private PictureBox pictureChangePassword;
        private CustomControls.CustomTextBox txtBoxOldPassword;
        private Label lblOldPassword;
        private Label lblNewPassword;
        private CustomControls.CustomTextBox txtBoxNewPassword;
        private PictureBox pictureEye;
        private Panel panelChangePassword;
        private Label lblPhoneWarning;
        private LinkLabel lblViewAccounts;
        private PictureBox genderIcon;
        private Label lblPasswordWarning;
        private CustomControls.CustomDateTimePicker dtpBirth;
        private Label lblBirthWarning;
        private PictureBox pictureChangeDOB;
        private Label label1;
        private LinkLabel lblChangeMailTemplate;
    }
}
