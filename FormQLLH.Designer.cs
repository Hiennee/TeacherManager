namespace TeacherManager
{
    partial class FormQLLH
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
            lblHeader = new Label();
            btnAddClass = new CustomControls.CustomButton();
            panelClasses = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(22, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(218, 31);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // btnAddClass
            // 
            btnAddClass.BackColor = Color.MediumSlateBlue;
            btnAddClass.BackgroundColor = Color.MediumSlateBlue;
            btnAddClass.BorderColor = Color.PaleVioletRed;
            btnAddClass.BorderRadius = 10;
            btnAddClass.BorderSize = 0;
            btnAddClass.FlatAppearance.BorderSize = 0;
            btnAddClass.FlatStyle = FlatStyle.Flat;
            btnAddClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddClass.ForeColor = Color.White;
            btnAddClass.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddClass.Location = new Point(1193, 15);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(201, 43);
            btnAddClass.TabIndex = 2;
            btnAddClass.Text = "Thêm lớp học";
            btnAddClass.TextColor = Color.White;
            btnAddClass.UseVisualStyleBackColor = false;
            btnAddClass.Click += ShowAddClassForm;
            // 
            // panelClasses
            // 
            panelClasses.AutoScroll = true;
            panelClasses.Location = new Point(41, 81);
            panelClasses.Name = "panelClasses";
            panelClasses.RightToLeft = RightToLeft.No;
            panelClasses.Size = new Size(1413, 563);
            panelClasses.TabIndex = 0;
            // 
            // FormQLLH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelClasses);
            Controls.Add(btnAddClass);
            Controls.Add(lblHeader);
            Name = "FormQLLH";
            Size = new Size(1492, 791);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private TeacherManager.CustomControls.CustomButton btnAddClass;
        private FlowLayoutPanel panelClasses;
    }
}
