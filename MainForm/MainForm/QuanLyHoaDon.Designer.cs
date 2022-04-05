
namespace QuanLyThuPhiCapNuocsach
{
    partial class QuanLyHoaDon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.dgrChiTietHD = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseHD = new System.Windows.Forms.Button();
            this.btnRefreshHD = new System.Windows.Forms.Button();
            this.btnTimKiemHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.cbMaCT = new System.Windows.Forms.ComboBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.txtCSM = new System.Windows.Forms.TextBox();
            this.txtCSC = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lbLoaiKhachHang = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbMaCT = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbChiSoMoi = new System.Windows.Forms.Label();
            this.lbChiSoCu = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbHeading = new System.Windows.Forms.Label();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.dgrThongKe = new System.Windows.Forms.DataGridView();
            this.lbTraCuu = new System.Windows.Forms.Label();
            this.grTraCuu = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTimHD = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimMaNV = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clbLoaiKH = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChiTietHD)).BeginInit();
            this.tabThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrThongKe)).BeginInit();
            this.grTraCuu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHoaDon);
            this.tabControl1.Controls.Add(this.tabThongKe);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1361, 740);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.Controls.Add(this.clbLoaiKH);
            this.tabHoaDon.Controls.Add(this.dtpNgayLap);
            this.tabHoaDon.Controls.Add(this.dgrChiTietHD);
            this.tabHoaDon.Controls.Add(this.label3);
            this.tabHoaDon.Controls.Add(this.btnCloseHD);
            this.tabHoaDon.Controls.Add(this.btnRefreshHD);
            this.tabHoaDon.Controls.Add(this.btnTimKiemHD);
            this.tabHoaDon.Controls.Add(this.btnXoaHD);
            this.tabHoaDon.Controls.Add(this.btnSuaHD);
            this.tabHoaDon.Controls.Add(this.btnThemHD);
            this.tabHoaDon.Controls.Add(this.cbMaNV);
            this.tabHoaDon.Controls.Add(this.cbMaCT);
            this.tabHoaDon.Controls.Add(this.cbMaKH);
            this.tabHoaDon.Controls.Add(this.txtCSM);
            this.tabHoaDon.Controls.Add(this.txtCSC);
            this.tabHoaDon.Controls.Add(this.txtMaHD);
            this.tabHoaDon.Controls.Add(this.lbLoaiKhachHang);
            this.tabHoaDon.Controls.Add(this.lbNgayLap);
            this.tabHoaDon.Controls.Add(this.lbMaCT);
            this.tabHoaDon.Controls.Add(this.lbMaKH);
            this.tabHoaDon.Controls.Add(this.lbMaNV);
            this.tabHoaDon.Controls.Add(this.lbChiSoMoi);
            this.tabHoaDon.Controls.Add(this.lbChiSoCu);
            this.tabHoaDon.Controls.Add(this.lbMaHD);
            this.tabHoaDon.Controls.Add(this.lbHeading);
            this.tabHoaDon.Location = new System.Drawing.Point(4, 25);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoaDon.Size = new System.Drawing.Size(1353, 711);
            this.tabHoaDon.TabIndex = 0;
            this.tabHoaDon.Text = "Chi Tiết Hóa Đơn";
            this.tabHoaDon.UseVisualStyleBackColor = true;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Location = new System.Drawing.Point(807, 175);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayLap.TabIndex = 29;
            // 
            // dgrChiTietHD
            // 
            this.dgrChiTietHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrChiTietHD.Location = new System.Drawing.Point(42, 446);
            this.dgrChiTietHD.Name = "dgrChiTietHD";
            this.dgrChiTietHD.RowHeadersWidth = 51;
            this.dgrChiTietHD.RowTemplate.Height = 24;
            this.dgrChiTietHD.Size = new System.Drawing.Size(957, 246);
            this.dgrChiTietHD.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(38, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Bảng Chi Tiết Hóa Đơn";
            // 
            // btnCloseHD
            // 
            this.btnCloseHD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCloseHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseHD.ForeColor = System.Drawing.Color.Orange;
            this.btnCloseHD.Location = new System.Drawing.Point(1224, 630);
            this.btnCloseHD.Name = "btnCloseHD";
            this.btnCloseHD.Size = new System.Drawing.Size(106, 35);
            this.btnCloseHD.TabIndex = 21;
            this.btnCloseHD.Text = "Close";
            this.btnCloseHD.UseVisualStyleBackColor = false;
            this.btnCloseHD.Click += new System.EventHandler(this.btnCloseHD_Click);
            // 
            // btnRefreshHD
            // 
            this.btnRefreshHD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshHD.Location = new System.Drawing.Point(1123, 369);
            this.btnRefreshHD.Name = "btnRefreshHD";
            this.btnRefreshHD.Size = new System.Drawing.Size(121, 34);
            this.btnRefreshHD.TabIndex = 22;
            this.btnRefreshHD.Text = "Refresh";
            this.btnRefreshHD.UseVisualStyleBackColor = false;
            this.btnRefreshHD.Click += new System.EventHandler(this.btnRefreshHD_Click);
            // 
            // btnTimKiemHD
            // 
            this.btnTimKiemHD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiemHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemHD.Location = new System.Drawing.Point(1123, 300);
            this.btnTimKiemHD.Name = "btnTimKiemHD";
            this.btnTimKiemHD.Size = new System.Drawing.Size(121, 37);
            this.btnTimKiemHD.TabIndex = 23;
            this.btnTimKiemHD.Text = "Tìm Kiếm";
            this.btnTimKiemHD.UseVisualStyleBackColor = false;
            this.btnTimKiemHD.Click += new System.EventHandler(this.btnTimKiemHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHD.ForeColor = System.Drawing.Color.Red;
            this.btnXoaHD.Location = new System.Drawing.Point(1123, 233);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(121, 36);
            this.btnXoaHD.TabIndex = 24;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.UseVisualStyleBackColor = false;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuaHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHD.Location = new System.Drawing.Point(1123, 159);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(121, 36);
            this.btnSuaHD.TabIndex = 25;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.UseVisualStyleBackColor = false;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemHD.Location = new System.Drawing.Point(1123, 86);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(121, 42);
            this.btnThemHD.TabIndex = 26;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(238, 173);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(192, 24);
            this.cbMaNV.TabIndex = 19;
            // 
            // cbMaCT
            // 
            this.cbMaCT.FormattingEnabled = true;
            this.cbMaCT.Location = new System.Drawing.Point(807, 102);
            this.cbMaCT.Name = "cbMaCT";
            this.cbMaCT.Size = new System.Drawing.Size(192, 24);
            this.cbMaCT.TabIndex = 19;
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(238, 238);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(192, 24);
            this.cbMaKH.TabIndex = 19;
            // 
            // txtCSM
            // 
            this.txtCSM.Location = new System.Drawing.Point(510, 381);
            this.txtCSM.Name = "txtCSM";
            this.txtCSM.Size = new System.Drawing.Size(192, 22);
            this.txtCSM.TabIndex = 18;
            // 
            // txtCSC
            // 
            this.txtCSC.Location = new System.Drawing.Point(510, 315);
            this.txtCSC.Name = "txtCSC";
            this.txtCSC.Size = new System.Drawing.Size(192, 22);
            this.txtCSC.TabIndex = 18;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(238, 102);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(192, 22);
            this.txtMaHD.TabIndex = 18;
            // 
            // lbLoaiKhachHang
            // 
            this.lbLoaiKhachHang.AutoSize = true;
            this.lbLoaiKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiKhachHang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbLoaiKhachHang.Location = new System.Drawing.Point(572, 243);
            this.lbLoaiKhachHang.Name = "lbLoaiKhachHang";
            this.lbLoaiKhachHang.Size = new System.Drawing.Size(195, 26);
            this.lbLoaiKhachHang.TabIndex = 15;
            this.lbLoaiKhachHang.Text = "Loại Khách Hàng";
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNgayLap.Location = new System.Drawing.Point(650, 169);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(112, 26);
            this.lbNgayLap.TabIndex = 14;
            this.lbNgayLap.Text = "Ngày Lập";
            // 
            // lbMaCT
            // 
            this.lbMaCT.AutoSize = true;
            this.lbMaCT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaCT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaCT.Location = new System.Drawing.Point(626, 102);
            this.lbMaCT.Name = "lbMaCT";
            this.lbMaCT.Size = new System.Drawing.Size(141, 26);
            this.lbMaCT.TabIndex = 13;
            this.lbMaCT.Text = "Mã Công Tơ";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaKH.Location = new System.Drawing.Point(37, 236);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(183, 26);
            this.lbMaKH.TabIndex = 12;
            this.lbMaKH.Text = "Mã Khách Hàng";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaNV.Location = new System.Drawing.Point(37, 169);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(161, 26);
            this.lbMaNV.TabIndex = 11;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // lbChiSoMoi
            // 
            this.lbChiSoMoi.AutoSize = true;
            this.lbChiSoMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiSoMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbChiSoMoi.Location = new System.Drawing.Point(310, 377);
            this.lbChiSoMoi.Name = "lbChiSoMoi";
            this.lbChiSoMoi.Size = new System.Drawing.Size(129, 26);
            this.lbChiSoMoi.TabIndex = 10;
            this.lbChiSoMoi.Text = "Chỉ Số Mới";
            // 
            // lbChiSoCu
            // 
            this.lbChiSoCu.AutoSize = true;
            this.lbChiSoCu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiSoCu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbChiSoCu.Location = new System.Drawing.Point(310, 315);
            this.lbChiSoCu.Name = "lbChiSoCu";
            this.lbChiSoCu.Size = new System.Drawing.Size(116, 26);
            this.lbChiSoCu.TabIndex = 10;
            this.lbChiSoCu.Text = "Chỉ Số Cũ";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaHD.Location = new System.Drawing.Point(37, 102);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(145, 26);
            this.lbMaHD.TabIndex = 10;
            this.lbMaHD.Text = "Mã Hóa Đơn";
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.ForeColor = System.Drawing.Color.Red;
            this.lbHeading.Location = new System.Drawing.Point(502, 27);
            this.lbHeading.Margin = new System.Windows.Forms.Padding(0);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(365, 45);
            this.lbHeading.TabIndex = 3;
            this.lbHeading.Text = "Danh Sách Hóa Đơn";
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.dgrThongKe);
            this.tabThongKe.Controls.Add(this.lbTraCuu);
            this.tabThongKe.Controls.Add(this.grTraCuu);
            this.tabThongKe.Location = new System.Drawing.Point(4, 25);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongKe.Size = new System.Drawing.Size(1353, 711);
            this.tabThongKe.TabIndex = 1;
            this.tabThongKe.Text = "Thống Kê";
            this.tabThongKe.UseVisualStyleBackColor = true;
            // 
            // dgrThongKe
            // 
            this.dgrThongKe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgrThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrThongKe.Location = new System.Drawing.Point(86, 212);
            this.dgrThongKe.Name = "dgrThongKe";
            this.dgrThongKe.RowHeadersWidth = 51;
            this.dgrThongKe.RowTemplate.Height = 24;
            this.dgrThongKe.Size = new System.Drawing.Size(1187, 459);
            this.dgrThongKe.TabIndex = 19;
            // 
            // lbTraCuu
            // 
            this.lbTraCuu.AutoSize = true;
            this.lbTraCuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTraCuu.ForeColor = System.Drawing.Color.Red;
            this.lbTraCuu.Location = new System.Drawing.Point(97, 183);
            this.lbTraCuu.Name = "lbTraCuu";
            this.lbTraCuu.Size = new System.Drawing.Size(292, 23);
            this.lbTraCuu.TabIndex = 18;
            this.lbTraCuu.Text = "Lượng nước tiêu dùng hàng tháng";
            // 
            // grTraCuu
            // 
            this.grTraCuu.Controls.Add(this.btnIn);
            this.grTraCuu.Controls.Add(this.btnTimHD);
            this.grTraCuu.Controls.Add(this.txtTimKiem);
            this.grTraCuu.Controls.Add(this.lbTimMaNV);
            this.grTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTraCuu.Location = new System.Drawing.Point(86, 19);
            this.grTraCuu.Name = "grTraCuu";
            this.grTraCuu.Size = new System.Drawing.Size(1186, 140);
            this.grTraCuu.TabIndex = 1;
            this.grTraCuu.TabStop = false;
            this.grTraCuu.Text = "Tra Cứu Hóa Đơn Nước Hàng Tháng";
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.Location = new System.Drawing.Point(1031, 81);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(121, 42);
            this.btnIn.TabIndex = 15;
            this.btnIn.Text = "In HĐ";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTimHD
            // 
            this.btnTimHD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimHD.Location = new System.Drawing.Point(1031, 21);
            this.btnTimHD.Name = "btnTimHD";
            this.btnTimHD.Size = new System.Drawing.Size(121, 42);
            this.btnTimHD.TabIndex = 15;
            this.btnTimHD.Text = "Tìm";
            this.btnTimHD.UseVisualStyleBackColor = false;
            this.btnTimHD.Click += new System.EventHandler(this.btnTimHD_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(351, 55);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(602, 22);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lbTimMaNV
            // 
            this.lbTimMaNV.AutoSize = true;
            this.lbTimMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimMaNV.ForeColor = System.Drawing.Color.Blue;
            this.lbTimMaNV.Location = new System.Drawing.Point(27, 55);
            this.lbTimMaNV.Name = "lbTimMaNV";
            this.lbTimMaNV.Size = new System.Drawing.Size(276, 23);
            this.lbTimMaNV.TabIndex = 0;
            this.lbTimMaNV.Text = "Nhập Mã KH hoặc Mã Công Tơ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // clbLoaiKH
            // 
            this.clbLoaiKH.FormattingEnabled = true;
            this.clbLoaiKH.Location = new System.Drawing.Point(815, 243);
            this.clbLoaiKH.Name = "clbLoaiKH";
            this.clbLoaiKH.Size = new System.Drawing.Size(192, 55);
            this.clbLoaiKH.TabIndex = 30;
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 738);
            this.Controls.Add(this.tabControl1);
            this.Name = "QuanLyHoaDon";
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHoaDon.ResumeLayout(false);
            this.tabHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChiTietHD)).EndInit();
            this.tabThongKe.ResumeLayout(false);
            this.tabThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrThongKe)).EndInit();
            this.grTraCuu.ResumeLayout(false);
            this.grTraCuu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHoaDon;
        private System.Windows.Forms.TabPage tabThongKe;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.Label lbLoaiKhachHang;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Label lbMaCT;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.ComboBox cbMaCT;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtCSM;
        private System.Windows.Forms.TextBox txtCSC;
        private System.Windows.Forms.Label lbChiSoMoi;
        private System.Windows.Forms.Label lbChiSoCu;
        private System.Windows.Forms.DataGridView dgrChiTietHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseHD;
        private System.Windows.Forms.Button btnRefreshHD;
        private System.Windows.Forms.Button btnTimKiemHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.GroupBox grTraCuu;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTimHD;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbTimMaNV;
        private System.Windows.Forms.DataGridView dgrThongKe;
        private System.Windows.Forms.Label lbTraCuu;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckedListBox clbLoaiKH;
    }
}