
namespace Nhom8_TraCuuDichBenh
{
    partial class FDangNhap
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
            this.btQuayLai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkHienThiMK = new System.Windows.Forms.CheckBox();
            this.lbTbao = new System.Windows.Forms.Label();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuayLai.Location = new System.Drawing.Point(25, 22);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(118, 53);
            this.btQuayLai.TabIndex = 4;
            this.btQuayLai.Text = "Quay về";
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.chkHienThiMK);
            this.panel1.Controls.Add(this.lbTbao);
            this.panel1.Controls.Add(this.btDangNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTDN);
            this.panel1.Location = new System.Drawing.Point(227, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 392);
            this.panel1.TabIndex = 1;
            // 
            // chkHienThiMK
            // 
            this.chkHienThiMK.AutoSize = true;
            this.chkHienThiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienThiMK.Location = new System.Drawing.Point(267, 244);
            this.chkHienThiMK.Name = "chkHienThiMK";
            this.chkHienThiMK.Size = new System.Drawing.Size(152, 24);
            this.chkHienThiMK.TabIndex = 8;
            this.chkHienThiMK.Text = "Hiển thị mật khẩu";
            this.chkHienThiMK.UseVisualStyleBackColor = true;
            this.chkHienThiMK.CheckedChanged += new System.EventHandler(this.chkHienThiMK_CheckedChanged);
            // 
            // lbTbao
            // 
            this.lbTbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTbao.ForeColor = System.Drawing.Color.Maroon;
            this.lbTbao.Location = new System.Drawing.Point(59, 287);
            this.lbTbao.Name = "lbTbao";
            this.lbTbao.Size = new System.Drawing.Size(672, 22);
            this.lbTbao.TabIndex = 6;
            this.lbTbao.Text = "Thông báo";
            this.lbTbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTbao.Visible = false;
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.btDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangNhap.Location = new System.Drawing.Point(303, 324);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(184, 53);
            this.btDangNhap.TabIndex = 3;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(162, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(467, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "ĐĂNG NHẬP TÀI KHOẢN CÁN BỘ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(267, 195);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(443, 32);
            this.txtMK.TabIndex = 1;
            this.txtMK.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
            this.txtMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(267, 123);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(443, 32);
            this.txtTDN.TabIndex = 0;
            this.txtTDN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btQuayLai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.FDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.Label lbTbao;
        private System.Windows.Forms.CheckBox chkHienThiMK;
    }
}