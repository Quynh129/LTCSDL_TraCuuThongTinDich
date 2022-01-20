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
using wfDAL;

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

        private void grdDsachTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            Random rmd = new Random();
            nv.MaNv = rmd.Next(0, 1000);
            nv.TenUser = txtTenTK.Text;
            nv.Password = txtMK.Text;
            nv_bll.Them(nv);
            FQlyThanhVien_Load(sender, e);

            ResetGridview();

        }


        private void ResetGridview()
        {
            txtMaTK.ResetText();
            txtTenTK.ResetText();
            txtMK.ResetText();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNv = int.Parse(txtMaTK.Text);
            nv.TenUser = txtTenTK.Text;
            nv.TenUser = txtMK.Text;
            nv_bll.Sua(nv);
            FQlyThanhVien_Load(sender, e);
            ResetGridview();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTK.Text != "")
            {
                nv_bll.Xoa(txtMaTK.Text);
                ResetGridview();
                FQlyThanhVien_Load(sender, e);

            }
        }
    }
}
