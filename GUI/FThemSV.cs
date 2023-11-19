using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace GUI
{
	public partial class FThemSV : Form
	{
		private bool isSua;
		private string masv;
		private string tensv;
		private string makhoa;
		private FSinhVien fSV;
		public FThemSV()
		{
			InitializeComponent();
		}
		public void loadFThemSV()
		{
			textBox_MaSV.Text = this.masv;
			textBox_TenSV.Text = this.tensv;
			textBox_MaKhoa.Text = this.makhoa;
		}
		public FThemSV(FSinhVien fSV, bool isSua, string masv = "", string tensv = "", string makhoa = "")
		{
			InitializeComponent();
			this.isSua = isSua;
			this.masv=masv;
			this.tensv=tensv;
			this.makhoa = makhoa;
			this.fSV = fSV;
			loadFThemSV();
		}

		private void button_Huy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button_Luu_Click(object sender, EventArgs e)
		{
			string masv = textBox_MaSV.Text.ToString();
			string tensv = textBox_TenSV.Text.ToString();
			string makhoa = textBox_MaKhoa.Text.ToString();
			if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(tensv) || string.IsNullOrEmpty(makhoa))
			{
				MessageBox.Show("Chưa nhập đủ thông tin sinh viên!");
				return;
			}
			
			if (this.isSua)//Sửa tt sv
			{
				bool checkUpdate = BUS.SinhVienBUS.Instance.suaSinhVien(masv, tensv, makhoa);
				if (checkUpdate)
				{
					MessageBox.Show("Thay đổi thông tin sinh viên thành công", "Thành công");
					fSV.FSinhVienLoad();
					this.Close();
				}
				else
				{
					MessageBox.Show("Thay đổi thông tin sinh viên thất bại", "Thất bại");
				}
			}
			else //them sv
			{
				bool check = BUS.SinhVienBUS.Instance.kiemTraDaCoSinhVien(masv);
				if (check) // da ton tai masv
				{
					MessageBox.Show("Đã tồn tại mã số sinh viên này!" + masv.ToString());
					return;
				}
				else //chua ton tai masv
				{
					bool checkInsert = BUS.SinhVienBUS.Instance.themSinhVien(masv, tensv, makhoa);
					if (checkInsert)
					{
						MessageBox.Show("Thêm sinh viên thành công", "Thành công");
						fSV.FSinhVienLoad();
						this.Close();
					}
					else
					{
						MessageBox.Show("Thêm sinh viên thất bại", "Thất bại");
					}
				}
			}
		}
	}
}
