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
    public class TheGioiBLL
    {
        TheGioiDAL TG_dal = new TheGioiDAL();
        public DataTable GetList()
        {
            return TG_dal.loadThongTinTG();
        }
        public DataTable GetListInfoTG()
        {
            return TG_dal.loadTTTG();
        }
        public DataTable GetListUp()
        {
            return TG_dal.loadThongTinTG_Up();
        }
        public bool CapNhat(TheGioiDTO _tg)
        {
            if (string.IsNullOrEmpty(_tg.MaQg))
                return false;
            TG_dal.Update(_tg);
            return true;
        }
    }
}
