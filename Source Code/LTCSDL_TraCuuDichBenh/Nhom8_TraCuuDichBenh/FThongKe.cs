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
    public partial class FThongKe : Form
    {
        bool closeF = true;

        VietNamBLL vn = new VietNamBLL();
        TheGioiBLL tg = new TheGioiBLL();

        private FTrangChu fHome;
        public FThongKe(FTrangChu _fHome)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
        }

        private void FThongKe_Load(object sender, EventArgs e)
        {
            gridDsTG.DataSource = tg.GetListInfoTG();
            gridDsVN.DataSource = vn.GetListInfoVN();

            #region định dạng datagrid TG
            this.gridDsTG.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            this.gridDsTG.EnableHeadersVisualStyles = false;
            this.gridDsTG.ColumnHeadersDefaultCellStyle.ForeColor = Color.Indigo;
            this.gridDsTG.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            this.gridDsTG.DefaultCellStyle.BackColor = Color.AliceBlue;
            this.gridDsTG.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            this.gridDsTG.DefaultCellStyle.SelectionForeColor = Color.OrangeRed;
            this.gridDsTG.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
            #endregion

            #region định dạng datagrid VN
            this.gridDsVN.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            this.gridDsVN.EnableHeadersVisualStyles = false;
            this.gridDsVN.ColumnHeadersDefaultCellStyle.ForeColor = Color.Indigo;
            this.gridDsVN.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            this.gridDsVN.DefaultCellStyle.BackColor = Color.AliceBlue;
            this.gridDsVN.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            this.gridDsVN.DefaultCellStyle.SelectionForeColor = Color.OrangeRed;
            this.gridDsVN.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
            #endregion
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

        private void btVietNam_Click(object sender, EventArgs e)
        {
            closeF = false;
            FThongTinVN fTG = new FThongTinVN(fHome);
            fTG.Show();
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

        private void txtTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Vị trí này chỉ được nhập số!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTopTG_TextChanged(object sender, EventArgs e)
        {
            if(txtTopTG.Text == "")
            {
                if (rdbTGNhiemTong.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(229, "TGNhiemTong");
                else if (rdbTGNhiemMoi.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(229, "TGNhiemMoi");
                else if (rdbTGTuTong.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(229, "TGTuTong");
                else if (rdbTGTuMoi.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(229, "TGTuMoi");
                else if (rdbTGKhoi.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(229, "TGKhoiTong");
            }
            else
            {
                if (rdbTGNhiemTong.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(int.Parse(txtTopTG.Text), "TGNhiemTong");
                else if (rdbTGNhiemMoi.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(int.Parse(txtTopTG.Text), "TGNhiemMoi");
                else if (rdbTGTuTong.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(int.Parse(txtTopTG.Text), "TGTuTong");
                else if (rdbTGTuMoi.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(int.Parse(txtTopTG.Text), "TGTuMoi");
                else if (rdbTGKhoi.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(int.Parse(txtTopTG.Text), "TGKhoiTong");
            }
        }

        private void txtTopVN_TextChanged(object sender, EventArgs e)
        {
            if (txtTopVN.Text == "")
            {
                if (rdbVNNhiemTong.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(63, "NhiemTong");
                else if (rdbVNNhiemMoi.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(63, "NhiemMoi");
                else if (rdbVNTuTong.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(63, "TuTong");
                else if (rdbVNTuMoi.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(63, "TuMoi");
                else if (rdbVNMui1.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(63, "TiemMot");
                else if (rdbVNMui2.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(63, "TiemDu");
            }
            else
            {
                if (rdbVNNhiemTong.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(int.Parse(txtTopVN.Text), "NhiemTong");
                else if (rdbVNNhiemMoi.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(int.Parse(txtTopVN.Text), "NhiemMoi");
                else if (rdbVNTuTong.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(int.Parse(txtTopVN.Text), "TuTong");
                else if (rdbVNTuMoi.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(int.Parse(txtTopVN.Text), "TuMoi");
                else if (rdbVNMui1.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(int.Parse(txtTopVN.Text), "TiemMot");
                else if (rdbVNMui2.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(int.Parse(txtTopVN.Text), "TiemDu");
            }
        }

        private void rdbTG_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTopTG.Text == "")
            {
                if (rdbTGNhiemTong.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(229, "TGNhiemTong");
                else if (rdbTGNhiemMoi.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(229, "TGNhiemMoi");
                else if (rdbTGTuTong.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(229, "TGTuTong");
                else if (rdbTGTuMoi.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(229, "TGTuMoi");
                else if (rdbTGKhoi.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(229, "TGKhoiTong");
            }
            else
            {
                if (rdbTGNhiemTong.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(int.Parse(txtTopTG.Text), "TGNhiemTong");
                else if (rdbTGNhiemMoi.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(int.Parse(txtTopTG.Text), "TGNhiemMoi");
                else if (rdbTGTuTong.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(int.Parse(txtTopTG.Text), "TGTuTong");
                else if (rdbTGTuMoi.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(int.Parse(txtTopTG.Text), "TGTuMoi");
                else if (rdbTGKhoi.Checked == true)
                    gridDsTG.DataSource = tg.GetListTG_Top(int.Parse(txtTopTG.Text), "TGKhoiTong");
            }

            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked == true)
                rdb.ForeColor = Color.OrangeRed;
            else
                rdb.ForeColor = Color.Black;
        }

        private void rdbVN_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTopVN.Text == "")
            {
                if (rdbVNNhiemTong.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(63, "NhiemTong");
                else if (rdbVNNhiemMoi.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(63, "NhiemMoi");
                else if (rdbVNTuTong.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(63, "TuTong");
                else if (rdbVNTuMoi.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(63, "TuMoi");
                else if (rdbVNMui1.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(63, "TiemMot");
                else if (rdbVNMui2.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(63, "TiemDu");
            }
            else
            {
                if (rdbVNNhiemTong.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(int.Parse(txtTopVN.Text), "NhiemTong");
                else if (rdbVNNhiemMoi.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(int.Parse(txtTopVN.Text), "NhiemMoi");
                else if (rdbVNTuTong.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(int.Parse(txtTopVN.Text), "TuTong");
                else if (rdbVNTuMoi.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(int.Parse(txtTopVN.Text), "TuMoi");
                else if (rdbVNMui1.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(int.Parse(txtTopVN.Text), "TiemMot");
                else if (rdbVNMui2.Checked == true)
                    gridDsVN.DataSource = vn.GetListVN_Top(int.Parse(txtTopVN.Text), "TiemDu");
            }

            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked == true)
                rdb.ForeColor = Color.OrangeRed;
            else
                rdb.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(txtTopTG.Text != "")
            {
                if (int.Parse(txtTopTG.Text) <= 0 || int.Parse(txtTopTG.Text) >= 230)
                {
                    txtTopTG.Text = "";
                    MessageBox.Show("Chỉ được nhập từ 1 tới 229", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (txtTopVN.Text != "")
            {
                if (int.Parse(txtTopVN.Text) <= 0 || int.Parse(txtTopVN.Text) >= 64)
                {
                    txtTopVN.Text = "";
                    MessageBox.Show("Chỉ được nhập từ 1 tới 229", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closeF == true)
            {
                    Application.Exit();
            }    
        }
    }
}
