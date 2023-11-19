namespace GUI
{
	partial class FSinhVien
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
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			label_DSSV = new Label();
			dataGridView_DSSV = new DataGridView();
			MaSV = new DataGridViewTextBoxColumn();
			TenSV = new DataGridViewTextBoxColumn();
			MaKhoa = new DataGridViewTextBoxColumn();
			button_Xoa = new Button();
			button_Sua = new Button();
			button_Them = new Button();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView_DSSV).BeginInit();
			SuspendLayout();
			// 
			// label_DSSV
			// 
			label_DSSV.Anchor = AnchorStyles.Top;
			label_DSSV.AutoSize = true;
			label_DSSV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label_DSSV.Location = new Point(408, 18);
			label_DSSV.Margin = new Padding(4, 0, 4, 0);
			label_DSSV.Name = "label_DSSV";
			label_DSSV.Size = new Size(236, 28);
			label_DSSV.TabIndex = 0;
			label_DSSV.Text = "DANH SÁCH SINH VIÊN";
			// 
			// dataGridView_DSSV
			// 
			dataGridView_DSSV.AllowUserToAddRows = false;
			dataGridView_DSSV.AllowUserToDeleteRows = false;
			dataGridView_DSSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView_DSSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_DSSV.BackgroundColor = SystemColors.Info;
			dataGridView_DSSV.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dataGridView_DSSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridView_DSSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView_DSSV.Columns.AddRange(new DataGridViewColumn[] { MaSV, TenSV, MaKhoa });
			dataGridView_DSSV.Location = new Point(3, 63);
			dataGridView_DSSV.Margin = new Padding(4);
			dataGridView_DSSV.Name = "dataGridView_DSSV";
			dataGridView_DSSV.ReadOnly = true;
			dataGridView_DSSV.RowHeadersVisible = false;
			dataGridView_DSSV.RowHeadersWidth = 51;
			dataGridView_DSSV.RowTemplate.Height = 29;
			dataGridView_DSSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_DSSV.Size = new Size(1035, 523);
			dataGridView_DSSV.TabIndex = 1;
			// 
			// MaSV
			// 
			MaSV.DataPropertyName = "MaSV";
			MaSV.HeaderText = "Mã Sinh Viên";
			MaSV.MinimumWidth = 6;
			MaSV.Name = "MaSV";
			MaSV.ReadOnly = true;
			// 
			// TenSV
			// 
			TenSV.DataPropertyName = "TenSV";
			TenSV.HeaderText = "Tên Sinh Viên";
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
			// button_Xoa
			// 
			button_Xoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button_Xoa.Location = new Point(797, 607);
			button_Xoa.Margin = new Padding(4);
			button_Xoa.Name = "button_Xoa";
			button_Xoa.Size = new Size(118, 45);
			button_Xoa.TabIndex = 21;
			button_Xoa.Text = "Xóa";
			button_Xoa.UseVisualStyleBackColor = true;
			button_Xoa.Click += button_Xoa_Click;
			// 
			// button_Sua
			// 
			button_Sua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button_Sua.Location = new Point(654, 607);
			button_Sua.Margin = new Padding(4);
			button_Sua.Name = "button_Sua";
			button_Sua.Size = new Size(118, 45);
			button_Sua.TabIndex = 20;
			button_Sua.Text = "Sửa";
			button_Sua.UseVisualStyleBackColor = true;
			button_Sua.Click += button_Sua_Click;
			// 
			// button_Them
			// 
			button_Them.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button_Them.Location = new Point(506, 607);
			button_Them.Margin = new Padding(4);
			button_Them.Name = "button_Them";
			button_Them.Size = new Size(118, 45);
			button_Them.TabIndex = 19;
			button_Them.Text = "Thêm";
			button_Them.UseVisualStyleBackColor = true;
			button_Them.Click += button_Them_Click;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button1.Location = new Point(42, 607);
			button1.Margin = new Padding(4);
			button1.Name = "button1";
			button1.Size = new Size(194, 45);
			button1.TabIndex = 22;
			button1.Text = "Xuất kết quả sinh viên";
			button1.UseVisualStyleBackColor = true;
			// 
			// FSinhVien
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1039, 672);
			Controls.Add(button1);
			Controls.Add(button_Xoa);
			Controls.Add(button_Sua);
			Controls.Add(button_Them);
			Controls.Add(dataGridView_DSSV);
			Controls.Add(label_DSSV);
			Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "FSinhVien";
			Text = "FSinhVien";
			((System.ComponentModel.ISupportInitialize)dataGridView_DSSV).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label_DSSV;
		private DataGridView dataGridView_DSSV;
		private DataGridViewTextBoxColumn MaSV;
		private DataGridViewTextBoxColumn TenSV;
		private DataGridViewTextBoxColumn MaKhoa;
		private Button button_Xoa;
		private Button button_Sua;
		private Button button_Them;
		private Button button1;
	}
}