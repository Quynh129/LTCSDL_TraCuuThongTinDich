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
    public partial class FQlyThanhVien : Form
    {
        private FTrangChu fHome;
        public FQlyThanhVien(FTrangChu _fHome)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
        }

        private void FQlyThanhVien_Load(object sender, EventArgs e)
        {

        }

        #region Các button chuyển form
        private void btDangXuat_Click(object sender, EventArgs e)
        {
            fHome.Show();
            this.Close();
        }
        #endregion

        private void FQlyThanhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
