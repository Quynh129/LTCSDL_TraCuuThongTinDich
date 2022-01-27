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

        //sd cho FThongTinVN
        #region FThongTinVN
        public DataTable GetListInfoVN()
        {
            return VN_dal.loadThongTinVN();
        }
        public DataTable TimKiemVN(string _tp)
        {
            return VN_dal.SearchVN(_tp);
        }
        #endregion

        //sd cho FCapNhatVN
        #region FCapNhatVN
        public DataTable GetListVN_Up()
        {
            return VN_dal.loadThongTinVN_Up();
        }
        public DataTable TimKiemVN_Up(string _tp)
        {
            return VN_dal.SearchVN_Up(_tp);
        }
        public bool CapNhatVN(VietNamDTO VN)
        {
            if (string.IsNullOrEmpty(VN.MaTp))
                return false;
            VN_dal.UpdateVN(VN);
            return true;
        }
        #endregion


        #region FCapNhatVN1
        public DataTable GetList_TiemChung()
        {
            return VN_dal.loadThongTinVN_TiemChung();
        }
        public DataTable TimKiemVN_TiemChung(string _tp)
        {
            return VN_dal.SearchVN_TiemChung(_tp);
        }
        public bool CapNhatVN1(VietNamDTO VN)
        {
            if (string.IsNullOrEmpty(VN.MaTp))
                return false;
            VN_dal.UpdateVN1(VN);
            return true;
        }
        #endregion

        #region FThongKe
        public DataTable GetListVN_Top(int _top, string _thongKe)
        {
            return VN_dal.loadThongTinVN_Top(_top, _thongKe);
        }
        #endregion
    }
}
