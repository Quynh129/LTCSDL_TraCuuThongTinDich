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
        bool closeF = true;

        VietNamBLL vn_bll = new VietNamBLL();
        TheGioiBLL tg_bll = new TheGioiBLL();
        ConnectData _dt = new ConnectData();

        #region Lấy mã nhân viên
        private string tdn, maNV;
        bool flag = false;
        #endregion

        #region biến toàn cục
        string maTP, tenTP;
        double nhiemTong, nhiemMoi, tuTong, tuMoi; //VN: cellclick hàng mình chọn
        double txt_nhiemMoi, txt_tuMoi, txt_khoiMoi; //txt nhập
        double VNnhiemTong, VNnhiemMoi, VNtuTong, VNtuMoi;//VN: hàng tổng 00
        double VNkhoiTong; //TG: hang VN QB32
        double TGnhiemTong, TGnhiemMoi, TGtuTong, TGtuMoi, TGkhoiTong;// TG: hang tổng QG00

        bool canDelete = true;
        #endregion

        
        public FCapNhatVN(string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
        }

        private void FCapNhatVN_Load(object sender, EventArgs e)
        {
            if (flag == false)
            {
                DataTable dt = _dt.GetData("select * from NhanVien where TenUser = '" + tdn + "'");
                txtMa.DataBindings.Add("Text", dt, "MaNV", true);
                maNV = txtMa.Text;
                flag = true;
            }
            else
                txtMa.Text = maNV;

            #region định dạng datagrid
            this.grdDsachVN.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            this.grdDsachVN.EnableHeadersVisualStyles = false;
            this.grdDsachVN.ColumnHeadersDefaultCellStyle.ForeColor = Color.Indigo;
            this.grdDsachVN.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            this.grdDsachVN.DefaultCellStyle.BackColor = Color.AliceBlue;
            this.grdDsachVN.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            this.grdDsachVN.DefaultCellStyle.SelectionForeColor = Color.OrangeRed;
            this.grdDsachVN.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
            #endregion
            grdDsachVN.DataSource = vn_bll.GetListVN_Up();

            #region Đọc dlieu TP00 từ bảng VN
            DataTable dt1 = _dt.GetData("select * from VietNam where MaTP = '00'");
            txtNhiemTong.DataBindings.Clear();
            txtNhiemTong.DataBindings.Add("Text", dt1, "NhiemTong", true);
            txtNhiemMoiTong.DataBindings.Clear();
            txtNhiemMoiTong.DataBindings.Add("Text", dt1, "NhiemMoi", true);
            txtTuTong.DataBindings.Clear();
            txtTuTong.DataBindings.Add("Text", dt1, "TuTong", true);
            txtTuMoiTong.DataBindings.Clear();
            txtTuMoiTong.DataBindings.Add("Text", dt1, "TuMoi", true);
            //cột khỏi của VN qg32 bảng TG
            DataTable dt2 = _dt.GetData("select TGKhoiTong from TheGioi where MaQG = ('QG32')");
            txtKhoiTong.DataBindings.Clear();
            txtKhoiTong.DataBindings.Add("Text", dt2, "TGKhoiTong", true);
            #endregion

            ResetGridview();
        }


        #region Các button chuyển form
        private void btQuayLai_Click(object sender, EventArgs e)
        {
            closeF = false;
            FTrangChu fHome = new FTrangChu();
            FDsChucNang fDs = new FDsChucNang(fHome, tdn);
            fDs.Show();
            this.Close();
        }
        #endregion

        private void txtTKTenTP_TextChanged(object sender, EventArgs e)
        {
            if (txtTKTenTP.Text.Trim() == "")
            {
                grdDsachVN.DataSource = vn_bll.GetListVN_Up();
            }
            else
                grdDsachVN.DataSource = vn_bll.TimKiemVN_Up(txtTKTenTP.Text);
        }

        private void txtSoLieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMaTP.Text.Trim() == "")
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải chọn 1 tỉnh thành để cập nhật số liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //chỉ cho nhập số
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    MessageBox.Show("Vị trí này chỉ được nhập số!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Bạn không được khoảng trắng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grdDsachVN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdDsachVN.Rows[e.RowIndex];
                txtMaTP.Text = row.Cells[0].Value.ToString();
                txtTenTP.Text = row.Cells[1].Value.ToString();
                nhiemTong = int.Parse(row.Cells[2].Value.ToString());
                nhiemMoi = int.Parse(row.Cells[3].Value.ToString());
                tuTong = int.Parse(row.Cells[4].Value.ToString());
                tuMoi = int.Parse(row.Cells[5].Value.ToString());
                tenTP = txtTenTP.Text;
            }
        }

        private void ResetGridview()
        {
            txtMaTP.ResetText();
            txtTenTP.ResetText();
            txtNhiem.ResetText();
            txtTu.ResetText();
            txtKhoi.ResetText();
        }

        private void layDuLieuVN()
        {
            //Lấy dữ liệu từ textbox (hàng chọn):
            txt_nhiemMoi = int.Parse(txtNhiem.Text);
            txt_tuMoi = int.Parse(txtTu.Text);
            txt_khoiMoi = int.Parse(txtKhoi.Text);

            //Lấy dữ liệu hàng tổng:
            VNnhiemTong = int.Parse(txtNhiemTong.Text);
            VNnhiemMoi = int.Parse(txtNhiemMoiTong.Text);
            VNtuTong = int.Parse(txtTuTong.Text);
            VNtuMoi = int.Parse(txtTuMoiTong.Text);
            VNkhoiTong = int.Parse(txtKhoiTong.Text);//đây là dlieu lấy từ QG32
        }

        private void layDuLieuTG()
        {
            DataTable dtTG = _dt.GetData("select * from TheGioi where MaQG = 'QG00'");

            TGnhiemTong = double.Parse(dtTG.Rows[0][2].ToString());//hàng cột
            TGnhiemMoi = double.Parse(dtTG.Rows[0][3].ToString());//hàng cột
            TGtuTong = double.Parse(dtTG.Rows[0][4].ToString());//hàng cột
            TGtuMoi = double.Parse(dtTG.Rows[0][5].ToString());//hàng cột
            TGkhoiTong = double.Parse(dtTG.Rows[0][6].ToString());//hàng cột
        }

        private void luuDuLieuVN()//Gán dữ liệu vào bảng VN
        {
            //Gán dữ liệu vào hàng chọn i:
            VietNamDTO vn = new VietNamDTO();
            vn.MaTp = txtMaTP.Text;
            //vn.TenTp = txtTenTP.Text;
            vn.NhiemTong = nhiemTong;
            vn.NhiemMoi = nhiemMoi;
            vn.TuTong = tuTong;
            vn.TuMoi = tuMoi;
            vn.MaNv = double.Parse(maNV);
            vn_bll.CapNhatVN(vn);
        }

        private void luuDuLieuVNTong_TG32()
        {
            //Gán dữ liệu vào hàng tổng 00 của bảng VN:
            VietNamDTO vn1 = new VietNamDTO();
            vn1.MaTp = "00";
            vn1.NhiemTong = VNnhiemTong;
            vn1.NhiemMoi = VNnhiemMoi;
            vn1.TuTong = VNtuTong;
            vn1.TuMoi = VNtuMoi;
            vn1.MaNv = double.Parse(maNV);
            vn_bll.CapNhatVN(vn1);
            //Gán dữ liệu vào hàng VN QG32 bảng TG:
            TheGioiDTO _tg = new TheGioiDTO();
            _tg.MaQg = "QG32";
            _tg.TgnhiemTong = VNnhiemTong;
            _tg.TgnhiemMoi = VNnhiemMoi;
            _tg.TgtuTong = VNtuTong;
            _tg.TgtuMoi = VNtuMoi;
            _tg.TgkhoiTong = VNkhoiTong;
            _tg.MaNv = double.Parse(maNV);
            tg_bll.CapNhatTG(_tg);
        }

        private void luuDuLieuTGTong()//Gán dữ liệu vào bảng TG: hàng tổng
        {
            //Gán dữ liệu vào hàng tổng QG00 của bảng TG:
            TheGioiDTO _tg1 = new TheGioiDTO();
            _tg1.MaQg = "QG00";
            _tg1.TgnhiemTong = TGnhiemTong;
            _tg1.TgnhiemMoi = TGnhiemMoi;
            _tg1.TgtuTong = TGtuTong;
            _tg1.TgtuMoi = TGtuMoi;
            _tg1.TgkhoiTong = TGkhoiTong;
            _tg1.MaNv = double.Parse(maNV);
            tg_bll.CapNhatTG(_tg1);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaTP.Text.Trim() != "")
            {
                if (txtNhiem.Text.Trim() != "" && txtTu.Text.Trim() != "" && txtKhoi.Text.Trim() != "")
                {
                    layDuLieuVN();
                    layDuLieuTG();

                    #region hàng VN chọn
                    //Cộng dữ liệu vào hàng chọn của bảng VN:
                    nhiemTong += txt_nhiemMoi;
                    nhiemMoi = txt_nhiemMoi;
                    tuTong += txt_tuMoi;
                    tuMoi = txt_tuMoi;
                    //khoiTong += txt_khoiMoi;
                    luuDuLieuVN();
                    #endregion

                    #region hàng VN 00 và QG32
                    //Cộng dữ liệu vào hàng tổng của bảng VN: (cũng là hàng QG32 bảng TG)
                    VNnhiemTong += txt_nhiemMoi;
                    VNtuTong += txt_tuMoi;
                    VNkhoiTong += txt_khoiMoi;

                    grdDsachVN.DataSource = vn_bll.GetListVN_Up();
                    VNnhiemMoi = 0;
                    VNtuMoi = 0;
                    int _r = grdDsachVN.Rows.Count;
                    for (int i = 0; i < _r - 1; i++)
                    {
                        VNnhiemMoi += double.Parse(grdDsachVN[3, i].Value.ToString());
                        VNtuMoi += double.Parse(grdDsachVN[5, i].Value.ToString());
                    }
                    luuDuLieuVNTong_TG32();
                    #endregion

                    #region hàng QG00
                    //Cộng dữ liệu vào hàng tổng của bảng TG QG00
                    TGnhiemTong += txt_nhiemMoi;
                    TGtuTong += txt_tuMoi;
                    TGkhoiTong += txt_khoiMoi;

                    grdDsachVN.DataSource = tg_bll.GetListTG_Up(); //sd bảng TG để cập nhật trong quá trình chạy
                    TGnhiemMoi = 0;
                    TGtuMoi = 0;
                    int _r2 = grdDsachVN.Rows.Count;
                    for (int i = 0; i < _r2 - 1; i++)
                    {
                        TGnhiemMoi += double.Parse(grdDsachVN[3, i].Value.ToString());
                        TGtuMoi += double.Parse(grdDsachVN[5, i].Value.ToString());
                    }
                    luuDuLieuTGTong();
                    #endregion

                    FCapNhatVN_Load(sender, e);

                    lbThongBao.Text = "Bạn vừa cập nhật thành công thông tin của tỉnh thành: " + tenTP;
                    lbThongBao.Visible = true;
                }
                else
                    MessageBox.Show("Bạn không thể để trống dữ liệu nhập vào!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn quên chọn 1 tỉnh thành cần cập nhật rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btGiam_Click(object sender, EventArgs e)
        {
            canDelete = true;
            if (txtMaTP.Text.Trim() != "")
            {
                if (txtNhiem.Text.Trim() != "" && txtTu.Text.Trim() != "" && txtKhoi.Text.Trim() != "")
                {
                    layDuLieuVN();
                    layDuLieuTG();

                    //Cộng dữ liệu vào hàng chọn của bảng VN:
                    nhiemTong -= txt_nhiemMoi;
                    tuTong -= txt_tuMoi;
                    if ((nhiemMoi - txt_nhiemMoi) >= 0 && (tuMoi - txt_tuMoi) >= 0)
                    {
                        nhiemMoi -= txt_nhiemMoi;
                        tuMoi -= txt_tuMoi;
                    }
                    else
                    {
                        MessageBox.Show("Số chỉnh sửa không được lớn hơn số cập nhật trước đó, hãy nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        canDelete = false;
                    }

                    if (canDelete)
                    {
                        luuDuLieuVN();

                        #region hàng VN 00 và QG32
                        //Cộng dữ liệu vào hàng tổng của bảng VN: (cũng là hàng QG32 bảng TG)
                        VNnhiemTong -= txt_nhiemMoi;
                        VNtuTong -= txt_tuMoi;
                        VNkhoiTong -= txt_khoiMoi;

                        grdDsachVN.DataSource = vn_bll.GetListVN_Up();
                        VNnhiemMoi = 0;
                        VNtuMoi = 0;
                        int _r = grdDsachVN.Rows.Count;
                        for (int i = 0; i < _r - 1; i++)
                        {
                            VNnhiemMoi += double.Parse(grdDsachVN[3, i].Value.ToString());
                            VNtuMoi += double.Parse(grdDsachVN[5, i].Value.ToString());
                        }
                        luuDuLieuVNTong_TG32();
                        #endregion

                        #region hàng QG00
                        //Cộng dữ liệu vào hàng tổng của bảng TG QG00
                        TGnhiemTong -= txt_nhiemMoi;
                        TGtuTong -= txt_tuMoi;
                        TGkhoiTong -= txt_khoiMoi;

                        grdDsachVN.DataSource = tg_bll.GetListTG_Up();
                        TGnhiemMoi = 0;
                        TGtuMoi = 0;
                        int _r2 = grdDsachVN.Rows.Count;
                        for (int i = 0; i < _r2 - 1; i++)
                        {
                            TGnhiemMoi += double.Parse(grdDsachVN[3, i].Value.ToString());
                            TGtuMoi += double.Parse(grdDsachVN[5, i].Value.ToString());
                        }
                        luuDuLieuTGTong();
                        #endregion

                        FCapNhatVN_Load(sender, e);

                        lbThongBao.Text = "Bạn vừa chỉnh sửa thành công thông tin của tỉnh thành: " + tenTP;
                        lbThongBao.Visible = true;
                    }
                }
                else
                    MessageBox.Show("Bạn không thể để trống dữ liệu nhập vào!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn quên chọn 1 tỉnh thành cần chỉnh sửa rồi!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FCapNhatVN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeF == true)
            {
                Application.Exit();
            }
        }

    }
}
