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
using wfDAL;

namespace Nhom8_TraCuuDichBenh
{
    public partial class FThongTinVN : Form
    {
        bool closeF = true;

        VietNamBLL vn = new VietNamBLL();
        BindingSource bs;
        ConnectData _dt = new ConnectData();

        private FTrangChu fHome;
        public FThongTinVN(FTrangChu _fHome)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
        }

        private void FThongTinVN_Load(object sender, EventArgs e)
        {
            #region định dạng datagrid
            this.gridDsVN.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            this.gridDsVN.EnableHeadersVisualStyles = false;
            this.gridDsVN.ColumnHeadersDefaultCellStyle.ForeColor = Color.Indigo;
            this.gridDsVN.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            this.gridDsVN.DefaultCellStyle.BackColor = Color.AliceBlue;
            this.gridDsVN.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            this.gridDsVN.DefaultCellStyle.SelectionForeColor = Color.OrangeRed;
            this.gridDsVN.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
            #endregion

            gridDsVN.DataSource = vn.GetListInfoVN();
            GetSizeColumns();
            GetHeader();

            DataTable dt2 = _dt.GetData("select NhiemTong, TuTong from VietNam where MaTP = ('00')");
            lbTongNhiem.DataBindings.Add("Text", dt2, "NhiemTong", true);
            lbTongTu.DataBindings.Add("Text", dt2, "TuTong", true);
            DataTable dt3 = _dt.GetData("select TGNhiemTong, TGTuTong, TGKhoiTong from TheGioi where MaQG = ('QG32')");
            lbTongKhoi.DataBindings.Add("Text", dt3, "TGKhoiTong", true);
        }

        #region Các button chuyển form
        private void btTrangChu_Click(object sender, EventArgs e)
        {
            closeF = false;
            fHome.Show();
            this.Close();
        }

        private void btTheGioi_Click(object sender, EventArgs e)
        {
            closeF = false;
            FThongTinTG fTG = new FThongTinTG(fHome);
            fTG.Show();
            this.Close();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            closeF = false;
            FThongKe fTop = new FThongKe(fHome);
            fTop.Show();
            this.Close();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            closeF = false;
            FDangNhap fTG = new FDangNhap(fHome);
            fTG.Show();
            this.Close();
        }
        #endregion

        private void gridDsVN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = gridDsVN.Rows[e.RowIndex];

                txtTenTP.Text = row.Cells["TenTp"].Value.ToString();
                txtNhiemVN.Text = row.Cells["NhiemTong"].Value.ToString();
                txtNhiemMoiVN.Text = row.Cells["NhiemMoi"].Value.ToString();
                txtCaTuVN.Text = row.Cells["TuTong"].Value.ToString();
                txtCaTuMoiVN.Text = row.Cells["TuMoi"].Value.ToString();
                txtTiemMot.Text = row.Cells["TiemMot"].Value.ToString();
                txtTiemDu.Text = row.Cells["TiemDu"].Value.ToString();
            }    
                
        }
        public void GetHeader()
        {
            gridDsVN.Columns[0].HeaderText = "MãTP";
            gridDsVN.Columns[1].HeaderText = "TênTP";
            gridDsVN.Columns[2].HeaderText = "Tổng ca nhiễm";
            gridDsVN.Columns[3].HeaderText = "Ca nhiễm trong ngày";
            gridDsVN.Columns[4].HeaderText = "Tổng ca tử vong";
            gridDsVN.Columns[5].HeaderText = "Ca tử vong trong ngày";
            gridDsVN.Columns[6].HeaderText = "Tiêm mũi 1";
            gridDsVN.Columns[7].HeaderText = "Tiêm đủ 2 mũi";
        }
        public void GetSizeColumns()
        {
            gridDsVN.Columns[0].Width = 100;

            gridDsVN.Columns[1].Width = 150;
            gridDsVN.Columns[2].Width = 200;
            gridDsVN.Columns[3].Width = 200;
            gridDsVN.Columns[4].Width = 200;
            gridDsVN.Columns[5].Width = 200;
            gridDsVN.Columns[6].Width = 200;
            gridDsVN.Columns[7].Width = 200;

        }
        private void txtTKTenVN_TextChanged(object sender, EventArgs e)
        {
            if (txtTKTenVN.Text == "")
            {
                gridDsVN.DataSource = vn.GetListInfoVN();
            }
            else
                gridDsVN.DataSource = vn.TimKiemVN(txtTKTenVN.Text);
            //string rowFilter = string.Format("{0} like '{1}'", "TenTp", "*" + txtTKTenVN.Text + "*");
            //(gridDsVN.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

        }

        private void FThongTinVN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeF == true)
            {
                Application.Exit();
            }
        }
    }
}
