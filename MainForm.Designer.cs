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
            panel1 = new Panel();
            label1 = new Label();
            panelNavigate = new Panel();
            btnLogOut = new CustomControls.CustomControls.CustomButton();
            btnQLHK = new CustomControls.CustomControls.CustomButton();
            btnLGD = new CustomControls.CustomControls.CustomButton();
            btnQLTK = new CustomControls.CustomControls.CustomButton();
            btnQLLH = new CustomControls.CustomControls.CustomButton();
            panelControl = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panelNavigate.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(353, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1492, 160);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 68);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panelNavigate
            // 
            panelNavigate.Controls.Add(btnLGD);
            panelNavigate.Controls.Add(btnLogOut);
            panelNavigate.Controls.Add(btnQLHK);
            panelNavigate.Controls.Add(btnQLTK);
            panelNavigate.Controls.Add(btnQLLH);
            panelNavigate.Location = new Point(2, 157);
            panelNavigate.Name = "panelNavigate";
            panelNavigate.Size = new Size(351, 605);
            panelNavigate.TabIndex = 1;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.MediumSlateBlue;
            btnLogOut.BackgroundColor = Color.MediumSlateBlue;
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
            btnLogOut.Location = new Point(0, 347);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(12, 0, 12, 0);
            btnLogOut.Size = new Size(351, 92);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "ĐĂNG XUẤT";
            btnLogOut.TextAlign = ContentAlignment.MiddleRight;
            btnLogOut.TextColor = Color.White;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.MouseClick += OnButtonNavigateClick;
            // 
            // btnQLHK
            // 
            btnQLHK.BackColor = Color.MediumSlateBlue;
            btnQLHK.BackgroundColor = Color.MediumSlateBlue;
            btnQLHK.BorderColor = Color.PaleVioletRed;
            btnQLHK.BorderRadius = 1;
            btnQLHK.BorderSize = 0;
            btnQLHK.Cursor = Cursors.PanEast;
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
            btnQLHK.Click += btnLHK_Click;
            btnQLHK.MouseClick += OnButtonNavigateClick;
            // 
            // btnLGD
            // 
            btnLGD.BackColor = Color.MediumSlateBlue;
            btnLGD.BackgroundColor = Color.MediumSlateBlue;
            btnLGD.BorderColor = Color.PaleVioletRed;
            btnLGD.BorderRadius = 1;
            btnLGD.BorderSize = 0;
            btnLGD.Cursor = Cursors.PanEast;
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
            btnLGD.MouseClick += OnButtonNavigateClick;
            // 
            // btnQLTK
            // 
            btnQLTK.BackColor = Color.MediumSlateBlue;
            btnQLTK.BackgroundColor = Color.MediumSlateBlue;
            btnQLTK.BorderColor = Color.PaleVioletRed;
            btnQLTK.BorderRadius = 1;
            btnQLTK.BorderSize = 0;
            btnQLTK.Cursor = Cursors.PanEast;
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
            btnQLTK.MouseClick += OnButtonNavigateClick;
            // 
            // btnQLLH
            // 
            btnQLLH.BackColor = Color.MediumSlateBlue;
            btnQLLH.BackgroundColor = Color.MediumSlateBlue;
            btnQLLH.BorderColor = Color.PaleVioletRed;
            btnQLLH.BorderRadius = 1;
            btnQLLH.BorderSize = 0;
            btnQLLH.Cursor = Cursors.PanEast;
            btnQLLH.FlatAppearance.BorderSize = 0;
            btnQLLH.FlatStyle = FlatStyle.Flat;
            btnQLLH.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLLH.ForeColor = Color.White;
            btnQLLH.Image = Properties.Resources.class_icon;
            btnQLLH.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLLH.Location = new Point(0, 0);
            btnQLLH.Name = "btnQLLH";
            btnQLLH.Padding = new Padding(12, 0, 12, 0);
            btnQLLH.Size = new Size(351, 92);
            btnQLLH.TabIndex = 0;
            btnQLLH.Text = "QUẢN LÍ LỚP HỌC";
            btnQLLH.TextAlign = ContentAlignment.MiddleRight;
            btnQLLH.TextColor = Color.White;
            btnQLLH.UseVisualStyleBackColor = false;
            btnQLLH.MouseClick += OnButtonNavigateClick;
            // 
            // panelControl
            // 
            panelControl.Location = new Point(353, 157);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1492, 589);
            panelControl.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1846, 745);
            Controls.Add(panelControl);
            Controls.Add(panelNavigate);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelNavigate.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ToolStripButton toolStripButton1;
        private ToolStripComboBox toolStripComboBox1;
        private Panel panelNavigate;
        private Panel panelControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomControls.CustomControls.CustomButton btnQLLH;
        private CustomControls.CustomControls.CustomButton btnLogOut;
        private CustomControls.CustomControls.CustomButton btnQLHK;
        private CustomControls.CustomControls.CustomButton btnLGD;
        private CustomControls.CustomControls.CustomButton btnQLTK;
    }
}