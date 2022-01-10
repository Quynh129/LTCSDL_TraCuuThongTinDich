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
    public class VietNamBLL
    {
        VietNamDAL VN_dal = new VietNamDAL();
        public DataTable GetList()
        {
            return VN_dal.loadThongTinVN();
        }
        public DataTable GetList_TiemChung()
        {
            return VN_dal.loadThongTinVN_TiemChung();
        }
    }
}
