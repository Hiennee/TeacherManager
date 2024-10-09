namespace TeacherManager
{
    partial class FormCreateStudentClasses
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
            lblStudentName = new Label();
            lblAccountName = new Label();
            txtBoxStudentName = new CustomControls.CustomTextBox();
            btnAddStudent = new CustomControls.CustomButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblHeader = new Label();
            txtBoxAccountId = new CustomControls.CustomComboBox();
            toolTipAccountId = new ToolTip(components);
            timerKeyTyped = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(209, 83);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(145, 31);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Tên sinh viên";
            // 
            // lblAccountName
            // 
            lblAccountName.AutoSize = true;
            lblAccountName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccountName.Location = new Point(209, 174);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(202, 31);
            lblAccountName.TabIndex = 1;
            lblAccountName.Text = "Mã số sinh viên (?)";
            toolTipAccountId.SetToolTip(lblAccountName, "Nhập tên sinh viên cần thêm và hệ thống sẽ tìm MSSV dựa trên họ tên đã nhập\r\n");
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
            txtBoxStudentName.Location = new Point(209, 117);
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
            txtBoxStudentName._TextChanged += CheckTimerTyping;
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
            btnAddStudent.Location = new Point(209, 314);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(250, 44);
            btnAddStudent.TabIndex = 9;
            btnAddStudent.Text = "Thêm sinh viên vào lớp";
            btnAddStudent.TextColor = Color.White;
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += AddStudentToClass;
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
            lblHeader.Size = new Size(187, 31);
            lblHeader.TabIndex = 12;
            lblHeader.Text = "THÊM SINH VIÊN";
            // 
            // txtBoxAccountId
            // 
            txtBoxAccountId.AutoCompleteCustomSource.AddRange(new string[] { "test_hocsinh", "ma_c" });
            txtBoxAccountId.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBoxAccountId.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtBoxAccountId.BackColor = Color.WhiteSmoke;
            txtBoxAccountId.BorderColor = Color.MediumSlateBlue;
            txtBoxAccountId.BorderSize = 2;
            txtBoxAccountId.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBoxAccountId.Font = new Font("Segoe UI", 10F);
            txtBoxAccountId.ForeColor = SystemColors.Desktop;
            txtBoxAccountId.IconColor = Color.MediumSlateBlue;
            txtBoxAccountId.ListBackColor = Color.FromArgb(230, 228, 245);
            txtBoxAccountId.ListTextColor = Color.DimGray;
            txtBoxAccountId.Location = new Point(209, 208);
            txtBoxAccountId.MinimumSize = new Size(200, 30);
            txtBoxAccountId.Name = "txtBoxAccountId";
            txtBoxAccountId.Padding = new Padding(2);
            txtBoxAccountId.Size = new Size(250, 38);
            txtBoxAccountId.TabIndex = 13;
            txtBoxAccountId.Texts = "";
            // 
            // timerKeyTyped
            // 
            timerKeyTyped.Tick += TypingTimer_Tick;
            // 
            // FormCreateStudentClasses
            // 
            AcceptButton = btnAddStudent;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 417);
            Controls.Add(txtBoxAccountId);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddStudent);
            Controls.Add(txtBoxStudentName);
            Controls.Add(lblAccountName);
            Controls.Add(lblStudentName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCreateStudentClasses";
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
        private TeacherManager.CustomControls.CustomTextBox txtBoxStudentName;
        private TeacherManager.CustomControls.CustomButton btnAddStudent;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TeacherManager.CustomControls.CustomTextBox txtBoxMSSV;
        private Label lblMSSV;
        private Label lblHeader;
        private CustomControls.CustomComboBox txtBoxAccountId;
        private ToolTip toolTipAccountId;
        private System.Windows.Forms.Timer timerKeyTyped;
    }
}