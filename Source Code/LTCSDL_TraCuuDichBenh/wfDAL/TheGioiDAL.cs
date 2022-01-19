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
        public DataTable loadThongTinTG()
        {
            string sqlString = @" select MaQG, TenQG, TGNhiemTong,
                                           isnull(TGNhiemMoi, 0) as TGNhiemMoi,
                                           isnull(TGTuTong, 0) as TGTuTong,
                                           isnull(TGTuMoi, 0) as TGTuMoi,
                                           TGKhoiTong,
                                           MaNV from TheGioi";
            return GetData(sqlString);
        }
        public void Update(TheGioiDTO _tg)
        {
            string sql = string.Format("update TheGioi set TgnhiemTong='{0}', TGNhiemMoi = '{1}', TgtuTong='{2}' , TGTuMoi = '{3}' , TGKhoiTong = '{4}' where MaQG = '{5}' ",
               _tg.TgnhiemTong, _tg.TgnhiemMoi, _tg.TgtuTong, _tg.TgtuMoi, _tg.TgkhoiTong, _tg.MaQg);
            Excute(sql);
        }
    }
    
}
