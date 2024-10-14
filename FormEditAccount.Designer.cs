namespace TeacherManager
{
    partial class FormEditAccount
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private DataGridView dataGridViewAccounts;
        private TextBox txtAccountId, txtName, txtEmail, txtRole, txtPhone;
        private PictureBox pictureBoxAvatar;
        private Button btnChooseAvatar, btnSaveChanges, btnDeleteAccount, btnAddAccount, btnCancel;
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
            Label lblName = new Label() { Text = "Tên", Location = new Point(20, 20), Width = 100, Font = new Font("Arial", 10, FontStyle.Bold) };
            Label lblEmail = new Label() { Text = "Email", Location = new Point(20, 60), Width = 100, Font = new Font("Arial", 10, FontStyle.Bold) };
            Label lblPhone = new Label() { Text = "Số điện thoại", Location = new Point(20, 100), Width = 100, Font = new Font("Arial", 10, FontStyle.Bold) };
            Label lblRole = new Label() { Text = "Vai trò", Location = new Point(20, 140), Width = 100, Font = new Font("Arial", 10, FontStyle.Bold) };
            Label lblAvatar = new Label() { Text = "Avatar", Location = new Point(20, 180), Width = 100, Font = new Font("Arial", 10, FontStyle.Bold) };

            txtName = new TextBox() { Location = new Point(120, 20), Width = 220, Font = new Font("Arial", 10) };
            txtEmail = new TextBox() { Location = new Point(120, 60), Width = 220, Font = new Font("Arial", 10) };
            txtPhone = new TextBox() { Location = new Point(120, 100), Width = 220, Font = new Font("Arial", 10) };
            txtRole = new TextBox() { Location = new Point(120, 140), Width = 220, Font = new Font("Arial", 10) };

            pictureBoxAvatar = new PictureBox()
            {
                Location = new Point(120, 180),
                Size = new Size(100, 100),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            btnChooseAvatar = new Button() { Text = "Chọn Avatar", Location = new Point(230, 220), Width = 90 };
            btnChooseAvatar.Click += btnChooseAvatar_Click;

            btnSaveChanges = new Button() { Text = "Lưu", Location = new Point(120, 300), Width = 100, Height = 40, BackColor = Color.LightGreen };
            btnSaveChanges.Click += SaveChanges_Click;
            btnCancel = new Button() { Text = "Hủy", Location = new Point(230, 300), Width = 100, Height = 40, BackColor = Color.LightCoral };
            btnCancel.Click += btnCancel_Click;

            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblRole);
            Controls.Add(txtRole);
            Controls.Add(lblAvatar);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(btnChooseAvatar);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnCancel);

            Size = new Size(400, 380);
            Padding = new Padding(10);
            Text = "Chỉnh sửa tài khoản";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion
    }
}
