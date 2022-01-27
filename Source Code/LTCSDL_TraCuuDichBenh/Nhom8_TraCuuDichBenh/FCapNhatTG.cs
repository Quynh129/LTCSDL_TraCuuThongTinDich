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
    public partial class FCapNhatTG : Form
    {
        bool closeF = true;

        TheGioiBLL tg_bll = new TheGioiBLL();
        ConnectData dt = new ConnectData();

        #region Lấy mã nhân viên
        private string tdn, maNV;
        bool flag = false;
        #endregion

        #region bien toan cuc
        string maQG, tenQG;
        double nhiemTong, nhiemMoi, tuTong, tuMoi, khoiTong; // TG: hang duoc chon
        double txt_nhiemMoi, txt_tuMoi, txt_khoiMoi; //txt nhập
        double TGnhiemTong, TGnhiemMoi, TGtuTong, TGtuMoi, TGkhoiTong;// TG: hang tong QG00
        bool canDelete = true;
        #endregion

        public FCapNhatTG(string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
        }

        private void FCapNhatTG_Load(object sender, EventArgs e)
        {
            if (flag == false)
            {
                DataTable dt1 = dt.GetData("select * from NhanVien where TenUser = '" + tdn + "'");
                txtMa.DataBindings.Add("Text", dt1, "MaNV", true);
                maNV = txtMa.Text;
                flag = true;
            }
            else
                txtMa.Text = maNV;

            #region định dạng datagrid
            this.grdDsachTG.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            this.grdDsachTG.EnableHeadersVisualStyles = false;
            this.grdDsachTG.ColumnHeadersDefaultCellStyle.ForeColor = Color.Indigo;
            this.grdDsachTG.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            this.grdDsachTG.DefaultCellStyle.BackColor = Color.AliceBlue;
            this.grdDsachTG.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            this.grdDsachTG.DefaultCellStyle.SelectionForeColor = Color.OrangeRed;
            this.grdDsachTG.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
            #endregion

            grdDsachTG.DataSource = tg_bll.GetListTG_Up();

            #region Đọc dlieu hàng QG00 từ bảng TG
            DataTable dt2 = dt.GetData("select * from TheGioi where MaQG = 'QG00'");
            txtNhiemTong.DataBindings.Clear();
            txtNhiemTong.DataBindings.Add("text", dt2, "TGNhiemTong", true);
            txtNhiemMoiTong.DataBindings.Clear();
            txtNhiemMoiTong.DataBindings.Add("text", dt2, "TGNhiemMoi", true);
            txtTuTong.DataBindings.Clear();
            txtTuTong.DataBindings.Add("text", dt2, "TGTuTong", true);
            txtTuMoiTong.DataBindings.Clear();
            txtTuMoiTong.DataBindings.Add("text", dt2, "TGTuMoi", true);
            txtKhoiTong.DataBindings.Clear();
            txtKhoiTong.DataBindings.Add("text", dt2, "TGKhoiTong", true);
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

        private void txtTKTenQG_TextChanged(object sender, EventArgs e)
        {
            if (txtTKTenQG.Text.Trim() == "")
            {
                grdDsachTG.DataSource = tg_bll.GetListTG_Up();
            }
            else
                grdDsachTG.DataSource = tg_bll.TimKiemTG_Up(txtTKTenQG.Text);
        }

        private void txtSoLieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMaQG.Text.Trim() == "")
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải chọn 1 quốc gia để cập nhật số liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void grdDsachTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdDsachTG.Rows[e.RowIndex];
                txtMaQG.Text = row.Cells[0].Value.ToString();
                txtTenQG.Text = row.Cells[1].Value.ToString();
                tenQG = txtTenQG.Text;
                if (txtMaQG.Text == "QG32")
                    MessageBox.Show("Bạn không thể cập nhật Việt Nam tại bảng này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    nhiemTong = int.Parse(row.Cells[2].Value.ToString());
                    nhiemMoi = int.Parse(row.Cells[3].Value.ToString());
                    tuTong = int.Parse(row.Cells[4].Value.ToString());
                    tuMoi = int.Parse(row.Cells[5].Value.ToString());
                    khoiTong = int.Parse(row.Cells[6].Value.ToString());
                }
            }

        }

        private void ResetGridview()
        {
            txtMaQG.ResetText();
            txtTenQG.ResetText();
            txtNhiem.ResetText();
            txtTu.ResetText();
            txtKhoi.ResetText();
        }

        private void layDuLieu()
        {
            // lay du lieu từ txt
            txt_nhiemMoi = int.Parse(txtNhiem.Text);
            txt_tuMoi = int.Parse(txtTu.Text);
            txt_khoiMoi = int.Parse(txtKhoi.Text);

            //lay du lieu hang QG00
            TGnhiemTong = int.Parse(txtNhiemTong.Text);
            //TGnhiemMoi = int.Parse(txtNhiemMoiTong.Text);
            TGtuTong = int.Parse(txtTuTong.Text);
            //TGtuMoi = int.Parse(txtTuMoiTong.Text);
            TGkhoiTong = int.Parse(txtKhoiTong.Text);
        }

        private void luuDuLieu()
        {
            // luu hang chon
            TheGioiDTO _tg = new TheGioiDTO();
            _tg.MaQg = txtMaQG.Text;
            _tg.TgnhiemTong = nhiemTong;
            _tg.TgnhiemMoi = nhiemMoi;
            _tg.TgtuTong = tuTong;
            _tg.TgtuMoi = tuMoi;
            _tg.TgkhoiTong = khoiTong;
            _tg.MaNv = double.Parse(maNV);
            tg_bll.CapNhatTG(_tg);
        }

        private void luuDuLieuTong()
        {
            // Luu vao QG00
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
            if(txtMaQG.Text.Trim() != "")
            {
                if (txtNhiem.Text.Trim() != "" && txtTu.Text.Trim() != "" && txtKhoi.Text.Trim() != "")
                {
                    layDuLieu();

                    #region hang chon
                    nhiemTong += txt_nhiemMoi;
                    nhiemMoi = txt_nhiemMoi;
                    tuTong += txt_tuMoi;
                    tuMoi = txt_tuMoi;
                    khoiTong += txt_khoiMoi;
                    luuDuLieu();
                    #endregion

                    #region hang tong QG00
                    TGnhiemTong += txt_nhiemMoi;
                    TGtuTong += txt_tuMoi;
                    TGkhoiTong += txt_khoiMoi;

                    grdDsachTG.DataSource = tg_bll.GetListTG_Up();
                    TGnhiemMoi = 0;
                    TGtuMoi = 0;
                    int _r = grdDsachTG.Rows.Count;
                    for (int i = 0; i < _r - 1; i++)
                    {
                        TGnhiemMoi += double.Parse(grdDsachTG[3, i].Value.ToString());
                        TGtuMoi += double.Parse(grdDsachTG[5, i].Value.ToString());
                    }
                    luuDuLieuTong();
                    #endregion

                    FCapNhatTG_Load(sender, e);

                    lbThongBao.Text = "Bạn vừa cập nhật thành công thông tin của quốc gia: " + tenQG;
                    lbThongBao.Visible = true;
                }
                else
                    MessageBox.Show("Bạn không thể để trống dữ liệu nhập vào!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn quên chọn 1 quốc gia cần cập nhật rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btGiam_Click(object sender, EventArgs e)
        {
            canDelete = true;
            if (txtMaQG.Text.Trim() != "")
            {
                if (txtNhiem.Text.Trim() != "" && txtTu.Text.Trim() != "" && txtKhoi.Text.Trim() != "")
                {
                    layDuLieu();

                    nhiemTong -= txt_nhiemMoi;
                    tuTong -= txt_tuMoi;
                    khoiTong -= txt_khoiMoi;
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
                        luuDuLieu();

                        #region hang tong QG00
                        TGnhiemTong -= txt_nhiemMoi;
                        TGtuTong -= txt_tuMoi;
                        TGkhoiTong -= txt_khoiMoi;

                        grdDsachTG.DataSource = tg_bll.GetListTG_Up();
                        TGnhiemMoi = 0;
                        TGtuMoi = 0;
                        int _r = grdDsachTG.Rows.Count;
                        for (int i = 0; i < _r - 1; i++)
                        {
                            TGnhiemMoi += double.Parse(grdDsachTG[3, i].Value.ToString());
                            TGtuMoi += double.Parse(grdDsachTG[5, i].Value.ToString());
                        }
                        luuDuLieuTong();
                        #endregion

                        FCapNhatTG_Load(sender, e);

                        lbThongBao.Text = "Bạn vừa chỉnh sửa thành công thông tin của quốc gia: " + tenQG;
                        lbThongBao.Visible = true;
                        
                    }
                }
                else
                    MessageBox.Show("Bạn không thể để trống dữ liệu nhập vào!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn quên chọn 1 quốc gia cần chỉnh sửa rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void FCapNhatTG_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeF == true)
            {
                Application.Exit();
            }
        }

    }
}
