using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using wfDTO;

namespace wfDAL
{
    public class VietNamDAL : ConnectData
    {
        #region FThongTinVN
        public DataTable loadThongTinVN()
        {
            string sqlString = @"select MaTP, TenTP, NhiemTong, NhiemMoi, TuTong, TuMoi, TiemMot, TiemDu from VietNam where MaTP NOT IN ('00')";
            return GetData(sqlString);
        }
        public DataTable SearchVN(string _tp)
        {
            string sqlString = string.Format("select MaTP, TenTP, NhiemTong, NhiemMoi, TuTong, TuMoi, TiemMot, TiemDu from VietNam where MaTP NOT IN ('00') and TenTP like N'%{0}%'", _tp);
            return GetData(sqlString);
        }
        #endregion

        #region FCapNhatVN
        public DataTable loadThongTinVN_Up()
        {
            string sqlString = @"select MaTP, TenTP, NhiemTong, NhiemMoi, TuTong, TuMoi, MaNV from VietNam where MaTP NOT IN ('00')";
            return GetData(sqlString);
        }
        public DataTable SearchVN_Up(string _tp)
        {
            string sqlString = string.Format("select MaTP, TenTP, NhiemTong, NhiemMoi, TuTong, TuMoi, MaNV from VietNam where MaTP NOT IN ('00') and TenTP like N'%{0}%'", _tp);
            return GetData(sqlString);
        }
        public void UpdateVN(VietNamDTO VN)
        {
            string sql = string.Format("update VietNam set NhiemTong = '{0}', NhiemMoi = '{1}', TuTong = '{2}', TuMoi = '{3}', MaNV = '{4}' where MaTp = '{5}'",
                 VN.NhiemTong, VN.NhiemMoi, VN.TuTong, VN.TuMoi, VN.MaNv, VN.MaTp);
            Excute(sql);
        }
        #endregion


        #region FCapNhatVN1
        public DataTable loadThongTinVN_TiemChung()
        {
            string sqlString = @"select MaTP, TenTP, TiemMot, TiemDu, MaNV from VietNam where MaTP NOT IN ('00')";
            return GetData(sqlString);
        }
        public DataTable SearchVN_TiemChung(string _tp)
        {
            string sqlString = string.Format("select MaTP, TenTP, TiemMot, TiemDu, MaNV from VietNam where MaTP NOT IN ('00') and TenTP like N'%{0}%'", _tp);
            return GetData(sqlString);
        }
        public void UpdateVN1(VietNamDTO VN)
        {
            string sql = string.Format("update VietNam set TiemMot = '{0}', TiemDu = '{1}',  MaNV = '{2}' where MaTp = '{3}'",
                 VN.TiemMot, VN.TiemDu, VN.MaNv, VN.MaTp);
            Excute(sql);
        }
        #endregion

        #region FThongKe
        public DataTable loadThongTinVN_Top(int _top, string _thongKe)
        {
            string sqlString = string.Format("select TOP {0} MaTP, TenTP, NhiemTong, NhiemMoi, TuTong, TuMoi, TiemMot, TiemDu from VietNam where MaTP NOT IN ('00') ORDER BY {1} DESC;", _top, _thongKe);
            return GetData(sqlString);
        }
        #endregion

    }
}
