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
    public class QtvBLL
    {
        QtvDAL qtv_dal = new QtvDAL();
        public DataTable GetList()
        {
            return qtv_dal.loadThongTinQtv();
        }
        public bool DangNhap(string _tk, string _mk)
        {
            if (qtv_dal.login(_tk, _mk) == true)
                return true; //có tài khoản
            return false;
        }
    }
}
