namespace GUI
{
	partial class FThemSVHP
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
			label_TieuDe = new Label();
			button_Huy = new Button();
			button_Luu = new Button();
			dataGridView_DSSinhVienHocPhan = new DataGridView();
			MaSV = new DataGridViewTextBoxColumn();
			TenSV = new DataGridViewTextBoxColumn();
			label_DSSinhVien = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView_DSSinhVienHocPhan).BeginInit();
			SuspendLayout();
			// 
			// label_TieuDe
			// 
			label_TieuDe.AutoSize = true;
			label_TieuDe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label_TieuDe.Location = new Point(213, 21);
			label_TieuDe.Margin = new Padding(4, 0, 4, 0);
			label_TieuDe.Name = "label_TieuDe";
			label_TieuDe.Size = new Size(379, 31);
			label_TieuDe.TabIndex = 22;
			label_TieuDe.Text = "THÊM SINH VIÊN VÀO HỌC PHẦN";
			// 
			// button_Huy
			// 
			button_Huy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button_Huy.Location = new Point(635, 460);
			button_Huy.Margin = new Padding(4);
			button_Huy.Name = "button_Huy";
			button_Huy.Size = new Size(118, 45);
			button_Huy.TabIndex = 31;
			button_Huy.Text = "Hủy";
			button_Huy.UseVisualStyleBackColor = true;
			// 
			// button_Luu
			// 
			button_Luu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button_Luu.Location = new Point(494, 460);
			button_Luu.Margin = new Padding(4);
			button_Luu.Name = "button_Luu";
			button_Luu.Size = new Size(118, 45);
			button_Luu.TabIndex = 30;
			button_Luu.Text = "Thêm";
			button_Luu.UseVisualStyleBackColor = true;
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
			dataGridView_DSSinhVienHocPhan.Location = new Point(4, 89);
			dataGridView_DSSinhVienHocPhan.Name = "dataGridView_DSSinhVienHocPhan";
			dataGridView_DSSinhVienHocPhan.ReadOnly = true;
			dataGridView_DSSinhVienHocPhan.RowHeadersVisible = false;
			dataGridView_DSSinhVienHocPhan.RowHeadersWidth = 51;
			dataGridView_DSSinhVienHocPhan.RowTemplate.Height = 29;
			dataGridView_DSSinhVienHocPhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_DSSinhVienHocPhan.Size = new Size(794, 348);
			dataGridView_DSSinhVienHocPhan.TabIndex = 32;
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
			// label_DSSinhVien
			// 
			label_DSSinhVien.Anchor = AnchorStyles.Top;
			label_DSSinhVien.AutoSize = true;
			label_DSSinhVien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			label_DSSinhVien.Location = new Point(12, 62);
			label_DSSinhVien.Name = "label_DSSinhVien";
			label_DSSinhVien.Size = new Size(166, 23);
			label_DSSinhVien.TabIndex = 33;
			label_DSSinhVien.Text = "Danh sách sinh viên";
			// 
			// FThemSVHP
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 533);
			Controls.Add(label_DSSinhVien);
			Controls.Add(dataGridView_DSSinhVienHocPhan);
			Controls.Add(button_Huy);
			Controls.Add(button_Luu);
			Controls.Add(label_TieuDe);
			Name = "FThemSVHP";
			Text = "FThemSVHP";
			((System.ComponentModel.ISupportInitialize)dataGridView_DSSinhVienHocPhan).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label_TieuDe;
		private Button button_Huy;
		private Button button_Luu;
		private DataGridView dataGridView_DSSinhVienHocPhan;
		private DataGridViewTextBoxColumn MaSV;
		private DataGridViewTextBoxColumn TenSV;
		private Label label_DSSinhVien;
	}
}