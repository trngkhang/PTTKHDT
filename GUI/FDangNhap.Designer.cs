namespace GUI
{
	partial class FDangNhap
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
			label_TieuDe = new Label();
			label_TaiKhoan = new Label();
			textBox_TaiKhoan = new TextBox();
			button_DangNhap = new Button();
			label_MatKhau = new Label();
			textBox_MatKhau = new TextBox();
			button_Thoat = new Button();
			SuspendLayout();
			// 
			// label_TieuDe
			// 
			label_TieuDe.AutoSize = true;
			label_TieuDe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label_TieuDe.Location = new Point(254, 35);
			label_TieuDe.Margin = new Padding(4, 0, 4, 0);
			label_TieuDe.Name = "label_TieuDe";
			label_TieuDe.Size = new Size(297, 31);
			label_TieuDe.TabIndex = 0;
			label_TieuDe.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
			// 
			// label_TaiKhoan
			// 
			label_TaiKhoan.AutoSize = true;
			label_TaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label_TaiKhoan.Location = new Point(194, 140);
			label_TaiKhoan.Margin = new Padding(4, 0, 4, 0);
			label_TaiKhoan.Name = "label_TaiKhoan";
			label_TaiKhoan.Size = new Size(96, 28);
			label_TaiKhoan.TabIndex = 1;
			label_TaiKhoan.Text = "Tài Khoản";
			// 
			// textBox_TaiKhoan
			// 
			textBox_TaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox_TaiKhoan.Location = new Point(357, 137);
			textBox_TaiKhoan.Margin = new Padding(4);
			textBox_TaiKhoan.Name = "textBox_TaiKhoan";
			textBox_TaiKhoan.Size = new Size(233, 34);
			textBox_TaiKhoan.TabIndex = 2;
			// 
			// button_DangNhap
			// 
			button_DangNhap.Location = new Point(561, 350);
			button_DangNhap.Margin = new Padding(4);
			button_DangNhap.Name = "button_DangNhap";
			button_DangNhap.Size = new Size(142, 53);
			button_DangNhap.TabIndex = 3;
			button_DangNhap.Text = "Đâng nhập";
			button_DangNhap.UseVisualStyleBackColor = true;
			button_DangNhap.Click += button1_Click;
			// 
			// label_MatKhau
			// 
			label_MatKhau.AutoSize = true;
			label_MatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label_MatKhau.Location = new Point(194, 229);
			label_MatKhau.Margin = new Padding(4, 0, 4, 0);
			label_MatKhau.Name = "label_MatKhau";
			label_MatKhau.Size = new Size(94, 28);
			label_MatKhau.TabIndex = 4;
			label_MatKhau.Text = "Mật khẩu";
			// 
			// textBox_MatKhau
			// 
			textBox_MatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox_MatKhau.Location = new Point(357, 225);
			textBox_MatKhau.Margin = new Padding(4);
			textBox_MatKhau.Name = "textBox_MatKhau";
			textBox_MatKhau.Size = new Size(233, 34);
			textBox_MatKhau.TabIndex = 5;
			// 
			// button_Thoat
			// 
			button_Thoat.Location = new Point(409, 350);
			button_Thoat.Margin = new Padding(4);
			button_Thoat.Name = "button_Thoat";
			button_Thoat.Size = new Size(142, 53);
			button_Thoat.TabIndex = 6;
			button_Thoat.Text = "Thoát";
			button_Thoat.UseVisualStyleBackColor = true;
			button_Thoat.Click += button_Thoat_Click;
			// 
			// FDangNhap
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(782, 453);
			Controls.Add(button_Thoat);
			Controls.Add(textBox_MatKhau);
			Controls.Add(label_MatKhau);
			Controls.Add(button_DangNhap);
			Controls.Add(textBox_TaiKhoan);
			Controls.Add(label_TaiKhoan);
			Controls.Add(label_TieuDe);
			Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FDangNhap";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Đăng Nhập";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label_TieuDe;
		private Label label_TaiKhoan;
		private TextBox textBox_TaiKhoan;
		private Button button_DangNhap;
		private Label label_MatKhau;
		private TextBox textBox_MatKhau;
		private Button button_Thoat;
	}
}