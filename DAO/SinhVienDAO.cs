using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
	public class SinhVienDAO
	{

		private static SinhVienDAO instance;

		public static SinhVienDAO Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new SinhVienDAO();
				}
				return instance;
			}

		}

		private SinhVienDAO()
		{
		}

		public DataTable getAllSinhVien()
		{
			return DataProvider.Instance.ExecuteQuery("SELECT * FROM SINHVIEN");
		}
		public bool themSinhVien(String masv, String tensv, String makhoa)
		{
			String query = string.Format("INSERT INTO SINHVIEN VALUES('{0}', '{1}', '{2}')", masv, tensv, makhoa);
			MessageBox.Show(query);
			return DataProvider.Instance.ExecuteNonQuery(query) > 0;
		}
		public bool kiemTraDaCoSinhVien(String masv)
		{
			String query = "SELECT * FROM SINHVIEN WHERE MaSV = @masv";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { masv });

			if (data.Rows.Count == 0)
			{
				return false;
			}

			return true; // return an object SinhVien if exists in database
		}

		public bool xoaSinhVien(String masv)
		{
			String query = string.Format("DELETE FROM SINHVIEN WHERE MaSV='{0}'", masv);
			return DataProvider.Instance.ExecuteNonQuery(query) > 0;
		}
		public bool suaSinhVien(String masv, String tensv, String makhoa)
		{
			String query = string.Format("UPDATE SINHVIEN SET TenSV='{0}', MaKhoa='{1}' WHERE MaSV='{2}'", tensv, makhoa, masv);
			return DataProvider.Instance.ExecuteNonQuery(query) > 0;
		}
	}
}
