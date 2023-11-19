using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class TaiKhoanBUS
	{
		private static TaiKhoanBUS instance;
		public static TaiKhoanBUS Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new TaiKhoanBUS();
				}
				return instance;
			}

		}

		public TaiKhoanBUS()
		{

		}

		public TaiKhoan DangNhap(String tk, String mk)
		{
			return DAO.TaiKhoanDAO.Instance.DangNhap(tk, mk);
		}
	}
}
