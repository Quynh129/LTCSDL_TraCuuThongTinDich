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
        public bool Insert(NhanVienDTO nv)
        {
            if (GetData("select* from NhanVien where MaV = '" + nv.MaNv + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into NhanVien values('{0}','{1}','{2}',')",
              nv.MaNv, nv.TenUser, nv.Password);

            Excute(sql);
            return true;
        }
        public void Delete(string MaNV)
        {
            Excute("delete from NhanVien where MaNv = '" + MaNV + "'");
        }

        public void Update(NhanVienDTO nv)
        {
            string sql = string.Format("update NhanVien set TenUser = N'{0}', Password = N'{1}' where MaNv = '{2}'",
               nv.TenUser, nv.Password, nv.MaNv);
            Excute(sql);
        }
    }
}
