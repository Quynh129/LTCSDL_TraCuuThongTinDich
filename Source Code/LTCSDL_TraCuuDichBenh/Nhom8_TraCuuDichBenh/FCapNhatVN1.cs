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
    public partial class FCapNhatVN1 : Form
    {
        VietNamBLL vn_bll = new VietNamBLL();
        public FCapNhatVN1()
        {
            InitializeComponent();
        }

        private void FCapNhatVN1_Load(object sender, EventArgs e)
        {
            grdDsachVN1.DataSource = vn_bll.GetList_TiemChung();
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

    }
}
