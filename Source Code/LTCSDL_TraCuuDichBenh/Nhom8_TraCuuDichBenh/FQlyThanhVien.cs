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
    public partial class FQlyThanhVien : Form
    {
        bool closeF = true;

        NhanVienBLL nv_bll = new NhanVienBLL();
        QtvBLL qtv_bll = new QtvBLL();

        private FTrangChu fHome;
        ConnectData _dt = new ConnectData();
        private string tdn, _maAdmin;
        bool flag = false;
        bool check = true;//có tồn tại

        public FQlyThanhVien(FTrangChu _fHome, string _tdn)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
            tdn = _tdn;
        }

        private void FQlyThanhVien_Load(object sender, EventArgs e)
        {
            if (flag == false)
            {
                DataTable dtM = _dt.GetData("select * from Qtv where TenUser = '" + tdn + "'");
                txtMaAdmin.DataBindings.Add("Text", dtM, "MaAdmin", true);
                _maAdmin = txtMaAdmin.Text;
                flag = true;
            }
            else
                txtMaAdmin.Text = _maAdmin;

            #region định dạng datagrid
            this.grdDsachTaiKhoan.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            this.grdDsachTaiKhoan.EnableHeadersVisualStyles = false;
            this.grdDsachTaiKhoan.ColumnHeadersDefaultCellStyle.ForeColor = Color.Indigo;
            this.grdDsachTaiKhoan.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            this.grdDsachTaiKhoan.DefaultCellStyle.BackColor = Color.AliceBlue;
            this.grdDsachTaiKhoan.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            this.grdDsachTaiKhoan.DefaultCellStyle.SelectionForeColor = Color.OrangeRed;
            this.grdDsachTaiKhoan.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;

            grdDsachTaiKhoan.Columns[0].Width = (int)(grdDsachTaiKhoan.Width * 0.1);
            grdDsachTaiKhoan.Columns["MaNV"].Width = (int)(grdDsachTaiKhoan.Width * 0.15);
            grdDsachTaiKhoan.Columns["TenUser"].Width = (int)(grdDsachTaiKhoan.Width * 0.3);
            grdDsachTaiKhoan.Columns["Password"].Width = (int)(grdDsachTaiKhoan.Width * 0.3);
            grdDsachTaiKhoan.Columns["MaAdmin"].Width = (int)(grdDsachTaiKhoan.Width * 0.15);
            #endregion

            grdDsachTaiKhoan.DataSource = nv_bll.GetList();
            //grdDsachTaiKhoan.DataSource = tg_bll.GetListUp();

            ResetGridview();
        }

        #region Các button chuyển form
        private void btDangXuat_Click(object sender, EventArgs e)
        {
            closeF = false;
            fHome.Show();
            this.Close();
        }
        #endregion

        private void ResetGridview()
        {
            txtMaTK.ResetText();
            txtTenTK.ResetText();
            txtMK.ResetText();
            txtMaAd.ResetText();
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chỉ cho nhập số
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được khoảng trắng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDsachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdDsachTaiKhoan.Rows[e.RowIndex];
                txtMaTK.Text = row.Cells[0].Value.ToString();
                txtTenTK.Text = row.Cells[1].Value.ToString();
                txtMK.Text = row.Cells[2].Value.ToString();
                txtMaAd.Text = row.Cells[3].Value.ToString();
            }
        }

        private double taoMaNV()
        {
            double max = 1;
            DataTable dt = _dt.GetData("select MaNV from NhanVien");
            if (dt != null && dt.Rows.Count > 0)
            {
                max = double.Parse(dt.Rows[0][0].ToString());

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (max < double.Parse(dt.Rows[i][0].ToString()))
                        max = double.Parse(dt.Rows[i][0].ToString());//dòng cột
                }
                max++;
            }
            return max;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            check = true;
            if (txtTenTK.Text.Trim() != "" && txtMK.Text.Trim() != "")
            {
                if (txtMaAd.Text.Trim() != "")
                {
                    bool chkMa = qtv_bll.kiemTaTonTai(txtMaAd.Text); //có: true
                    if (chkMa == false) check = false; //ko có mã admin này
                }
                if (txtMK.Text.Length < 3 || txtMK.Text.Length > 10)
                    check = false;
                if(check)
                {
                    NhanVienDTO nv = new NhanVienDTO();
                    if (txtMaTK.Text.Trim() == "")
                        nv.MaNv = taoMaNV();
                    else nv.MaNv = double.Parse(txtMaTK.Text); //xảy ra khi người dùng đã chọn 1 hàng trong grid và ấn thêm tiếp
                    nv.TenUser = txtTenTK.Text;
                    nv.Password = txtMK.Text;
                    nv.TonTai = 1;
                    if (txtMaAd.Text.Trim() == "")
                        nv.MaAdmin = txtMaAdmin.Text;
                    else
                        nv.MaAdmin = txtMaAd.Text;

                    int chk = nv_bll.Them(nv);
                    if (chk == -1)
                    {
                        lbThongBao.Text = "Mã tài khoản nhân viên " + nv.MaNv + " đã tồn tại!";
                        lbThongBao.Visible = true;
                    }
                    else if (chk == 1)
                    {
                        lbThongBao.Text = "Bạn vừa thêm nhân viên có mã tài khoản là " + nv.MaNv + " !";
                        lbThongBao.Visible = true;
                        FQlyThanhVien_Load(sender, e);
                    }
                }                
                else
                {
                    if (txtMK.Text.Length < 3 || txtMK.Text.Length > 10)
                    {
                        lbThongBao.Text = "Mật khẩu phải có từ 3-10 ký tự";
                        lbThongBao.Visible = true;
                    }
                    else
                    {
                        lbThongBao.Text = "Mã tài khoản quản trị viên " + txtMaAd.Text + " không tồn tại!";
                        lbThongBao.Visible = true;
                    }    
                        
                }
            }
            else
            {
                if (txtTenTK.Text.Trim() == "")
                {
                    lbThongBao.Text = "Không được để trống tên đăng nhập!";
                    lbThongBao.Visible = true;
                }
                else if (txtMK.Text.Trim() == "")
                {
                    lbThongBao.Text = "Không được để trống tên mật khẩu!";
                    lbThongBao.Visible = true;
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            check = true;
            if (txtMaTK.Text.Trim() != "")
            {
                if (txtTenTK.Text.Trim() != "" && txtMK.Text.Trim() != "")
                {
                    if (txtMaAd.Text.Trim() != "")
                    {
                        bool chkMa = qtv_bll.kiemTaTonTai(txtMaAd.Text); //có: true
                        if (chkMa == false) check = false; //ko có mã admin này
                    }
                    if (txtMK.Text.Length < 3 || txtMK.Text.Length > 10)
                        check = false;
                    if (check)
                    {
                        NhanVienDTO nv = new NhanVienDTO();
                        nv.MaNv = double.Parse(txtMaTK.Text);
                        nv.TenUser = txtTenTK.Text;
                        nv.Password = txtMK.Text;
                        if (txtMaAd.Text.Trim() == "")
                            nv.MaAdmin = txtMaAdmin.Text;
                        else
                            nv.MaAdmin = txtMaAd.Text;

                        nv_bll.Sua(nv);
                        lbThongBao.Text = "Bạn vừa cập nhật thông tin nhân viên có mã tài khoản là " + nv.MaNv + " !";
                        lbThongBao.Visible = true;
                        FQlyThanhVien_Load(sender, e);

                    }
                    else
                    {
                        if (txtMK.Text.Length < 3 || txtMK.Text.Length > 10)
                        {
                            lbThongBao.Text = "Mật khẩu phải có từ 3-10 ký tự";
                            lbThongBao.Visible = true;
                        }
                        else
                        {
                            lbThongBao.Text = "Mã tài khoản quản trị viên " + txtMaAd.Text + " không tồn tại!";
                            lbThongBao.Visible = true;
                        }

                    }
                }
                else
                {
                    if (txtTenTK.Text.Trim() == "")
                    {
                        lbThongBao.Text = "Không được để trống tên đăng nhập!";
                        lbThongBao.Visible = true;
                    }
                    else if (txtMK.Text.Trim() == "")
                    {
                        lbThongBao.Text = "Không được để trống tên mật khẩu!";
                        lbThongBao.Visible = true;
                    }
                }
            }
            else
            {
                lbThongBao.Text = "Phải chọn 1 tài khoản nhân viên cần chỉnh sửa!";
                lbThongBao.Visible = true;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTK.Text.Trim() != "")
            {
                nv_bll.Xoa(txtMaTK.Text);
                lbThongBao.Text = "Bạn vừa xóa tài khoản nhân viên có mã tài khoản là " + txtMaTK.Text + " !";
                lbThongBao.Visible = true;
                FQlyThanhVien_Load(sender, e);

            }
        }

        private void FQlyThanhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeF == true)
            {
                Application.Exit();
            }
        }

    }
}
