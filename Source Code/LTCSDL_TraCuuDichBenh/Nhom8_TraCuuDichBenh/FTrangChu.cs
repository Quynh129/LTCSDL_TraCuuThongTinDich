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
    public partial class FTrangChu : Form
    {
        TheGioiBLL tg_bll = new TheGioiBLL();
        VietNamBLL vn_bll = new VietNamBLL();
        ConnectData _dt = new ConnectData();

        public FTrangChu()
        {
            InitializeComponent();
        }

        private void FTrangChu_Load(object sender, EventArgs e)
        {
            DataTable dt = _dt.GetData("select TGNhiemTong, TGTuTong, TGKhoiTong from TheGioi where MaQG = ('QG00')");
            lbTGnhiem.DataBindings.Add("Text", dt, "TGNhiemTong", true);
            lbTGtu.DataBindings.Add("Text", dt, "TGTuTong", true);
            lbTGKhoi.DataBindings.Add("Text", dt, "TGKhoiTong", true);

            DataTable dt2 = _dt.GetData("select NhiemTong, TuTong from VietNam where MaTP = ('00')");
            lbVNnhiem.DataBindings.Add("Text", dt2, "NhiemTong", true);
            lbVNtu.DataBindings.Add("Text", dt2, "TuTong", true);
            DataTable dt3 = _dt.GetData("select TGNhiemTong, TGTuTong, TGKhoiTong from TheGioi where MaQG = ('QG32')");
            lbVNkhoi.DataBindings.Add("Text", dt3, "TGKhoiTong", true);
            
        }

        #region Các button chuyển form
        private void btTheGioi_Click(object sender, EventArgs e)
        {
            FThongTinTG fTG = new FThongTinTG(this);
            fTG.Show();
            this.Hide();
        }

        private void btVietNam_Click(object sender, EventArgs e)
        {
            FThongTinVN fVN = new FThongTinVN(this);
            fVN.Show();
            this.Hide();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            FThongKe fTop = new FThongKe(this);
            fTop.Show();
            this.Hide();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            FDangNhap flogin = new FDangNhap(this);
            flogin.Show();
            this.Hide();
        }
        #endregion

        private void FTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
