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
    public class TheGioiBLL
    {
       
        TheGioiDAL TG_dal = new TheGioiDAL();
        public DataTable GetList()
        {
           return TG_dal.loadThongTinTG();
        }
        public DataTable GetListInfoTG()
        {
           return TG_dal.loadTTTG();
        }
        
      
    }
}
