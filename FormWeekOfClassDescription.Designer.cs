using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace TeacherManager
{
    partial class FormWeekOfClassDescription
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
            arrowBack = new PictureBox();
            dataViewWeek = new DataGridView();
            excelIcon = new PictureBox();
            lblWeekNo = new Label();
            ((ISupportInitialize)arrowBack).BeginInit();
            ((ISupportInitialize)dataViewWeek).BeginInit();
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
            // arrowBack
            // 
            arrowBack.Cursor = Cursors.Hand;
            arrowBack.Image = Properties.Resources.back_icon;
            arrowBack.Location = new Point(29, 23);
            arrowBack.Name = "arrowBack";
            arrowBack.Size = new Size(73, 44);
            arrowBack.SizeMode = PictureBoxSizeMode.Zoom;
            arrowBack.TabIndex = 12;
            arrowBack.TabStop = false;
            arrowBack.Click += ExitSemesterDescriptionForm;
            // 
            // dataViewWeek
            // 
            dataViewWeek.AllowUserToAddRows = false;
            dataViewWeek.AllowUserToDeleteRows = false;
            dataViewWeek.AllowUserToResizeColumns = false;
            dataViewWeek.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataViewWeek.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataViewWeek.BackgroundColor = Color.WhiteSmoke;
            dataViewWeek.BorderStyle = BorderStyle.None;
            dataViewWeek.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataViewWeek.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 28, 181);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataViewWeek.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataViewWeek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataViewWeek.DefaultCellStyle = dataGridViewCellStyle3;
            dataViewWeek.EditMode = DataGridViewEditMode.EditOnEnter;
            dataViewWeek.EnableHeadersVisualStyles = false;
            dataViewWeek.GridColor = Color.WhiteSmoke;
            dataViewWeek.Location = new Point(42, 211);
            dataViewWeek.Name = "dataViewWeek";
            dataViewWeek.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataViewWeek.RowHeadersVisible = false;
            dataViewWeek.RowHeadersWidth = 51;
            dataViewWeek.RowTemplate.Height = 40;
            dataViewWeek.Size = new Size(1492, 270);
            dataViewWeek.TabIndex = 13;
            dataViewWeek.CellContentClick += CheckInForStudent;
            // 
            // excelIcon
            // 
            excelIcon.Cursor = Cursors.Hand;
            excelIcon.Image = Properties.Resources.excel_icon;
            excelIcon.Location = new Point(1482, 147);
            excelIcon.Name = "excelIcon";
            excelIcon.Size = new Size(52, 43);
            excelIcon.TabIndex = 15;
            excelIcon.TabStop = false;
            excelIcon.Click += ExportSemesterDataToExcel;
            // 
            // lblWeekNo
            // 
            lblWeekNo.AutoSize = true;
            lblWeekNo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeekNo.Location = new Point(65, 147);
            lblWeekNo.Name = "lblWeekNo";
            lblWeekNo.Size = new Size(281, 31);
            lblWeekNo.TabIndex = 16;
            lblWeekNo.Text = "Danh sách sinh viên tuần";
            // 
            // FormWeekOfClassDescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1628, 858);
            Controls.Add(lblWeekNo);
            Controls.Add(excelIcon);
            Controls.Add(dataViewWeek);
            Controls.Add(arrowBack);
            Controls.Add(lblClassName);
            Controls.Add(dividerControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormWeekOfClassDescription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách tuần";
            ((ISupportInitialize)arrowBack).EndInit();
            ((ISupportInitialize)dataViewWeek).EndInit();
            ((ISupportInitialize)excelIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.DividerControl dividerControl1;
        private Label lblClassName;
        private Label lblSemesterId;
        private PictureBox arrowBack;
        private DataGridView dataViewWeek;
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
        private Label lblWeekNo;
    }
}
