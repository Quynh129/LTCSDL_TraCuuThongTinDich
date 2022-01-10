using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using wfDTO;
using wfDAL;

namespace wfBLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nv_dal = new NhanVienDAL();
        public DataTable GetList()
        {
            return nv_dal.loadThongTinNV();
        }
    }
}
