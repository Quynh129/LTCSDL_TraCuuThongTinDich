using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using wfDTO;

namespace wfDAL
{
    public class TheGioiDAL : ConnectData
    {
        //sd cho FThongTinTG
        #region FThongTinTG
        public DataTable loadThongTinTG()
        {
            string sqlString = @"select MaQG, TenQG, TGNhiemTong,
                                           isnull(TGNhiemMoi, 0) as TGNhiemMoi,
                                           isnull(TGTuTong, 0) as TGTuTong,
                                           isnull(TGTuMoi, 0) as TGTuMoi,
                                           TGKhoiTong from TheGioi where MaQG NOT IN ('QG00')";
            return GetData(sqlString);
        }
        public DataTable SearchTG(string _tp)
        {
            string sqlString = string.Format("select MaQG, TenQG, TGNhiemTong, isnull(TGNhiemMoi, 0) as TGNhiemMoi, isnull(TGTuTong, 0) as TGTuTong, isnull(TGTuMoi, 0) as TGTuMoi, TGKhoiTong from TheGioi where MaQG NOT IN ('QG00') and TenQG like N'%{0}%'", _tp);
            return GetData(sqlString);
        }
        #endregion

        //sd cho FCapNhatTG
        #region FCapNhatTG
        public DataTable loadThongTinTG_Up()
        {
            string sqlString = @" select MaQG, TenQG, TGNhiemTong,
                                           isnull(TGNhiemMoi, 0) as TGNhiemMoi,
                                           isnull(TGTuTong, 0) as TGTuTong,
                                           isnull(TGTuMoi, 0) as TGTuMoi,
                                           TGKhoiTong,
                                           MaNV from TheGioi where MaQG NOT IN ('QG00')";
            return GetData(sqlString);
        }
        public DataTable SearchTG_Up(string _tp)
        {
            string sqlString = string.Format("select MaQG, TenQG, TGNhiemTong, isnull(TGNhiemMoi, 0) as TGNhiemMoi, isnull(TGTuTong, 0) as TGTuTong, isnull(TGTuMoi, 0) as TGTuMoi, TGKhoiTong, MaNV from TheGioi where MaQG NOT IN ('QG00') and TenQG like N'%{0}%'", _tp);
            return GetData(sqlString);
        }
        public void UpdateTG(TheGioiDTO _tg)
        {
            string sql = string.Format("update TheGioi set TgnhiemTong='{0}', TGNhiemMoi = '{1}', TgtuTong='{2}' , TGTuMoi = '{3}' , TGKhoiTong = '{4}', MaNV = '{5}' where MaQG = '{6}' ",
               _tg.TgnhiemTong, _tg.TgnhiemMoi, _tg.TgtuTong, _tg.TgtuMoi, _tg.TgkhoiTong, _tg.MaNv, _tg.MaQg);
            Excute(sql);
        }

        #endregion

        #region FThongKe
        public DataTable loadThongTinTG_Top(int _top, string _thongKe)
        {
            string sqlString = string.Format("select TOP ({0}) MaQG, TenQG, TGNhiemTong, isnull(TGNhiemMoi, 0) as TGNhiemMoi, isnull(TGTuTong, 0) as TGTuTong, isnull(TGTuMoi, 0) as TGTuMoi, TGKhoiTong from TheGioi where MaQG NOT IN ('QG00') ORDER BY {1} DESC;", _top, _thongKe);
            return GetData(sqlString);
        }
        #endregion
    }
}
