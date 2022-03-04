using QuanLyThuPhiCapNuocsach.DAO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuPhiCapNuocsach
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            LoadNhanVienList();
            AddNhanVienBinding();
        }

        private void btnCloseNV_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        void LoadNhanVienList()
        {
             
            string query = "SELECT * FROM tbl_NhanVien";
            dgrChiTietNV.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void AddNhanVienBinding()
        {
            txtMaNV.DataBindings.Add(new Binding("Text", dgrChiTietNV.DataSource, "sMaNV", true, DataSourceUpdateMode.Never));
            txtTenNV.DataBindings.Add(new Binding("Text", dgrChiTietNV.DataSource, "sTenNV", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgrChiTietNV.DataSource, "sDiachi", true, DataSourceUpdateMode.Never));
            txtGioiTinh.DataBindings.Add(new Binding("Text", dgrChiTietNV.DataSource, "bGioiTinh", true, DataSourceUpdateMode.Never));
            mskNgaySinh.DataBindings.Add(new Binding("Text", dgrChiTietNV.DataSource, "dNgaySinh", true, DataSourceUpdateMode.Never));
            txtChucVu.DataBindings.Add(new Binding("Text", dgrChiTietNV.DataSource, "sChucVu", true, DataSourceUpdateMode.Never));
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string DiaChi = txtDiaChi.Text;
            string GioiTinh = txtGioiTinh.Text;
            string NgaySinh = mskNgaySinh.Text;
            string ChucVu = txtChucVu.Text;
            if(NhanVienDAO.Instance.InsertNV(maNV, tenNV, DiaChi, GioiTinh, NgaySinh, ChucVu))
            {
                MessageBox.Show("Thêm Nhân Viên Thành Công!");
                LoadNhanVienList();
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Thêm Nhân Viên!");
            }
        }

        private void btnRefreshNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = " ";
            txtTenNV.Text = " ";
            txtDiaChi.Text = " ";
            txtGioiTinh.Text = " ";
            mskNgaySinh.Text = " ";
            txtChucVu.Text = " ";
        }
    }
}
