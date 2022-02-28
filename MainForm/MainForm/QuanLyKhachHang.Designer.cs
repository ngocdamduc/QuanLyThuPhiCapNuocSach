namespace WindowsFormsApp1
{
    partial class QuanLyKhachHang
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
            this.tbLoaiKhachHang = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefreshLKH = new System.Windows.Forms.Button();
            this.btnXoaLKH = new System.Windows.Forms.Button();
            this.btnSuaLKH = new System.Windows.Forms.Button();
            this.btnThemLKH = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDonGia = new System.Windows.Forms.TextBox();
            this.txtLoaiKH = new System.Windows.Forms.TextBox();
            this.lbChiTietLoaiKH = new System.Windows.Forms.Label();
            this.lbLoaiKH = new System.Windows.Forms.Label();
            this.lbMaLoaiKH = new System.Windows.Forms.Label();
            this.tbKhachHang = new System.Windows.Forms.TabPage();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnRefreshKH = new System.Windows.Forms.Button();
            this.btnTimKiemKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.dgrChiTietKH = new System.Windows.Forms.DataGridView();
            this.lbChiTiet = new System.Windows.Forms.Label();
            this.cbLoaiKH = new System.Windows.Forms.ComboBox();
            this.mskNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.lbLoaiKhachHang = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbHeading = new System.Windows.Forms.Label();
            this.tabKhachHang = new System.Windows.Forms.TabControl();
            this.tbLoaiKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChiTietKH)).BeginInit();
            this.tabKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLoaiKhachHang
            // 
            this.tbLoaiKhachHang.Controls.Add(this.button1);
            this.tbLoaiKhachHang.Controls.Add(this.btnRefreshLKH);
            this.tbLoaiKhachHang.Controls.Add(this.btnXoaLKH);
            this.tbLoaiKhachHang.Controls.Add(this.btnSuaLKH);
            this.tbLoaiKhachHang.Controls.Add(this.btnThemLKH);
            this.tbLoaiKhachHang.Controls.Add(this.dataGridView1);
            this.tbLoaiKhachHang.Controls.Add(this.iDonGia);
            this.tbLoaiKhachHang.Controls.Add(this.txtLoaiKH);
            this.tbLoaiKhachHang.Controls.Add(this.lbChiTietLoaiKH);
            this.tbLoaiKhachHang.Controls.Add(this.lbLoaiKH);
            this.tbLoaiKhachHang.Controls.Add(this.lbMaLoaiKH);
            this.tbLoaiKhachHang.Location = new System.Drawing.Point(4, 28);
            this.tbLoaiKhachHang.Name = "tbLoaiKhachHang";
            this.tbLoaiKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tbLoaiKhachHang.Size = new System.Drawing.Size(1367, 716);
            this.tbLoaiKhachHang.TabIndex = 1;
            this.tbLoaiKhachHang.Text = "Loại Khách Hàng";
            this.tbLoaiKhachHang.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1240, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnRefreshLKH
            // 
            this.btnRefreshLKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshLKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshLKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefreshLKH.Location = new System.Drawing.Point(1066, 358);
            this.btnRefreshLKH.Name = "btnRefreshLKH";
            this.btnRefreshLKH.Size = new System.Drawing.Size(121, 42);
            this.btnRefreshLKH.TabIndex = 14;
            this.btnRefreshLKH.Text = "Refresh";
            this.btnRefreshLKH.UseVisualStyleBackColor = false;
            // 
            // btnXoaLKH
            // 
            this.btnXoaLKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaLKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLKH.ForeColor = System.Drawing.Color.Red;
            this.btnXoaLKH.Location = new System.Drawing.Point(1066, 267);
            this.btnXoaLKH.Name = "btnXoaLKH";
            this.btnXoaLKH.Size = new System.Drawing.Size(121, 42);
            this.btnXoaLKH.TabIndex = 14;
            this.btnXoaLKH.Text = "Xóa";
            this.btnXoaLKH.UseVisualStyleBackColor = false;
            // 
            // btnSuaLKH
            // 
            this.btnSuaLKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuaLKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuaLKH.Location = new System.Drawing.Point(1066, 177);
            this.btnSuaLKH.Name = "btnSuaLKH";
            this.btnSuaLKH.Size = new System.Drawing.Size(121, 42);
            this.btnSuaLKH.TabIndex = 14;
            this.btnSuaLKH.Text = "Sửa";
            this.btnSuaLKH.UseVisualStyleBackColor = false;
            // 
            // btnThemLKH
            // 
            this.btnThemLKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemLKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemLKH.Location = new System.Drawing.Point(1066, 93);
            this.btnThemLKH.Name = "btnThemLKH";
            this.btnThemLKH.Size = new System.Drawing.Size(121, 42);
            this.btnThemLKH.TabIndex = 14;
            this.btnThemLKH.Text = "Thêm";
            this.btnThemLKH.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(815, 295);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDonGia
            // 
            this.iDonGia.Location = new System.Drawing.Point(251, 197);
            this.iDonGia.Name = "iDonGia";
            this.iDonGia.Size = new System.Drawing.Size(173, 22);
            this.iDonGia.TabIndex = 1;
            this.iDonGia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLoaiKH
            // 
            this.txtLoaiKH.Location = new System.Drawing.Point(251, 113);
            this.txtLoaiKH.Name = "txtLoaiKH";
            this.txtLoaiKH.Size = new System.Drawing.Size(173, 22);
            this.txtLoaiKH.TabIndex = 1;
            this.txtLoaiKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbChiTietLoaiKH
            // 
            this.lbChiTietLoaiKH.AutoSize = true;
            this.lbChiTietLoaiKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietLoaiKH.ForeColor = System.Drawing.Color.Red;
            this.lbChiTietLoaiKH.Location = new System.Drawing.Point(51, 317);
            this.lbChiTietLoaiKH.Name = "lbChiTietLoaiKH";
            this.lbChiTietLoaiKH.Size = new System.Drawing.Size(274, 23);
            this.lbChiTietLoaiKH.TabIndex = 0;
            this.lbChiTietLoaiKH.Text = "Bảng chi tiết Loại Khách Hàng:";
            // 
            // lbLoaiKH
            // 
            this.lbLoaiKH.AutoSize = true;
            this.lbLoaiKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbLoaiKH.Location = new System.Drawing.Point(100, 197);
            this.lbLoaiKH.Name = "lbLoaiKH";
            this.lbLoaiKH.Size = new System.Drawing.Size(98, 26);
            this.lbLoaiKH.TabIndex = 0;
            this.lbLoaiKH.Text = "Đơn Giá";
            // 
            // lbMaLoaiKH
            // 
            this.lbMaLoaiKH.AutoSize = true;
            this.lbMaLoaiKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaLoaiKH.Location = new System.Drawing.Point(95, 113);
            this.lbMaLoaiKH.Name = "lbMaLoaiKH";
            this.lbMaLoaiKH.Size = new System.Drawing.Size(103, 26);
            this.lbMaLoaiKH.TabIndex = 0;
            this.lbMaLoaiKH.Text = "Loại KH";
            // 
            // tbKhachHang
            // 
            this.tbKhachHang.Controls.Add(this.btnKH);
            this.tbKhachHang.Controls.Add(this.btnRefreshKH);
            this.tbKhachHang.Controls.Add(this.btnTimKiemKH);
            this.tbKhachHang.Controls.Add(this.btnXoaKH);
            this.tbKhachHang.Controls.Add(this.btnSuaKH);
            this.tbKhachHang.Controls.Add(this.btnThemKH);
            this.tbKhachHang.Controls.Add(this.dgrChiTietKH);
            this.tbKhachHang.Controls.Add(this.lbChiTiet);
            this.tbKhachHang.Controls.Add(this.cbLoaiKH);
            this.tbKhachHang.Controls.Add(this.mskNgaySinh);
            this.tbKhachHang.Controls.Add(this.lbLoaiKhachHang);
            this.tbKhachHang.Controls.Add(this.lbNgaySinh);
            this.tbKhachHang.Controls.Add(this.lbSDT);
            this.tbKhachHang.Controls.Add(this.lbDiaChi);
            this.tbKhachHang.Controls.Add(this.lbTenKH);
            this.tbKhachHang.Controls.Add(this.txtDiaChi);
            this.tbKhachHang.Controls.Add(this.txtSĐT);
            this.tbKhachHang.Controls.Add(this.txtTenKH);
            this.tbKhachHang.Controls.Add(this.txtMaKH);
            this.tbKhachHang.Controls.Add(this.lbMaKH);
            this.tbKhachHang.Controls.Add(this.lbHeading);
            this.tbKhachHang.Location = new System.Drawing.Point(4, 28);
            this.tbKhachHang.Name = "tbKhachHang";
            this.tbKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tbKhachHang.Size = new System.Drawing.Size(1367, 716);
            this.tbKhachHang.TabIndex = 0;
            this.tbKhachHang.Text = "Khách Hàng";
            this.tbKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnKH
            // 
            this.btnKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKH.ForeColor = System.Drawing.Color.Orange;
            this.btnKH.Location = new System.Drawing.Point(1245, 659);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(106, 35);
            this.btnKH.TabIndex = 13;
            this.btnKH.Text = "Close";
            this.btnKH.UseVisualStyleBackColor = false;
            this.btnKH.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefreshKH
            // 
            this.btnRefreshKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshKH.Location = new System.Drawing.Point(1144, 410);
            this.btnRefreshKH.Name = "btnRefreshKH";
            this.btnRefreshKH.Size = new System.Drawing.Size(121, 34);
            this.btnRefreshKH.TabIndex = 13;
            this.btnRefreshKH.Text = "Refresh";
            this.btnRefreshKH.UseVisualStyleBackColor = false;
            this.btnRefreshKH.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiemKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemKH.Location = new System.Drawing.Point(1144, 336);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(121, 37);
            this.btnTimKiemKH.TabIndex = 13;
            this.btnTimKiemKH.Text = "Tìm Kiếm";
            this.btnTimKiemKH.UseVisualStyleBackColor = false;
            this.btnTimKiemKH.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.ForeColor = System.Drawing.Color.Red;
            this.btnXoaKH.Location = new System.Drawing.Point(1144, 262);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(121, 36);
            this.btnXoaKH.TabIndex = 13;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = false;
            this.btnXoaKH.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuaKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKH.Location = new System.Drawing.Point(1144, 188);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(121, 36);
            this.btnSuaKH.TabIndex = 13;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = false;
            this.btnSuaKH.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemKH.Location = new System.Drawing.Point(1144, 115);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(121, 42);
            this.btnThemKH.TabIndex = 13;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgrChiTietKH
            // 
            this.dgrChiTietKH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrChiTietKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrChiTietKH.Location = new System.Drawing.Point(62, 362);
            this.dgrChiTietKH.Name = "dgrChiTietKH";
            this.dgrChiTietKH.RowHeadersWidth = 51;
            this.dgrChiTietKH.RowTemplate.Height = 24;
            this.dgrChiTietKH.Size = new System.Drawing.Size(932, 315);
            this.dgrChiTietKH.TabIndex = 12;
            // 
            // lbChiTiet
            // 
            this.lbChiTiet.AutoSize = true;
            this.lbChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTiet.ForeColor = System.Drawing.Color.Red;
            this.lbChiTiet.Location = new System.Drawing.Point(58, 336);
            this.lbChiTiet.Name = "lbChiTiet";
            this.lbChiTiet.Size = new System.Drawing.Size(242, 23);
            this.lbChiTiet.TabIndex = 11;
            this.lbChiTiet.Text = "Bảng Chi Tiết Khách Hàng:";
            // 
            // cbLoaiKH
            // 
            this.cbLoaiKH.FormattingEnabled = true;
            this.cbLoaiKH.Location = new System.Drawing.Point(802, 276);
            this.cbLoaiKH.Name = "cbLoaiKH";
            this.cbLoaiKH.Size = new System.Drawing.Size(192, 24);
            this.cbLoaiKH.TabIndex = 10;
            // 
            // mskNgaySinh
            // 
            this.mskNgaySinh.Location = new System.Drawing.Point(802, 202);
            this.mskNgaySinh.Mask = "00/00/0000";
            this.mskNgaySinh.Name = "mskNgaySinh";
            this.mskNgaySinh.Size = new System.Drawing.Size(135, 22);
            this.mskNgaySinh.TabIndex = 9;
            this.mskNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // lbLoaiKhachHang
            // 
            this.lbLoaiKhachHang.AutoSize = true;
            this.lbLoaiKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiKhachHang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbLoaiKhachHang.Location = new System.Drawing.Point(601, 272);
            this.lbLoaiKhachHang.Name = "lbLoaiKhachHang";
            this.lbLoaiKhachHang.Size = new System.Drawing.Size(195, 26);
            this.lbLoaiKhachHang.TabIndex = 8;
            this.lbLoaiKhachHang.Text = "Loại Khách Hàng";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNgaySinh.Location = new System.Drawing.Point(601, 198);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(117, 26);
            this.lbNgaySinh.TabIndex = 7;
            this.lbNgaySinh.Text = "Ngày Sinh";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbSDT.Location = new System.Drawing.Point(601, 131);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(57, 26);
            this.lbSDT.TabIndex = 6;
            this.lbSDT.Text = "SĐT";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDiaChi.Location = new System.Drawing.Point(149, 272);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(91, 26);
            this.lbDiaChi.TabIndex = 5;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTenKH.Location = new System.Drawing.Point(57, 198);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(187, 26);
            this.lbTenKH.TabIndex = 4;
            this.lbTenKH.Text = "Tên Khách Hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(265, 276);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(277, 22);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtSĐT
            // 
            this.txtSĐT.Location = new System.Drawing.Point(802, 135);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(192, 22);
            this.txtSĐT.TabIndex = 2;
            this.txtSĐT.TextChanged += new System.EventHandler(this.txtSĐT_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(265, 202);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(192, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(265, 135);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(192, 22);
            this.txtMaKH.TabIndex = 2;
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaKH.Location = new System.Drawing.Point(57, 131);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(183, 26);
            this.lbMaKH.TabIndex = 2;
            this.lbMaKH.Text = "Mã Khách Hàng";
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.ForeColor = System.Drawing.Color.Red;
            this.lbHeading.Location = new System.Drawing.Point(500, 50);
            this.lbHeading.Margin = new System.Windows.Forms.Padding(0);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(347, 45);
            this.lbHeading.TabIndex = 1;
            this.lbHeading.Text = "Hồ Sơ Khách Hàng";
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabKhachHang.Controls.Add(this.tbKhachHang);
            this.tabKhachHang.Controls.Add(this.tbLoaiKhachHang);
            this.tabKhachHang.Location = new System.Drawing.Point(0, 0);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.SelectedIndex = 0;
            this.tabKhachHang.Size = new System.Drawing.Size(1375, 748);
            this.tabKhachHang.TabIndex = 0;
            this.tabKhachHang.Tag = "";
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 746);
            this.Controls.Add(this.tabKhachHang);
            this.Name = "QuanLyKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.tbLoaiKhachHang.ResumeLayout(false);
            this.tbLoaiKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbKhachHang.ResumeLayout(false);
            this.tbKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChiTietKH)).EndInit();
            this.tabKhachHang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbLoaiKhachHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefreshLKH;
        private System.Windows.Forms.Button btnXoaLKH;
        private System.Windows.Forms.Button btnSuaLKH;
        private System.Windows.Forms.Button btnThemLKH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox iDonGia;
        private System.Windows.Forms.TextBox txtLoaiKH;
        private System.Windows.Forms.Label lbChiTietLoaiKH;
        private System.Windows.Forms.Label lbLoaiKH;
        private System.Windows.Forms.Label lbMaLoaiKH;
        private System.Windows.Forms.TabPage tbKhachHang;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnRefreshKH;
        private System.Windows.Forms.Button btnTimKiemKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.DataGridView dgrChiTietKH;
        private System.Windows.Forms.Label lbChiTiet;
        private System.Windows.Forms.ComboBox cbLoaiKH;
        private System.Windows.Forms.MaskedTextBox mskNgaySinh;
        private System.Windows.Forms.Label lbLoaiKhachHang;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.TabControl tabKhachHang;
    }
}

