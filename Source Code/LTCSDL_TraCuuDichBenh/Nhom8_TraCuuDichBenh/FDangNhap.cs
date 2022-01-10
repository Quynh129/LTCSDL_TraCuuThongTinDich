using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom8_TraCuuDichBenh
{
    public partial class FDangNhap : Form
    {
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
            if (txtTDN.Text == "admin1" && txtMK.Text == "12345")
                fQlyTK.Show();
            else if (txtTDN.Text == "Quynh" && txtMK.Text == "12345")
                fDs.Show();

            this.Close();

        }
        #endregion

    }
}
