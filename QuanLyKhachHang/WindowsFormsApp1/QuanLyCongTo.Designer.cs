﻿
namespace QuanLyThuPhiCapNuocsach
{
    partial class QuanLyCongTo
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
            this.grDanhMuc = new System.Windows.Forms.GroupBox();
            this.mskNgayLapDat = new System.Windows.Forms.MaskedTextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtChiSo = new System.Windows.Forms.TextBox();
            this.txtHangSX = new System.Windows.Forms.TextBox();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.lbChiSo = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbHangSX = new System.Windows.Forms.Label();
            this.lbNgayLapDat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbMaCT = new System.Windows.Forms.Label();
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.btnCloseCT = new System.Windows.Forms.Button();
            this.btnTimCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.lbChiTietCT = new System.Windows.Forms.Label();
            this.btnRefreshCT = new System.Windows.Forms.Button();
            this.dgrChiTietCT = new System.Windows.Forms.DataGridView();
            this.grDanhMuc.SuspendLayout();
            this.grChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChiTietCT)).BeginInit();
            this.SuspendLayout();
            // 
            // grDanhMuc
            // 
            this.grDanhMuc.Controls.Add(this.mskNgayLapDat);
            this.grDanhMuc.Controls.Add(this.txtMaNV);
            this.grDanhMuc.Controls.Add(this.txtMaKH);
            this.grDanhMuc.Controls.Add(this.txtChiSo);
            this.grDanhMuc.Controls.Add(this.txtHangSX);
            this.grDanhMuc.Controls.Add(this.txtMaCT);
            this.grDanhMuc.Controls.Add(this.lbChiSo);
            this.grDanhMuc.Controls.Add(this.lbMaNV);
            this.grDanhMuc.Controls.Add(this.lbHangSX);
            this.grDanhMuc.Controls.Add(this.lbNgayLapDat);
            this.grDanhMuc.Controls.Add(this.label6);
            this.grDanhMuc.Controls.Add(this.lbMaKH);
            this.grDanhMuc.Controls.Add(this.lbMaCT);
            this.grDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDanhMuc.Location = new System.Drawing.Point(62, 32);
            this.grDanhMuc.Name = "grDanhMuc";
            this.grDanhMuc.Size = new System.Drawing.Size(1020, 211);
            this.grDanhMuc.TabIndex = 1;
            this.grDanhMuc.TabStop = false;
            this.grDanhMuc.Text = "Danh Mục";
            // 
            // mskNgayLapDat
            // 
            this.mskNgayLapDat.Location = new System.Drawing.Point(626, 87);
            this.mskNgayLapDat.Mask = "00/00/0000";
            this.mskNgayLapDat.Name = "mskNgayLapDat";
            this.mskNgayLapDat.Size = new System.Drawing.Size(169, 22);
            this.mskNgayLapDat.TabIndex = 2;
            this.mskNgayLapDat.ValidatingType = typeof(System.DateTime);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(204, 140);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(230, 22);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(204, 87);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(230, 22);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtChiSo
            // 
            this.txtChiSo.Location = new System.Drawing.Point(626, 140);
            this.txtChiSo.Name = "txtChiSo";
            this.txtChiSo.Size = new System.Drawing.Size(169, 22);
            this.txtChiSo.TabIndex = 1;
            // 
            // txtHangSX
            // 
            this.txtHangSX.Location = new System.Drawing.Point(626, 33);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(76, 22);
            this.txtHangSX.TabIndex = 1;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(204, 39);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(230, 22);
            this.txtMaCT.TabIndex = 1;
            // 
            // lbChiSo
            // 
            this.lbChiSo.AutoSize = true;
            this.lbChiSo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiSo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbChiSo.Location = new System.Drawing.Point(527, 140);
            this.lbChiSo.Name = "lbChiSo";
            this.lbChiSo.Size = new System.Drawing.Size(58, 19);
            this.lbChiSo.TabIndex = 0;
            this.lbChiSo.Text = "Chỉ Số";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaNV.Location = new System.Drawing.Point(15, 141);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(174, 19);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã Nhân Viên Lắp Đặt";
            this.lbMaNV.Click += new System.EventHandler(this.lbDiaChi_Click);
            // 
            // lbHangSX
            // 
            this.lbHangSX.AutoSize = true;
            this.lbHangSX.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHangSX.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbHangSX.Location = new System.Drawing.Point(502, 36);
            this.lbHangSX.Name = "lbHangSX";
            this.lbHangSX.Size = new System.Drawing.Size(108, 19);
            this.lbHangSX.TabIndex = 0;
            this.lbHangSX.Text = "Hãn Sản Xuất";
            // 
            // lbNgayLapDat
            // 
            this.lbNgayLapDat.AutoSize = true;
            this.lbNgayLapDat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLapDat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNgayLapDat.Location = new System.Drawing.Point(502, 85);
            this.lbNgayLapDat.Name = "lbNgayLapDat";
            this.lbNgayLapDat.Size = new System.Drawing.Size(108, 19);
            this.lbNgayLapDat.TabIndex = 0;
            this.lbNgayLapDat.Text = "Ngày Lắp Đặt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "label1";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaKH.Location = new System.Drawing.Point(25, 90);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(126, 19);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "Mã Khách Hàng";
            // 
            // lbMaCT
            // 
            this.lbMaCT.AutoSize = true;
            this.lbMaCT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaCT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaCT.Location = new System.Drawing.Point(43, 39);
            this.lbMaCT.Name = "lbMaCT";
            this.lbMaCT.Size = new System.Drawing.Size(99, 19);
            this.lbMaCT.TabIndex = 0;
            this.lbMaCT.Text = "Mã Công Tơ";
            // 
            // grChucNang
            // 
            this.grChucNang.Controls.Add(this.btnThemCT);
            this.grChucNang.Controls.Add(this.btnCloseCT);
            this.grChucNang.Controls.Add(this.btnRefreshCT);
            this.grChucNang.Controls.Add(this.btnTimCT);
            this.grChucNang.Controls.Add(this.btnXoaCT);
            this.grChucNang.Controls.Add(this.btnSuaCT);
            this.grChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grChucNang.Location = new System.Drawing.Point(62, 266);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Size = new System.Drawing.Size(1020, 89);
            this.grChucNang.TabIndex = 2;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Chức Năng";
            // 
            // btnThemCT
            // 
            this.btnThemCT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemCT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemCT.Location = new System.Drawing.Point(47, 24);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(104, 42);
            this.btnThemCT.TabIndex = 14;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.UseVisualStyleBackColor = false;
            // 
            // btnCloseCT
            // 
            this.btnCloseCT.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseCT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseCT.ForeColor = System.Drawing.Color.Orange;
            this.btnCloseCT.Location = new System.Drawing.Point(881, 24);
            this.btnCloseCT.Name = "btnCloseCT";
            this.btnCloseCT.Size = new System.Drawing.Size(121, 42);
            this.btnCloseCT.TabIndex = 14;
            this.btnCloseCT.Text = "Close";
            this.btnCloseCT.UseVisualStyleBackColor = false;
            this.btnCloseCT.Click += new System.EventHandler(this.btnCloseNV_Click);
            // 
            // btnTimCT
            // 
            this.btnTimCT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimCT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimCT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimCT.Location = new System.Drawing.Point(427, 24);
            this.btnTimCT.Name = "btnTimCT";
            this.btnTimCT.Size = new System.Drawing.Size(98, 42);
            this.btnTimCT.TabIndex = 14;
            this.btnTimCT.Text = "Tìm Kiếm";
            this.btnTimCT.UseVisualStyleBackColor = false;
            this.btnTimCT.Click += new System.EventHandler(this.btnRefreshNV_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaCT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCT.ForeColor = System.Drawing.Color.Red;
            this.btnXoaCT.Location = new System.Drawing.Point(302, 24);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(94, 42);
            this.btnXoaCT.TabIndex = 14;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.UseVisualStyleBackColor = false;
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuaCT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuaCT.Location = new System.Drawing.Point(175, 24);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(97, 42);
            this.btnSuaCT.TabIndex = 14;
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.UseVisualStyleBackColor = false;
            // 
            // lbChiTietCT
            // 
            this.lbChiTietCT.AutoSize = true;
            this.lbChiTietCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietCT.ForeColor = System.Drawing.Color.Red;
            this.lbChiTietCT.Location = new System.Drawing.Point(58, 381);
            this.lbChiTietCT.Name = "lbChiTietCT";
            this.lbChiTietCT.Size = new System.Drawing.Size(205, 23);
            this.lbChiTietCT.TabIndex = 16;
            this.lbChiTietCT.Text = "Bảng Chi Tiết Công Tơ";
            // 
            // btnRefreshCT
            // 
            this.btnRefreshCT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshCT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefreshCT.Location = new System.Drawing.Point(561, 24);
            this.btnRefreshCT.Name = "btnRefreshCT";
            this.btnRefreshCT.Size = new System.Drawing.Size(98, 42);
            this.btnRefreshCT.TabIndex = 14;
            this.btnRefreshCT.Text = "Refresh";
            this.btnRefreshCT.UseVisualStyleBackColor = false;
            // 
            // dgrChiTietCT
            // 
            this.dgrChiTietCT.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgrChiTietCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrChiTietCT.Location = new System.Drawing.Point(62, 407);
            this.dgrChiTietCT.Name = "dgrChiTietCT";
            this.dgrChiTietCT.RowHeadersWidth = 51;
            this.dgrChiTietCT.RowTemplate.Height = 24;
            this.dgrChiTietCT.Size = new System.Drawing.Size(1020, 294);
            this.dgrChiTietCT.TabIndex = 17;
            // 
            // QuanLyCongTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 725);
            this.Controls.Add(this.dgrChiTietCT);
            this.Controls.Add(this.lbChiTietCT);
            this.Controls.Add(this.grChucNang);
            this.Controls.Add(this.grDanhMuc);
            this.Name = "QuanLyCongTo";
            this.Text = "Form1";
            this.grDanhMuc.ResumeLayout(false);
            this.grDanhMuc.PerformLayout();
            this.grChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrChiTietCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grDanhMuc;
        private System.Windows.Forms.MaskedTextBox mskNgayLapDat;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtChiSo;
        private System.Windows.Forms.TextBox txtHangSX;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.Label lbChiSo;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbHangSX;
        private System.Windows.Forms.Label lbNgayLapDat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbMaCT;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.Button btnCloseCT;
        private System.Windows.Forms.Button btnTimCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnRefreshCT;
        private System.Windows.Forms.Label lbChiTietCT;
        private System.Windows.Forms.DataGridView dgrChiTietCT;
    }
}