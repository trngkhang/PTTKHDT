namespace GUI
{
    partial class FGiangVien
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
            dataGridView_DSSV = new DataGridView();
            MaCB = new DataGridViewTextBoxColumn();
            TenSV = new DataGridViewTextBoxColumn();
            MaKhoa = new DataGridViewTextBoxColumn();
            label_DSSV = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSSV).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_DSSV
            // 
            dataGridView_DSSV.AllowUserToAddRows = false;
            dataGridView_DSSV.AllowUserToDeleteRows = false;
            dataGridView_DSSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_DSSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DSSV.BackgroundColor = SystemColors.Info;
            dataGridView_DSSV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_DSSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_DSSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DSSV.Columns.AddRange(new DataGridViewColumn[] { MaCB, TenSV, MaKhoa });
            dataGridView_DSSV.Location = new Point(2, 48);
            dataGridView_DSSV.Margin = new Padding(4, 3, 4, 3);
            dataGridView_DSSV.Name = "dataGridView_DSSV";
            dataGridView_DSSV.ReadOnly = true;
            dataGridView_DSSV.RowHeadersVisible = false;
            dataGridView_DSSV.RowHeadersWidth = 51;
            dataGridView_DSSV.RowTemplate.Height = 29;
            dataGridView_DSSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_DSSV.Size = new Size(906, 392);
            dataGridView_DSSV.TabIndex = 23;
            dataGridView_DSSV.CellContentClick += dataGridView_DSSV_CellContentClick;
            // 
            // MaCB
            // 
            MaCB.DataPropertyName = "MaCB";
            MaCB.HeaderText = "Mã giảng viên";
            MaCB.MinimumWidth = 6;
            MaCB.Name = "MaCB";
            MaCB.ReadOnly = true;
            // 
            // TenSV
            // 
            TenSV.DataPropertyName = "TenCB";
            TenSV.HeaderText = "Tên giảng viên";
            TenSV.MinimumWidth = 6;
            TenSV.Name = "TenSV";
            TenSV.ReadOnly = true;
            // 
            // MaKhoa
            // 
            MaKhoa.DataPropertyName = "MaKhoa";
            MaKhoa.HeaderText = "Mã Khoa";
            MaKhoa.MinimumWidth = 6;
            MaKhoa.Name = "MaKhoa";
            MaKhoa.ReadOnly = true;
            // 
            // label_DSSV
            // 
            label_DSSV.Anchor = AnchorStyles.Top;
            label_DSSV.AutoSize = true;
            label_DSSV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_DSSV.Location = new Point(356, 14);
            label_DSSV.Margin = new Padding(4, 0, 4, 0);
            label_DSSV.Name = "label_DSSV";
            label_DSSV.Size = new Size(201, 21);
            label_DSSV.TabIndex = 22;
            label_DSSV.Text = "DANH SÁCH GIẢNG VIÊN";
            // 
            // FGiangVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 504);
            Controls.Add(dataGridView_DSSV);
            Controls.Add(label_DSSV);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FGiangVien";
            Text = "FGiangVien";
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_DSSV;
        private DataGridViewTextBoxColumn MaCB;
        private DataGridViewTextBoxColumn TenSV;
        private DataGridViewTextBoxColumn MaKhoa;
        private Label label_DSSV;
    }
}