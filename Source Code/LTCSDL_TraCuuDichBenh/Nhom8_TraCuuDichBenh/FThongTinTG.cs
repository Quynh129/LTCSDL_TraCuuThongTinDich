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
    public partial class FThongTinTG : Form
    {
        private FTrangChu fHome;
        public FThongTinTG(FTrangChu _fHome)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
        }

        private void FThongTinTG_Load(object sender, EventArgs e)
        {

        }

        #region Các button chuyển form
        private void btTrangChu_Click(object sender, EventArgs e)
        {
            fHome.Show();
            this.Close();
        }

        private void btVietNam_Click(object sender, EventArgs e)
        {
            FThongTinVN fTG = new FThongTinVN(fHome);
            fTG.Show();
            this.Close();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            FDangNhap fTG = new FDangNhap(fHome);
            fTG.Show();
            this.Close();
        }
        #endregion

    }
}
