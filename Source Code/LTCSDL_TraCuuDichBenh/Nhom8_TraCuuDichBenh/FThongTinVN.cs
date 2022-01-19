using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfDTO;
using wfBLL;
namespace Nhom8_TraCuuDichBenh
{
    public partial class FThongTinVN : Form
    {
       VietNamBLL vn;
        BindingSource bs;
        private FTrangChu fHome;
        public FThongTinVN(FTrangChu _fHome)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
            vn = new VietNamBLL();
        }
      
        private void FThongTinVN_Load(object sender, EventArgs e)
        {
            gridDsVN.DataSource = vn.GetList();
            GetSizeColumns();
            GetHeader();
         
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

        private void gridDsVN_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            var row = gridDsVN.Rows[e.RowIndex];
           
            txtTenTP.Text = row.Cells["TenTp"].Value.ToString();
            txtNhiemVN.Text = row.Cells["NhiemTong"].Value.ToString();
            txtCaTuVN.Text = row.Cells["TuTong"].Value.ToString();
            txtTiemDu.Text = row.Cells["TiemDu"].Value.ToString();
        }
        public void GetHeader()
        {
            gridDsVN.Columns[0].HeaderText = "MãTP";
            gridDsVN.Columns[1].HeaderText = "TênTP";
            gridDsVN.Columns[2].HeaderText = "Ca nhiễm";
            gridDsVN.Columns[3].HeaderText = "Ca tử vong";
            gridDsVN.Columns[4].HeaderText = "Tiêm mũi 1";
            gridDsVN.Columns[5].HeaderText = "Tiêm đủ mũi";
        }
        public void GetSizeColumns()
        {
            gridDsVN.Columns[0].Width = 100;
          
            gridDsVN.Columns[1].Width = 150;
            gridDsVN.Columns[2].Width = 200;
            gridDsVN.Columns[3].Width = 200;
            gridDsVN.Columns[4].Width = 200;
            gridDsVN.Columns[5].Width = 200;
           
        }



        private void txtTKTenVN_TextChanged(object sender, EventArgs e)
        {
            
            string rowFilter = string.Format("{0} like '{1}'", "TenTp", "*" + txtTKTenVN.Text + "*");
            (gridDsVN.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

        }
       
   
    }
}
