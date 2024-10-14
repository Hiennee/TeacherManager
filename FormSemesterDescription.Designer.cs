using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace TeacherManager
{
    partial class FormSemesterDescription
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
            lblSemester = new Label();
            pictureBox2 = new PictureBox();
            dataViewSemester = new DataGridView();
            excelIcon = new PictureBox();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)dataViewSemester).BeginInit();
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
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemester.Location = new Point(65, 92);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(124, 31);
            lblSemester.TabIndex = 1;
            lblSemester.Text = "Mã học kỳ";
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
            pictureBox2.Click += ExitSemesterDescriptionForm;
            // 
            // dataViewSemester
            // 
            dataViewSemester.AllowUserToAddRows = false;
            dataViewSemester.AllowUserToDeleteRows = false;
            dataViewSemester.AllowUserToResizeColumns = false;
            dataViewSemester.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataViewSemester.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataViewSemester.BackgroundColor = Color.WhiteSmoke;
            dataViewSemester.BorderStyle = BorderStyle.None;
            dataViewSemester.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataViewSemester.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 28, 181);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataViewSemester.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataViewSemester.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataViewSemester.DefaultCellStyle = dataGridViewCellStyle3;
            dataViewSemester.EditMode = DataGridViewEditMode.EditOnEnter;
            dataViewSemester.EnableHeadersVisualStyles = false;
            dataViewSemester.GridColor = Color.WhiteSmoke;
            dataViewSemester.Location = new Point(42, 211);
            dataViewSemester.Name = "dataViewSemester";
            dataViewSemester.ReadOnly = true;
            dataViewSemester.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataViewSemester.RowHeadersVisible = false;
            dataViewSemester.RowHeadersWidth = 51;
            dataViewSemester.RowTemplate.Height = 40;
            dataViewSemester.Size = new Size(1543, 270);
            dataViewSemester.TabIndex = 13;
            // 
            // excelIcon
            // 
            excelIcon.Image = Properties.Resources.excel_icon;
            excelIcon.Location = new Point(1211, 147);
            excelIcon.Name = "excelIcon";
            excelIcon.Size = new Size(52, 43);
            excelIcon.TabIndex = 15;
            excelIcon.TabStop = false;
            excelIcon.Click += ExportSemesterDataToExcel;
            // 
            // FormSemesterDescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1628, 858);
            Controls.Add(excelIcon);
            Controls.Add(dataViewSemester);
            Controls.Add(pictureBox2);
            Controls.Add(lblSemester);
            Controls.Add(dividerControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSemesterDescription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClassDescription";
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)dataViewSemester).EndInit();
            ((ISupportInitialize)excelIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.DividerControl dividerControl1;
        private Label lblSemester;
        private Label lblSemesterId;
        private PictureBox pictureBox2;
        private DataGridView dataViewSemester;
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
