namespace TeacherManager
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeading = new Panel();
            pictureAvt = new CustomControls.CustomPictureBox();
            lblName = new Label();
            panelNavigate = new Panel();
            lblVersion = new Label();
            btnLGD = new CustomControls.CustomButton();
            btnLogOut = new CustomControls.CustomButton();
            btnQLHK = new CustomControls.CustomButton();
            btnQLTK = new CustomControls.CustomButton();
            btnQLLH = new CustomControls.CustomButton();
            panelControl = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ChooseAvtDialog = new OpenFileDialog();
            btnIndex = new PictureBox();
            button1 = new Button();
            panelHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAvt).BeginInit();
            panelNavigate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnIndex).BeginInit();
            SuspendLayout();
            // 
            // panelHeading
            // 
            panelHeading.BackColor = Color.CornflowerBlue;
            panelHeading.Controls.Add(pictureAvt);
            panelHeading.Controls.Add(lblName);
            panelHeading.Location = new Point(353, -2);
            panelHeading.Name = "panelHeading";
            panelHeading.Size = new Size(1569, 160);
            panelHeading.TabIndex = 0;
            // 
            // pictureAvt
            // 
            pictureAvt.BackColor = Color.LavenderBlush;
            pictureAvt.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pictureAvt.BorderColor = Color.RoyalBlue;
            pictureAvt.BorderColor2 = Color.HotPink;
            pictureAvt.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pictureAvt.BorderSize = 5;
            pictureAvt.Cursor = Cursors.Hand;
            pictureAvt.GradientAngle = 50F;
            pictureAvt.Image = Properties.Resources.default_avatar_icon;
            pictureAvt.Location = new Point(1218, 14);
            pictureAvt.Name = "pictureAvt";
            pictureAvt.Size = new Size(128, 128);
            pictureAvt.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAvt.TabIndex = 3;
            pictureAvt.TabStop = false;
            pictureAvt.Click += ChangeAvatar;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(991, 52);
            lblName.Name = "lblName";
            lblName.Size = new Size(194, 41);
            lblName.TabIndex = 0;
            lblName.Text = "Tên tài khoản";
            lblName.TextAlign = ContentAlignment.TopRight;
            // 
            // panelNavigate
            // 
            panelNavigate.BackColor = SystemColors.ControlLightLight;
            panelNavigate.Controls.Add(button1);
            panelNavigate.Controls.Add(lblVersion);
            panelNavigate.Controls.Add(btnLGD);
            panelNavigate.Controls.Add(btnLogOut);
            panelNavigate.Controls.Add(btnQLHK);
            panelNavigate.Controls.Add(btnQLTK);
            panelNavigate.Controls.Add(btnQLLH);
            panelNavigate.Location = new Point(2, 157);
            panelNavigate.Name = "panelNavigate";
            panelNavigate.RightToLeft = RightToLeft.No;
            panelNavigate.Size = new Size(351, 899);
            panelNavigate.TabIndex = 1;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(109, 846);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(128, 20);
            lblVersion.TabIndex = 5;
            lblVersion.Text = "v1.0.1 by Shifu Ma";
            // 
            // btnLGD
            // 
            btnLGD.BackColor = Color.CornflowerBlue;
            btnLGD.BackgroundColor = Color.CornflowerBlue;
            btnLGD.BorderColor = Color.PaleVioletRed;
            btnLGD.BorderRadius = 1;
            btnLGD.BorderSize = 0;
            btnLGD.Cursor = Cursors.Hand;
            btnLGD.FlatAppearance.BorderSize = 0;
            btnLGD.FlatStyle = FlatStyle.Flat;
            btnLGD.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLGD.ForeColor = Color.White;
            btnLGD.Image = Properties.Resources.calendar_icon;
            btnLGD.ImageAlign = ContentAlignment.MiddleLeft;
            btnLGD.Location = new Point(0, 263);
            btnLGD.Name = "btnLGD";
            btnLGD.Padding = new Padding(12, 0, 12, 0);
            btnLGD.Size = new Size(351, 92);
            btnLGD.TabIndex = 2;
            btnLGD.Text = "LỊCH GIẢNG DẠY";
            btnLGD.TextAlign = ContentAlignment.MiddleRight;
            btnLGD.TextColor = Color.White;
            btnLGD.UseVisualStyleBackColor = false;
            btnLGD.Click += OnButtonNavigateClick;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.CornflowerBlue;
            btnLogOut.BackgroundColor = Color.CornflowerBlue;
            btnLogOut.BorderColor = Color.PaleVioletRed;
            btnLogOut.BorderRadius = 1;
            btnLogOut.BorderSize = 0;
            btnLogOut.Cursor = Cursors.PanEast;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = Properties.Resources.dooropen_icon;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 352);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(12, 0, 12, 0);
            btnLogOut.Size = new Size(351, 92);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "ĐĂNG XUẤT";
            btnLogOut.TextAlign = ContentAlignment.MiddleRight;
            btnLogOut.TextColor = Color.White;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += LogOut;
            // 
            // btnQLHK
            // 
            btnQLHK.BackColor = Color.CornflowerBlue;
            btnQLHK.BackgroundColor = Color.CornflowerBlue;
            btnQLHK.BorderColor = Color.PaleVioletRed;
            btnQLHK.BorderRadius = 1;
            btnQLHK.BorderSize = 0;
            btnQLHK.Cursor = Cursors.Hand;
            btnQLHK.FlatAppearance.BorderSize = 0;
            btnQLHK.FlatStyle = FlatStyle.Flat;
            btnQLHK.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLHK.ForeColor = Color.White;
            btnQLHK.Image = Properties.Resources.book_icon;
            btnQLHK.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLHK.Location = new Point(0, 178);
            btnQLHK.Name = "btnQLHK";
            btnQLHK.Padding = new Padding(6, 0, 12, 0);
            btnQLHK.Size = new Size(351, 92);
            btnQLHK.TabIndex = 3;
            btnQLHK.Text = "QUẢN LÍ HỌC KÌ";
            btnQLHK.TextAlign = ContentAlignment.MiddleRight;
            btnQLHK.TextColor = Color.White;
            btnQLHK.UseVisualStyleBackColor = false;
            btnQLHK.Click += OnButtonNavigateClick;
            // 
            // btnQLTK
            // 
            btnQLTK.BackColor = Color.CornflowerBlue;
            btnQLTK.BackgroundColor = Color.CornflowerBlue;
            btnQLTK.BorderColor = Color.PaleVioletRed;
            btnQLTK.BorderRadius = 1;
            btnQLTK.BorderSize = 0;
            btnQLTK.Cursor = Cursors.Hand;
            btnQLTK.FlatAppearance.BorderSize = 0;
            btnQLTK.FlatStyle = FlatStyle.Flat;
            btnQLTK.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLTK.ForeColor = Color.White;
            btnQLTK.Image = Properties.Resources.account_icon;
            btnQLTK.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLTK.Location = new Point(0, 89);
            btnQLTK.Name = "btnQLTK";
            btnQLTK.Padding = new Padding(12, 0, 12, 0);
            btnQLTK.Size = new Size(351, 92);
            btnQLTK.TabIndex = 1;
            btnQLTK.Text = "QUẢN LÍ TÀI KHOẢN";
            btnQLTK.TextAlign = ContentAlignment.MiddleRight;
            btnQLTK.TextColor = Color.White;
            btnQLTK.UseVisualStyleBackColor = false;
            btnQLTK.Click += OnButtonNavigateClick;
            // 
            // btnQLLH
            // 
            btnQLLH.BackColor = Color.CornflowerBlue;
            btnQLLH.BackgroundColor = Color.CornflowerBlue;
            btnQLLH.BorderColor = Color.PaleVioletRed;
            btnQLLH.BorderRadius = 1;
            btnQLLH.BorderSize = 0;
            btnQLLH.Cursor = Cursors.Hand;
            btnQLLH.FlatAppearance.BorderSize = 0;
            btnQLLH.FlatStyle = FlatStyle.Flat;
            btnQLLH.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLLH.ForeColor = Color.White;
            btnQLLH.Image = Properties.Resources.class_icon;
            btnQLLH.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLLH.Location = new Point(0, 0);
            btnQLLH.Name = "btnQLLH";
            btnQLLH.Padding = new Padding(12, 0, 12, 0);
            btnQLLH.RightToLeft = RightToLeft.No;
            btnQLLH.Size = new Size(351, 92);
            btnQLLH.TabIndex = 0;
            btnQLLH.Text = "QUẢN LÍ LỚP HỌC";
            btnQLLH.TextAlign = ContentAlignment.MiddleRight;
            btnQLLH.TextColor = Color.White;
            btnQLLH.UseVisualStyleBackColor = false;
            btnQLLH.Click += OnButtonNavigateClick;
            // 
            // panelControl
            // 
            panelControl.BackColor = SystemColors.ControlLightLight;
            panelControl.Location = new Point(353, 157);
            panelControl.Name = "panelControl";
            panelControl.RightToLeft = RightToLeft.No;
            panelControl.Size = new Size(1572, 899);
            panelControl.TabIndex = 5;
            // 
            // ChooseAvtDialog
            // 
            ChooseAvtDialog.FileName = "avtFile";
            // 
            // btnIndex
            // 
            btnIndex.Cursor = Cursors.Hand;
            btnIndex.Image = Properties.Resources.logo;
            btnIndex.Location = new Point(2, -41);
            btnIndex.Name = "btnIndex";
            btnIndex.Size = new Size(351, 199);
            btnIndex.SizeMode = PictureBoxSizeMode.Zoom;
            btnIndex.TabIndex = 6;
            btnIndex.TabStop = false;
            btnIndex.Click += OnButtonNavigateClick;
            // 
            // button1
            // 
            button1.Location = new Point(176, 483);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "demo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnIndex);
            Controls.Add(panelControl);
            Controls.Add(panelNavigate);
            Controls.Add(panelHeading);
            Name = "MainForm";
            Text = "Trang chủ";
            WindowState = FormWindowState.Maximized;
            Leave += MainForm_Leave;
            panelHeading.ResumeLayout(false);
            panelHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAvt).EndInit();
            panelNavigate.ResumeLayout(false);
            panelNavigate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnIndex).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeading;
        private Label lblName;
        private ToolStripButton toolStripButton1;
        private ToolStripComboBox toolStripComboBox1;
        private Panel panelNavigate;
        private Panel panelControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TeacherManager.CustomControls.CustomButton btnQLLH;
        private TeacherManager.CustomControls.CustomButton btnLogOut;
        private TeacherManager.CustomControls.CustomButton btnQLHK;
        private TeacherManager.CustomControls.CustomButton btnLGD;
        private TeacherManager.CustomControls.CustomButton btnQLTK;
        private OpenFileDialog ChooseAvtDialog;
        private Panel panel1;
        private Label lblVersion;
        private FormLGD formlgd1;
        private CustomControls.CustomPictureBox pictureAvt;
        private PictureBox btnIndex;
        private Button btnTest;
        private Button button1;
    }
}