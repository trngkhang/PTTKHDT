using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class FTrangChu : Form
	{
		public FTrangChu()
		{
			InitializeComponent();
			// Đặt kích thước của Form bằng kích thước của màn hình
			this.Size = Screen.PrimaryScreen.WorkingArea.Size;
		}
		private Form currentFormChild;
		private void OpenChildForm(Form childForm, Button button)
		{
			if (currentFormChild != null)
			{
				currentFormChild.Close();
			}
			currentFormChild = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panel_Body.Controls.Add(childForm);
			panel_Body.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			label_TieuDe.Text = ("Quản Lý " + button.Text).ToUpperInvariant();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (currentFormChild != null)
			{
				currentFormChild.Close();
			}
			label_TieuDe.Text = "TRANG CHỦ";
		}

		private void button_SinhVien_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FSinhVien(), button_SinhVien);
		}

		private void button_HocPhan_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FHocPhan(), button_HocPhan);
		}

		private void button_CanBo_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FGiangVien(), button_CanBo);

		}

		private void button_DiemSo_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FDiemSo(), button_DiemSo);
		}

		private void button_LichThi_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FLichThi(), button_LichThi);
		}

		private void button_DangXuat_Click(object sender, EventArgs e)
		{
			FDangNhap fDangNhap = new FDangNhap();
			fDangNhap.Show();
			this.Hide();
		}
	}
}
