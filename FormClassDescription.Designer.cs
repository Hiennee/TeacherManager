using System.ComponentModel;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dividerControl1 = new CustomControls.DividerControl();
            lblClassName = new Label();
            lblSemesterId = new Label();
            pictureBox2 = new PictureBox();
            dataViewStudents = new DataGridView();
            btnAddStudentIntoClass = new CustomControls.CustomButton();
            excelIcon = new PictureBox();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)dataViewStudents).BeginInit();
            ((ISupportInitialize)excelIcon).BeginInit();
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
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(65, 92);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(92, 31);
            lblClassName.TabIndex = 1;
            lblClassName.Text = "Tên lớp";
            // 
            // lblSemesterId
            // 
            lblSemesterId.AutoSize = true;
            lblSemesterId.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSemesterId.Location = new Point(1401, 92);
            lblSemesterId.Name = "lblSemesterId";
            lblSemesterId.Size = new Size(93, 31);
            lblSemesterId.TabIndex = 2;
            lblSemesterId.Text = "Học kỳ ";
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
            dataViewStudents.Size = new Size(1543, 270);
            dataViewStudents.TabIndex = 13;
            dataViewStudents.CellValueChanged += UpdateStudentGrade;
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
            btnAddStudentIntoClass.Click += AddStudentIntoClass;
            // 
            // excelIcon
            // 
            excelIcon.Image = Properties.Resources.excel_icon;
            excelIcon.Location = new Point(1211, 147);
            excelIcon.Name = "excelIcon";
            excelIcon.Size = new Size(52, 43);
            excelIcon.TabIndex = 15;
            excelIcon.TabStop = false;
            excelIcon.Click += ExportStudentClassesDataToExcel;
            // 
            // FormClassDescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1628, 858);
            Controls.Add(excelIcon);
            Controls.Add(btnAddStudentIntoClass);
            Controls.Add(dataViewStudents);
            Controls.Add(pictureBox2);
            Controls.Add(lblSemesterId);
            Controls.Add(lblClassName);
            Controls.Add(dividerControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClassDescription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClassDescription";
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)dataViewStudents).EndInit();
            ((ISupportInitialize)excelIcon).EndInit();
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
    }
}
