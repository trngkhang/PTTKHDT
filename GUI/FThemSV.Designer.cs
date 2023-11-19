namespace GUI
{
	partial class FThemSV
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
			textBox_TenSV = new TextBox();
			label_MatKhau = new Label();
			textBox_MaSV = new TextBox();
			label_TaiKhoan = new Label();
			label_TieuDe = new Label();
			textBox_MaKhoa = new TextBox();
			label_MaKhoa = new Label();
			button_Luu = new Button();
			button_Huy = new Button();
			SuspendLayout();
			// 
			// textBox_TenSV
			// 
			textBox_TenSV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox_TenSV.Location = new Point(309, 207);
			textBox_TenSV.Margin = new Padding(4);
			textBox_TenSV.Name = "textBox_TenSV";
			textBox_TenSV.Size = new Size(233, 34);
			textBox_TenSV.TabIndex = 12;
			// 
			// label_MatKhau
			// 
			label_MatKhau.AutoSize = true;
			label_MatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label_MatKhau.Location = new Point(146, 211);
			label_MatKhau.Margin = new Padding(4, 0, 4, 0);
			label_MatKhau.Name = "label_MatKhau";
			label_MatKhau.Size = new Size(122, 28);
			label_MatKhau.TabIndex = 11;
			label_MatKhau.Text = "Tên sinh viên";
			// 
			// textBox_MaSV
			// 
			textBox_MaSV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox_MaSV.Location = new Point(309, 143);
			textBox_MaSV.Margin = new Padding(4);
			textBox_MaSV.Name = "textBox_MaSV";
			textBox_MaSV.Size = new Size(233, 34);
			textBox_MaSV.TabIndex = 9;
			// 
			// label_TaiKhoan
			// 
			label_TaiKhoan.AutoSize = true;
			label_TaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label_TaiKhoan.Location = new Point(146, 146);
			label_TaiKhoan.Margin = new Padding(4, 0, 4, 0);
			label_TaiKhoan.Name = "label_TaiKhoan";
			label_TaiKhoan.Size = new Size(121, 28);
			label_TaiKhoan.TabIndex = 8;
			label_TaiKhoan.Text = "Mã sinh viên";
			// 
			// label_TieuDe
			// 
			label_TieuDe.AutoSize = true;
			label_TieuDe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label_TieuDe.Location = new Point(296, 34);
			label_TieuDe.Margin = new Padding(4, 0, 4, 0);
			label_TieuDe.Name = "label_TieuDe";
			label_TieuDe.Size = new Size(260, 31);
			label_TieuDe.TabIndex = 7;
			label_TieuDe.Text = "THÔNG TIN SINH VIÊN";
			// 
			// textBox_MaKhoa
			// 
			textBox_MaKhoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox_MaKhoa.Location = new Point(309, 266);
			textBox_MaKhoa.Margin = new Padding(4);
			textBox_MaKhoa.Name = "textBox_MaKhoa";
			textBox_MaKhoa.Size = new Size(233, 34);
			textBox_MaKhoa.TabIndex = 15;
			// 
			// label_MaKhoa
			// 
			label_MaKhoa.AutoSize = true;
			label_MaKhoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label_MaKhoa.Location = new Point(146, 270);
			label_MaKhoa.Margin = new Padding(4, 0, 4, 0);
			label_MaKhoa.Name = "label_MaKhoa";
			label_MaKhoa.Size = new Size(90, 28);
			label_MaKhoa.TabIndex = 14;
			label_MaKhoa.Text = "Mã Khoa";
			// 
			// button_Luu
			// 
			button_Luu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button_Luu.Location = new Point(437, 355);
			button_Luu.Margin = new Padding(4);
			button_Luu.Name = "button_Luu";
			button_Luu.Size = new Size(118, 45);
			button_Luu.TabIndex = 19;
			button_Luu.Text = "Lưu";
			button_Luu.UseVisualStyleBackColor = true;
			button_Luu.Click += button_Luu_Click;
			// 
			// button_Huy
			// 
			button_Huy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button_Huy.Location = new Point(578, 355);
			button_Huy.Margin = new Padding(4);
			button_Huy.Name = "button_Huy";
			button_Huy.Size = new Size(118, 45);
			button_Huy.TabIndex = 20;
			button_Huy.Text = "Hủy";
			button_Huy.UseVisualStyleBackColor = true;
			button_Huy.Click += button_Huy_Click;
			// 
			// FThemSV
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button_Huy);
			Controls.Add(button_Luu);
			Controls.Add(textBox_MaKhoa);
			Controls.Add(label_MaKhoa);
			Controls.Add(textBox_TenSV);
			Controls.Add(label_MatKhau);
			Controls.Add(textBox_MaSV);
			Controls.Add(label_TaiKhoan);
			Controls.Add(label_TieuDe);
			Name = "FThemSV";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FThemSV";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox textBox_TenSV;
		private Label label_MatKhau;
		private TextBox textBox_MaSV;
		private Label label_TaiKhoan;
		private Label label_TieuDe;
		private TextBox textBox_MaKhoa;
		private Label label_MaKhoa;
		private Button button_Luu;
		private Button button_Huy;
	}
}