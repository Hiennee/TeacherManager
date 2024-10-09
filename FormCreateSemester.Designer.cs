namespace TeacherManager
{
    partial class FormCreateSemester
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
            lblSemesterId = new Label();
            txtBoxSemesterId = new CustomControls.CustomTextBox();
            btnAddSemester = new CustomControls.CustomButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblHeader = new Label();
            lblFromDate = new Label();
            dateTimePickerTo = new CustomControls.CustomDateTimePicker();
            lblScheduleTo = new Label();
            label1 = new Label();
            dateTimePickerFrom = new CustomControls.CustomDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblSemesterId
            // 
            lblSemesterId.AutoSize = true;
            lblSemesterId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSemesterId.Location = new Point(190, 80);
            lblSemesterId.Name = "lblSemesterId";
            lblSemesterId.Size = new Size(160, 31);
            lblSemesterId.TabIndex = 1;
            lblSemesterId.Text = "Số hiệu học kỳ";
            // 
            // txtBoxSemesterId
            // 
            txtBoxSemesterId.BackColor = SystemColors.Window;
            txtBoxSemesterId.BorderColor = Color.MediumSlateBlue;
            txtBoxSemesterId.BorderFocusColor = Color.HotPink;
            txtBoxSemesterId.BorderRadius = 0;
            txtBoxSemesterId.BorderSize = 2;
            txtBoxSemesterId.Font = new Font("Segoe UI", 9.5F);
            txtBoxSemesterId.ForeColor = Color.DimGray;
            txtBoxSemesterId.Location = new Point(190, 115);
            txtBoxSemesterId.Margin = new Padding(4);
            txtBoxSemesterId.Multiline = false;
            txtBoxSemesterId.Name = "txtBoxSemesterId";
            txtBoxSemesterId.Padding = new Padding(7);
            txtBoxSemesterId.PasswordChar = false;
            txtBoxSemesterId.PlaceholderColor = Color.DarkGray;
            txtBoxSemesterId.PlaceholderText = "";
            txtBoxSemesterId.Size = new Size(324, 36);
            txtBoxSemesterId.TabIndex = 4;
            txtBoxSemesterId.Texts = "";
            txtBoxSemesterId.UnderlinedStyle = false;
            // 
            // btnAddSemester
            // 
            btnAddSemester.BackColor = Color.MediumSlateBlue;
            btnAddSemester.BackgroundColor = Color.MediumSlateBlue;
            btnAddSemester.BorderColor = Color.PaleVioletRed;
            btnAddSemester.BorderRadius = 20;
            btnAddSemester.BorderSize = 0;
            btnAddSemester.FlatAppearance.BorderSize = 0;
            btnAddSemester.FlatStyle = FlatStyle.Flat;
            btnAddSemester.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSemester.ForeColor = Color.White;
            btnAddSemester.Location = new Point(230, 321);
            btnAddSemester.Name = "btnAddSemester";
            btnAddSemester.Size = new Size(206, 44);
            btnAddSemester.TabIndex = 9;
            btnAddSemester.Text = "Thêm học kỳ";
            btnAddSemester.TextColor = Color.White;
            btnAddSemester.UseVisualStyleBackColor = false;
            btnAddSemester.Click += AddSemester;
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
            lblHeader.Size = new Size(160, 31);
            lblHeader.TabIndex = 12;
            lblHeader.Text = "THÊM HỌC KỲ";
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFromDate.Location = new Point(190, 174);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(40, 31);
            lblFromDate.TabIndex = 13;
            lblFromDate.Text = "Từ";
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.BorderColor = Color.MediumSlateBlue;
            dateTimePickerTo.BorderSize = 2;
            dateTimePickerTo.CalendarTrailingForeColor = Color.Gray;
            dateTimePickerTo.CustomFormat = "dd/MM/yyyy";
            dateTimePickerTo.Font = new Font("Segoe UI", 9.5F);
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.Location = new Point(372, 208);
            dateTimePickerTo.MinimumSize = new Size(0, 35);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(142, 35);
            dateTimePickerTo.SkinColor = SystemColors.Window;
            dateTimePickerTo.TabIndex = 16;
            dateTimePickerTo.TextColor = Color.Black;
            dateTimePickerTo.Value = new DateTime(2025, 1, 4, 0, 0, 0, 0);
            // 
            // lblScheduleTo
            // 
            lblScheduleTo.AutoSize = true;
            lblScheduleTo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScheduleTo.Location = new Point(459, 174);
            lblScheduleTo.Name = "lblScheduleTo";
            lblScheduleTo.Size = new Size(55, 31);
            lblScheduleTo.TabIndex = 15;
            lblScheduleTo.Text = "Đến";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 204);
            label1.Name = "label1";
            label1.Size = new Size(28, 38);
            label1.TabIndex = 17;
            label1.Text = "-";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.BorderColor = Color.MediumSlateBlue;
            dateTimePickerFrom.BorderSize = 2;
            dateTimePickerFrom.CalendarTrailingForeColor = Color.Gray;
            dateTimePickerFrom.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFrom.Font = new Font("Segoe UI", 9.5F);
            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.Location = new Point(190, 208);
            dateTimePickerFrom.MinimumSize = new Size(0, 35);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(142, 35);
            dateTimePickerFrom.SkinColor = SystemColors.Window;
            dateTimePickerFrom.TabIndex = 18;
            dateTimePickerFrom.TextColor = Color.Black;
            dateTimePickerFrom.ValueChanged += SemesterPickFromDate;
            // 
            // FormCreateSemester
            // 
            AcceptButton = btnAddSemester;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 439);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(label1);
            Controls.Add(dateTimePickerTo);
            Controls.Add(lblScheduleTo);
            Controls.Add(lblFromDate);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddSemester);
            Controls.Add(txtBoxSemesterId);
            Controls.Add(lblSemesterId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCreateSemester";
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
        private Label lblSemesterId;
        private TeacherManager.CustomControls.CustomTextBox txtBoxSemesterId;
        private TeacherManager.CustomControls.CustomButton btnAddSemester;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblHeader;
        private Label lblFromDate;
        private TeacherManager.CustomControls.CustomDateTimePicker dateTimePickerTo;
        private Label lblScheduleTo;
        private Label label1;
        private TeacherManager.CustomControls.CustomDateTimePicker dateTimePickerFrom;
    }
}