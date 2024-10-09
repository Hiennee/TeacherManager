namespace TeacherManager.Models
{
    partial class ScheduleDisplay
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
            lblClassName = new Label();
            lblSchedule = new Label();
            lblRoom = new Label();
            SuspendLayout();
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblClassName.ForeColor = SystemColors.Highlight;
            lblClassName.Location = new Point(0, 0);
            lblClassName.Margin = new Padding(3, 5, 3, 5);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(126, 28);
            lblClassName.TabIndex = 1;
            lblClassName.Text = "Tên môn 1...";
            // 
            // lblSchedule
            // 
            lblSchedule.AutoSize = true;
            lblSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSchedule.Location = new Point(34, 38);
            lblSchedule.Margin = new Padding(5, 5, 3, 0);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(87, 28);
            lblSchedule.TabIndex = 2;
            lblSchedule.Text = "Từ - Đến";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(316, 38);
            lblRoom.Margin = new Padding(5, 5, 3, 0);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(69, 28);
            lblRoom.TabIndex = 3;
            lblRoom.Text = "Phòng";
            lblRoom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ScheduleDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblRoom);
            Controls.Add(lblSchedule);
            Controls.Add(lblClassName);
            Name = "ScheduleDisplay";
            Size = new Size(430, 72);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClassName;
        private Label lblSchedule;
        private Label lblRoom;
    }
}
