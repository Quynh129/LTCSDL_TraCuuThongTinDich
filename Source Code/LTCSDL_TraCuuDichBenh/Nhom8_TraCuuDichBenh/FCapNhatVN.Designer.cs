
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
            this.label6 = new System.Windows.Forms.Label();
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
            this.txtTenTP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNhiemTong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhiemMoiTong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTuTong = new System.Windows.Forms.TextBox();
            this.txtTuMoiTong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDsachVN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thông tin Việt Nam:";
            // 
            // btGiam
            // 
            this.btGiam.Location = new System.Drawing.Point(297, 302);
            this.btGiam.Name = "btGiam";
            this.btGiam.Size = new System.Drawing.Size(121, 45);
            this.btGiam.TabIndex = 9;
            this.btGiam.Text = "Chỉnh sửa";
            this.toolTip1.SetToolTip(this.btGiam, "Dùng để xóa đi 1 lượng nhất định");
            this.btGiam.UseVisualStyleBackColor = true;
            this.btGiam.Click += new System.EventHandler(this.btGiam_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(21, 302);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(121, 45);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Cập nhật";
            this.toolTip1.SetToolTip(this.btThem, "Dùng để tăng số lượng");
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtNhiem
            // 
            this.txtNhiem.Location = new System.Drawing.Point(190, 178);
            this.txtNhiem.Name = "txtNhiem";
            this.txtNhiem.Size = new System.Drawing.Size(212, 26);
            this.txtNhiem.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ca nhiễm:";
            // 
            // grdDsachVN
            // 
            this.grdDsachVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDsachVN.Location = new System.Drawing.Point(624, 265);
            this.grdDsachVN.Name = "grdDsachVN";
            this.grdDsachVN.RowHeadersWidth = 51;
            this.grdDsachVN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDsachVN.Size = new System.Drawing.Size(510, 373);
            this.grdDsachVN.TabIndex = 10;
            this.grdDsachVN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDsachVN_CellClick);
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(190, 232);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(212, 26);
            this.txtTu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ca tử vong:";
            // 
            // txtMaTP
            // 
            this.txtMaTP.Enabled = false;
            this.txtMaTP.Location = new System.Drawing.Point(190, 52);
            this.txtMaTP.Name = "txtMaTP";
            this.txtMaTP.Size = new System.Drawing.Size(80, 26);
            this.txtMaTP.TabIndex = 1;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 363);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật thông tin trong ngày";
            // 
            // txtTenTP
            // 
            this.txtTenTP.Location = new System.Drawing.Point(190, 113);
            this.txtTenTP.Name = "txtTenTP";
            this.txtTenTP.Size = new System.Drawing.Size(212, 26);
            this.txtTenTP.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tên tỉnh thành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
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
            this.panel2.Controls.Add(this.btQuayLai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 53);
            this.panel2.TabIndex = 12;
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btQuayLai.ForeColor = System.Drawing.Color.Black;
            this.btQuayLai.Location = new System.Drawing.Point(41, 4);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(157, 42);
            this.btQuayLai.TabIndex = 5;
            this.btQuayLai.Text = "Quay về";
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(12, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ca nhiễm tổng:";
            // 
            // txtNhiemTong
            // 
            this.txtNhiemTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhiemTong.ForeColor = System.Drawing.Color.Maroon;
            this.txtNhiemTong.Location = new System.Drawing.Point(153, 146);
            this.txtNhiemTong.Name = "txtNhiemTong";
            this.txtNhiemTong.Size = new System.Drawing.Size(128, 26);
            this.txtNhiemTong.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(867, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ca tử vong tổng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(296, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ca nhiễm mới:";
            // 
            // txtNhiemMoiTong
            // 
            this.txtNhiemMoiTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhiemMoiTong.ForeColor = System.Drawing.Color.Maroon;
            this.txtNhiemMoiTong.Location = new System.Drawing.Point(440, 146);
            this.txtNhiemMoiTong.Name = "txtNhiemMoiTong";
            this.txtNhiemMoiTong.Size = new System.Drawing.Size(111, 26);
            this.txtNhiemMoiTong.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(577, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ca tử vong mới:";
            // 
            // txtTuTong
            // 
            this.txtTuTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuTong.ForeColor = System.Drawing.Color.Maroon;
            this.txtTuTong.Location = new System.Drawing.Point(1029, 149);
            this.txtTuTong.Name = "txtTuTong";
            this.txtTuTong.Size = new System.Drawing.Size(143, 26);
            this.txtTuTong.TabIndex = 14;
            // 
            // txtTuMoiTong
            // 
            this.txtTuMoiTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuMoiTong.ForeColor = System.Drawing.Color.Maroon;
            this.txtTuMoiTong.Location = new System.Drawing.Point(732, 147);
            this.txtTuMoiTong.Name = "txtTuMoiTong";
            this.txtTuMoiTong.Size = new System.Drawing.Size(106, 26);
            this.txtTuMoiTong.TabIndex = 18;
            // 
            // FCapNhatVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.txtTuMoiTong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNhiemMoiTong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTuTong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNhiemTong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grdDsachVN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FCapNhatVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCapNhatVN";
            this.Load += new System.EventHandler(this.FCapNhatVN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDsachVN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
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
    }
}