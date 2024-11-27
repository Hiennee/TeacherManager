namespace TeacherManager
{
    partial class Index
    {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureSchool = new PictureBox();
            lblHeader = new Label();
            lblHeader1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureSchool).BeginInit();
            SuspendLayout();
            // 
            // pictureSchool
            // 
            pictureSchool.Image = Properties.Resources.school;
            pictureSchool.InitialImage = Properties.Resources.school;
            pictureSchool.Location = new Point(177, 257);
            pictureSchool.Name = "pictureSchool";
            pictureSchool.Size = new Size(1077, 583);
            pictureSchool.SizeMode = PictureBoxSizeMode.Zoom;
            pictureSchool.TabIndex = 0;
            pictureSchool.TabStop = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(203, 143);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1100, 50);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Chào mừng quý giảng viên đến với ứng dụng quản lý lớp học!";
            // 
            // lblHeader1
            // 
            lblHeader1.AutoSize = true;
            lblHeader1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader1.Location = new Point(327, 205);
            lblHeader1.Name = "lblHeader1";
            lblHeader1.Size = new Size(737, 38);
            lblHeader1.TabIndex = 2;
            lblHeader1.Text = "Nếu gặp bất cứ vấn đề gì vui lòng liên hệ với phòng CNTT";
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblHeader1);
            Controls.Add(lblHeader);
            Controls.Add(pictureSchool);
            Name = "Index";
            Size = new Size(1572, 899);
            ((System.ComponentModel.ISupportInitialize)pictureSchool).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureSchool;
        private Label lblHeader;
        private Label lblHeader1;
    }
}
