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
    public partial class FThongTinTG : Form
    {
        TheGioiBLL bus;
        BindingSource bs; 
        private FTrangChu fHome;
       

        public FThongTinTG(FTrangChu _fHome)
        {
            
            InitializeComponent();
            fHome = _fHome; //liên kết form
            bus = new TheGioiBLL();
        }

        private void FThongTinTG_Load(object sender, EventArgs e)
        {
            gridDsTG.DataSource = bus.GetList();
            GetHeaderTG();
            GetSizeColumnsTG();
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

        private void gridDsTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridDsTG.Rows[e.RowIndex];
            txtTenQG.Text = row.Cells["TenQg"].Value.ToString();
            txtCaNhiemTG.Text = row.Cells["TgnhiemTong"].Value.ToString();
            txtCaTuTG.Text = row.Cells["TgtuTong"].Value.ToString();
            txtCaKhoiTG.Text = row.Cells["TgkhoiTong"].Value.ToString();

        }

        public void GetHeaderTG()
        {
            gridDsTG.Columns[0].HeaderText = "MãQG";
            gridDsTG.Columns[1].HeaderText = "TênQG";
            gridDsTG.Columns[2].HeaderText = "Ca nhiễm";
            gridDsTG.Columns[3].HeaderText = "Ca tử vong";
            gridDsTG.Columns[4].HeaderText = "Ca khỏi bệnh";
        
        }
        public void GetSizeColumnsTG()
        {
            gridDsTG.Columns[0].Width = 100;
            gridDsTG.Columns[1].Width = 150;
            gridDsTG.Columns[2].Width = 200;
            gridDsTG.Columns[3].Width = 200;
            gridDsTG.Columns[4].Width = 200;
           

        }

        private void txtTKTenQG_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "TenQg", "*" + txtTKTenQG.Text + "*");
            (gridDsTG.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
