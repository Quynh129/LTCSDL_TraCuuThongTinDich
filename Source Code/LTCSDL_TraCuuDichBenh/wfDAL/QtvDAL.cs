using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using wfDTO;

namespace wfDAL
{
    public class QtvDAL : ConnectData
    {
        public DataTable loadThongTinQtv()
        {
            string sqlString = @"select * from Qtv";
            return GetData(sqlString);
        }
        public bool login(string _tk, string _mk)
        {
            if (GetData("select* from Qtv where TenUser = '" + _tk + "' and Password = '" + _mk + "'").Rows.Count > 0)
                return true;
            return false;
        }
        public bool checkExist(string _maAd)
        {
            if (GetData("select* from Qtv where MaAdmin = '" + _maAd + "'").Rows.Count > 0)
                return true;
            return false;
        }
    }
}
