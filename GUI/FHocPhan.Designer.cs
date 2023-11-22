namespace GUI
{
    partial class FHocPhan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button_ThemHocPhan = new Button();
            button_ThemSVVaoHP = new Button();
            label_DSSinhVienHocPhan = new Label();
            dataGridView_DSSinhVienHocPhan = new DataGridView();
            MaSV = new DataGridViewTextBoxColumn();
            TenSV = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dataGridView_DSHocPhan = new DataGridView();
            TenMH = new DataGridViewTextBoxColumn();
            MaMH = new DataGridViewTextBoxColumn();
            MaHP = new DataGridViewTextBoxColumn();
            HocKy = new DataGridViewTextBoxColumn();
            Nam = new DataGridViewTextBoxColumn();
            label_DSLopHoc = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSSinhVienHocPhan).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSHocPhan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button_ThemHocPhan);
            panel1.Controls.Add(button_ThemSVVaoHP);
            panel1.Controls.Add(label_DSSinhVienHocPhan);
            panel1.Controls.Add(dataGridView_DSSinhVienHocPhan);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(420, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 504);
            panel1.TabIndex = 0;
            // 
            // button_ThemHocPhan
            // 
            button_ThemHocPhan.Location = new Point(73, 460);
            button_ThemHocPhan.Margin = new Padding(3, 2, 3, 2);
            button_ThemHocPhan.Name = "button_ThemHocPhan";
            button_ThemHocPhan.Size = new Size(105, 34);
            button_ThemHocPhan.TabIndex = 3;
            button_ThemHocPhan.Text = "Thêm học phần";
            button_ThemHocPhan.UseVisualStyleBackColor = true;
            // 
            // button_ThemSVVaoHP
            // 
            button_ThemSVVaoHP.Location = new Point(198, 460);
            button_ThemSVVaoHP.Margin = new Padding(3, 2, 3, 2);
            button_ThemSVVaoHP.Name = "button_ThemSVVaoHP";
            button_ThemSVVaoHP.Size = new Size(196, 34);
            button_ThemSVVaoHP.TabIndex = 5;
            button_ThemSVVaoHP.Text = "Thêm sinh viên vào học phần";
            button_ThemSVVaoHP.UseVisualStyleBackColor = true;
            // 
            // label_DSSinhVienHocPhan
            // 
            label_DSSinhVienHocPhan.Anchor = AnchorStyles.Top;
            label_DSSinhVienHocPhan.AutoSize = true;
            label_DSSinhVienHocPhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_DSSinhVienHocPhan.Location = new Point(116, 26);
            label_DSSinhVienHocPhan.Name = "label_DSSinhVienHocPhan";
            label_DSSinhVienHocPhan.Size = new Size(266, 21);
            label_DSSinhVienHocPhan.TabIndex = 4;
            label_DSSinhVienHocPhan.Text = "Danh sách sinh viên lớp học phần";
            // 
            // dataGridView_DSSinhVienHocPhan
            // 
            dataGridView_DSSinhVienHocPhan.AllowUserToAddRows = false;
            dataGridView_DSSinhVienHocPhan.AllowUserToDeleteRows = false;
            dataGridView_DSSinhVienHocPhan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_DSSinhVienHocPhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DSSinhVienHocPhan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView_DSSinhVienHocPhan.BackgroundColor = SystemColors.Info;
            dataGridView_DSSinhVienHocPhan.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_DSSinhVienHocPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_DSSinhVienHocPhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DSSinhVienHocPhan.Columns.AddRange(new DataGridViewColumn[] { MaSV, TenSV });
            dataGridView_DSSinhVienHocPhan.Location = new Point(0, 54);
            dataGridView_DSSinhVienHocPhan.Margin = new Padding(3, 2, 3, 2);
            dataGridView_DSSinhVienHocPhan.Name = "dataGridView_DSSinhVienHocPhan";
            dataGridView_DSSinhVienHocPhan.ReadOnly = true;
            dataGridView_DSSinhVienHocPhan.RowHeadersVisible = false;
            dataGridView_DSSinhVienHocPhan.RowHeadersWidth = 51;
            dataGridView_DSSinhVienHocPhan.RowTemplate.Height = 29;
            dataGridView_DSSinhVienHocPhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_DSSinhVienHocPhan.Size = new Size(489, 394);
            dataGridView_DSSinhVienHocPhan.TabIndex = 3;
            // 
            // MaSV
            // 
            MaSV.HeaderText = "Mã sinh viên";
            MaSV.MinimumWidth = 6;
            MaSV.Name = "MaSV";
            MaSV.ReadOnly = true;
            // 
            // TenSV
            // 
            TenSV.HeaderText = "Tên sinh viên";
            TenSV.MinimumWidth = 6;
            TenSV.Name = "TenSV";
            TenSV.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView_DSHocPhan);
            panel2.Controls.Add(label_DSLopHoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 504);
            panel2.TabIndex = 1;
            // 
            // dataGridView_DSHocPhan
            // 
            dataGridView_DSHocPhan.AllowUserToAddRows = false;
            dataGridView_DSHocPhan.AllowUserToDeleteRows = false;
            dataGridView_DSHocPhan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_DSHocPhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DSHocPhan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView_DSHocPhan.BackgroundColor = SystemColors.Info;
            dataGridView_DSHocPhan.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_DSHocPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_DSHocPhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DSHocPhan.Columns.AddRange(new DataGridViewColumn[] { TenMH, MaMH, MaHP, HocKy, Nam });
            dataGridView_DSHocPhan.Location = new Point(0, 54);
            dataGridView_DSHocPhan.Margin = new Padding(3, 2, 3, 2);
            dataGridView_DSHocPhan.Name = "dataGridView_DSHocPhan";
            dataGridView_DSHocPhan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_DSHocPhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_DSHocPhan.RowHeadersVisible = false;
            dataGridView_DSHocPhan.RowHeadersWidth = 51;
            dataGridView_DSHocPhan.RowTemplate.Height = 29;
            dataGridView_DSHocPhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_DSHocPhan.Size = new Size(420, 394);
            dataGridView_DSHocPhan.TabIndex = 2;
            dataGridView_DSHocPhan.CellContentClick += dataGridView_DSHocPhan_CellContentClick;
            // 
            // TenMH
            // 
            TenMH.HeaderText = "Tên môn học";
            TenMH.MinimumWidth = 6;
            TenMH.Name = "TenMH";
            TenMH.ReadOnly = true;
            // 
            // MaMH
            // 
            MaMH.DataPropertyName = "MaMH";
            MaMH.HeaderText = "Mã môn học";
            MaMH.MinimumWidth = 6;
            MaMH.Name = "MaMH";
            MaMH.ReadOnly = true;
            // 
            // MaHP
            // 
            MaHP.DataPropertyName = "MaHP";
            MaHP.HeaderText = "Mã học phần";
            MaHP.MinimumWidth = 6;
            MaHP.Name = "MaHP";
            MaHP.ReadOnly = true;
            // 
            // HocKy
            // 
            HocKy.DataPropertyName = "HocKy";
            HocKy.HeaderText = "Học kỳ";
            HocKy.MinimumWidth = 6;
            HocKy.Name = "HocKy";
            HocKy.ReadOnly = true;
            // 
            // Nam
            // 
            Nam.DataPropertyName = "Nam";
            Nam.HeaderText = "Năm";
            Nam.MinimumWidth = 6;
            Nam.Name = "Nam";
            Nam.ReadOnly = true;
            // 
            // label_DSLopHoc
            // 
            label_DSLopHoc.Anchor = AnchorStyles.Top;
            label_DSLopHoc.AutoSize = true;
            label_DSLopHoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_DSLopHoc.Location = new Point(113, 26);
            label_DSLopHoc.Name = "label_DSLopHoc";
            label_DSLopHoc.Size = new Size(164, 21);
            label_DSLopHoc.TabIndex = 1;
            label_DSLopHoc.Text = "Danh sách học phần";
            // 
            // FHocPhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 504);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FHocPhan";
            Text = "FHocPhan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSSinhVienHocPhan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSHocPhan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label_DSLopHoc;
        private DataGridView dataGridView_DSHocPhan;
        private DataGridView dataGridView_DSSinhVienHocPhan;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn TenSV;
        private Label label_DSSinhVienHocPhan;
        private Button button_ThemSVVaoHP;
        private Button button_ThemHocPhan;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn MaHP;
        private DataGridViewTextBoxColumn HocKy;
        private DataGridViewTextBoxColumn Nam;
    }
}