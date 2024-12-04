namespace TeacherManager
{
    partial class FormQLBM
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblHeader = new Label();
            lblSort = new Label();
            cbSort = new CustomControls.CustomComboBox();
            btnAddFaculty = new CustomControls.CustomButton();
            dataViewFaculties = new DataGridView();
            timerNameTyped = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataViewFaculties).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(22, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(214, 31);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "QUẢN LÝ BỘ MÔN";
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Font = new Font("Segoe UI", 13.8F);
            lblSort.Location = new Point(41, 94);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(147, 31);
            lblSort.TabIndex = 6;
            lblSort.Text = "Sắp xếp theo";
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
            cbSort.Location = new Point(194, 93);
            cbSort.MinimumSize = new Size(50, 30);
            cbSort.Name = "cbSort";
            cbSort.Padding = new Padding(2);
            cbSort.Size = new Size(141, 38);
            cbSort.TabIndex = 7;
            cbSort.Texts = "";
            cbSort.OnSelectedIndexChanged += OnSortChange;
            // 
            // btnAddFaculty
            // 
            btnAddFaculty.BackColor = Color.MediumSlateBlue;
            btnAddFaculty.BackgroundColor = Color.MediumSlateBlue;
            btnAddFaculty.BorderColor = Color.PaleVioletRed;
            btnAddFaculty.BorderRadius = 10;
            btnAddFaculty.BorderSize = 0;
            btnAddFaculty.Cursor = Cursors.Hand;
            btnAddFaculty.FlatAppearance.BorderSize = 0;
            btnAddFaculty.FlatStyle = FlatStyle.Flat;
            btnAddFaculty.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFaculty.ForeColor = Color.White;
            btnAddFaculty.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddFaculty.Location = new Point(1326, 15);
            btnAddFaculty.Name = "btnAddFaculty";
            btnAddFaculty.Size = new Size(201, 43);
            btnAddFaculty.TabIndex = 17;
            btnAddFaculty.Text = "Thêm bộ môn";
            btnAddFaculty.TextColor = Color.White;
            btnAddFaculty.UseVisualStyleBackColor = false;
            btnAddFaculty.Click += ShowAddFacultyForm;
            // 
            // dataViewFaculties
            // 
            dataViewFaculties.AllowUserToAddRows = false;
            dataViewFaculties.AllowUserToDeleteRows = false;
            dataViewFaculties.AllowUserToResizeColumns = false;
            dataViewFaculties.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataViewFaculties.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataViewFaculties.BackgroundColor = Color.WhiteSmoke;
            dataViewFaculties.BorderStyle = BorderStyle.None;
            dataViewFaculties.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataViewFaculties.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 28, 181);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataViewFaculties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataViewFaculties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(55, 28, 191);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataViewFaculties.DefaultCellStyle = dataGridViewCellStyle3;
            dataViewFaculties.EditMode = DataGridViewEditMode.EditOnEnter;
            dataViewFaculties.EnableHeadersVisualStyles = false;
            dataViewFaculties.GridColor = Color.WhiteSmoke;
            dataViewFaculties.Location = new Point(40, 148);
            dataViewFaculties.MultiSelect = false;
            dataViewFaculties.Name = "dataViewFaculties";
            dataViewFaculties.ReadOnly = true;
            dataViewFaculties.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataViewFaculties.RowHeadersVisible = false;
            dataViewFaculties.RowHeadersWidth = 51;
            dataViewFaculties.RowTemplate.Height = 40;
            dataViewFaculties.Size = new Size(1492, 602);
            dataViewFaculties.TabIndex = 18;
            // 
            // FormQLBM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataViewFaculties);
            Controls.Add(btnAddFaculty);
            Controls.Add(cbSort);
            Controls.Add(lblSort);
            Controls.Add(lblHeader);
            Name = "FormQLBM";
            Size = new Size(1572, 899);
            ((System.ComponentModel.ISupportInitialize)dataViewFaculties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TeacherManager.CustomControls.CustomButton btnAddFaculty;
        private Label lblHeader;
        private Label lblSort;
        private CustomControls.CustomComboBox cbSort;
        private DataGridView dataViewFaculties;
        private System.Windows.Forms.Timer timerNameTyped;
    }
}
