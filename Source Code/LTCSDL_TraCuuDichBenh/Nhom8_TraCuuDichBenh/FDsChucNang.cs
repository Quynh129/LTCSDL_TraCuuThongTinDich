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
    public partial class FDsChucNang : Form
    {
        bool closeF = true;

        private FTrangChu fHome;
        ConnectData _dt = new ConnectData();
        private string tdn, maNV;
        bool flag = false;
        public FDsChucNang(FTrangChu _fHome, string _tdn)
        {
            InitializeComponent();
            fHome = _fHome; //liên kết form
            tdn = _tdn;
        }

        private void FDsChucNang_Load(object sender, EventArgs e)
        {
            txtTen.Text = tdn;
            if (flag == false)
            {
                DataTable dt = _dt.GetData("select * from NhanVien where TenUser = '" + tdn + "'");
                txtMa.DataBindings.Add("Text", dt, "MaNV", true);
                maNV = txtMa.Text;
                flag = true;
            }
            else
                txtMa.Text = maNV;
        }

        #region Các button chuyển form
        private void btDangXuat_Click(object sender, EventArgs e)
        {
            closeF = false;
            fHome.Show();
            fHome.Update();
            this.Close();
        }

        private void btUpTheGioi_Click(object sender, EventArgs e)
        {
            closeF = false;
            FCapNhatTG fUpTG = new FCapNhatTG(tdn);
            fUpTG.Show();
            this.Close();
        }

        private void btUpVietNam_Click(object sender, EventArgs e)
        {
            closeF = false;
            FCapNhatVN fUpVN = new FCapNhatVN(tdn);
            fUpVN.Show();
            this.Close();
        }

        private void btUpVN1_Click(object sender, EventArgs e)
        {
            closeF = false;
            FCapNhatVN1 fUpVN1 = new FCapNhatVN1(tdn);
            fUpVN1.Show();
            this.Close();
        }
        #endregion

        private void FDsChucNang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeF == true)
            {
                Application.Exit();
            }
        }

    }
}
