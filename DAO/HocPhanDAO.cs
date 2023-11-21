using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HocPhanBUS
    {
        private static HocPhanBUS instance;

        public static HocPhanBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HocPhanBUS();
                }
                return instance;
            }
        }

        private HocPhanBUS()
        {
        }

        public DataTable getAllHocPhan()
        {
            
            string query = "SELECT H.MaHP, MH.MaMH, MH.TenMH, H.HocKy, H.Nam " + "FROM HOCPHAN H " + "JOIN MONHOC MH ON H.MaMH = MH.MaMH";

            
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
