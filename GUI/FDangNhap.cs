using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class FDangNhap : Form
	{
		public FDangNhap()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String tk = textBox_TaiKhoan.Text.ToString();
			String mk = textBox_MatKhau.Text.ToString();
			TaiKhoan nv = null;
			nv = TaiKhoanBUS.Instance.DangNhap(tk, mk);
			if (nv != null)
			{
				FTrangChu f;
				f = new FTrangChu();
				f.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
			}
		}

		private void button_Thoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
