﻿using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace TeacherManager
{
    partial class FormClassDescription
    {
        private int borderWidth = 5;  // Width of the custom border
        private Color borderColor = Color.MediumSlateBlue;  // Border color

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the custom border
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid);
        }
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
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dividerControl1 = new CustomControls.DividerControl();
            lblClassName = new Label();
            lblSemesterId = new Label();
            pictureBox2 = new PictureBox();
            dataViewStudents = new DataGridView();
            btnAddStudentIntoClass = new CustomControls.CustomButton();
            excelIcon = new PictureBox();
            mailIcon = new PictureBox();
            lblStudNo = new Label();
            mailGradeIcon = new PictureBox();
            lblSwitchView = new LinkLabel();
            panelButtons = new Panel();
            dataViewWeeks = new DataGridView();
            lblStudentNumbers = new Label();
            panelStudentNo = new Panel();
            ttSendGrade = new ToolTip(components);
            ttSendEmail = new ToolTip(components);
            ttExportExcel = new ToolTip(components);
            lblFind = new Label();
            txtBoxNameToFind = new CustomControls.CustomTextBox();
            panelFindName = new Panel();
            timerNameTyped = new System.Windows.Forms.Timer(components);
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)dataViewStudents).BeginInit();
            ((ISupportInitialize)excelIcon).BeginInit();
            ((ISupportInitialize)mailIcon).BeginInit();
            ((ISupportInitialize)mailGradeIcon).BeginInit();
            panelButtons.SuspendLayout();
            ((ISupportInitialize)dataViewWeeks).BeginInit();
            panelStudentNo.SuspendLayout();
            panelFindName.SuspendLayout();
            SuspendLayout();
            // 
            // dividerControl1
            // 
            dividerControl1.DividerColor = Color.Gray;
            dividerControl1.IsVertical = false;
            dividerControl1.Location = new Point(42, 110);
            dividerControl1.Name = "dividerControl1";
            dividerControl1.Size = new Size(1739, 2);
            dividerControl1.TabIndex = 0;
            dividerControl1.Thickness = 2;
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(81, 76);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(92, 31);
            lblClassName.TabIndex = 1;
            lblClassName.Text = "Tên lớp";
            // 
            // lblSemesterId
            // 
            lblSemesterId.AutoSize = true;
            lblSemesterId.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSemesterId.Location = new Point(1598, 76);
            lblSemesterId.Name = "lblSemesterId";
            lblSemesterId.Size = new Size(93, 31);
            lblSemesterId.TabIndex = 2;
            lblSemesterId.Text = "Học kỳ ";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.back_icon;
            pictureBox2.Location = new Point(29, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += ExitClassDescriptionForm;
            // 
            // dataViewStudents
            // 
            dataViewStudents.AllowUserToAddRows = false;
            dataViewStudents.AllowUserToDeleteRows = false;
            dataViewStudents.AllowUserToResizeColumns = false;
            dataViewStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataViewStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataViewStudents.BackgroundColor = Color.WhiteSmoke;
            dataViewStudents.BorderStyle = BorderStyle.None;
            dataViewStudents.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataViewStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 28, 181);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataViewStudents.DefaultCellStyle = dataGridViewCellStyle3;
            dataViewStudents.EditMode = DataGridViewEditMode.EditOnEnter;
            dataViewStudents.EnableHeadersVisualStyles = false;
            dataViewStudents.GridColor = Color.WhiteSmoke;
            dataViewStudents.Location = new Point(42, 211);
            dataViewStudents.Name = "dataViewStudents";
            dataViewStudents.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataViewStudents.RowHeadersVisible = false;
            dataViewStudents.RowHeadersWidth = 51;
            dataViewStudents.RowTemplate.Height = 40;
            dataViewStudents.Size = new Size(1749, 635);
            dataViewStudents.TabIndex = 13;
            dataViewStudents.CellValueChanged += UpdateStudentGrade;
            dataViewStudents.CurrentCellDirtyStateChanged += StateChanged;
            // 
            // btnAddStudentIntoClass
            // 
            btnAddStudentIntoClass.BackColor = Color.MediumSlateBlue;
            btnAddStudentIntoClass.BackgroundColor = Color.MediumSlateBlue;
            btnAddStudentIntoClass.BorderColor = Color.PaleVioletRed;
            btnAddStudentIntoClass.BorderRadius = 10;
            btnAddStudentIntoClass.BorderSize = 0;
            btnAddStudentIntoClass.Cursor = Cursors.Hand;
            btnAddStudentIntoClass.FlatAppearance.BorderSize = 0;
            btnAddStudentIntoClass.FlatStyle = FlatStyle.Flat;
            btnAddStudentIntoClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudentIntoClass.ForeColor = Color.White;
            btnAddStudentIntoClass.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddStudentIntoClass.Location = new Point(443, 12);
            btnAddStudentIntoClass.Name = "btnAddStudentIntoClass";
            btnAddStudentIntoClass.Size = new Size(247, 43);
            btnAddStudentIntoClass.TabIndex = 14;
            btnAddStudentIntoClass.Text = "Thêm sinh viên vào lớp";
            btnAddStudentIntoClass.TextColor = Color.White;
            btnAddStudentIntoClass.UseVisualStyleBackColor = false;
            btnAddStudentIntoClass.Click += AddStudentIntoClass;
            // 
            // excelIcon
            // 
            excelIcon.Cursor = Cursors.Hand;
            excelIcon.Image = Properties.Resources.excel_icon;
            excelIcon.Location = new Point(352, 12);
            excelIcon.Name = "excelIcon";
            excelIcon.Size = new Size(52, 43);
            excelIcon.TabIndex = 15;
            excelIcon.TabStop = false;
            excelIcon.Click += ExportStudentClassesDataToExcel;
            // 
            // mailIcon
            // 
            mailIcon.Cursor = Cursors.Hand;
            mailIcon.Image = Properties.Resources.mail_icon;
            mailIcon.Location = new Point(260, 12);
            mailIcon.Name = "mailIcon";
            mailIcon.Size = new Size(52, 43);
            mailIcon.TabIndex = 19;
            mailIcon.TabStop = false;
            mailIcon.Click += SendEmail;
            // 
            // lblStudNo
            // 
            lblStudNo.AutoSize = true;
            lblStudNo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudNo.Location = new Point(15, 12);
            lblStudNo.Name = "lblStudNo";
            lblStudNo.Size = new Size(70, 31);
            lblStudNo.TabIndex = 20;
            lblStudNo.Text = "Sĩ số:";
            // 
            // mailGradeIcon
            // 
            mailGradeIcon.Cursor = Cursors.Hand;
            mailGradeIcon.Image = Properties.Resources.mail_2_icon;
            mailGradeIcon.Location = new Point(129, -5);
            mailGradeIcon.Name = "mailGradeIcon";
            mailGradeIcon.Size = new Size(89, 75);
            mailGradeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            mailGradeIcon.TabIndex = 21;
            mailGradeIcon.TabStop = false;
            mailGradeIcon.Click += SendGradeEmail;
            // 
            // lblSwitchView
            // 
            lblSwitchView.AutoSize = true;
            lblSwitchView.Cursor = Cursors.Hand;
            lblSwitchView.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSwitchView.Location = new Point(42, 118);
            lblSwitchView.Name = "lblSwitchView";
            lblSwitchView.Size = new Size(202, 23);
            lblSwitchView.TabIndex = 22;
            lblSwitchView.TabStop = true;
            lblSwitchView.Text = "Chuyển sang biểu đồ tuần";
            lblSwitchView.LinkClicked += SwitchBetweenGradeOrWeekView;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnAddStudentIntoClass);
            panelButtons.Controls.Add(excelIcon);
            panelButtons.Controls.Add(mailGradeIcon);
            panelButtons.Controls.Add(mailIcon);
            panelButtons.Location = new Point(1063, 118);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(718, 73);
            panelButtons.TabIndex = 23;
            // 
            // dataViewWeeks
            // 
            dataViewWeeks.AllowUserToAddRows = false;
            dataViewWeeks.AllowUserToDeleteRows = false;
            dataViewWeeks.AllowUserToResizeColumns = false;
            dataViewWeeks.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataViewWeeks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataViewWeeks.BackgroundColor = Color.WhiteSmoke;
            dataViewWeeks.BorderStyle = BorderStyle.None;
            dataViewWeeks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataViewWeeks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(45, 28, 181);
            dataGridViewCellStyle5.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataViewWeeks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataViewWeeks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataViewWeeks.DefaultCellStyle = dataGridViewCellStyle6;
            dataViewWeeks.EditMode = DataGridViewEditMode.EditOnEnter;
            dataViewWeeks.EnableHeadersVisualStyles = false;
            dataViewWeeks.GridColor = Color.WhiteSmoke;
            dataViewWeeks.Location = new Point(42, 211);
            dataViewWeeks.Name = "dataViewWeeks";
            dataViewWeeks.ReadOnly = true;
            dataViewWeeks.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataViewWeeks.RowHeadersVisible = false;
            dataViewWeeks.RowHeadersWidth = 51;
            dataViewWeeks.RowTemplate.Height = 40;
            dataViewWeeks.Size = new Size(1623, 659);
            dataViewWeeks.TabIndex = 24;
            dataViewWeeks.CellClick += HandleGridViewButtons;
            // 
            // lblStudentNumbers
            // 
            lblStudentNumbers.AutoSize = true;
            lblStudentNumbers.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentNumbers.Location = new Point(91, 12);
            lblStudentNumbers.Name = "lblStudentNumbers";
            lblStudentNumbers.Size = new Size(27, 31);
            lblStudentNumbers.TabIndex = 25;
            lblStudentNumbers.Text = "0";
            // 
            // panelStudentNo
            // 
            panelStudentNo.Controls.Add(lblStudNo);
            panelStudentNo.Controls.Add(lblStudentNumbers);
            panelStudentNo.Location = new Point(42, 861);
            panelStudentNo.Name = "panelStudentNo";
            panelStudentNo.Size = new Size(250, 47);
            panelStudentNo.TabIndex = 26;
            // 
            // lblFind
            // 
            lblFind.AutoSize = true;
            lblFind.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFind.Location = new Point(3, 13);
            lblFind.Name = "lblFind";
            lblFind.Size = new Size(151, 31);
            lblFind.TabIndex = 28;
            lblFind.Text = "Tìm theo tên";
            // 
            // txtBoxNameToFind
            // 
            txtBoxNameToFind.BackColor = SystemColors.Window;
            txtBoxNameToFind.BorderColor = Color.MediumSlateBlue;
            txtBoxNameToFind.BorderFocusColor = Color.HotPink;
            txtBoxNameToFind.BorderRadius = 0;
            txtBoxNameToFind.BorderSize = 2;
            txtBoxNameToFind.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNameToFind.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxNameToFind.Location = new Point(161, 9);
            txtBoxNameToFind.Margin = new Padding(4);
            txtBoxNameToFind.Multiline = false;
            txtBoxNameToFind.Name = "txtBoxNameToFind";
            txtBoxNameToFind.Padding = new Padding(10, 7, 10, 7);
            txtBoxNameToFind.PasswordChar = false;
            txtBoxNameToFind.PlaceholderColor = Color.DarkGray;
            txtBoxNameToFind.PlaceholderText = "";
            txtBoxNameToFind.Size = new Size(312, 35);
            txtBoxNameToFind.TabIndex = 27;
            txtBoxNameToFind.Texts = "";
            txtBoxNameToFind.UnderlinedStyle = false;
            txtBoxNameToFind._TextChanged += CheckTimerTyping;
            // 
            // panelFindName
            // 
            panelFindName.Controls.Add(lblFind);
            panelFindName.Controls.Add(txtBoxNameToFind);
            panelFindName.Location = new Point(42, 144);
            panelFindName.Name = "panelFindName";
            panelFindName.Size = new Size(513, 61);
            panelFindName.TabIndex = 29;
            // 
            // timerNameTyped
            // 
            timerNameTyped.Tick += TypingTimer_Tick;
            // 
            // FormClassDescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1853, 939);
            Controls.Add(panelFindName);
            Controls.Add(panelStudentNo);
            Controls.Add(dataViewWeeks);
            Controls.Add(panelButtons);
            Controls.Add(lblSwitchView);
            Controls.Add(dataViewStudents);
            Controls.Add(pictureBox2);
            Controls.Add(lblSemesterId);
            Controls.Add(lblClassName);
            Controls.Add(dividerControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClassDescription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách lớp";
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)dataViewStudents).EndInit();
            ((ISupportInitialize)excelIcon).EndInit();
            ((ISupportInitialize)mailIcon).EndInit();
            ((ISupportInitialize)mailGradeIcon).EndInit();
            panelButtons.ResumeLayout(false);
            ((ISupportInitialize)dataViewWeeks).EndInit();
            panelStudentNo.ResumeLayout(false);
            panelStudentNo.PerformLayout();
            panelFindName.ResumeLayout(false);
            panelFindName.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.DividerControl dividerControl1;
        private Label lblClassName;
        private Label lblSemesterId;
        private PictureBox pictureBox2;
        private DataGridView dataViewStudents;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn avatarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private CustomControls.CustomButton btnAddStudentIntoClass;
        private PictureBox excelIcon;
        private PictureBox mailIcon;
        private Label lblStudNo;
        private PictureBox mailGradeIcon;
        private LinkLabel lblSwitchView;
        private Panel panelButtons;
        private DataGridView dataViewWeeks;
        private Label lblStudentNumbers;
        private Panel panelStudentNo;
        private ToolTip ttSendGrade;
        private ToolTip ttSendEmail;
        private ToolTip ttExportExcel;
        private Label lblFind;
        private CustomControls.CustomTextBox txtBoxNameToFind;
        private Panel panelFindName;
        private System.Windows.Forms.Timer timerNameTyped;
    }
}
