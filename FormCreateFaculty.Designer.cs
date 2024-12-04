namespace TeacherManager
{
    partial class FormCreateFaculty
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
            components = new System.ComponentModel.Container();
            lblFacultyId = new Label();
            txtBoxFacultyId = new CustomControls.CustomTextBox();
            btnAddFaculty = new CustomControls.CustomButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblHeader = new Label();
            lblFacultyName = new Label();
            label1 = new Label();
            cbTeacher = new CustomControls.CustomComboBox();
            txtBoxFacultyName = new CustomControls.CustomTextBox();
            timerNameTyped = new System.Windows.Forms.Timer(components);
            txtBoxNameToFind = new CustomControls.CustomTextBox();
            lblNameToFind = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblFacultyId
            // 
            lblFacultyId.AutoSize = true;
            lblFacultyId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFacultyId.Location = new Point(190, 80);
            lblFacultyId.Name = "lblFacultyId";
            lblFacultyId.Size = new Size(132, 31);
            lblFacultyId.TabIndex = 1;
            lblFacultyId.Text = "Mã bộ môn";
            // 
            // txtBoxFacultyId
            // 
            txtBoxFacultyId.BackColor = SystemColors.Window;
            txtBoxFacultyId.BorderColor = Color.MediumSlateBlue;
            txtBoxFacultyId.BorderFocusColor = Color.HotPink;
            txtBoxFacultyId.BorderRadius = 0;
            txtBoxFacultyId.BorderSize = 2;
            txtBoxFacultyId.Font = new Font("Segoe UI", 9.5F);
            txtBoxFacultyId.ForeColor = Color.DimGray;
            txtBoxFacultyId.Location = new Point(190, 115);
            txtBoxFacultyId.Margin = new Padding(4);
            txtBoxFacultyId.Multiline = false;
            txtBoxFacultyId.Name = "txtBoxFacultyId";
            txtBoxFacultyId.Padding = new Padding(7);
            txtBoxFacultyId.PasswordChar = false;
            txtBoxFacultyId.PlaceholderColor = Color.DarkGray;
            txtBoxFacultyId.PlaceholderText = "";
            txtBoxFacultyId.Size = new Size(324, 36);
            txtBoxFacultyId.TabIndex = 1;
            txtBoxFacultyId.Texts = "";
            txtBoxFacultyId.UnderlinedStyle = false;
            // 
            // btnAddFaculty
            // 
            btnAddFaculty.BackColor = Color.MediumSlateBlue;
            btnAddFaculty.BackgroundColor = Color.MediumSlateBlue;
            btnAddFaculty.BorderColor = Color.PaleVioletRed;
            btnAddFaculty.BorderRadius = 20;
            btnAddFaculty.BorderSize = 0;
            btnAddFaculty.Cursor = Cursors.Hand;
            btnAddFaculty.FlatAppearance.BorderSize = 0;
            btnAddFaculty.FlatStyle = FlatStyle.Flat;
            btnAddFaculty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFaculty.ForeColor = Color.White;
            btnAddFaculty.Location = new Point(247, 460);
            btnAddFaculty.Name = "btnAddFaculty";
            btnAddFaculty.Size = new Size(206, 44);
            btnAddFaculty.TabIndex = 9;
            btnAddFaculty.Text = "Thêm bộ môn";
            btnAddFaculty.TextColor = Color.White;
            btnAddFaculty.UseVisualStyleBackColor = false;
            btnAddFaculty.Click += AddFaculty;
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
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(27, 25);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(172, 31);
            lblHeader.TabIndex = 12;
            lblHeader.Text = "THÊM BỘ MÔN";
            // 
            // lblFacultyName
            // 
            lblFacultyName.AutoSize = true;
            lblFacultyName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFacultyName.Location = new Point(190, 173);
            lblFacultyName.Name = "lblFacultyName";
            lblFacultyName.Size = new Size(134, 31);
            lblFacultyName.TabIndex = 19;
            lblFacultyName.Text = "Tên bộ môn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 353);
            label1.Name = "label1";
            label1.Size = new Size(142, 31);
            label1.TabIndex = 20;
            label1.Text = "Trưởng khoa";
            // 
            // cbTeacher
            // 
            cbTeacher.BackColor = Color.WhiteSmoke;
            cbTeacher.BorderColor = Color.MediumSlateBlue;
            cbTeacher.BorderSize = 2;
            cbTeacher.DropDownStyle = ComboBoxStyle.DropDown;
            cbTeacher.Font = new Font("Segoe UI", 10F);
            cbTeacher.ForeColor = Color.DimGray;
            cbTeacher.IconColor = Color.MediumSlateBlue;
            cbTeacher.ListBackColor = Color.FromArgb(230, 228, 245);
            cbTeacher.ListTextColor = Color.DimGray;
            cbTeacher.Location = new Point(190, 387);
            cbTeacher.MinimumSize = new Size(50, 30);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Padding = new Padding(2);
            cbTeacher.Size = new Size(324, 38);
            cbTeacher.TabIndex = 4;
            cbTeacher.Texts = "";
            // 
            // txtBoxFacultyName
            // 
            txtBoxFacultyName.BackColor = SystemColors.Window;
            txtBoxFacultyName.BorderColor = Color.MediumSlateBlue;
            txtBoxFacultyName.BorderFocusColor = Color.HotPink;
            txtBoxFacultyName.BorderRadius = 0;
            txtBoxFacultyName.BorderSize = 2;
            txtBoxFacultyName.Font = new Font("Segoe UI", 9.5F);
            txtBoxFacultyName.ForeColor = Color.DimGray;
            txtBoxFacultyName.Location = new Point(190, 208);
            txtBoxFacultyName.Margin = new Padding(4);
            txtBoxFacultyName.Multiline = false;
            txtBoxFacultyName.Name = "txtBoxFacultyName";
            txtBoxFacultyName.Padding = new Padding(7);
            txtBoxFacultyName.PasswordChar = false;
            txtBoxFacultyName.PlaceholderColor = Color.DarkGray;
            txtBoxFacultyName.PlaceholderText = "";
            txtBoxFacultyName.Size = new Size(324, 36);
            txtBoxFacultyName.TabIndex = 2;
            txtBoxFacultyName.Texts = "";
            txtBoxFacultyName.UnderlinedStyle = false;
            // 
            // timerNameTyped
            // 
            timerNameTyped.Tick += TypingTimer_Tick;
            // 
            // txtBoxNameToFind
            // 
            txtBoxNameToFind.BackColor = SystemColors.Window;
            txtBoxNameToFind.BorderColor = Color.MediumSlateBlue;
            txtBoxNameToFind.BorderFocusColor = Color.HotPink;
            txtBoxNameToFind.BorderRadius = 0;
            txtBoxNameToFind.BorderSize = 2;
            txtBoxNameToFind.Font = new Font("Segoe UI", 9.5F);
            txtBoxNameToFind.ForeColor = Color.DimGray;
            txtBoxNameToFind.Location = new Point(190, 298);
            txtBoxNameToFind.Margin = new Padding(4);
            txtBoxNameToFind.Multiline = false;
            txtBoxNameToFind.Name = "txtBoxNameToFind";
            txtBoxNameToFind.Padding = new Padding(7);
            txtBoxNameToFind.PasswordChar = false;
            txtBoxNameToFind.PlaceholderColor = Color.DarkGray;
            txtBoxNameToFind.PlaceholderText = "";
            txtBoxNameToFind.Size = new Size(324, 36);
            txtBoxNameToFind.TabIndex = 3;
            txtBoxNameToFind.Texts = "";
            txtBoxNameToFind.UnderlinedStyle = false;
            txtBoxNameToFind._TextChanged += CheckTimerTyping;
            // 
            // lblNameToFind
            // 
            lblNameToFind.AutoSize = true;
            lblNameToFind.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameToFind.Location = new Point(190, 263);
            lblNameToFind.Name = "lblNameToFind";
            lblNameToFind.Size = new Size(165, 31);
            lblNameToFind.TabIndex = 23;
            lblNameToFind.Text = "Tìm giảng viên";
            // 
            // FormCreateFaculty
            // 
            AcceptButton = btnAddFaculty;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 516);
            Controls.Add(txtBoxNameToFind);
            Controls.Add(lblNameToFind);
            Controls.Add(txtBoxFacultyName);
            Controls.Add(cbTeacher);
            Controls.Add(label1);
            Controls.Add(lblFacultyName);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddFaculty);
            Controls.Add(txtBoxFacultyId);
            Controls.Add(lblFacultyId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCreateFaculty";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo học kỳ mới";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFacultyId;
        private TeacherManager.CustomControls.CustomTextBox txtBoxFacultyId;
        private TeacherManager.CustomControls.CustomButton btnAddFaculty;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblHeader;
        private Label lblFacultyName;
        private Label label1;
        private CustomControls.CustomComboBox cbTeacher;
        private CustomControls.CustomTextBox txtBoxFacultyName;
        private System.Windows.Forms.Timer timerNameTyped;
        private CustomControls.CustomTextBox txtBoxNameToFind;
        private Label lblNameToFind;
    }
}