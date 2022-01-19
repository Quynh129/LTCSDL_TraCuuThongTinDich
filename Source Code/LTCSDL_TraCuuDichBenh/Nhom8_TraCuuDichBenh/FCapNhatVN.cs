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
    public partial class FCapNhatVN : Form
    {
        VietNamBLL vn_bll = new VietNamBLL();
        TheGioiBLL tg_bll = new TheGioiBLL();

        #region connect
        //lấy mã nv
        ConnectData _dt = new ConnectData();
        ConnectData _dt1 = new ConnectData();
        #endregion

        #region biến toàn cục
        string maTP, tenTP;
        double nhiemTong, nhiemMoi, tuTong, tuMoi; //VN: hàng mình chọn
        double VNnhiemTong, VNnhiemMoi, VNtuTong, VNtuMoi; //VN: hàng tổng
        #endregion

        public FCapNhatVN()
        {
            InitializeComponent();
        }

        private void FCapNhatVN_Load(object sender, EventArgs e)
        {
            grdDsachVN.DataSource = vn_bll.GetList();

            #region Đọc dlieu VN hàng tổng
            DataTable dt1 = _dt.GetData("select * from VietNam where MaTP = '00'");
            txtNhiemTong.DataBindings.Clear();
            txtNhiemTong.DataBindings.Add("Text", dt1, "NhiemTong", true);
            txtNhiemMoiTong.DataBindings.Clear();
            txtNhiemMoiTong.DataBindings.Add("Text", dt1, "NhiemMoi", true);
            txtTuTong.DataBindings.Clear();
            txtTuTong.DataBindings.Add("Text", dt1, "TuTong", true);
            txtTuMoiTong.DataBindings.Clear();
            txtTuMoiTong.DataBindings.Add("Text", dt1, "TuMoi", true);
            #endregion
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

        private void grdDsachVN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdDsachVN.Rows[e.RowIndex];
                maTP = row.Cells[0].Value.ToString();
                tenTP = row.Cells[1].Value.ToString();
                nhiemTong = int.Parse(row.Cells[2].Value.ToString());
                //nhiemMoi = int.Parse(row.Cells[3].Value.ToString());
                tuTong = int.Parse(row.Cells[4].Value.ToString());
                //tuMoi = int.Parse(row.Cells[5].Value.ToString());

                txtTenTP.Text = tenTP;
                txtMaTP.Text = maTP;
            }

            if (txtMaTP.Text == "00")
                MessageBox.Show("Bạn không thể cập nhật trường này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ textbox (hàng chọn):
            nhiemMoi = int.Parse(txtNhiem.Text);
            tuMoi = int.Parse(txtTu.Text);

            //Lấy dữ liệu hàng tổng:
            VNnhiemTong = int.Parse(txtNhiemTong.Text);
            VNnhiemMoi = int.Parse(txtNhiemMoiTong.Text);
            VNtuTong = int.Parse(txtTuTong.Text);
            VNtuMoi = int.Parse(txtTuMoiTong.Text);

            //Cộng dữ liệu vào hàng chọn của bảng VN:
            nhiemTong += nhiemMoi;
            tuTong += tuMoi;

            //Cộng dữ liệu vào hàng tổng của bảng VN:
            VNnhiemTong += nhiemMoi;
            VNnhiemMoi += nhiemMoi;
            VNtuTong += tuMoi;
            VNtuMoi += tuMoi;

            //Gán dữ liệu vào bảng VN:
            VietNamDTO vn = new VietNamDTO();
            vn.MaTp = txtMaTP.Text;
            vn.TenTp = txtTenTP.Text;
            vn.NhiemTong = nhiemTong;
            vn.NhiemMoi = nhiemMoi;
            vn.TuTong = tuTong;
            vn.TuMoi = tuMoi;
            vn_bll.CapNhat(vn);

            //Gán dữ liệu vào hàng tổng của bảng VN:
            VietNamDTO vn1 = new VietNamDTO();
            vn1.MaTp = "00";
            vn1.NhiemTong = VNnhiemTong;
            vn1.NhiemMoi = VNnhiemMoi;
            vn1.TuTong = VNtuTong;
            vn1.TuMoi = VNtuMoi;
            vn_bll.CapNhat(vn1);

            FCapNhatVN_Load(sender, e);
        }

        private void btGiam_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ textbox (hàng chọn):
            nhiemMoi = int.Parse(txtNhiem.Text);
            tuMoi = int.Parse(txtTu.Text);

            //Lấy dữ liệu hàng tổng:
            VNnhiemTong = int.Parse(txtNhiemTong.Text);
            VNnhiemMoi = int.Parse(txtNhiemMoiTong.Text);
            VNtuTong = int.Parse(txtTuTong.Text);
            VNtuMoi = int.Parse(txtTuMoiTong.Text);

            //Trừ dữ liệu vào hàng chọn của bảng VN:
            nhiemTong -= nhiemMoi;
            tuTong -= tuMoi;

            //Trừ dữ liệu vào hàng tổng của bảng VN:
            VNnhiemTong -= nhiemMoi;
            VNnhiemMoi -= nhiemMoi;
            VNtuTong -= tuMoi;
            VNtuMoi -= tuMoi;

            //Gán dữ liệu vào bảng VN
            VietNamDTO vn = new VietNamDTO();
            vn.MaTp = txtMaTP.Text;
            vn.TenTp = txtTenTP.Text;
            vn.NhiemTong = nhiemTong;
            vn.NhiemMoi = nhiemMoi;
            vn.TuTong = tuTong;
            vn.TuMoi = tuMoi;
            vn_bll.CapNhat(vn);

            //Gán dữ liệu vào hàng tổng của bảng VN:
            VietNamDTO vn1 = new VietNamDTO();
            vn1.MaTp = "00";
            vn1.NhiemTong = VNnhiemTong;
            vn1.NhiemMoi = VNnhiemMoi;
            vn1.TuTong = VNtuTong;
            vn1.TuMoi = VNtuMoi;
            vn_bll.CapNhat(vn1);

            FCapNhatVN_Load(sender, e);
        }
    }
}
