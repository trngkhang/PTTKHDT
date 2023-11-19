using BUS;
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
	public partial class FSinhVien : Form
	{
		public FSinhVien()
		{
			InitializeComponent();
			FSinhVienLoad();
		}
		public void FSinhVienLoad()
		{
			dataGridView_DSSV.DataSource = BUS.SinhVienBUS.Instance.getAllSinhVien();
		}

		private void button_Them_Click(object sender, EventArgs e)
		{
			FThemSV fThemSV = new FThemSV(this, false);
			fThemSV.Show();
		}

		/*private void button_ThongTinChiTiet_Click(object sender, EventArgs e)
		{
			if (dataGridView_DSSV.RowCount > 0)
			{
				string masv = dataGridView_DSSV.CurrentRow.Cells["MaSV"].Value.ToString();
				string tensv = dataGridView_DSSV.CurrentRow.Cells["TenSV"].Value.ToString();
				string makhoa = dataGridView_DSSV.CurrentRow.Cells["MaKhoa"].Value.ToString();
				FThemSV f = new FThemSV(masv, tensv, makhoa);
				f.Show();
			}
		}*/

		private void button_Sua_Click(object sender, EventArgs e)
		{
			if (dataGridView_DSSV.RowCount > 0)
			{
				string masv = dataGridView_DSSV.CurrentRow.Cells["MaSV"].Value.ToString();
				string tensv = dataGridView_DSSV.CurrentRow.Cells["TenSV"].Value.ToString();
				string makhoa = dataGridView_DSSV.CurrentRow.Cells["MaKhoa"].Value.ToString();
				FThemSV f = new FThemSV(this, true, masv, tensv, makhoa);
				f.Show();
			}
		}

		private void button_Xoa_Click(object sender, EventArgs e)
		{
			if (dataGridView_DSSV.RowCount != 0)
			{
				string masv = dataGridView_DSSV.CurrentRow.Cells["MaSV"].Value.ToString();
				DialogResult res = MessageBox.Show("Xóa sinh viên này không thể hoàn tác", "Bạn có chắc là muốn xóa sinh viên: " + masv, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				if (res == DialogResult.OK)
				{
					bool check = SinhVienBUS.Instance.xoaSinhVien(masv);
					if (check)
					{
						MessageBox.Show("Xóa sinh viên thành công");
						FSinhVienLoad();
					}
					else
					{
						MessageBox.Show("Xóa sinh viên không thành công");
					}
				}
			}
			FSinhVienLoad();
		}
	}
}
