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
    public partial class FDangNhap : Form
    {
        QtvBLL qtv_bll = new QtvBLL();
        NhanVienBLL nv_bll = new NhanVienBLL();
        private FTrangChu fHome;
        public FDangNhap(FTrangChu _fHome)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {

        }

        #region Các button chuyển form
        private void btQuayLai_Click(object sender, EventArgs e)
        {
            fHome.Show();
            this.Close();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            FQlyThanhVien fQlyTK = new FQlyThanhVien(fHome);
            FDsChucNang fDs = new FDsChucNang(fHome);
            if (txtTDN.Text == "")
            {
                lbTbao.Text = "Không được để trống tên đăng nhập";
                lbTbao.Visible = true;
            }    
            else if (txtMK.Text == "")
            {
                lbTbao.Text = "Không được để trống mật khẩu";
                lbTbao.Visible = true;
            }    
            if(txtTDN.Text!="" && txtMK.Text!="")
            {
                if (qtv_bll.DangNhap(txtTDN.Text, txtMK.Text) == true)
                {
                    fQlyTK.Show();
                    this.Close();
                }
                else if (nv_bll.DangNhap(txtTDN.Text, txtMK.Text) == true)
                {
                    fDs.Show();
                    this.Close();
                }
                else 
                {
                    lbTbao.Text = "Tên đăng nhập hoặc mật khẩu sai";
                    lbTbao.Visible = true;
                }
            }


        }
        #endregion

    }
}
