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
    public partial class FCapNhatTG : Form
    {
        public FCapNhatTG()
        {
            InitializeComponent();
        }

        private void FCapNhatTG_Load(object sender, EventArgs e)
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

        private void FCapNhatTG_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
