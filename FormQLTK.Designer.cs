namespace TeacherManager
{
    partial class FormQLTK
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtAccountId, txtName, txtEmail, txtRole, txtPhone;
        private PictureBox pictureBoxAvatar;
        private Button btnChooseAvatar, btnSaveChanges, btnDeleteAccount, btnAddAccount, btnEditAccount;
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


        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEditAccount = new Button();
            btnAddAccount = new Button();
            btnDeleteAccount = new Button();
            lblHeader = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnEditAccount
            // 
            btnEditAccount.BackColor = Color.LightSkyBlue;
            btnEditAccount.FlatStyle = FlatStyle.Flat;
            btnEditAccount.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnEditAccount.Location = new Point(788, 20);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(159, 30);
            btnEditAccount.TabIndex = 2;
            btnEditAccount.Text = "Chỉnh sửa tài khoản";
            btnEditAccount.UseVisualStyleBackColor = false;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = Color.LightGreen;
            btnAddAccount.FlatStyle = FlatStyle.Flat;
            btnAddAccount.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnAddAccount.Location = new Point(555, 20);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(159, 30);
            btnAddAccount.TabIndex = 3;
            btnAddAccount.Text = "Thêm tài khoản";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.IndianRed;
            btnDeleteAccount.FlatStyle = FlatStyle.Flat;
            btnDeleteAccount.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnDeleteAccount.Location = new Point(996, 20);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(159, 30);
            btnDeleteAccount.TabIndex = 4;
            btnDeleteAccount.Text = "Xóa tài khoản";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblHeader.Location = new Point(22, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(244, 31);
            lblHeader.TabIndex = 15;
            lblHeader.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 70);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 16;
            label1.Text = "Tài khoản của tôi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 70);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 17;
            label2.Text = "Xem tài khoản";
            label2.Click += ShowAccountsDescriptionForm;
            // 
            // FormQLTK
            // 
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHeader);
            Controls.Add(btnEditAccount);
            Controls.Add(btnAddAccount);
            Controls.Add(btnDeleteAccount);
            Name = "FormQLTK";
            Size = new Size(1572, 899);
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataViewAccounts;
        private Panel panel1;
        private Label lblHeader;
        private Label label1;
        private Label label2;
    }
}
