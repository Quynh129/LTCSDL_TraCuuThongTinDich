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

        //sd cho FThongTinTG
        #region FThongTinTG
        public DataTable GetListInfoTG()
        {
            return TG_dal.loadThongTinTG();
        }
        public DataTable TimKiemTG(string _tp)
        {
            return TG_dal.SearchTG(_tp);
        }
        #endregion

        //sd co FCapNhatTG
        #region FCapNhatTG
        public DataTable GetListTG_Up()
        {
            return TG_dal.loadThongTinTG_Up();
        }
        public DataTable TimKiemTG_Up(string _tp)
        {
            return TG_dal.SearchTG_Up(_tp);
        }
        public bool CapNhatTG(TheGioiDTO _tg)
        {
            if (string.IsNullOrEmpty(_tg.MaQg))
                return false;
            TG_dal.UpdateTG(_tg);
            return true;
        }
        
        #endregion

        #region FThongKe
        public DataTable GetListTG_Top(int _top, string _thongKe)
        {
            return TG_dal.loadThongTinTG_Top(_top, _thongKe);
        }
        #endregion
    }
}
