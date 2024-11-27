namespace TeacherManager
{
    partial class FormTestingGround
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
            label1 = new Label();
            label2 = new Label();
            txtBoxName = new CustomControls.CustomTextBox();
            txtBoxResult = new CustomControls.CustomTextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Testing ground";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 148);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 1;
            label2.Text = "Tìm sinh viên theo tên";
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = SystemColors.Window;
            txtBoxName.BorderColor = Color.MediumSlateBlue;
            txtBoxName.BorderFocusColor = Color.HotPink;
            txtBoxName.BorderRadius = 0;
            txtBoxName.BorderSize = 2;
            txtBoxName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxName.Location = new Point(300, 172);
            txtBoxName.Margin = new Padding(4);
            txtBoxName.Multiline = false;
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Padding = new Padding(10, 7, 10, 7);
            txtBoxName.PasswordChar = false;
            txtBoxName.PlaceholderColor = Color.DarkGray;
            txtBoxName.PlaceholderText = "";
            txtBoxName.Size = new Size(488, 35);
            txtBoxName.TabIndex = 2;
            txtBoxName.Texts = "";
            txtBoxName.UnderlinedStyle = false;
            txtBoxName._TextChanged += OnFindStudent;
            // 
            // txtBoxResult
            // 
            txtBoxResult.BackColor = SystemColors.Window;
            txtBoxResult.BorderColor = Color.MediumSlateBlue;
            txtBoxResult.BorderFocusColor = Color.HotPink;
            txtBoxResult.BorderRadius = 0;
            txtBoxResult.BorderSize = 2;
            txtBoxResult.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxResult.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxResult.Location = new Point(300, 274);
            txtBoxResult.Margin = new Padding(4);
            txtBoxResult.Multiline = true;
            txtBoxResult.Name = "txtBoxResult";
            txtBoxResult.Padding = new Padding(10, 7, 10, 7);
            txtBoxResult.PasswordChar = false;
            txtBoxResult.PlaceholderColor = Color.DarkGray;
            txtBoxResult.PlaceholderText = "";
            txtBoxResult.Size = new Size(488, 163);
            txtBoxResult.TabIndex = 3;
            txtBoxResult.Texts = "";
            txtBoxResult.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 250);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 4;
            label3.Text = "Kết quả";
            // 
            // button1
            // 
            button1.Location = new Point(923, 73);
            button1.Name = "button1";
            button1.Size = new Size(300, 29);
            button1.TabIndex = 5;
            button1.Tag = "1";
            button1.Text = "Delete all data!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormTestingGround
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtBoxResult);
            Controls.Add(txtBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTestingGround";
            Size = new Size(1572, 899);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CustomControls.CustomTextBox txtBoxName;
        private CustomControls.CustomTextBox txtBoxResult;
        private Label label3;
        private Button button1;
    }
}
