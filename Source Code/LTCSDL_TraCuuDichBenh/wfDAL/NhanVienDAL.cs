using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using wfDTO;

namespace wfDAL
{
    public class NhanVienDAL : ConnectData
    {
        public DataTable loadThongTinNV()
        {
            string sqlString = @"select * from NhanVien";
            return GetData(sqlString);
        }
        public bool login(string _tk, string _mk)
        {
            if (GetData("select* from NhanVien where TenUser = '" + _tk + "' and Password = '" + _mk + "'").Rows.Count > 0)
                return true;
            return false;
        }
    }
}
