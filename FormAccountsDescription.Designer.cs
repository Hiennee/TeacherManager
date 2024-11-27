using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TeacherManager
{
    partial class FormAccountsDescription
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dividerControl1 = new CustomControls.DividerControl();
            lblHeader = new Label();
            pictureBox2 = new PictureBox();
            dataViewAccounts = new DataGridView();
            excelIcon = new PictureBox();
            cbRole = new CustomControls.CustomComboBox();
            mailIcon = new PictureBox();
            lblAccountsNumber = new Label();
            settingsIcon = new PictureBox();
            btnCreateStudent = new CustomControls.CustomButton();
            btnCreateTeacher = new CustomControls.CustomButton();
            txtBoxNameToFind = new CustomControls.CustomTextBox();
            lblFind = new Label();
            ttEmail = new ToolTip(components);
            ttExportExcel = new ToolTip(components);
            ttEdit = new ToolTip(components);
            timerNameTyped = new System.Windows.Forms.Timer(components);
            addUserIcon = new PictureBox();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)dataViewAccounts).BeginInit();
            ((ISupportInitialize)excelIcon).BeginInit();
            ((ISupportInitialize)mailIcon).BeginInit();
            ((ISupportInitialize)settingsIcon).BeginInit();
            ((ISupportInitialize)addUserIcon).BeginInit();
            SuspendLayout();
            // 
            // dividerControl1
            // 
            dividerControl1.DividerColor = Color.Gray;
            dividerControl1.IsVertical = false;
            dividerControl1.Location = new Point(42, 126);
            dividerControl1.Name = "dividerControl1";
            dividerControl1.Size = new Size(1492, 2);
            dividerControl1.TabIndex = 0;
            dividerControl1.Thickness = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(65, 92);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(124, 31);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Danh sách";
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
            pictureBox2.Click += ExitAccountsDescriptionForm;
            // 
            // dataViewAccounts
            // 
            dataViewAccounts.AllowUserToAddRows = false;
            dataViewAccounts.AllowUserToDeleteRows = false;
            dataViewAccounts.AllowUserToResizeColumns = false;
            dataViewAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataViewAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataViewAccounts.BackgroundColor = Color.WhiteSmoke;
            dataViewAccounts.BorderStyle = BorderStyle.None;
            dataViewAccounts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataViewAccounts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(45, 28, 181);
            dataGridViewCellStyle5.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataViewAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataViewAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataViewAccounts.DefaultCellStyle = dataGridViewCellStyle6;
            dataViewAccounts.EditMode = DataGridViewEditMode.EditOnEnter;
            dataViewAccounts.EnableHeadersVisualStyles = false;
            dataViewAccounts.GridColor = Color.WhiteSmoke;
            dataViewAccounts.Location = new Point(42, 211);
            dataViewAccounts.MultiSelect = false;
            dataViewAccounts.Name = "dataViewAccounts";
            dataViewAccounts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataViewAccounts.RowHeadersVisible = false;
            dataViewAccounts.RowHeadersWidth = 51;
            dataViewAccounts.RowTemplate.Height = 40;
            dataViewAccounts.Size = new Size(1492, 602);
            dataViewAccounts.TabIndex = 13;
            dataViewAccounts.CurrentCellDirtyStateChanged += StateChanged;
            // 
            // excelIcon
            // 
            excelIcon.Cursor = Cursors.Hand;
            excelIcon.Image = Properties.Resources.excel_icon;
            excelIcon.Location = new Point(1302, 141);
            excelIcon.Name = "excelIcon";
            excelIcon.Size = new Size(52, 43);
            excelIcon.TabIndex = 15;
            excelIcon.TabStop = false;
            excelIcon.Click += ExportAccountsDataToExcel;
            // 
            // cbRole
            // 
            cbRole.BackColor = Color.White;
            cbRole.BorderColor = Color.MediumSlateBlue;
            cbRole.BorderSize = 2;
            cbRole.DropDownStyle = ComboBoxStyle.DropDown;
            cbRole.Font = new Font("Segoe UI", 10F);
            cbRole.ForeColor = Color.DimGray;
            cbRole.IconColor = Color.MediumSlateBlue;
            cbRole.ListBackColor = Color.FromArgb(230, 228, 245);
            cbRole.ListTextColor = Color.DimGray;
            cbRole.Location = new Point(195, 88);
            cbRole.MinimumSize = new Size(50, 30);
            cbRole.Name = "cbRole";
            cbRole.Padding = new Padding(2);
            cbRole.Size = new Size(160, 35);
            cbRole.TabIndex = 16;
            cbRole.Texts = "";
            cbRole.OnSelectedIndexChanged += ChangeAccountsRoleData;
            // 
            // mailIcon
            // 
            mailIcon.Cursor = Cursors.Hand;
            mailIcon.Image = Properties.Resources.mail_icon;
            mailIcon.Location = new Point(1211, 141);
            mailIcon.Name = "mailIcon";
            mailIcon.Size = new Size(52, 43);
            mailIcon.TabIndex = 18;
            mailIcon.TabStop = false;
            mailIcon.Click += SendEmail;
            // 
            // lblAccountsNumber
            // 
            lblAccountsNumber.AutoSize = true;
            lblAccountsNumber.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAccountsNumber.Location = new Point(42, 827);
            lblAccountsNumber.Name = "lblAccountsNumber";
            lblAccountsNumber.Size = new Size(86, 25);
            lblAccountsNumber.TabIndex = 19;
            lblAccountsNumber.Text = "0 kết quả";
            // 
            // settingsIcon
            // 
            settingsIcon.Cursor = Cursors.Hand;
            settingsIcon.Image = Properties.Resources.settings_icon;
            settingsIcon.Location = new Point(1482, 141);
            settingsIcon.Name = "settingsIcon";
            settingsIcon.Size = new Size(52, 43);
            settingsIcon.SizeMode = PictureBoxSizeMode.Zoom;
            settingsIcon.TabIndex = 21;
            settingsIcon.TabStop = false;
            settingsIcon.Click += AdjustAccount;
            // 
            // btnCreateStudent
            // 
            btnCreateStudent.BackColor = Color.MediumSlateBlue;
            btnCreateStudent.BackgroundColor = Color.MediumSlateBlue;
            btnCreateStudent.BorderColor = Color.PaleVioletRed;
            btnCreateStudent.BorderRadius = 10;
            btnCreateStudent.BorderSize = 0;
            btnCreateStudent.FlatAppearance.BorderSize = 0;
            btnCreateStudent.FlatStyle = FlatStyle.Flat;
            btnCreateStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateStudent.ForeColor = Color.White;
            btnCreateStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateStudent.Location = new Point(1333, 77);
            btnCreateStudent.Name = "btnCreateStudent";
            btnCreateStudent.Size = new Size(201, 43);
            btnCreateStudent.TabIndex = 23;
            btnCreateStudent.Text = "Thêm sinh viên";
            btnCreateStudent.TextColor = Color.White;
            btnCreateStudent.UseVisualStyleBackColor = false;
            btnCreateStudent.Click += CreateStudent;
            // 
            // btnCreateTeacher
            // 
            btnCreateTeacher.BackColor = Color.MediumSlateBlue;
            btnCreateTeacher.BackgroundColor = Color.MediumSlateBlue;
            btnCreateTeacher.BorderColor = Color.PaleVioletRed;
            btnCreateTeacher.BorderRadius = 10;
            btnCreateTeacher.BorderSize = 0;
            btnCreateTeacher.FlatAppearance.BorderSize = 0;
            btnCreateTeacher.FlatStyle = FlatStyle.Flat;
            btnCreateTeacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateTeacher.ForeColor = Color.White;
            btnCreateTeacher.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateTeacher.Location = new Point(1062, 77);
            btnCreateTeacher.Name = "btnCreateTeacher";
            btnCreateTeacher.Size = new Size(201, 43);
            btnCreateTeacher.TabIndex = 22;
            btnCreateTeacher.Text = "Thêm giảng viên";
            btnCreateTeacher.TextColor = Color.White;
            btnCreateTeacher.UseVisualStyleBackColor = false;
            btnCreateTeacher.Click += CreateTeacher;
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
            txtBoxNameToFind.Location = new Point(195, 165);
            txtBoxNameToFind.Margin = new Padding(4);
            txtBoxNameToFind.Multiline = false;
            txtBoxNameToFind.Name = "txtBoxNameToFind";
            txtBoxNameToFind.Padding = new Padding(10, 7, 10, 7);
            txtBoxNameToFind.PasswordChar = false;
            txtBoxNameToFind.PlaceholderColor = Color.DarkGray;
            txtBoxNameToFind.PlaceholderText = "";
            txtBoxNameToFind.Size = new Size(312, 35);
            txtBoxNameToFind.TabIndex = 24;
            txtBoxNameToFind.Texts = "";
            txtBoxNameToFind.UnderlinedStyle = false;
            txtBoxNameToFind._TextChanged += CheckTimerTyping;
            // 
            // lblFind
            // 
            lblFind.AutoSize = true;
            lblFind.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFind.Location = new Point(65, 169);
            lblFind.Name = "lblFind";
            lblFind.Size = new Size(109, 31);
            lblFind.TabIndex = 25;
            lblFind.Text = "Tìm kiếm";
            // 
            // timerNameTyped
            // 
            timerNameTyped.Tick += TypingTimer_Tick;
            // 
            // addUserIcon
            // 
            addUserIcon.Cursor = Cursors.Hand;
            addUserIcon.Image = Properties.Resources.add_user_icon;
            addUserIcon.Location = new Point(1394, 141);
            addUserIcon.Name = "addUserIcon";
            addUserIcon.Size = new Size(52, 43);
            addUserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            addUserIcon.TabIndex = 26;
            addUserIcon.TabStop = false;
            addUserIcon.Click += AddStudentsFromExcel;
            // 
            // FormAccountsDescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1628, 884);
            Controls.Add(addUserIcon);
            Controls.Add(lblFind);
            Controls.Add(txtBoxNameToFind);
            Controls.Add(btnCreateStudent);
            Controls.Add(btnCreateTeacher);
            Controls.Add(settingsIcon);
            Controls.Add(lblAccountsNumber);
            Controls.Add(mailIcon);
            Controls.Add(cbRole);
            Controls.Add(excelIcon);
            Controls.Add(dataViewAccounts);
            Controls.Add(pictureBox2);
            Controls.Add(lblHeader);
            Controls.Add(dividerControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAccountsDescription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách tài khoản";
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)dataViewAccounts).EndInit();
            ((ISupportInitialize)excelIcon).EndInit();
            ((ISupportInitialize)mailIcon).EndInit();
            ((ISupportInitialize)settingsIcon).EndInit();
            ((ISupportInitialize)addUserIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.DividerControl dividerControl1;
        private Label lblHeader;
        private Label lblSemesterId;
        private PictureBox pictureBox2;
        private DataGridView dataViewAccounts;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn avatarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private PictureBox excelIcon;
        private CustomControls.CustomComboBox cbRole;
        private PictureBox mailIcon;
        private Label lblAccountsNumber;
        private PictureBox settingsIcon;
        private CustomControls.CustomButton btnCreateStudent;
        private CustomControls.CustomButton btnCreateTeacher;
        private CustomControls.CustomTextBox txtBoxNameToFind;
        private Label lblFind;
        private ToolTip ttEmail;
        private ToolTip ttExportExcel;
        private ToolTip ttEdit;
        private System.Windows.Forms.Timer timerNameTyped;
        private Label label1;
        private PictureBox addUserIcon;
    }
}
