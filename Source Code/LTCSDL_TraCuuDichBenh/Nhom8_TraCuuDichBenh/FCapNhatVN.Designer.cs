
namespace Nhom8_TraCuuDichBenh
{
    partial class FCapNhatVN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btGiam = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtNhiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grdDsachVN = new System.Windows.Forms.DataGridView();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKhoi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenTP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNhiemTong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhiemMoiTong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTuTong = new System.Windows.Forms.TextBox();
            this.txtTuMoiTong = new System.Windows.Forms.TextBox();
            this.txtKhoiTong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTKTenTP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDsachVN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGiam
            // 
            this.btGiam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btGiam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGiam.Location = new System.Drawing.Point(297, 302);
            this.btGiam.Name = "btGiam";
            this.btGiam.Size = new System.Drawing.Size(121, 45);
            this.btGiam.TabIndex = 5;
            this.btGiam.Text = "Chỉnh sửa";
            this.toolTip1.SetToolTip(this.btGiam, "Dùng để xóa đi 1 lượng nhất định");
            this.btGiam.UseVisualStyleBackColor = false;
            this.btGiam.Click += new System.EventHandler(this.btGiam_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThem.Location = new System.Drawing.Point(21, 302);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(121, 45);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Cập nhật";
            this.toolTip1.SetToolTip(this.btThem, "Dùng để tăng số lượng");
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtNhiem
            // 
            this.txtNhiem.Location = new System.Drawing.Point(188, 148);
            this.txtNhiem.Name = "txtNhiem";
            this.txtNhiem.Size = new System.Drawing.Size(212, 29);
            this.txtNhiem.TabIndex = 3;
            this.txtNhiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLieu_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ca nhiễm:";
            // 
            // grdDsachVN
            // 
            this.grdDsachVN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.grdDsachVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDsachVN.Location = new System.Drawing.Point(624, 265);
            this.grdDsachVN.MultiSelect = false;
            this.grdDsachVN.Name = "grdDsachVN";
            this.grdDsachVN.ReadOnly = true;
            this.grdDsachVN.RowHeadersWidth = 51;
            this.grdDsachVN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDsachVN.Size = new System.Drawing.Size(510, 373);
            this.grdDsachVN.TabIndex = 10;
            this.grdDsachVN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDsachVN_CellClick);
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(188, 196);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(212, 29);
            this.txtTu.TabIndex = 4;
            this.txtTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLieu_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ca tử vong:";
            // 
            // txtMaTP
            // 
            this.txtMaTP.Enabled = false;
            this.txtMaTP.Location = new System.Drawing.Point(188, 52);
            this.txtMaTP.Name = "txtMaTP";
            this.txtMaTP.Size = new System.Drawing.Size(80, 29);
            this.txtMaTP.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKhoi);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTenTP);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btGiam);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.txtNhiem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaTP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 363);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật thông tin trong ngày";
            // 
            // txtKhoi
            // 
            this.txtKhoi.Location = new System.Drawing.Point(188, 244);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.Size = new System.Drawing.Size(212, 29);
            this.txtKhoi.TabIndex = 5;
            this.txtKhoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLieu_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 24);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ca bình phục:";
            // 
            // txtTenTP
            // 
            this.txtTenTP.Enabled = false;
            this.txtTenTP.Location = new System.Drawing.Point(188, 100);
            this.txtTenTP.Name = "txtTenTP";
            this.txtTenTP.Size = new System.Drawing.Size(212, 29);
            this.txtTenTP.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tên tỉnh thành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã tỉnh thành:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT DIỄN BIẾN DỊCH";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 78);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtMa);
            this.panel2.Controls.Add(this.btQuayLai);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 53);
            this.panel2.TabIndex = 12;
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(1032, 14);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(40, 26);
            this.txtMa.TabIndex = 36;
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btQuayLai.ForeColor = System.Drawing.Color.Black;
            this.btQuayLai.Location = new System.Drawing.Point(41, 4);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(157, 42);
            this.btQuayLai.TabIndex = 0;
            this.btQuayLai.Text = "Quay về";
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(908, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 32);
            this.label13.TabIndex = 35;
            this.label13.Text = "Mã nhân viên:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(12, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ca nhiễm tổng:";
            // 
            // txtNhiemTong
            // 
            this.txtNhiemTong.Enabled = false;
            this.txtNhiemTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhiemTong.ForeColor = System.Drawing.Color.Maroon;
            this.txtNhiemTong.Location = new System.Drawing.Point(135, 143);
            this.txtNhiemTong.Name = "txtNhiemTong";
            this.txtNhiemTong.Size = new System.Drawing.Size(100, 26);
            this.txtNhiemTong.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(463, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ca tử vong tổng:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(241, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ca nhiễm mới:";
            // 
            // txtNhiemMoiTong
            // 
            this.txtNhiemMoiTong.Enabled = false;
            this.txtNhiemMoiTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhiemMoiTong.ForeColor = System.Drawing.Color.Maroon;
            this.txtNhiemMoiTong.Location = new System.Drawing.Point(357, 143);
            this.txtNhiemMoiTong.Name = "txtNhiemMoiTong";
            this.txtNhiemMoiTong.Size = new System.Drawing.Size(100, 26);
            this.txtNhiemMoiTong.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(704, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ca tử vong mới:";
            // 
            // txtTuTong
            // 
            this.txtTuTong.Enabled = false;
            this.txtTuTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuTong.ForeColor = System.Drawing.Color.Maroon;
            this.txtTuTong.Location = new System.Drawing.Point(595, 146);
            this.txtTuTong.Name = "txtTuTong";
            this.txtTuTong.Size = new System.Drawing.Size(100, 26);
            this.txtTuTong.TabIndex = 14;
            // 
            // txtTuMoiTong
            // 
            this.txtTuMoiTong.Enabled = false;
            this.txtTuMoiTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuMoiTong.ForeColor = System.Drawing.Color.Maroon;
            this.txtTuMoiTong.Location = new System.Drawing.Point(829, 146);
            this.txtTuMoiTong.Name = "txtTuMoiTong";
            this.txtTuMoiTong.Size = new System.Drawing.Size(100, 26);
            this.txtTuMoiTong.TabIndex = 18;
            // 
            // txtKhoiTong
            // 
            this.txtKhoiTong.Enabled = false;
            this.txtKhoiTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoiTong.ForeColor = System.Drawing.Color.Maroon;
            this.txtKhoiTong.Location = new System.Drawing.Point(1075, 146);
            this.txtKhoiTong.Name = "txtKhoiTong";
            this.txtKhoiTong.Size = new System.Drawing.Size(100, 26);
            this.txtKhoiTong.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(935, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ca hồi phục tổng:";
            // 
            // lbThongBao
            // 
            this.lbThongBao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.ForeColor = System.Drawing.Color.Maroon;
            this.lbThongBao.Location = new System.Drawing.Point(59, 588);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(436, 50);
            this.lbThongBao.TabIndex = 21;
            this.lbThongBao.Text = "label thông báo";
            this.lbThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbThongBao.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(619, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tìm kiếm theo tên tỉnh thành:";
            // 
            // txtTKTenTP
            // 
            this.txtTKTenTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTKTenTP.Location = new System.Drawing.Point(917, 207);
            this.txtTKTenTP.Multiline = true;
            this.txtTKTenTP.Name = "txtTKTenTP";
            this.txtTKTenTP.Size = new System.Drawing.Size(150, 40);
            this.txtTKTenTP.TabIndex = 1;
            this.txtTKTenTP.TextChanged += new System.EventHandler(this.txtTKTenTP_TextChanged);
            // 
            // FCapNhatVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTKTenTP);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.txtKhoiTong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTuMoiTong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNhiemMoiTong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTuTong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNhiemTong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grdDsachVN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FCapNhatVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật tình hình dịch tại Việt Nam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FCapNhatVN_FormClosing);
            this.Load += new System.EventHandler(this.FCapNhatVN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDsachVN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btGiam;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtNhiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdDsachVN;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNhiemTong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenTP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhiemMoiTong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTuTong;
        private System.Windows.Forms.TextBox txtTuMoiTong;
        private System.Windows.Forms.TextBox txtKhoiTong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKhoi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTKTenTP;
    }
}