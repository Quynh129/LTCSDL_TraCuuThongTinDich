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
    public partial class FCapNhatVN1 : Form
    {
        bool closeF = true;

        VietNamBLL vn_bll = new VietNamBLL();
        ConnectData dt = new ConnectData();

        #region Lấy mã nhân viên
        private string tdn, maNV;
        bool flag = false;
        #endregion

        #region bien toan cuc
        String MaTp, tenTP;
        double tiemMot, tiemDu; // VN: hang duoc chon
        double txt_tiemMot, txt_tiemDu; // txt nhập
        double VNTiemMot, VNTiemDu;// VN: hang tong VN00
        #endregion

        public FCapNhatVN1(string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
        }

        private void FCapNhatVN1_Load(object sender, EventArgs e)
        {
            
            if (flag == false)
            {
                DataTable _dt = dt.GetData("select * from NhanVien where TenUser = '" + tdn + "'");
                txtMa.DataBindings.Add("Text", _dt, "MaNV", true);
                maNV = txtMa.Text;
                flag = true;
            }
            else
                txtMa.Text = maNV;

            #region định dạng datagrid
            this.grdDsachVN1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            this.grdDsachVN1.EnableHeadersVisualStyles = false;
            this.grdDsachVN1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Indigo;
            this.grdDsachVN1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            this.grdDsachVN1.DefaultCellStyle.BackColor = Color.AliceBlue;
            this.grdDsachVN1.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            this.grdDsachVN1.DefaultCellStyle.SelectionForeColor = Color.OrangeRed;
            this.grdDsachVN1.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
            #endregion
            grdDsachVN1.DataSource = vn_bll.GetList_TiemChung();

            #region Doc du lieu hàng VN00 từ bảng VN
            DataTable dt1 = dt.GetData("select * from VietNam where MaTP = '00'");
            txtMui1Tong.DataBindings.Clear();
            txtMui1Tong.DataBindings.Add("Text", dt1, "TiemMot", true);
            txtMui2Tong.DataBindings.Clear();
            txtMui2Tong.DataBindings.Add("Text", dt1, "TiemDu", true);
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
                grdDsachVN1.DataSource = vn_bll.GetList_TiemChung();
            }
            else
                grdDsachVN1.DataSource = vn_bll.TimKiemVN_TiemChung(txtTKTenTP.Text);
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
        
        private void grdDsachVN1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                DataGridViewRow row = this.grdDsachVN1.Rows[e.RowIndex];
                txtMaTP.Text = row.Cells[0].Value.ToString();
                txtTenTP.Text = row.Cells[1].Value.ToString();
                tiemMot = int.Parse(row.Cells[2].Value.ToString());
                tiemDu = int.Parse(row.Cells[3].Value.ToString());
                tenTP = txtTenTP.Text;
            }
        }

        private void ResetGridview()
        {
            txtMaTP.ResetText();
            txtTenTP.ResetText();
            txtMuiMot.ResetText();
            txtMuiHai.ResetText();
        }

        private void layDuLieu()
        {
            //Lấy dữ liệu từ textbox (hàng chọn):
            txt_tiemMot = int.Parse(txtMuiMot.Text);
            txt_tiemDu = int.Parse(txtMuiHai.Text);

            //Lấy dữ liệu hàng tổng:
            VNTiemMot = int.Parse(txtMui1Tong.Text);
            VNTiemDu = int.Parse(txtMui2Tong.Text);
        }

        private void luuDuLieuVN1()
        {
            //Gán dữ liệu vào hàng chọn i:
            VietNamDTO vn = new VietNamDTO();
            vn.MaTp = txtMaTP.Text;
            vn.TiemMot = tiemMot;
            vn.TiemDu = tiemDu;
            vn.MaNv = double.Parse(maNV);
            vn_bll.CapNhatVN1(vn);
            //Gán dữ liệu vào hàng tổng 00 của bảng VN:
            VietNamDTO vn1 = new VietNamDTO();
            vn1.MaTp = "00";
            vn1.TiemMot = VNTiemMot;
            vn1.TiemDu = VNTiemDu;
            vn1.MaNv = double.Parse(maNV);
            vn_bll.CapNhatVN1(vn1);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaTP.Text.Trim() != "")
            {
                if(txtMuiMot.Text.Trim() != "" && txtMuiHai.Text.Trim() != "")
                {
                    layDuLieu();
                    #region hàng chọn
                    tiemMot += txt_tiemMot;
                    tiemDu += txt_tiemDu;
                    #endregion

                    #region hàng tổng
                    VNTiemMot += txt_tiemMot;
                    VNTiemDu += txt_tiemDu;
                    #endregion
                    luuDuLieuVN1();
                    FCapNhatVN1_Load(sender, e);
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
            if (txtMaTP.Text.Trim() != "")
            {
                if (txtMuiMot.Text.Trim() != "" && txtMuiHai.Text.Trim() != "")
                {
                    layDuLieu();
                    #region hàng chọn
                    tiemMot -= txt_tiemMot;
                    tiemDu -= txt_tiemDu;
                    #endregion

                    #region hàng tổng
                    VNTiemMot -= txt_tiemMot;
                    VNTiemDu -= txt_tiemDu;
                    #endregion
                    luuDuLieuVN1();
                    FCapNhatVN1_Load(sender, e);
                    lbThongBao.Text = "Bạn vừa chỉnh sửa thành công thông tin của tỉnh thành: " + tenTP;
                    lbThongBao.Visible = true;
                }
                else
                    MessageBox.Show("Bạn không thể để trống dữ liệu nhập vào!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn quên chọn 1 tỉnh thành cần cập nhật rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FCapNhatVN1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeF == true)
            {
                Application.Exit();
            }
        }


    }
}
