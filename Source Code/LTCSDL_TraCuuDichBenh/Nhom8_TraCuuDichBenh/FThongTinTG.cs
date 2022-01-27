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
using wfDAL;

namespace Nhom8_TraCuuDichBenh
{
    public partial class FThongTinTG : Form
    {
        bool closeF = true;

        TheGioiBLL bus = new TheGioiBLL();
        BindingSource bs;
        ConnectData _dt = new ConnectData();

        private FTrangChu fHome;
        public FThongTinTG(FTrangChu _fHome)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
        }

        private void FThongTinTG_Load(object sender, EventArgs e)
        {
            #region định dạng datagrid
            this.gridDsTG.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            this.gridDsTG.EnableHeadersVisualStyles = false;
            this.gridDsTG.ColumnHeadersDefaultCellStyle.ForeColor = Color.Indigo;
            this.gridDsTG.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            this.gridDsTG.DefaultCellStyle.BackColor = Color.AliceBlue;
            this.gridDsTG.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            this.gridDsTG.DefaultCellStyle.SelectionForeColor = Color.OrangeRed;
            this.gridDsTG.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue; 
            #endregion

            gridDsTG.DataSource = bus.GetListInfoTG();
            GetHeaderTG();
            GetSizeColumnsTG();

            DataTable dt = _dt.GetData("select TGNhiemTong, TGTuTong, TGKhoiTong from TheGioi where MaQG = ('QG00')");
            lbTongNhiem.DataBindings.Add("Text", dt, "TGNhiemTong", true);
            lbTongTu.DataBindings.Add("Text", dt, "TGTuTong", true);
            lbTongKhoi.DataBindings.Add("Text", dt, "TGKhoiTong", true);
        }

        #region Các button chuyển form
        private void btTrangChu_Click(object sender, EventArgs e)
        {
            closeF = false;
            fHome.Show();
            this.Close();
        }

        private void btVietNam_Click(object sender, EventArgs e)
        {
            closeF = false;
            FThongTinVN fTG = new FThongTinVN(fHome);
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

        private void gridDsTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var row = gridDsTG.Rows[e.RowIndex];
                txtTenQG.Text = row.Cells["TenQg"].Value.ToString();
                txtCaNhiemTG.Text = row.Cells["TgnhiemTong"].Value.ToString();
                txtCaNhiemMoiTG.Text = row.Cells["TgnhiemMoi"].Value.ToString();
                txtCaTuTG.Text = row.Cells["TgtuTong"].Value.ToString();
                txtCaTuMoiTG.Text = row.Cells["TgtuMoi"].Value.ToString();
                txtCaKhoiTG.Text = row.Cells["TgkhoiTong"].Value.ToString();
            }
            

        }

        public void GetHeaderTG()
        {
            gridDsTG.Columns[0].HeaderText = "MãQG";
            gridDsTG.Columns[1].HeaderText = "TênQG";
            gridDsTG.Columns[2].HeaderText = "Tổng ca nhiễm";
            gridDsTG.Columns[3].HeaderText = "Ca nhiễm trong ngày";
            gridDsTG.Columns[4].HeaderText = "Tổng ca tử vong";
            gridDsTG.Columns[5].HeaderText = "Ca tử vong trong ngày";
            gridDsTG.Columns[6].HeaderText = "Tổng ca khỏi bệnh";

        }
        public void GetSizeColumnsTG()
        {
            gridDsTG.Columns[0].Width = 100;
            gridDsTG.Columns[1].Width = 150;
            gridDsTG.Columns[2].Width = 200;
            gridDsTG.Columns[3].Width = 200;
            gridDsTG.Columns[4].Width = 200;
            gridDsTG.Columns[5].Width = 200;
            gridDsTG.Columns[6].Width = 200;


        }

        private void txtTKTenQG_TextChanged(object sender, EventArgs e)
        {
            if (txtTKTenQG.Text == "")
            {
                gridDsTG.DataSource = bus.GetListInfoTG();
            }
            else
                gridDsTG.DataSource = bus.TimKiemTG(txtTKTenQG.Text);
        }

        private void FThongTinTG_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeF == true)
            {
                Application.Exit();
            }
        }
    }
}
