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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dividerControl1 = new CustomControls.DividerControl();
            lblHeader = new Label();
            pictureBox2 = new PictureBox();
            dataViewAccounts = new DataGridView();
            btnAddStudentIntoClass = new CustomControls.CustomButton();
            excelIcon = new PictureBox();
            cbRole = new CustomControls.CustomComboBox();
            mailIcon = new PictureBox();
            lblAccountsNumber = new Label();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)dataViewAccounts).BeginInit();
            ((ISupportInitialize)excelIcon).BeginInit();
            ((ISupportInitialize)mailIcon).BeginInit();
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
            pictureBox2.Image = Properties.Resources.back_icon;
            pictureBox2.Location = new Point(29, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += ExitClassDescriptionForm;
            // 
            // dataViewAccounts
            // 
            dataViewAccounts.AllowUserToAddRows = false;
            dataViewAccounts.AllowUserToDeleteRows = false;
            dataViewAccounts.AllowUserToResizeColumns = false;
            dataViewAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataViewAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataViewAccounts.BackgroundColor = Color.WhiteSmoke;
            dataViewAccounts.BorderStyle = BorderStyle.None;
            dataViewAccounts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataViewAccounts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 28, 181);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataViewAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataViewAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataViewAccounts.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataViewAccounts.Size = new Size(1543, 616);
            dataViewAccounts.TabIndex = 13;
            dataViewAccounts.CurrentCellDirtyStateChanged += StateChanged;
            // 
            // btnAddStudentIntoClass
            // 
            btnAddStudentIntoClass.BackColor = Color.MediumSlateBlue;
            btnAddStudentIntoClass.BackgroundColor = Color.MediumSlateBlue;
            btnAddStudentIntoClass.BorderColor = Color.PaleVioletRed;
            btnAddStudentIntoClass.BorderRadius = 10;
            btnAddStudentIntoClass.BorderSize = 0;
            btnAddStudentIntoClass.FlatAppearance.BorderSize = 0;
            btnAddStudentIntoClass.FlatStyle = FlatStyle.Flat;
            btnAddStudentIntoClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudentIntoClass.ForeColor = Color.White;
            btnAddStudentIntoClass.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddStudentIntoClass.Location = new Point(1287, 147);
            btnAddStudentIntoClass.Name = "btnAddStudentIntoClass";
            btnAddStudentIntoClass.Size = new Size(247, 43);
            btnAddStudentIntoClass.TabIndex = 14;
            btnAddStudentIntoClass.Text = "Thêm học sinh vào lớp";
            btnAddStudentIntoClass.TextColor = Color.White;
            btnAddStudentIntoClass.UseVisualStyleBackColor = false;
            // 
            // excelIcon
            // 
            excelIcon.Image = Properties.Resources.excel_icon;
            excelIcon.Location = new Point(1211, 147);
            excelIcon.Name = "excelIcon";
            excelIcon.Size = new Size(52, 43);
            excelIcon.TabIndex = 15;
            excelIcon.TabStop = false;
            excelIcon.Click += ExportAccountsDataToExcel;
            // 
            // cbRole
            // 
            cbRole.BackColor = Color.WhiteSmoke;
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
            mailIcon.Image = Properties.Resources.mail_icon;
            mailIcon.Location = new Point(1120, 147);
            mailIcon.Name = "mailIcon";
            mailIcon.Size = new Size(52, 43);
            mailIcon.TabIndex = 18;
            mailIcon.TabStop = false;
            mailIcon.Click += AccountChecked;
            // 
            // lblAccountsNumber
            // 
            lblAccountsNumber.AutoSize = true;
            lblAccountsNumber.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAccountsNumber.Location = new Point(42, 159);
            lblAccountsNumber.Name = "lblAccountsNumber";
            lblAccountsNumber.Size = new Size(86, 25);
            lblAccountsNumber.TabIndex = 19;
            lblAccountsNumber.Text = "0 kết quả";
            // 
            // FormAccountsDescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1628, 858);
            Controls.Add(lblAccountsNumber);
            Controls.Add(mailIcon);
            Controls.Add(cbRole);
            Controls.Add(excelIcon);
            Controls.Add(btnAddStudentIntoClass);
            Controls.Add(dataViewAccounts);
            Controls.Add(pictureBox2);
            Controls.Add(lblHeader);
            Controls.Add(dividerControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAccountsDescription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClassDescription";
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)dataViewAccounts).EndInit();
            ((ISupportInitialize)excelIcon).EndInit();
            ((ISupportInitialize)mailIcon).EndInit();
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
        private CustomControls.CustomButton btnAddStudentIntoClass;
        private PictureBox excelIcon;
        private CustomControls.CustomComboBox cbRole;
        private PictureBox mailIcon;
        private Label lblAccountsNumber;
    }
}
