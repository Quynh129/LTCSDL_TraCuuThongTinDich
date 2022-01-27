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

namespace Nhom8_TraCuuDichBenh
{
    public partial class FDangNhap : Form
    {
        bool closeF = true;

        QtvBLL qtv_bll = new QtvBLL();
        NhanVienBLL nv_bll = new NhanVienBLL();
        private FTrangChu fHome;
        public FDangNhap(FTrangChu _fHome)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
            txtTDN.Focus();
        }

        #region Các button chuyển form
        private void btQuayLai_Click(object sender, EventArgs e)
        {
            closeF = false;
            fHome.Show();
            this.Close();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTDN.Text == "")
            {
                lbTbao.Text = "Bạn quên nhập tên đăng nhập rồi kìa!";
                lbTbao.Visible = true;
            }    
            else if (txtMK.Text == "")
            {
                lbTbao.Text = "Hình như bạn quên nhập mật khẩu rồi đó!";
                lbTbao.Visible = true;
            }    
            if(txtTDN.Text!="" && txtMK.Text!="")
            {
                FQlyThanhVien fQlyTK = new FQlyThanhVien(fHome, txtTDN.Text);
                FDsChucNang fDs = new FDsChucNang(fHome, txtTDN.Text);
                if (qtv_bll.DangNhap(txtTDN.Text, txtMK.Text) == true)
                {
                    closeF = false;
                    fQlyTK.Show();
                    this.Close();
                }
                else if (nv_bll.DangNhap(txtTDN.Text, txtMK.Text) == true)
                {
                    closeF = false;
                    fDs.Show();
                    this.Close();
                }
                else 
                {
                    lbTbao.Text = "Tên đăng nhập hoặc mật khẩu sai! Hãy thử nhập lại lần nữa.";
                    lbTbao.Visible = true;
                }
            }


        }
        #endregion

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được khoảng trắng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked)
                txtMK.PasswordChar = (char)0;
            else
                txtMK.PasswordChar = char.Parse("*");
        }

        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked)
                txtMK.PasswordChar = (char)0;
            else
                txtMK.PasswordChar = char.Parse("*");
        }

        private void FDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeF == true)
            {
                Application.Exit();
            }
        }
    }
}
