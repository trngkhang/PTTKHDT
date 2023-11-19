using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class SinhVienBUS
	{
		private static SinhVienBUS instance;
		public static SinhVienBUS Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new SinhVienBUS();
				}
				return instance;
			}

		}

		public SinhVienBUS()
		{

		}
		public DataTable getAllSinhVien()
		{
			return DAO.SinhVienDAO.Instance.getAllSinhVien();
		}
		public bool themSinhVien(String masv, String tensv, String makhoa)
		{
			return DAO.SinhVienDAO.Instance.themSinhVien(masv, tensv, makhoa);
		}
		public bool kiemTraDaCoSinhVien(String masv)
		{
			return DAO.SinhVienDAO.Instance.kiemTraDaCoSinhVien(masv);
		}
		public bool xoaSinhVien(String masv)
		{
			return DAO.SinhVienDAO.Instance.xoaSinhVien(masv);
		}
		public bool suaSinhVien(String masv, String tensv, String makhoa)
		{
			return DAO.SinhVienDAO.Instance.suaSinhVien(masv, tensv, makhoa);
		}
	}
}
