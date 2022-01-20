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
            string sqlString = @"select * from TheGioi";
            return GetData(sqlString);
        }
        public DataTable loadTTTG()
        {
            string sqlString = @"select MaQg,TenQg, TgnhiemTong,TgtuTong,TgkhoiTong from TheGioi";

            return GetData(sqlString);
        }
    }
}
