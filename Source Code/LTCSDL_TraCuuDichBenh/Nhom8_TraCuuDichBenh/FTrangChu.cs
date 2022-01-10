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
    public partial class FTrangChu : Form
    {
        public FTrangChu()
        {
            InitializeComponent();
        }

        private void FTrangChu_Load(object sender, EventArgs e)
        {
            
        }

        #region Các button chuyển form
        private void btTheGioi_Click(object sender, EventArgs e)
        {
            FThongTinTG fTG = new FThongTinTG(this);
            fTG.Show();
            this.Hide();
        }

        private void btVietNam_Click(object sender, EventArgs e)
        {
            FThongTinVN fTG = new FThongTinVN(this);
            fTG.Show();
            this.Hide();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            FDangNhap fTG = new FDangNhap(this);
            fTG.Show();
            this.Hide();
        }
        #endregion

        private void FTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
