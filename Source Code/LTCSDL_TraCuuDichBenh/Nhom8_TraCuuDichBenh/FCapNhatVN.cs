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
    public partial class FCapNhatVN : Form
    {
        public FCapNhatVN()
        {
            InitializeComponent();
        }

        private void FCapNhatVN_Load(object sender, EventArgs e)
        {

        }

        #region Các button chuyển form
        private void btQuayLai_Click(object sender, EventArgs e)
        {
            FTrangChu fHome = new FTrangChu();
            FDsChucNang fDs = new FDsChucNang(fHome);
            fDs.Show();
            this.Close();
        }
        #endregion

        private void FCapNhatVN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
