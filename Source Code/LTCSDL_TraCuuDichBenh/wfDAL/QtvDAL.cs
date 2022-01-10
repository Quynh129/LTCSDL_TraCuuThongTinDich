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
    }
}
