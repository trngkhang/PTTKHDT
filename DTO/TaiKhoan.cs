using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class TaiKhoan
	{
		private string taikhoan;
		private string matkhau;

		public string Taikhoan
		{
			get { return taikhoan; }
			set { taikhoan = value; }
		}
		public string Matkhau { 
			get { return matkhau; }
			set { matkhau = value; }
		}

		public TaiKhoan(string taikhoan, string matkhau)
		{
			this.taikhoan = taikhoan;
			this.matkhau = matkhau;
		}
		public TaiKhoan(DataRow row)
		{
			this.taikhoan = row["TaiKhoan"].ToString();
			this.matkhau = row["MatKhau"].ToString();
		}
	}
}
