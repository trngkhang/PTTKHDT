using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
	public class TaiKhoanDAO
	{
		private static TaiKhoanDAO instance;
		public static TaiKhoanDAO Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new TaiKhoanDAO();
				}
				return instance;
			}
		}
		public TaiKhoanDAO() { }

		public TaiKhoan DangNhap(String tk, String mk)    // Check whether exist an account of user to login
		{
			String query = "proc_DangNhap @tk , @mk";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tk, mk });

			if (data.Rows.Count == 0)
			{
				return null;
			}

			return new TaiKhoan(data.Rows[0]);
		}
	}
}
