using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HocPhanDAO
    {
        private static HocPhanDAO instance;

        public static HocPhanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HocPhanDAO();
                }
                return instance;
            }

        }

        private HocPhanDAO()
        {
        }

        public DataTable getAllGiangVien()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM CANBO");
        }
    }
}
