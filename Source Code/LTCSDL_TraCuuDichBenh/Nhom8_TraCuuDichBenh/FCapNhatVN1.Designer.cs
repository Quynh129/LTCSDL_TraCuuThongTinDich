﻿
namespace Nhom8_TraCuuDichBenh
{
    partial class FCapNhatVN1
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
            this.txtMui1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grdDsachVN1 = new System.Windows.Forms.DataGridView();
            this.txtMui2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDsachVN1)).BeginInit();
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
            this.btGiam.Location = new System.Drawing.Point(292, 245);
            this.btGiam.Name = "btGiam";
            this.btGiam.Size = new System.Drawing.Size(121, 45);
            this.btGiam.TabIndex = 9;
            this.btGiam.Text = "Xóa";
            this.toolTip1.SetToolTip(this.btGiam, "Dùng để xóa đi 1 lượng nhất định");
            this.btGiam.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(20, 245);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(121, 45);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Cập nhật";
            this.toolTip1.SetToolTip(this.btThem, "Dùng để tăng số lượng");
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // txtMui1
            // 
            this.txtMui1.Location = new System.Drawing.Point(190, 110);
            this.txtMui1.Name = "txtMui1";
            this.txtMui1.Size = new System.Drawing.Size(212, 32);
            this.txtMui1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mũi 1:";
            // 
            // grdDsachVN1
            // 
            this.grdDsachVN1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDsachVN1.Location = new System.Drawing.Point(624, 265);
            this.grdDsachVN1.Name = "grdDsachVN1";
            this.grdDsachVN1.Size = new System.Drawing.Size(510, 373);
            this.grdDsachVN1.TabIndex = 10;
            // 
            // txtMui2
            // 
            this.txtMui2.Location = new System.Drawing.Point(190, 168);
            this.txtMui2.Name = "txtMui2";
            this.txtMui2.Size = new System.Drawing.Size(212, 32);
            this.txtMui2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mũi 2:";
            // 
            // txtMaTP
            // 
            this.txtMaTP.Enabled = false;
            this.txtMaTP.Location = new System.Drawing.Point(190, 52);
            this.txtMaTP.Name = "txtMaTP";
            this.txtMaTP.Size = new System.Drawing.Size(80, 32);
            this.txtMaTP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tỉnh thành:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btGiam);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.txtMui1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMui2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaTP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(59, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 307);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật thông tin trong ngày";
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
            // FCapNhatVN1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grdDsachVN1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FCapNhatVN1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCapNhatVN1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FCapNhatVN1_FormClosing);
            this.Load += new System.EventHandler(this.FCapNhatVN1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDsachVN1)).EndInit();
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
        private System.Windows.Forms.TextBox txtMui1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdDsachVN1;
        private System.Windows.Forms.TextBox txtMui2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btQuayLai;
    }
}