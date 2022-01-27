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
            string sqlString = @"select MaNV, TenUser, Password, MaAdmin from NhanVien where TonTai = 1";
            return GetData(sqlString);
        }
        public bool login(string _tk, string _mk)
        {
            if (GetData("select* from NhanVien where TenUser = '" + _tk + "' and Password = '" + _mk + "' and TonTai = 1").Rows.Count > 0)
                return true;
            return false;
        }

        public bool Insert(NhanVienDTO nv)
        {
            if (GetData("select* from NhanVien where MaNv = '" + nv.MaNv + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into NhanVien values('{0}','{1}','{2}','{3}', '{4}')",
              nv.MaNv, nv.TenUser, nv.Password, nv.TonTai, nv.MaAdmin);

            Excute(sql);
            return true;
        }

        public void Delete(string MaNV)
        {
            //Excute("delete from NhanVien where MaNv = '" + MaNV + "'"); 
            //sẽ không xóa tài khoản khỏi database mà cài quyền về là 0 (không tồn tại)
            string sql = string.Format("update NhanVien set TonTai = 0 where MaNv = '" + MaNV + "'");
            Excute(sql);
        }

        public void Update(NhanVienDTO nv)
        {
            string sql = string.Format("update NhanVien set TenUser = '{0}', Password = '{1}', MaAdmin = '{2}' where MaNv = '{3}'",
               nv.TenUser, nv.Password, nv.MaAdmin , nv.MaNv);
            Excute(sql);
        }
    }
}
