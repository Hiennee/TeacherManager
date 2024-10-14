namespace TeacherManager
{
    partial class FormCreateAccount
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtAccountId, txtName, txtEmail, txtPassword, txtRole, txtPhone,txtAvatar;
        private DateTimePicker dtpDOB;
        private Button btnSave, btnCancel, btnSelectAvatar;  
        private Label lblAccountId, lblName, lblEmail, lblPassword, lblRole, lblAvatar, lblDOB, lblPhone;
        private PictureBox pictureBoxAvatar;  

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
            lblAccountId = new Label() { Text = "Mã tài khoản", Location = new Point(20, 20), Width = 100 };
            lblName = new Label() { Text = "Tên", Location = new Point(20, 60), Width = 100 };
            lblEmail = new Label() { Text = "Email", Location = new Point(20, 100), Width = 100 };
            lblPassword = new Label() { Text = "Mật khẩu", Location = new Point(20, 140), Width = 100 };
            lblRole = new Label() { Text = "Vai trò", Location = new Point(20, 180), Width = 100 };
            lblAvatar = new Label() { Text = "Avatar", Location = new Point(20, 220), Width = 100 };
            lblDOB = new Label() { Text = "Ngày sinh", Location = new Point(20, 340), Width = 100 };
            lblPhone = new Label() { Text = "Số điện thoại", Location = new Point(20, 380), Width = 100 };

            txtAccountId = new TextBox() { Location = new Point(120, 20), Width = 200 };
            txtName = new TextBox() { Location = new Point(120, 60), Width = 200 };
            txtEmail = new TextBox() { Location = new Point(120, 100), Width = 200 };
            txtPassword = new TextBox() { Location = new Point(120, 140), Width = 200, PasswordChar = '*' };
            txtRole = new TextBox() { Location = new Point(120, 180), Width = 200 };
            txtPhone = new TextBox() { Location = new Point(120, 380), Width = 200 };
            dtpDOB = new DateTimePicker() { Location = new Point(120, 340), Width = 200 };

            pictureBoxAvatar = new PictureBox()
            {
                Location = new Point(120, 220),
                Size = new Size(100, 100),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            txtAvatar = new TextBox() { Location = new Point(120, 220), Width = 100, Visible = false };  

            btnSelectAvatar = new Button() { Text = "Chọn Avatar", Location = new Point(230, 220), Width = 90 };
            btnSave = new Button() { Text = "Lưu", Location = new Point(120, 420), Width = 100, Height = 40, BackColor = Color.LightGreen };
            btnCancel = new Button() { Text = "Hủy", Location = new Point(230, 420), Width = 100, Height = 40, BackColor = Color.LightCoral };

            btnSelectAvatar.Click += btnChooseAvatar_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;

            Controls.Add(lblAccountId);
            Controls.Add(lblName);
            Controls.Add(lblEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblRole);
            Controls.Add(lblAvatar);
            Controls.Add(lblDOB);
            Controls.Add(lblPhone);
            Controls.Add(txtAccountId);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtRole);
            Controls.Add(txtPhone);
            Controls.Add(dtpDOB);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(btnSelectAvatar);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtAvatar);  

            Size = new Size(400, 500);
            Padding = new Padding(10);
            Text = "Thêm Tài Khoản";
        }

        #endregion
    }
}
