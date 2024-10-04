namespace TeacherManager
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            chkBoxShowPassword = new CheckBox();
            btnLogin = new Button();
            txbPassword = new TextBox();
            txbID = new TextBox();
            lblPassword = new Label();
            lblName = new Label();
            lblHeader = new Label();
            lblHeader_2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(chkBoxShowPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txbPassword);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(140, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 205);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.account_icon;
            pictureBox1.Location = new Point(3, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // chkBoxShowPassword
            // 
            chkBoxShowPassword.AutoSize = true;
            chkBoxShowPassword.ImageAlign = ContentAlignment.MiddleLeft;
            chkBoxShowPassword.Location = new Point(235, 117);
            chkBoxShowPassword.Name = "chkBoxShowPassword";
            chkBoxShowPassword.Size = new Size(148, 24);
            chkBoxShowPassword.TabIndex = 4;
            chkBoxShowPassword.Text = "Hiển thị mật khẩu";
            chkBoxShowPassword.UseVisualStyleBackColor = true;
            chkBoxShowPassword.CheckedChanged += ToggleVisiblePassword;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(185, 163);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += OnLoginAttempt;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(235, 74);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '•';
            txbPassword.PlaceholderText = "Mật khẩu...";
            txbPassword.RightToLeft = RightToLeft.No;
            txbPassword.Size = new Size(182, 27);
            txbPassword.TabIndex = 3;
            // 
            // txbID
            // 
            txbID.Location = new Point(235, 25);
            txbID.Name = "txbID";
            txbID.PlaceholderText = "User ID...";
            txbID.Size = new Size(182, 27);
            txbID.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(59, 74);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(94, 28);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Mật khẩu";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(59, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Tên đăng nhập";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(182, 34);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(413, 54);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "HỆ THỐNG QUẢN LÝ";
            // 
            // lblHeader_2
            // 
            lblHeader_2.AutoSize = true;
            lblHeader_2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeader_2.Location = new Point(404, 88);
            lblHeader_2.Name = "lblHeader_2";
            lblHeader_2.Size = new Size(207, 38);
            lblHeader_2.TabIndex = 3;
            lblHeader_2.Text = "Cho giảng viên";
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHeader_2);
            Controls.Add(lblHeader);
            Controls.Add(panel1);
            Name = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label lblName;
        private TextBox txbPassword;
        private TextBox txbID;
        private Label lblPassword;
        private Button btnLogin;
        private Label lblHeader;
        private Label lblHeader_2;
        private CheckBox chkBoxShowPassword;
        private PictureBox pictureBox1;
    }
}
