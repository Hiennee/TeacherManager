using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TeacherManager
{
    partial class FormChangeGradeEmailTemplate
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
            pictureBox2 = new PictureBox();
            dividerControl1 = new CustomControls.DividerControl();
            lblHeader = new Label();
            txtBoxBody = new CustomControls.CustomTextBox();
            lblBody = new Label();
            btnChangeTemplate = new CustomControls.CustomButton();
            lblTip = new Label();
            toolTipKeyword = new ToolTip(components);
            lblSetDefault = new LinkLabel();
            ((ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            pictureBox2.Click += ExitChangeGradeEmailTemplateForm;
            // 
            // dividerControl1
            // 
            dividerControl1.DividerColor = Color.Gray;
            dividerControl1.IsVertical = false;
            dividerControl1.Location = new Point(65, 118);
            dividerControl1.Name = "dividerControl1";
            dividerControl1.Size = new Size(827, 2);
            dividerControl1.TabIndex = 13;
            dividerControl1.Thickness = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(65, 84);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(400, 31);
            lblHeader.TabIndex = 14;
            lblHeader.Text = "Thay đổi định dạng e-mail gửi điểm";
            // 
            // txtBoxBody
            // 
            txtBoxBody.BackColor = SystemColors.Window;
            txtBoxBody.BorderColor = Color.MediumSlateBlue;
            txtBoxBody.BorderFocusColor = Color.HotPink;
            txtBoxBody.BorderRadius = 0;
            txtBoxBody.BorderSize = 2;
            txtBoxBody.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxBody.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxBody.Location = new Point(65, 179);
            txtBoxBody.Margin = new Padding(4);
            txtBoxBody.Multiline = true;
            txtBoxBody.Name = "txtBoxBody";
            txtBoxBody.Padding = new Padding(10, 7, 10, 7);
            txtBoxBody.PasswordChar = false;
            txtBoxBody.PlaceholderColor = Color.DarkGray;
            txtBoxBody.PlaceholderText = "";
            txtBoxBody.Size = new Size(827, 472);
            txtBoxBody.TabIndex = 15;
            txtBoxBody.Texts = "";
            txtBoxBody.UnderlinedStyle = false;
            // 
            // lblBody
            // 
            lblBody.AutoSize = true;
            lblBody.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBody.Location = new Point(65, 144);
            lblBody.Name = "lblBody";
            lblBody.Size = new Size(112, 31);
            lblBody.TabIndex = 18;
            lblBody.Text = "Nội dung";
            // 
            // btnChangeTemplate
            // 
            btnChangeTemplate.BackColor = Color.MediumSlateBlue;
            btnChangeTemplate.BackgroundColor = Color.MediumSlateBlue;
            btnChangeTemplate.BorderColor = Color.PaleVioletRed;
            btnChangeTemplate.BorderRadius = 10;
            btnChangeTemplate.BorderSize = 0;
            btnChangeTemplate.Cursor = Cursors.Hand;
            btnChangeTemplate.FlatAppearance.BorderSize = 0;
            btnChangeTemplate.FlatStyle = FlatStyle.Flat;
            btnChangeTemplate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeTemplate.ForeColor = Color.White;
            btnChangeTemplate.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangeTemplate.Location = new Point(406, 672);
            btnChangeTemplate.Name = "btnChangeTemplate";
            btnChangeTemplate.Size = new Size(132, 43);
            btnChangeTemplate.TabIndex = 21;
            btnChangeTemplate.Text = "Lưu";
            btnChangeTemplate.TextColor = Color.White;
            btnChangeTemplate.UseVisualStyleBackColor = false;
            btnChangeTemplate.Click += SaveGradeEmailTemplate;
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTip.Location = new Point(192, 153);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(298, 20);
            lblTip.TabIndex = 22;
            lblTip.Text = "Hỗ trợ định dạng HTML cùng các keyword (?)";
            // 
            // lblSetDefault
            // 
            lblSetDefault.AutoSize = true;
            lblSetDefault.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblSetDefault.Location = new Point(741, 148);
            lblSetDefault.Name = "lblSetDefault";
            lblSetDefault.Size = new Size(151, 25);
            lblSetDefault.TabIndex = 23;
            lblSetDefault.TabStop = true;
            lblSetDefault.Text = "Cài đặt mặc định";
            lblSetDefault.LinkClicked += ChangeTemplateToDefault;
            // 
            // FormChangeGradeEmailTemplate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(979, 762);
            Controls.Add(lblSetDefault);
            Controls.Add(lblTip);
            Controls.Add(btnChangeTemplate);
            Controls.Add(lblBody);
            Controls.Add(txtBoxBody);
            Controls.Add(lblHeader);
            Controls.Add(dividerControl1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChangeGradeEmailTemplate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gửi E-mail";
            ((ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSemesterId;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn avatarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private CustomControls.DividerControl dividerControl1;
        private Label lblHeader;
        private CustomControls.CustomTextBox txtBoxBody;
        private CustomControls.CustomTextBox txtBoxSubject;
        private Label lblSubject;
        private Label lblBody;
        private Label lblTo;
        private CustomControls.CustomTextBox txtBoxTo;
        private CustomControls.CustomButton btnAddStudentIntoClass;
        private CustomControls.CustomButton btnChangeTemplate;
        private Label lblTip;
        private ToolTip toolTipKeyword;
        private LinkLabel lblSetDefault;
    }
}
