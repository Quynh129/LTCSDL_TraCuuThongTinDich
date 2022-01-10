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
    public partial class FDsChucNang : Form
    {
        private FTrangChu fHome;
        public FDsChucNang(FTrangChu _fHome)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
        }

        private void FDsChucNang_Load(object sender, EventArgs e)
        {

        }

        #region Các button chuyển form
        private void btDangXuat_Click(object sender, EventArgs e)
        {
            fHome.Show();
            this.Close();
        }

        private void btUpTheGioi_Click(object sender, EventArgs e)
        {
            FCapNhatTG fUpTG = new FCapNhatTG();
            fUpTG.Show();
            this.Close();
        }

        private void btUpVietNam_Click(object sender, EventArgs e)
        {
            FCapNhatVN fUpVN = new FCapNhatVN();
            fUpVN.Show();
            this.Close();
        }

        private void btUpVN1_Click(object sender, EventArgs e)
        {
            FCapNhatVN1 fUpVN1 = new FCapNhatVN1();
            fUpVN1.Show();
            this.Close();
        }
        #endregion

        private void FDsChucNang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
