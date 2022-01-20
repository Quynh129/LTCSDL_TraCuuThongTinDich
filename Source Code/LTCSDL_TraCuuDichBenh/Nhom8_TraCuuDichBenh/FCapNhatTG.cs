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
        TheGioiBLL tg_bll = new TheGioiBLL();
        ConnectData dt = new ConnectData();
        #region bien toan cuc
        // string maQG, tenQG;
        double nhiemTong, nhiemMoi, tuTong, tuMoi, khoiMoi, khoiTong; // TG: hang duoc chon
        double TGnhiemTong, TGnhiemMoi, TGtuTong, TGtuMoi, TGkhoiTong;// TG: hang tong QG00


        #endregion
        public FCapNhatTG()
        {
            InitializeComponent();
        }

        private void FCapNhatTG_Load(object sender, EventArgs e)
        {
            grdDsachTG.DataSource = tg_bll.GetListUp();

            #region Đọc dlieu hàng QG00 từ bảng TG

            DataTable dt2 = dt.GetData("select * from TheGioi where MaQG = 'QG00'");
            lbTGnhiemTong.DataBindings.Clear();
            lbTGnhiemTong.DataBindings.Add("text", dt2, "TGNhiemTong", true);
            lbTGnhiemMoi.DataBindings.Clear();
            lbTGnhiemMoi.DataBindings.Add("text", dt2, "TGNhiemMoi", true);
            lbTGTuTong.DataBindings.Clear();
            lbTGTuTong.DataBindings.Add("text", dt2, "TGTuTong", true);
            lbTGTumoi.DataBindings.Clear();
            lbTGTumoi.DataBindings.Add("text", dt2, "TGTuMoi", true);
            lbTGKhoiTong.DataBindings.Clear();
            lbTGKhoiTong.DataBindings.Add("text", dt2, "TGKhoiTong", true);
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

        private void grdDsachTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdDsachTG.Rows[e.RowIndex];
                txtMaQG.Text = row.Cells[0].Value.ToString();
                txtTenQG.Text = row.Cells[1].Value.ToString();
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

                if (txtMaQG.Text == "QG00")
                    MessageBox.Show("Bạn không thể cập nhật trường này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void btThem_Click(object sender, EventArgs e)
        {
            // lay du lieu 
            nhiemMoi = int.Parse(txtNhiem.Text);
            tuMoi = int.Parse(txtTu.Text);
            khoiMoi = int.Parse(txtKhoi.Text);

            //lay du lieu hang QG00
            TGnhiemTong = int.Parse(lbTGKhoiTong.Text);
            TGnhiemMoi = int.Parse(lbTGnhiemMoi.Text);
            TGtuTong = int.Parse(lbTGTuTong.Text);
            TGtuMoi = int.Parse(lbTGTumoi.Text);
            TGkhoiTong = int.Parse(lbTGKhoiTong.Text);

            // hang chon
            nhiemTong += nhiemMoi;
            tuTong += tuMoi;
            khoiTong += khoiMoi;

            // hang tong QG00
            TGnhiemTong += nhiemMoi;
            TGnhiemMoi += nhiemMoi;
            TGtuTong += tuMoi;
            TGtuMoi += tuMoi;
            TGkhoiTong += khoiMoi;

            // luu hang chon
            TheGioiDTO _tg = new TheGioiDTO();
            _tg.MaQg = txtMaQG.Text;
            _tg.TgnhiemTong = nhiemTong;
            _tg.TgnhiemMoi = nhiemMoi;
            _tg.TgtuTong = tuTong;
            _tg.TgtuMoi = tuMoi;
            _tg.TgkhoiTong = khoiTong;
            tg_bll.CapNhat(_tg);
            // Luu vao QG00
            TheGioiDTO _tg1 = new TheGioiDTO();
            _tg1.MaQg = "QG00";
            _tg1.TgnhiemTong = TGnhiemTong;
            _tg1.TgnhiemMoi = TGnhiemMoi;
            _tg1.TgtuTong = TGtuTong;
            _tg1.TgtuMoi = TGtuMoi;
            _tg1.TgkhoiTong = TGkhoiTong;
            tg_bll.CapNhat(_tg1);
            FCapNhatTG_Load(sender, e);



        }
        private void btGiam_Click(object sender, EventArgs e)
        {
            // lay du lieu 
            nhiemMoi = int.Parse(txtNhiem.Text);
            tuMoi = int.Parse(txtTu.Text);
            khoiMoi = int.Parse(txtKhoi.Text);

            //lay du lieu hang QG00
            TGnhiemTong = int.Parse(lbTGKhoiTong.Text);
            TGnhiemMoi = int.Parse(lbTGnhiemMoi.Text);
            TGtuTong = int.Parse(lbTGTuTong.Text);
            TGtuMoi = int.Parse(lbTGTumoi.Text);
            TGkhoiTong = int.Parse(lbTGKhoiTong.Text);

            // hang chon
            nhiemTong -= nhiemMoi;
            nhiemMoi -= nhiemMoi;
            tuTong -= tuMoi;
            tuMoi -= tuMoi;
            khoiTong -= khoiMoi;

            // hang tong QG00
            TGnhiemTong -= nhiemMoi;
            TGnhiemMoi -= nhiemMoi;
            TGtuTong -= tuMoi;
            TGtuMoi -= tuMoi;
            TGkhoiTong -= khoiMoi;

            // luu hang chon
            TheGioiDTO _tg = new TheGioiDTO();
            _tg.MaQg = txtMaQG.Text;
            _tg.TgnhiemTong = nhiemTong;
            _tg.TgnhiemMoi = nhiemMoi;
            _tg.TgtuTong = tuTong;
            _tg.TgtuMoi = tuMoi;
            _tg.TgkhoiTong = khoiTong;
            tg_bll.CapNhat(_tg);
            // Luu vao QG00
            TheGioiDTO _tg1 = new TheGioiDTO();
            _tg1.MaQg = "QG00";
            _tg1.TgnhiemTong = TGnhiemTong;
            _tg1.TgnhiemMoi = TGnhiemMoi;
            _tg1.TgtuTong = TGtuTong;
            _tg1.TgtuMoi = TGtuMoi;
            _tg1.TgkhoiTong = TGkhoiTong;
            tg_bll.CapNhat(_tg1);
            FCapNhatTG_Load(sender, e);

        }

    }
}
