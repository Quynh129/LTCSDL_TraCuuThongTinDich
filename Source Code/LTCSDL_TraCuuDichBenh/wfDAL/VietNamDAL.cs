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
        public DataTable loadThongTinVN()
        {
            string sqlString = @"select MaTP, TenTP, NhiemTong, NhiemMoi, TuTong, TuMoi, MaNV from VietNam";
            return GetData(sqlString);
        }
        public DataTable loadThongTinVN_TiemChung()
        {
            string sqlString = @"select MaTP, TenTP, TiemMot, TiemDu, MaNV from VietNam";
            return GetData(sqlString);
        }
        public DataTable loadTTVN()
        {
            string sqlString = @"select MaTP, TenTP, NhiemTong,  TuTong, TiemMot, TiemDu  from VietNam";
            return GetData(sqlString);
        }
    }
}
