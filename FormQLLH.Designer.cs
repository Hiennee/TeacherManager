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
            panelClasses = new FlowLayoutPanel();
            cbSort = new CustomControls.CustomComboBox();
            lblSort = new Label();
            lblClassNameToFind = new Label();
            txtBoxClassNameToFind = new CustomControls.CustomTextBox();
            searchIcon = new PictureBox();
            reloadIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reloadIcon).BeginInit();
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
            // panelClasses
            // 
            panelClasses.AutoScroll = true;
            panelClasses.Location = new Point(41, 125);
            panelClasses.Name = "panelClasses";
            panelClasses.RightToLeft = RightToLeft.No;
            panelClasses.Size = new Size(1486, 708);
            panelClasses.TabIndex = 0;
            // 
            // cbSort
            // 
            cbSort.BackColor = Color.White;
            cbSort.BorderColor = Color.MediumSlateBlue;
            cbSort.BorderSize = 2;
            cbSort.DropDownStyle = ComboBoxStyle.DropDown;
            cbSort.Font = new Font("Segoe UI", 10F);
            cbSort.ForeColor = Color.DimGray;
            cbSort.IconColor = Color.MediumSlateBlue;
            cbSort.ListBackColor = Color.FromArgb(230, 228, 245);
            cbSort.ListTextColor = Color.DimGray;
            cbSort.Location = new Point(684, 84);
            cbSort.MinimumSize = new Size(50, 30);
            cbSort.Name = "cbSort";
            cbSort.Padding = new Padding(2);
            cbSort.Size = new Size(141, 35);
            cbSort.TabIndex = 9;
            cbSort.Texts = "";
            cbSort.OnSelectedIndexChanged += OnSortChange;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Font = new Font("Segoe UI", 13.8F);
            lblSort.Location = new Point(531, 88);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(147, 31);
            lblSort.TabIndex = 8;
            lblSort.Text = "Sắp xếp theo";
            // 
            // lblClassNameToFind
            // 
            lblClassNameToFind.AutoSize = true;
            lblClassNameToFind.Font = new Font("Segoe UI", 13.8F);
            lblClassNameToFind.Location = new Point(86, 88);
            lblClassNameToFind.Name = "lblClassNameToFind";
            lblClassNameToFind.Size = new Size(107, 31);
            lblClassNameToFind.TabIndex = 10;
            lblClassNameToFind.Text = "Tìm kiếm";
            // 
            // txtBoxClassNameToFind
            // 
            txtBoxClassNameToFind.BackColor = SystemColors.Window;
            txtBoxClassNameToFind.BorderColor = Color.MediumSlateBlue;
            txtBoxClassNameToFind.BorderFocusColor = Color.HotPink;
            txtBoxClassNameToFind.BorderRadius = 0;
            txtBoxClassNameToFind.BorderSize = 2;
            txtBoxClassNameToFind.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxClassNameToFind.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxClassNameToFind.Location = new Point(200, 84);
            txtBoxClassNameToFind.Margin = new Padding(4);
            txtBoxClassNameToFind.Multiline = false;
            txtBoxClassNameToFind.Name = "txtBoxClassNameToFind";
            txtBoxClassNameToFind.Padding = new Padding(10, 7, 10, 7);
            txtBoxClassNameToFind.PasswordChar = false;
            txtBoxClassNameToFind.PlaceholderColor = Color.DarkGray;
            txtBoxClassNameToFind.PlaceholderText = "";
            txtBoxClassNameToFind.Size = new Size(312, 35);
            txtBoxClassNameToFind.TabIndex = 11;
            txtBoxClassNameToFind.Texts = "";
            txtBoxClassNameToFind.UnderlinedStyle = false;
            txtBoxClassNameToFind._TextChanged += UpdateNameClassesToFind;
            // 
            // searchIcon
            // 
            searchIcon.Image = Properties.Resources.search_icon;
            searchIcon.Location = new Point(41, 84);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(39, 35);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 12;
            searchIcon.TabStop = false;
            // 
            // reloadIcon
            // 
            reloadIcon.Image = Properties.Resources.reload_icon;
            reloadIcon.Location = new Point(1488, 84);
            reloadIcon.Name = "reloadIcon";
            reloadIcon.Size = new Size(39, 35);
            reloadIcon.SizeMode = PictureBoxSizeMode.Zoom;
            reloadIcon.TabIndex = 13;
            reloadIcon.TabStop = false;
            reloadIcon.Click += ReloadClasses;
            // 
            // FormQLLH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(reloadIcon);
            Controls.Add(searchIcon);
            Controls.Add(txtBoxClassNameToFind);
            Controls.Add(lblClassNameToFind);
            Controls.Add(lblSort);
            Controls.Add(cbSort);
            Controls.Add(panelClasses);
            Controls.Add(lblHeader);
            Name = "FormQLLH";
            Size = new Size(1572, 899);
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)reloadIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private FlowLayoutPanel panelClasses;
        private CustomControls.CustomComboBox cbSort;
        private Label lblSort;
        private Label lblClassNameToFind;
        private CustomControls.CustomTextBox txtBoxClassNameToFind;
        private PictureBox searchIcon;
        private PictureBox pictureBox1;
        private PictureBox reloadIcon;
    }
}
