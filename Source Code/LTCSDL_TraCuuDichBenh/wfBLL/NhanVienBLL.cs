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
    public class NhanVienBLL
    {
        NhanVienDAL nv_dal = new NhanVienDAL();
        public DataTable GetList()
        {
            return nv_dal.loadThongTinNV();
        }
        public bool DangNhap(string _tk, string _mk)
        {
            if (nv_dal.login(_tk, _mk) == true)
                return true; //có tài khoản
            return false;
        }
        public void Xoa(string MaNV)
        {
            nv_dal.Delete(MaNV);
        }
        public bool Sua(NhanVienDTO nv)
        {
            if (nv.MaNv != null)
                return false;
            nv_dal.Update(nv);
            return true;
        }
        public int Them(NhanVienDTO nv)
        {
            if (nv.MaNv != null)
                return 0;
            if (!nv_dal.Insert(nv))
                return -1;
            return 1;
        }
    }
}
