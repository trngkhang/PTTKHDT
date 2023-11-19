namespace GUI
{
	partial class FTrangChu
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
			button_SinhVien = new Button();
			button_CanBo = new Button();
			button_LichThi = new Button();
			button_DiemSo = new Button();
			button_HocPhan = new Button();
			panel_Menu = new Panel();
			pictureBox_Logo = new PictureBox();
			button_DangXuat = new Button();
			panel_Header = new Panel();
			label_TieuDe = new Label();
			panel_Body = new Panel();
			panel_Menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox_Logo).BeginInit();
			panel_Header.SuspendLayout();
			SuspendLayout();
			// 
			// button_SinhVien
			// 
			button_SinhVien.FlatAppearance.BorderSize = 0;
			button_SinhVien.FlatStyle = FlatStyle.Flat;
			button_SinhVien.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button_SinhVien.ForeColor = Color.White;
			button_SinhVien.Location = new Point(0, 178);
			button_SinhVien.Margin = new Padding(3, 4, 3, 4);
			button_SinhVien.Name = "button_SinhVien";
			button_SinhVien.Size = new Size(286, 68);
			button_SinhVien.TabIndex = 0;
			button_SinhVien.Text = "Sinh viên";
			button_SinhVien.UseVisualStyleBackColor = false;
			button_SinhVien.Click += button_SinhVien_Click;
			// 
			// button_CanBo
			// 
			button_CanBo.FlatAppearance.BorderSize = 0;
			button_CanBo.FlatStyle = FlatStyle.Flat;
			button_CanBo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button_CanBo.ForeColor = Color.White;
			button_CanBo.Location = new Point(0, 329);
			button_CanBo.Margin = new Padding(3, 4, 3, 4);
			button_CanBo.Name = "button_CanBo";
			button_CanBo.Size = new Size(286, 68);
			button_CanBo.TabIndex = 1;
			button_CanBo.Text = "Giảng viên";
			button_CanBo.UseVisualStyleBackColor = true;
			button_CanBo.Click += button_CanBo_Click;
			// 
			// button_LichThi
			// 
			button_LichThi.FlatAppearance.BorderSize = 0;
			button_LichThi.FlatStyle = FlatStyle.Flat;
			button_LichThi.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button_LichThi.ForeColor = Color.White;
			button_LichThi.Location = new Point(0, 404);
			button_LichThi.Margin = new Padding(3, 4, 3, 4);
			button_LichThi.Name = "button_LichThi";
			button_LichThi.Size = new Size(286, 68);
			button_LichThi.TabIndex = 2;
			button_LichThi.Text = "Lịch Thi";
			button_LichThi.UseVisualStyleBackColor = true;
			button_LichThi.Click += button_LichThi_Click;
			// 
			// button_DiemSo
			// 
			button_DiemSo.FlatAppearance.BorderSize = 0;
			button_DiemSo.FlatStyle = FlatStyle.Flat;
			button_DiemSo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button_DiemSo.ForeColor = Color.White;
			button_DiemSo.Location = new Point(0, 479);
			button_DiemSo.Margin = new Padding(3, 4, 3, 4);
			button_DiemSo.Name = "button_DiemSo";
			button_DiemSo.Size = new Size(286, 68);
			button_DiemSo.TabIndex = 3;
			button_DiemSo.Text = "Điểm số";
			button_DiemSo.UseVisualStyleBackColor = true;
			button_DiemSo.Click += button_DiemSo_Click;
			// 
			// button_HocPhan
			// 
			button_HocPhan.FlatAppearance.BorderSize = 0;
			button_HocPhan.FlatStyle = FlatStyle.Flat;
			button_HocPhan.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			button_HocPhan.ForeColor = Color.White;
			button_HocPhan.Location = new Point(0, 252);
			button_HocPhan.Margin = new Padding(3, 4, 3, 4);
			button_HocPhan.Name = "button_HocPhan";
			button_HocPhan.Size = new Size(286, 68);
			button_HocPhan.TabIndex = 4;
			button_HocPhan.Text = "Học Phần";
			button_HocPhan.UseVisualStyleBackColor = true;
			button_HocPhan.Click += button_HocPhan_Click;
			// 
			// panel_Menu
			// 
			panel_Menu.BackColor = SystemColors.HotTrack;
			panel_Menu.Controls.Add(pictureBox_Logo);
			panel_Menu.Controls.Add(button_DangXuat);
			panel_Menu.Controls.Add(button_HocPhan);
			panel_Menu.Controls.Add(button_DiemSo);
			panel_Menu.Controls.Add(button_LichThi);
			panel_Menu.Controls.Add(button_CanBo);
			panel_Menu.Controls.Add(button_SinhVien);
			panel_Menu.Dock = DockStyle.Left;
			panel_Menu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			panel_Menu.Location = new Point(0, 0);
			panel_Menu.Margin = new Padding(3, 4, 3, 4);
			panel_Menu.Name = "panel_Menu";
			panel_Menu.Size = new Size(286, 874);
			panel_Menu.TabIndex = 3;
			// 
			// pictureBox_Logo
			// 
			pictureBox_Logo.BackColor = SystemColors.HotTrack;
			pictureBox_Logo.BackgroundImage = Properties.Resources.Logo_HCMUE_2023_svg;
			pictureBox_Logo.BackgroundImageLayout = ImageLayout.Zoom;
			pictureBox_Logo.Location = new Point(0, 0);
			pictureBox_Logo.Name = "pictureBox_Logo";
			pictureBox_Logo.Size = new Size(286, 111);
			pictureBox_Logo.TabIndex = 6;
			pictureBox_Logo.TabStop = false;
			pictureBox_Logo.Click += pictureBox1_Click;
			// 
			// button_DangXuat
			// 
			button_DangXuat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			button_DangXuat.FlatStyle = FlatStyle.Flat;
			button_DangXuat.ForeColor = Color.White;
			button_DangXuat.Image = Properties.Resources.dangxuat;
			button_DangXuat.ImageAlign = ContentAlignment.MiddleLeft;
			button_DangXuat.Location = new Point(59, 794);
			button_DangXuat.Margin = new Padding(3, 4, 3, 4);
			button_DangXuat.Name = "button_DangXuat";
			button_DangXuat.Size = new Size(162, 65);
			button_DangXuat.TabIndex = 5;
			button_DangXuat.Text = "Đăng Xuất";
			button_DangXuat.TextAlign = ContentAlignment.MiddleRight;
			button_DangXuat.UseVisualStyleBackColor = true;
			button_DangXuat.Click += button_DangXuat_Click;
			// 
			// panel_Header
			// 
			panel_Header.BackColor = SystemColors.Highlight;
			panel_Header.Controls.Add(label_TieuDe);
			panel_Header.Dock = DockStyle.Top;
			panel_Header.Location = new Point(286, 0);
			panel_Header.Name = "panel_Header";
			panel_Header.Size = new Size(1061, 64);
			panel_Header.TabIndex = 4;
			// 
			// label_TieuDe
			// 
			label_TieuDe.AutoSize = true;
			label_TieuDe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label_TieuDe.ForeColor = Color.White;
			label_TieuDe.Location = new Point(76, 16);
			label_TieuDe.Name = "label_TieuDe";
			label_TieuDe.Size = new Size(122, 31);
			label_TieuDe.TabIndex = 0;
			label_TieuDe.Text = "Trang Chủ";
			// 
			// panel_Body
			// 
			panel_Body.Dock = DockStyle.Fill;
			panel_Body.Location = new Point(286, 64);
			panel_Body.Name = "panel_Body";
			panel_Body.Size = new Size(1061, 810);
			panel_Body.TabIndex = 5;
			// 
			// FTrangChu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1347, 874);
			Controls.Add(panel_Body);
			Controls.Add(panel_Header);
			Controls.Add(panel_Menu);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FTrangChu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FSinhViencs";
			panel_Menu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox_Logo).EndInit();
			panel_Header.ResumeLayout(false);
			panel_Header.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Button button_SinhVien;
		private Button button_CanBo;
		private Button button_LichThi;
		private Button button_DiemSo;
		private Button button_HocPhan;
		private Button button_DangXuat;
		private Panel panel_Menu;
		private PictureBox pictureBox_Logo;
		private Panel panel_Header;
		private Label label_TieuDe;
		private Panel panel_Body;
	}
}