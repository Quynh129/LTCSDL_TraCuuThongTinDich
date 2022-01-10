using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfBLL;
using wfDTO;

namespace Nhom8_TraCuuDichBenh
{
    public partial class FQlyThanhVien : Form
    {
        NhanVienBLL nv_bll = new NhanVienBLL();
        QtvBLL qtv_bll = new QtvBLL();

        private FTrangChu fHome;
        public FQlyThanhVien(FTrangChu _fHome)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
        }

        private void FQlyThanhVien_Load(object sender, EventArgs e)
        {
            #region Định nghĩa 
            grdDsachTaiKhoan.Columns[0].Width = (int)(grdDsachTaiKhoan.Width * 0.2);
            grdDsachTaiKhoan.Columns[1].Width = (int)(grdDsachTaiKhoan.Width * 0.3);
            grdDsachTaiKhoan.Columns[2].Width = (int)(grdDsachTaiKhoan.Width * 0.3);
            grdDsachTaiKhoan.Columns[3].Width = (int)(grdDsachTaiKhoan.Width * 0.2);
            #endregion
            grdDsachTaiKhoan.DataSource = nv_bll.GetList();
        }

        #region Các button chuyển form
        private void btDangXuat_Click(object sender, EventArgs e)
        {
            fHome.Show();
            this.Close();
        }
        #endregion

    }
}
