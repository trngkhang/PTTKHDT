using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiangVienBUS
    {
        private static GiangVienBUS instance; 

        public static GiangVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GiangVienBUS();
                }
                return instance;
            }
        }

        public GiangVienBUS()
        {
        }

        public DataTable getAllGiangVien()
        {
            return DAO.HocPhanDAO.Instance.getAllGiangVien();
        }
    }
}
