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
using System.Data.SqlClient;


namespace Nhom8_TraCuuDichBenh
{
    public partial class FCapNhatVN1 : Form
    {
        VietNamBLL vn_bll = new VietNamBLL();
        ConnectData dt = new ConnectData();

        #region bien toan cuc
        // String MaTp, TenTp;
        double nhiemTong, nhiemMoi, tuTong, tuMoi, tiemMot, tiemDu; // VN: hang duoc chon
        /*double VNNhiemTong, VNNhiemMoi, VNTuTong, VNTuMoi, VNKhoiTong, VNTiemMot, VNTiemDu;// VN: hang tong VN00*/
        #endregion        
        public FCapNhatVN1()
        {
            InitializeComponent();
        }

        private void FCapNhatVN1_Load(object sender, EventArgs e)
        {
            grdDsachVN1.DataSource = vn_bll.GetList_TiemChung();

            /*#region Doc du lieu hàng VN00 từ bảng VN*/
            DataTable dt1 = dt.GetData("select * from VietNam where MaTP = 'VN00'");
            lbVNNhiemTong.DataBindings.Clear();
            lbVNNhiemTong.DataBindings.Add("Text", dt1, "NhiemTong", true);
            lbVNNhiemMoi.DataBindings.Clear();
            lbVNNhiemMoi.DataBindings.Add("Text", dt1, "NhiemMoi", true);
            lbVNTuTong.DataBindings.Clear();
            lbVNTuTong.DataBindings.Add("Text", dt1, "TuTong", true);
            lbVNTuMoi.DataBindings.Clear();
            lbVNTuMoi.DataBindings.Add("Text", dt1, "TuMoi", true);
            lbVNTiemMot.DataBindings.Clear();
            lbVNTiemMot.DataBindings.Add("Text", dt1, "TiemMot", true);
            lbVNTiemDu.DataBindings.Clear();
            lbVNTiemDu.DataBindings.Add("Text", dt1, "TiemDu", true);
            /*#endregion*/
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

        private void grdDsachVN1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)

            {
                DataGridViewRow row = this.grdDsachVN1.Rows[e.RowIndex];
                txtMaTP.Text = row.Cells[0].Value.ToString();
                lbTenTp.Text = row.Cells[1].Value.ToString();
                if (txtMaTP.Text == "VN32")
                    MessageBox.Show("Bạn không thể cập nhật tại bảng này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    nhiemTong = int.Parse(row.Cells[2].Value.ToString());
                    nhiemMoi = int.Parse(row.Cells[3].Value.ToString());
                    tuTong = int.Parse(row.Cells[4].Value.ToString());
                    tuMoi = int.Parse(row.Cells[5].Value.ToString());
                    tiemMot = int.Parse(row.Cells[6].Value.ToString());
                    tiemDu = int.Parse(row.Cells[7].Value.ToString());
                }

                if (txtMaTP.Text == "QG00")
                    MessageBox.Show("Bạn không thể cập nhật trường này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            /*// lay du lieu            
            tiemMot = int.Parse(txtMui1.Text);
            tiemDu = int.Parse(txtMui2.Text);
            //lay du lieu hang VN00
            VNTiemMot = int.Parse(lbTiemMot.Text);
            VNTiemDu = int.Parse(lbTiemDu.Text);


            // hang chon
            tiemMot =+ tiemMot;

            // hang tong VN00
            VNTiemMot += tiemMot;
            VNTiemDu += tiemDu;


            //luu hang chon
            VietNamDTO _tp = new VietNamDTO();
            _tp.MaTp = txtMaTP.Text;
            _tp.TiemMot = tiemMot;
            _tp.TiemDu = tiemDu;
            vn_bll.CapNhat(_tp);

            // Luu vao VN00
            VietNamDTO _tp1 = new VietNamDTO();
            _tp1.MaTp = "VN00";
            _tp1.TiemMot = VNTiemMot;
            _tp1.TiemDu = VNTiemDu;
            vn_bll.CapNhat(_tp1);
            FCapNhatVN1_Load(sender, e);*/
        }

        private void btGiam_Click(object sender, EventArgs e)
        {
            /*// lay du lieu 

            tiemMot = int.Parse(txtMui1.Text);
            tiemDu = int.Parse(txtMui2.Text);

            //lay du lieu hang VN00
            VNTiemMot = int.Parse(lbTiemMot.Text);
            VNTiemDu = int.Parse(lbTiemDu.Text);

            // hang chon
            tiemMot -= tiemMot;
            tiemDu -= tiemDu;

            // hang tong VN00
            VNTiemMot -= tiemMot;
            VNTiemDu -= tiemDu;

            // luu hang chon
            VietNamDTO _tp = new VietNamDTO();
            _tp.MaTp = txtMaTP.Text;
            _tp.TiemMot = tiemMot;
            _tp.TiemDu = tiemDu;
            vn_bll.CapNhat(_tp);
            // Luu vao QG00
            VietNamDTO _tp1 = new VietNamDTO();
            _tp1.TiemMot = VNTiemMot;
            _tp1.TiemDu = VNTiemDu;
            FCapNhatVN1_Load(sender, e);*/
        }
        private void grdDsachVN1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
