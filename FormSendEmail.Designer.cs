using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TeacherManager
{
    partial class FormSendEmail
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
            pictureBox2 = new PictureBox();
            dividerControl1 = new CustomControls.DividerControl();
            lblHeader = new Label();
            txtBoxBody = new CustomControls.CustomTextBox();
            txtBoxSubject = new CustomControls.CustomTextBox();
            lblSubject = new Label();
            lblBody = new Label();
            lblTo = new Label();
            txtBoxTo = new CustomControls.CustomTextBox();
            btnSendEmail = new CustomControls.CustomButton();
            ((ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            lblHeader.Size = new Size(117, 31);
            lblHeader.TabIndex = 14;
            lblHeader.Text = "Gửi Email";
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
            txtBoxBody.Location = new Point(65, 351);
            txtBoxBody.Margin = new Padding(4);
            txtBoxBody.Multiline = true;
            txtBoxBody.Name = "txtBoxBody";
            txtBoxBody.Padding = new Padding(10, 7, 10, 7);
            txtBoxBody.PasswordChar = false;
            txtBoxBody.PlaceholderColor = Color.DarkGray;
            txtBoxBody.PlaceholderText = "";
            txtBoxBody.Size = new Size(827, 272);
            txtBoxBody.TabIndex = 15;
            txtBoxBody.Texts = "";
            txtBoxBody.UnderlinedStyle = false;
            // 
            // txtBoxSubject
            // 
            txtBoxSubject.BackColor = SystemColors.Window;
            txtBoxSubject.BorderColor = Color.MediumSlateBlue;
            txtBoxSubject.BorderFocusColor = Color.HotPink;
            txtBoxSubject.BorderRadius = 0;
            txtBoxSubject.BorderSize = 2;
            txtBoxSubject.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSubject.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxSubject.Location = new Point(65, 260);
            txtBoxSubject.Margin = new Padding(4);
            txtBoxSubject.Multiline = false;
            txtBoxSubject.Name = "txtBoxSubject";
            txtBoxSubject.Padding = new Padding(10, 7, 10, 7);
            txtBoxSubject.PasswordChar = false;
            txtBoxSubject.PlaceholderColor = Color.DarkGray;
            txtBoxSubject.PlaceholderText = "";
            txtBoxSubject.Size = new Size(827, 35);
            txtBoxSubject.TabIndex = 16;
            txtBoxSubject.Texts = "";
            txtBoxSubject.UnderlinedStyle = false;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(65, 225);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(90, 31);
            lblSubject.TabIndex = 17;
            lblSubject.Text = "Tiêu đề";
            // 
            // lblBody
            // 
            lblBody.AutoSize = true;
            lblBody.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBody.Location = new Point(65, 316);
            lblBody.Name = "lblBody";
            lblBody.Size = new Size(112, 31);
            lblBody.TabIndex = 18;
            lblBody.Text = "Nội dung";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTo.Location = new Point(65, 136);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(56, 31);
            lblTo.TabIndex = 19;
            lblTo.Text = "Đến";
            // 
            // txtBoxTo
            // 
            txtBoxTo.BackColor = SystemColors.Window;
            txtBoxTo.BorderColor = Color.MediumSlateBlue;
            txtBoxTo.BorderFocusColor = Color.HotPink;
            txtBoxTo.BorderRadius = 0;
            txtBoxTo.BorderSize = 2;
            txtBoxTo.Enabled = false;
            txtBoxTo.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTo.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxTo.Location = new Point(65, 171);
            txtBoxTo.Margin = new Padding(4);
            txtBoxTo.Multiline = false;
            txtBoxTo.Name = "txtBoxTo";
            txtBoxTo.Padding = new Padding(10, 7, 10, 7);
            txtBoxTo.PasswordChar = false;
            txtBoxTo.PlaceholderColor = Color.DarkGray;
            txtBoxTo.PlaceholderText = "";
            txtBoxTo.Size = new Size(827, 35);
            txtBoxTo.TabIndex = 20;
            txtBoxTo.Texts = "";
            txtBoxTo.UnderlinedStyle = false;
            // 
            // btnSendEmail
            // 
            btnSendEmail.BackColor = Color.MediumSlateBlue;
            btnSendEmail.BackgroundColor = Color.MediumSlateBlue;
            btnSendEmail.BorderColor = Color.PaleVioletRed;
            btnSendEmail.BorderRadius = 10;
            btnSendEmail.BorderSize = 0;
            btnSendEmail.FlatAppearance.BorderSize = 0;
            btnSendEmail.FlatStyle = FlatStyle.Flat;
            btnSendEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendEmail.ForeColor = Color.White;
            btnSendEmail.ImageAlign = ContentAlignment.MiddleLeft;
            btnSendEmail.Location = new Point(406, 672);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new Size(132, 43);
            btnSendEmail.TabIndex = 21;
            btnSendEmail.Text = "Gửi";
            btnSendEmail.TextColor = Color.White;
            btnSendEmail.UseVisualStyleBackColor = false;
            // 
            // FormSendEmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(979, 762);
            Controls.Add(btnSendEmail);
            Controls.Add(txtBoxTo);
            Controls.Add(lblTo);
            Controls.Add(lblBody);
            Controls.Add(lblSubject);
            Controls.Add(txtBoxSubject);
            Controls.Add(txtBoxBody);
            Controls.Add(lblHeader);
            Controls.Add(dividerControl1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSendEmail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClassDescription";
            Click += SendEmail;
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
        private CustomControls.CustomButton btnSendEmail;
    }
}
