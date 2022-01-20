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
        public void Update(VietNamDTO VN)
        {
            string sql = string.Format("update VietNam set NhiemTong = '{0}', NhiemMoi = '{1}', TuTong = '{2}', TuMoi = '{3}' where MaTp = '{4}'",
                 VN.NhiemTong, VN.NhiemMoi, VN.TuTong, VN.TuMoi, VN.MaTp);
            Excute(sql);
        }
        public DataTable loadTTVN()
        {
            string sqlString = @"select MaTP, TenTP, NhiemTong,  TuTong, TiemMot, TiemDu  from VietNam";
            return GetData(sqlString);
        }
    }
}
