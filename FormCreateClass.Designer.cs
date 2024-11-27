namespace TeacherManager
{
    partial class FormCreateClass
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
            lblTeacherId = new Label();
            lblClassId = new Label();
            lblClassName = new Label();
            lblRoom = new Label();
            txtBoxClassId = new CustomControls.CustomTextBox();
            txtBoxTeacherId = new CustomControls.CustomTextBox();
            txtBoxClassName = new CustomControls.CustomTextBox();
            txtBoxRoom = new CustomControls.CustomTextBox();
            btnAddStudent = new CustomControls.CustomButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblScheduleFrom = new Label();
            lblHeader = new Label();
            lblScheduleTo = new Label();
            lblIcon1 = new Label();
            lblGradeWeight1 = new Label();
            lblGradeWeight2 = new Label();
            lblGradeWeight3 = new Label();
            lblGradeWeight4 = new Label();
            numericFromHour = new NumericUpDown();
            numericFromMinute = new NumericUpDown();
            numericToMinute = new NumericUpDown();
            numericToHour = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            numericGradeWeight1 = new NumericUpDown();
            numericGradeWeight2 = new NumericUpDown();
            numericGradeWeight3 = new NumericUpDown();
            numericGradeWeight4 = new NumericUpDown();
            txtBoxSemesterId = new CustomControls.CustomTextBox();
            lblSemesterId = new Label();
            lblDayOfWeek = new Label();
            cbDayOfWeek = new CustomControls.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericFromHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericFromMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericToMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericToHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGradeWeight1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGradeWeight2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGradeWeight3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGradeWeight4).BeginInit();
            SuspendLayout();
            // 
            // lblTeacherId
            // 
            lblTeacherId.AutoSize = true;
            lblTeacherId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeacherId.Location = new Point(143, 254);
            lblTeacherId.Name = "lblTeacherId";
            lblTeacherId.Size = new Size(189, 31);
            lblTeacherId.TabIndex = 0;
            lblTeacherId.Text = "Mã số giảng viên";
            // 
            // lblClassId
            // 
            lblClassId.AutoSize = true;
            lblClassId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassId.Location = new Point(143, 81);
            lblClassId.Name = "lblClassId";
            lblClassId.Size = new Size(129, 31);
            lblClassId.TabIndex = 1;
            lblClassId.Text = "Số hiệu lớp";
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(143, 343);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(150, 31);
            lblClassName.TabIndex = 2;
            lblClassName.Text = "Tên học phần";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(320, 417);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(80, 31);
            lblRoom.TabIndex = 3;
            lblRoom.Text = "Phòng";
            // 
            // txtBoxClassId
            // 
            txtBoxClassId.BackColor = SystemColors.Window;
            txtBoxClassId.BorderColor = Color.MediumSlateBlue;
            txtBoxClassId.BorderFocusColor = Color.HotPink;
            txtBoxClassId.BorderRadius = 0;
            txtBoxClassId.BorderSize = 2;
            txtBoxClassId.Font = new Font("Segoe UI", 9.5F);
            txtBoxClassId.ForeColor = Color.DimGray;
            txtBoxClassId.Location = new Point(143, 115);
            txtBoxClassId.Margin = new Padding(4);
            txtBoxClassId.Multiline = false;
            txtBoxClassId.Name = "txtBoxClassId";
            txtBoxClassId.Padding = new Padding(7);
            txtBoxClassId.PasswordChar = false;
            txtBoxClassId.PlaceholderColor = Color.DarkGray;
            txtBoxClassId.PlaceholderText = "";
            txtBoxClassId.Size = new Size(267, 36);
            txtBoxClassId.TabIndex = 4;
            txtBoxClassId.Texts = "";
            txtBoxClassId.UnderlinedStyle = false;
            txtBoxClassId._TextChanged += CheckAddStudentButtonAvailable;
            // 
            // txtBoxTeacherId
            // 
            txtBoxTeacherId.BackColor = SystemColors.Window;
            txtBoxTeacherId.BorderColor = Color.MediumSlateBlue;
            txtBoxTeacherId.BorderFocusColor = Color.HotPink;
            txtBoxTeacherId.BorderRadius = 0;
            txtBoxTeacherId.BorderSize = 2;
            txtBoxTeacherId.Font = new Font("Segoe UI", 9.5F);
            txtBoxTeacherId.ForeColor = Color.DimGray;
            txtBoxTeacherId.Location = new Point(143, 289);
            txtBoxTeacherId.Margin = new Padding(4);
            txtBoxTeacherId.Multiline = false;
            txtBoxTeacherId.Name = "txtBoxTeacherId";
            txtBoxTeacherId.Padding = new Padding(7);
            txtBoxTeacherId.PasswordChar = false;
            txtBoxTeacherId.PlaceholderColor = Color.DarkGray;
            txtBoxTeacherId.PlaceholderText = "";
            txtBoxTeacherId.Size = new Size(267, 36);
            txtBoxTeacherId.TabIndex = 6;
            txtBoxTeacherId.Texts = "";
            txtBoxTeacherId.UnderlinedStyle = false;
            txtBoxTeacherId._TextChanged += CheckAddStudentButtonAvailable;
            // 
            // txtBoxClassName
            // 
            txtBoxClassName.AccessibleDescription = "";
            txtBoxClassName.BackColor = SystemColors.Window;
            txtBoxClassName.BorderColor = Color.MediumSlateBlue;
            txtBoxClassName.BorderFocusColor = Color.HotPink;
            txtBoxClassName.BorderRadius = 0;
            txtBoxClassName.BorderSize = 2;
            txtBoxClassName.Font = new Font("Segoe UI", 9.5F);
            txtBoxClassName.ForeColor = Color.DimGray;
            txtBoxClassName.Location = new Point(143, 377);
            txtBoxClassName.Margin = new Padding(4);
            txtBoxClassName.Multiline = false;
            txtBoxClassName.Name = "txtBoxClassName";
            txtBoxClassName.Padding = new Padding(7);
            txtBoxClassName.PasswordChar = false;
            txtBoxClassName.PlaceholderColor = Color.DarkGray;
            txtBoxClassName.PlaceholderText = "";
            txtBoxClassName.Size = new Size(267, 36);
            txtBoxClassName.TabIndex = 7;
            txtBoxClassName.Texts = "";
            txtBoxClassName.UnderlinedStyle = false;
            txtBoxClassName._TextChanged += CheckAddStudentButtonAvailable;
            // 
            // txtBoxRoom
            // 
            txtBoxRoom.BackColor = SystemColors.Window;
            txtBoxRoom.BorderColor = Color.MediumSlateBlue;
            txtBoxRoom.BorderFocusColor = Color.HotPink;
            txtBoxRoom.BorderRadius = 0;
            txtBoxRoom.BorderSize = 2;
            txtBoxRoom.Font = new Font("Segoe UI", 9.5F);
            txtBoxRoom.ForeColor = Color.DimGray;
            txtBoxRoom.Location = new Point(291, 458);
            txtBoxRoom.Margin = new Padding(4);
            txtBoxRoom.Multiline = false;
            txtBoxRoom.Name = "txtBoxRoom";
            txtBoxRoom.Padding = new Padding(7);
            txtBoxRoom.PasswordChar = false;
            txtBoxRoom.PlaceholderColor = Color.DarkGray;
            txtBoxRoom.PlaceholderText = "";
            txtBoxRoom.Size = new Size(119, 36);
            txtBoxRoom.TabIndex = 9;
            txtBoxRoom.Texts = "";
            txtBoxRoom.UnderlinedStyle = false;
            txtBoxRoom._TextChanged += CheckAddStudentButtonAvailable;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.MediumSlateBlue;
            btnAddStudent.BackgroundColor = Color.MediumSlateBlue;
            btnAddStudent.BorderColor = Color.PaleVioletRed;
            btnAddStudent.BorderRadius = 20;
            btnAddStudent.BorderSize = 0;
            btnAddStudent.Cursor = Cursors.Hand;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(362, 539);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(206, 44);
            btnAddStudent.TabIndex = 18;
            btnAddStudent.Text = "Thêm lớp";
            btnAddStudent.TextColor = Color.White;
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += AddClass;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.minus_icon;
            pictureBox1.Location = new Point(794, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.x_icon;
            pictureBox2.Location = new Point(877, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += CloseForm;
            // 
            // lblScheduleFrom
            // 
            lblScheduleFrom.AutoSize = true;
            lblScheduleFrom.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScheduleFrom.Location = new Point(513, 81);
            lblScheduleFrom.Name = "lblScheduleFrom";
            lblScheduleFrom.Size = new Size(40, 31);
            lblScheduleFrom.TabIndex = 11;
            lblScheduleFrom.Text = "Từ";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(27, 25);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(123, 31);
            lblHeader.TabIndex = 12;
            lblHeader.Text = "THÊM LỚP";
            // 
            // lblScheduleTo
            // 
            lblScheduleTo.AutoSize = true;
            lblScheduleTo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScheduleTo.Location = new Point(656, 81);
            lblScheduleTo.Name = "lblScheduleTo";
            lblScheduleTo.Size = new Size(55, 31);
            lblScheduleTo.TabIndex = 14;
            lblScheduleTo.Text = "Đến";
            // 
            // lblIcon1
            // 
            lblIcon1.AutoSize = true;
            lblIcon1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIcon1.Location = new Point(640, 103);
            lblIcon1.Name = "lblIcon1";
            lblIcon1.Size = new Size(20, 28);
            lblIcon1.TabIndex = 15;
            lblIcon1.Text = "_";
            // 
            // lblGradeWeight1
            // 
            lblGradeWeight1.AutoSize = true;
            lblGradeWeight1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeWeight1.Location = new Point(513, 167);
            lblGradeWeight1.Name = "lblGradeWeight1";
            lblGradeWeight1.Size = new Size(186, 31);
            lblGradeWeight1.TabIndex = 17;
            lblGradeWeight1.Text = "Hệ số điểm 1 (%)";
            // 
            // lblGradeWeight2
            // 
            lblGradeWeight2.AutoSize = true;
            lblGradeWeight2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeWeight2.Location = new Point(513, 254);
            lblGradeWeight2.Name = "lblGradeWeight2";
            lblGradeWeight2.Size = new Size(186, 31);
            lblGradeWeight2.TabIndex = 19;
            lblGradeWeight2.Text = "Hệ số điểm 2 (%)";
            // 
            // lblGradeWeight3
            // 
            lblGradeWeight3.AutoSize = true;
            lblGradeWeight3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeWeight3.Location = new Point(513, 343);
            lblGradeWeight3.Name = "lblGradeWeight3";
            lblGradeWeight3.Size = new Size(186, 31);
            lblGradeWeight3.TabIndex = 21;
            lblGradeWeight3.Text = "Hệ số điểm 3 (%)";
            // 
            // lblGradeWeight4
            // 
            lblGradeWeight4.AutoSize = true;
            lblGradeWeight4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeWeight4.Location = new Point(513, 425);
            lblGradeWeight4.Name = "lblGradeWeight4";
            lblGradeWeight4.Size = new Size(186, 31);
            lblGradeWeight4.TabIndex = 23;
            lblGradeWeight4.Text = "Hệ số điểm 4 (%)";
            // 
            // numericFromHour
            // 
            numericFromHour.Location = new Point(513, 116);
            numericFromHour.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericFromHour.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            numericFromHour.Name = "numericFromHour";
            numericFromHour.Size = new Size(48, 27);
            numericFromHour.TabIndex = 10;
            numericFromHour.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // numericFromMinute
            // 
            numericFromMinute.Location = new Point(586, 115);
            numericFromMinute.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericFromMinute.Name = "numericFromMinute";
            numericFromMinute.Size = new Size(48, 27);
            numericFromMinute.TabIndex = 11;
            // 
            // numericToMinute
            // 
            numericToMinute.Location = new Point(735, 115);
            numericToMinute.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericToMinute.Name = "numericToMinute";
            numericToMinute.Size = new Size(48, 27);
            numericToMinute.TabIndex = 13;
            // 
            // numericToHour
            // 
            numericToHour.Location = new Point(663, 115);
            numericToHour.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            numericToHour.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericToHour.Name = "numericToHour";
            numericToHour.Size = new Size(48, 27);
            numericToHour.TabIndex = 12;
            numericToHour.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(568, 118);
            label1.Name = "label1";
            label1.Size = new Size(12, 20);
            label1.TabIndex = 28;
            label1.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(717, 118);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 29;
            label2.Text = ":";
            // 
            // numericGradeWeight1
            // 
            numericGradeWeight1.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericGradeWeight1.Location = new Point(513, 202);
            numericGradeWeight1.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numericGradeWeight1.Name = "numericGradeWeight1";
            numericGradeWeight1.Size = new Size(78, 27);
            numericGradeWeight1.TabIndex = 14;
            // 
            // numericGradeWeight2
            // 
            numericGradeWeight2.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericGradeWeight2.Location = new Point(513, 289);
            numericGradeWeight2.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numericGradeWeight2.Name = "numericGradeWeight2";
            numericGradeWeight2.Size = new Size(78, 27);
            numericGradeWeight2.TabIndex = 15;
            // 
            // numericGradeWeight3
            // 
            numericGradeWeight3.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericGradeWeight3.Location = new Point(513, 377);
            numericGradeWeight3.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numericGradeWeight3.Name = "numericGradeWeight3";
            numericGradeWeight3.Size = new Size(78, 27);
            numericGradeWeight3.TabIndex = 16;
            // 
            // numericGradeWeight4
            // 
            numericGradeWeight4.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericGradeWeight4.Location = new Point(513, 460);
            numericGradeWeight4.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numericGradeWeight4.Name = "numericGradeWeight4";
            numericGradeWeight4.Size = new Size(78, 27);
            numericGradeWeight4.TabIndex = 17;
            // 
            // txtBoxSemesterId
            // 
            txtBoxSemesterId.BackColor = SystemColors.Window;
            txtBoxSemesterId.BorderColor = Color.MediumSlateBlue;
            txtBoxSemesterId.BorderFocusColor = Color.HotPink;
            txtBoxSemesterId.BorderRadius = 0;
            txtBoxSemesterId.BorderSize = 2;
            txtBoxSemesterId.Enabled = false;
            txtBoxSemesterId.Font = new Font("Segoe UI", 9.5F);
            txtBoxSemesterId.ForeColor = Color.DimGray;
            txtBoxSemesterId.Location = new Point(143, 202);
            txtBoxSemesterId.Margin = new Padding(4);
            txtBoxSemesterId.Multiline = false;
            txtBoxSemesterId.Name = "txtBoxSemesterId";
            txtBoxSemesterId.Padding = new Padding(7);
            txtBoxSemesterId.PasswordChar = false;
            txtBoxSemesterId.PlaceholderColor = Color.DarkGray;
            txtBoxSemesterId.PlaceholderText = "";
            txtBoxSemesterId.Size = new Size(267, 36);
            txtBoxSemesterId.TabIndex = 5;
            txtBoxSemesterId.Texts = "";
            txtBoxSemesterId.UnderlinedStyle = false;
            txtBoxSemesterId._TextChanged += CheckAddStudentButtonAvailable;
            // 
            // lblSemesterId
            // 
            lblSemesterId.AutoSize = true;
            lblSemesterId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSemesterId.Location = new Point(143, 167);
            lblSemesterId.Name = "lblSemesterId";
            lblSemesterId.Size = new Size(118, 31);
            lblSemesterId.TabIndex = 34;
            lblSemesterId.Text = "Mã học kỳ";
            // 
            // lblDayOfWeek
            // 
            lblDayOfWeek.AutoSize = true;
            lblDayOfWeek.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDayOfWeek.Location = new Point(143, 425);
            lblDayOfWeek.Name = "lblDayOfWeek";
            lblDayOfWeek.Size = new Size(53, 31);
            lblDayOfWeek.TabIndex = 35;
            lblDayOfWeek.Text = "Thứ";
            // 
            // cbDayOfWeek
            // 
            cbDayOfWeek.BackColor = SystemColors.Window;
            cbDayOfWeek.BorderColor = Color.MediumSlateBlue;
            cbDayOfWeek.BorderSize = 2;
            cbDayOfWeek.DropDownStyle = ComboBoxStyle.DropDown;
            cbDayOfWeek.Font = new Font("Segoe UI", 10F);
            cbDayOfWeek.ForeColor = Color.DimGray;
            cbDayOfWeek.IconColor = Color.MediumSlateBlue;
            cbDayOfWeek.Items.AddRange(new object[] { "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy" });
            cbDayOfWeek.ListBackColor = Color.FromArgb(230, 228, 245);
            cbDayOfWeek.ListTextColor = Color.DimGray;
            cbDayOfWeek.Location = new Point(143, 458);
            cbDayOfWeek.MinimumSize = new Size(100, 30);
            cbDayOfWeek.Name = "cbDayOfWeek";
            cbDayOfWeek.Padding = new Padding(2);
            cbDayOfWeek.Size = new Size(118, 36);
            cbDayOfWeek.TabIndex = 8;
            cbDayOfWeek.Texts = "";
            // 
            // FormCreateClass
            // 
            AcceptButton = btnAddStudent;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 615);
            Controls.Add(cbDayOfWeek);
            Controls.Add(lblDayOfWeek);
            Controls.Add(txtBoxSemesterId);
            Controls.Add(lblSemesterId);
            Controls.Add(numericGradeWeight4);
            Controls.Add(numericGradeWeight3);
            Controls.Add(numericGradeWeight2);
            Controls.Add(numericGradeWeight1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericToMinute);
            Controls.Add(numericToHour);
            Controls.Add(numericFromMinute);
            Controls.Add(numericFromHour);
            Controls.Add(lblGradeWeight4);
            Controls.Add(lblGradeWeight3);
            Controls.Add(lblGradeWeight2);
            Controls.Add(lblGradeWeight1);
            Controls.Add(lblIcon1);
            Controls.Add(lblScheduleTo);
            Controls.Add(lblHeader);
            Controls.Add(lblScheduleFrom);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddStudent);
            Controls.Add(txtBoxRoom);
            Controls.Add(txtBoxClassName);
            Controls.Add(txtBoxTeacherId);
            Controls.Add(txtBoxClassId);
            Controls.Add(lblRoom);
            Controls.Add(lblClassName);
            Controls.Add(lblClassId);
            Controls.Add(lblTeacherId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCreateClass";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo lớp học mới";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericFromHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericFromMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericToMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericToHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGradeWeight1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGradeWeight2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGradeWeight3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGradeWeight4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTeacherId;
        private Label lblClassId;
        private Label lblClassName;
        private Label lblRoom;
        private TeacherManager.CustomControls.CustomTextBox txtBoxClassId;
        private TeacherManager.CustomControls.CustomTextBox txtBoxTeacherId;
        private TeacherManager.CustomControls.CustomTextBox txtBoxClassName;
        private TeacherManager.CustomControls.CustomTextBox txtBoxRoom;
        private TeacherManager.CustomControls.CustomButton btnAddStudent;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblScheduleFrom;
        private Label lblHeader;
        private Label lblScheduleTo;
        private Label lblIcon1;
        private Label lblGradeWeight1;
        private Label lblGradeWeight2;
        private Label lblGradeWeight3;
        private Label lblGradeWeight4;
        private TeacherManager.CustomControls.CustomNumericUpDown customNumericUpDown1;
        private NumericUpDown numericFromHour;
        private NumericUpDown numericFromMinute;
        private NumericUpDown numericToMinute;
        private NumericUpDown numericToHour;
        private Label label1;
        private Label label2;
        private NumericUpDown numericGradeWeight1;
        private NumericUpDown numericGradeWeight2;
        private NumericUpDown numericGradeWeight3;
        private NumericUpDown numericGradeWeight4;
        private CustomControls.CustomTextBox txtBoxSemesterId;
        private Label lblSemesterId;
        private Label lblDayOfWeek;
        private CustomControls.CustomComboBox cbDayOfWeek;
    }
}