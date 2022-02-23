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
            this.lbMaLoaiKH = new System.Windows.Forms.Label();
            this.lbLoaiKH = new System.Windows.Forms.Label();
            this.tbKhachHang = new System.Windows.Forms.TabPage();
            this.lbHeading = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbLoaiKhachHang = new System.Windows.Forms.Label();
            this.mskNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.cbLoaiKH = new System.Windows.Forms.ComboBox();
            this.lbChiTiet = new System.Windows.Forms.Label();
            this.dgrChiTietKH = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabKhachHang = new System.Windows.Forms.TabControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbChiTietLoaiKH = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThemLKH = new System.Windows.Forms.Button();
            this.btnSuaLKH = new System.Windows.Forms.Button();
            this.btnXoaLKH = new System.Windows.Forms.Button();
            this.btnRefreshLKH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbLoaiKhachHang.SuspendLayout();
            this.tbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChiTietKH)).BeginInit();
            this.tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tbLoaiKhachHang.Controls.Add(this.textBox2);
            this.tbLoaiKhachHang.Controls.Add(this.textBox1);
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
            // lbMaLoaiKH
            // 
            this.lbMaLoaiKH.AutoSize = true;
            this.lbMaLoaiKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaLoaiKH.Location = new System.Drawing.Point(50, 109);
            this.lbMaLoaiKH.Name = "lbMaLoaiKH";
            this.lbMaLoaiKH.Size = new System.Drawing.Size(144, 26);
            this.lbMaLoaiKH.TabIndex = 0;
            this.lbMaLoaiKH.Text = "Mã Loại KH";
            // 
            // lbLoaiKH
            // 
            this.lbLoaiKH.AutoSize = true;
            this.lbLoaiKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbLoaiKH.Location = new System.Drawing.Point(50, 193);
            this.lbLoaiKH.Name = "lbLoaiKH";
            this.lbLoaiKH.Size = new System.Drawing.Size(195, 26);
            this.lbLoaiKH.TabIndex = 0;
            this.lbLoaiKH.Text = "Loại Khách Hàng";
            // 
            // tbKhachHang
            // 
            this.tbKhachHang.Controls.Add(this.btnClose);
            this.tbKhachHang.Controls.Add(this.btnRefresh);
            this.tbKhachHang.Controls.Add(this.btnTimKiem);
            this.tbKhachHang.Controls.Add(this.btnXoa);
            this.tbKhachHang.Controls.Add(this.btnSua);
            this.tbKhachHang.Controls.Add(this.btnThem);
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
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(265, 135);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(192, 22);
            this.txtMaKH.TabIndex = 2;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(265, 202);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(192, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtSĐT
            // 
            this.txtSĐT.Location = new System.Drawing.Point(802, 135);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(192, 22);
            this.txtSĐT.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(265, 276);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(277, 22);
            this.txtDiaChi.TabIndex = 2;
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
            // mskNgaySinh
            // 
            this.mskNgaySinh.Location = new System.Drawing.Point(802, 202);
            this.mskNgaySinh.Mask = "00/00/0000";
            this.mskNgaySinh.Name = "mskNgaySinh";
            this.mskNgaySinh.Size = new System.Drawing.Size(135, 22);
            this.mskNgaySinh.TabIndex = 9;
            this.mskNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // cbLoaiKH
            // 
            this.cbLoaiKH.FormattingEnabled = true;
            this.cbLoaiKH.Location = new System.Drawing.Point(802, 276);
            this.cbLoaiKH.Name = "cbLoaiKH";
            this.cbLoaiKH.Size = new System.Drawing.Size(192, 24);
            this.cbLoaiKH.TabIndex = 10;
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
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(1144, 115);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 42);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1144, 188);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 36);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1144, 262);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 36);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1144, 336);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(121, 37);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1144, 410);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 34);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1245, 659);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // btnXoaLKH
            // 
            this.btnXoaLKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaLKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaLKH.Location = new System.Drawing.Point(1066, 267);
            this.btnXoaLKH.Name = "btnXoaLKH";
            this.btnXoaLKH.Size = new System.Drawing.Size(121, 42);
            this.btnXoaLKH.TabIndex = 14;
            this.btnXoaLKH.Text = "Xóa";
            this.btnXoaLKH.UseVisualStyleBackColor = false;
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
            this.tbKhachHang.ResumeLayout(false);
            this.tbKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChiTietKH)).EndInit();
            this.tabKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbLoaiKhachHang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbLoaiKH;
        private System.Windows.Forms.Label lbMaLoaiKH;
        private System.Windows.Forms.TabPage tbKhachHang;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbChiTietLoaiKH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefreshLKH;
        private System.Windows.Forms.Button btnXoaLKH;
        private System.Windows.Forms.Button btnSuaLKH;
        private System.Windows.Forms.Button btnThemLKH;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

