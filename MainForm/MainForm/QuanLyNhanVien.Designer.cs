
namespace QuanLyThuPhiCapNuocsach
{
    partial class QuanLyNhanVien
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
            this.tabChiTiet = new System.Windows.Forms.TabPage();
            this.dgrChiTietNV = new System.Windows.Forms.DataGridView();
            this.lbChiTietNV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnCloseNV = new System.Windows.Forms.Button();
            this.btnRefreshNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.grDanhMuc = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.tabTraCuu = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTraCuu = new System.Windows.Forms.Label();
            this.grTraCuu = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTimNV = new System.Windows.Forms.Button();
            this.txtTimTenNV = new System.Windows.Forms.TextBox();
            this.lbTimTenNV = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnInNV = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChiTietNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grDanhMuc.SuspendLayout();
            this.tabTraCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grTraCuu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChiTiet);
            this.tabControl1.Controls.Add(this.tabTraCuu);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1239, 706);
            this.tabControl1.TabIndex = 0;
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Controls.Add(this.dgrChiTietNV);
            this.tabChiTiet.Controls.Add(this.lbChiTietNV);
            this.tabChiTiet.Controls.Add(this.groupBox1);
            this.tabChiTiet.Controls.Add(this.grDanhMuc);
            this.tabChiTiet.Location = new System.Drawing.Point(4, 25);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTiet.Size = new System.Drawing.Size(1231, 677);
            this.tabChiTiet.TabIndex = 0;
            this.tabChiTiet.Text = "Thông tin Nhân Viên";
            this.tabChiTiet.UseVisualStyleBackColor = true;
            // 
            // dgrChiTietNV
            // 
            this.dgrChiTietNV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgrChiTietNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrChiTietNV.Location = new System.Drawing.Point(21, 373);
            this.dgrChiTietNV.Name = "dgrChiTietNV";
            this.dgrChiTietNV.RowHeadersWidth = 55;
            this.dgrChiTietNV.RowTemplate.Height = 24;
            this.dgrChiTietNV.Size = new System.Drawing.Size(1187, 298);
            this.dgrChiTietNV.TabIndex = 16;
            // 
            // lbChiTietNV
            // 
            this.lbChiTietNV.AutoSize = true;
            this.lbChiTietNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietNV.ForeColor = System.Drawing.Color.Red;
            this.lbChiTietNV.Location = new System.Drawing.Point(34, 345);
            this.lbChiTietNV.Name = "lbChiTietNV";
            this.lbChiTietNV.Size = new System.Drawing.Size(218, 23);
            this.lbChiTietNV.TabIndex = 15;
            this.lbChiTietNV.Text = "Bảng Chi Tiết Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInNV);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.Controls.Add(this.btnCloseNV);
            this.groupBox1.Controls.Add(this.btnRefreshNV);
            this.groupBox1.Controls.Add(this.btnXoaNV);
            this.groupBox1.Controls.Add(this.btnSuaNV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemNV.Location = new System.Drawing.Point(47, 24);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(121, 42);
            this.btnThemNV.TabIndex = 14;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnCloseNV
            // 
            this.btnCloseNV.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseNV.ForeColor = System.Drawing.Color.Orange;
            this.btnCloseNV.Location = new System.Drawing.Point(1015, 24);
            this.btnCloseNV.Name = "btnCloseNV";
            this.btnCloseNV.Size = new System.Drawing.Size(121, 42);
            this.btnCloseNV.TabIndex = 14;
            this.btnCloseNV.Text = "Close";
            this.btnCloseNV.UseVisualStyleBackColor = false;
            this.btnCloseNV.Click += new System.EventHandler(this.btnCloseNV_Click);
            // 
            // btnRefreshNV
            // 
            this.btnRefreshNV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefreshNV.Location = new System.Drawing.Point(726, 26);
            this.btnRefreshNV.Name = "btnRefreshNV";
            this.btnRefreshNV.Size = new System.Drawing.Size(121, 42);
            this.btnRefreshNV.TabIndex = 14;
            this.btnRefreshNV.Text = "Refresh";
            this.btnRefreshNV.UseVisualStyleBackColor = false;
            this.btnRefreshNV.Click += new System.EventHandler(this.btnRefreshNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.ForeColor = System.Drawing.Color.Red;
            this.btnXoaNV.Location = new System.Drawing.Point(396, 24);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(121, 42);
            this.btnXoaNV.TabIndex = 14;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuaNV.Location = new System.Drawing.Point(221, 24);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(121, 42);
            this.btnSuaNV.TabIndex = 14;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // grDanhMuc
            // 
            this.grDanhMuc.Controls.Add(this.dtpNgaySinh);
            this.grDanhMuc.Controls.Add(this.txtDiaChi);
            this.grDanhMuc.Controls.Add(this.txtTenNV);
            this.grDanhMuc.Controls.Add(this.txtChucVu);
            this.grDanhMuc.Controls.Add(this.txtGioiTinh);
            this.grDanhMuc.Controls.Add(this.txtMaNV);
            this.grDanhMuc.Controls.Add(this.lbChucVu);
            this.grDanhMuc.Controls.Add(this.lbDiaChi);
            this.grDanhMuc.Controls.Add(this.lbGioiTinh);
            this.grDanhMuc.Controls.Add(this.lbNgaySinh);
            this.grDanhMuc.Controls.Add(this.label6);
            this.grDanhMuc.Controls.Add(this.lbTenNV);
            this.grDanhMuc.Controls.Add(this.lbMaNV);
            this.grDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDanhMuc.Location = new System.Drawing.Point(21, 22);
            this.grDanhMuc.Name = "grDanhMuc";
            this.grDanhMuc.Size = new System.Drawing.Size(1187, 190);
            this.grDanhMuc.TabIndex = 0;
            this.grDanhMuc.TabStop = false;
            this.grDanhMuc.Text = "Danh Mục";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(626, 90);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(157, 140);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(230, 22);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(157, 87);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(230, 22);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(626, 140);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(169, 22);
            this.txtChucVu.TabIndex = 1;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(626, 33);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(76, 22);
            this.txtGioiTinh.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(157, 36);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(230, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbChucVu.Location = new System.Drawing.Point(527, 140);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(72, 19);
            this.lbChucVu.TabIndex = 0;
            this.lbChucVu.Text = "Chức Vụ";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDiaChi.Location = new System.Drawing.Point(43, 140);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(66, 19);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbGioiTinh.Location = new System.Drawing.Point(527, 36);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(82, 19);
            this.lbGioiTinh.TabIndex = 0;
            this.lbGioiTinh.Text = "Giới Tính";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNgaySinh.Location = new System.Drawing.Point(527, 87);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(83, 19);
            this.lbNgaySinh.TabIndex = 0;
            this.lbNgaySinh.Text = "Ngày Sinh";
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
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTenNV.Location = new System.Drawing.Point(25, 90);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(115, 19);
            this.lbTenNV.TabIndex = 0;
            this.lbTenNV.Text = "Tên Nhân Viên";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaNV.Location = new System.Drawing.Point(24, 39);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(112, 19);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // tabTraCuu
            // 
            this.tabTraCuu.Controls.Add(this.dataGridView1);
            this.tabTraCuu.Controls.Add(this.lbTraCuu);
            this.tabTraCuu.Controls.Add(this.grTraCuu);
            this.tabTraCuu.Location = new System.Drawing.Point(4, 25);
            this.tabTraCuu.Name = "tabTraCuu";
            this.tabTraCuu.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraCuu.Size = new System.Drawing.Size(1231, 677);
            this.tabTraCuu.TabIndex = 1;
            this.tabTraCuu.Text = "Tra Cứu Nhân Viên";
            this.tabTraCuu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1187, 459);
            this.dataGridView1.TabIndex = 17;
            // 
            // lbTraCuu
            // 
            this.lbTraCuu.AutoSize = true;
            this.lbTraCuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTraCuu.ForeColor = System.Drawing.Color.Red;
            this.lbTraCuu.Location = new System.Drawing.Point(35, 183);
            this.lbTraCuu.Name = "lbTraCuu";
            this.lbTraCuu.Size = new System.Drawing.Size(218, 23);
            this.lbTraCuu.TabIndex = 1;
            this.lbTraCuu.Text = "Bảng Chi Tiết Nhân Viên";
            // 
            // grTraCuu
            // 
            this.grTraCuu.Controls.Add(this.btnRefresh);
            this.grTraCuu.Controls.Add(this.btnTimNV);
            this.grTraCuu.Controls.Add(this.txtTimTenNV);
            this.grTraCuu.Controls.Add(this.lbTimTenNV);
            this.grTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTraCuu.Location = new System.Drawing.Point(24, 15);
            this.grTraCuu.Name = "grTraCuu";
            this.grTraCuu.Size = new System.Drawing.Size(1186, 140);
            this.grTraCuu.TabIndex = 0;
            this.grTraCuu.TabStop = false;
            this.grTraCuu.Text = "Tra Cứu Thông Tin Nhân Viên";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Orange;
            this.btnRefresh.Location = new System.Drawing.Point(1031, 81);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 42);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTimNV
            // 
            this.btnTimNV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimNV.Location = new System.Drawing.Point(1031, 21);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(121, 42);
            this.btnTimNV.TabIndex = 15;
            this.btnTimNV.Text = "Tìm";
            this.btnTimNV.UseVisualStyleBackColor = false;
            this.btnTimNV.Click += new System.EventHandler(this.btnTimNV_Click);
            // 
            // txtTimTenNV
            // 
            this.txtTimTenNV.Location = new System.Drawing.Point(421, 53);
            this.txtTimTenNV.Name = "txtTimTenNV";
            this.txtTimTenNV.Size = new System.Drawing.Size(566, 22);
            this.txtTimTenNV.TabIndex = 1;
            // 
            // lbTimTenNV
            // 
            this.lbTimTenNV.AutoSize = true;
            this.lbTimTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimTenNV.ForeColor = System.Drawing.Color.Blue;
            this.lbTimTenNV.Location = new System.Drawing.Point(30, 53);
            this.lbTimTenNV.Name = "lbTimTenNV";
            this.lbTimTenNV.Size = new System.Drawing.Size(350, 23);
            this.lbTimTenNV.TabIndex = 0;
            this.lbTimTenNV.Text = "Nhập Mã Nhân Viên hoặc Tên Nhân Viên";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnInNV
            // 
            this.btnInNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInNV.Location = new System.Drawing.Point(564, 25);
            this.btnInNV.Name = "btnInNV";
            this.btnInNV.Size = new System.Drawing.Size(116, 43);
            this.btnInNV.TabIndex = 15;
            this.btnInNV.Text = "In";
            this.btnInNV.UseVisualStyleBackColor = true;
            this.btnInNV.Click += new System.EventHandler(this.btnInNV_Click_1);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 708);
            this.Controls.Add(this.tabControl1);
            this.Name = "QuanLyNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabChiTiet.ResumeLayout(false);
            this.tabChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChiTietNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grDanhMuc.ResumeLayout(false);
            this.grDanhMuc.PerformLayout();
            this.tabTraCuu.ResumeLayout(false);
            this.tabTraCuu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grTraCuu.ResumeLayout(false);
            this.grTraCuu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChiTiet;
        private System.Windows.Forms.GroupBox grDanhMuc;
        private System.Windows.Forms.TabPage tabTraCuu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnCloseNV;
        private System.Windows.Forms.Button btnRefreshNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.DataGridView dgrChiTietNV;
        private System.Windows.Forms.Label lbChiTietNV;
        private System.Windows.Forms.GroupBox grTraCuu;
        private System.Windows.Forms.Button btnTimNV;
        private System.Windows.Forms.TextBox txtTimTenNV;
        private System.Windows.Forms.Label lbTimTenNV;
        private System.Windows.Forms.Label lbTraCuu;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnInNV;
    }
}