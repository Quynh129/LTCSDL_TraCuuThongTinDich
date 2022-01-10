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
    public partial class FThongTinVN : Form
    {
        private FTrangChu fHome;
        public FThongTinVN(FTrangChu _fHome)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
        }

        private void FThongTinVN_Load(object sender, EventArgs e)
        {

        }

        #region Các button chuyển form
        private void btTrangChu_Click(object sender, EventArgs e)
        {
            fHome.Show();
            this.Close();
        }

        private void btTheGioi_Click(object sender, EventArgs e)
        {
            FThongTinTG fTG = new FThongTinTG(fHome);
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

        private void FThongTinVN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
