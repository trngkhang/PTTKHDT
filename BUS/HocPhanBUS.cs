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
        public HocPhanBUS()
        {
        }

        public DataTable getAllHocPhan() => DAO.HocPhanDAO.Instance.getAllHocPhan();
    }
}
