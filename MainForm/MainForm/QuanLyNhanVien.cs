using QuanLyThuPhiCapNuocsach.BUS;
using System;
using System.Windows.Forms;

namespace QuanLyThuPhiCapNuocsach
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
         private void btnCloseNV_Click(object sender, System.EventArgs e)
        {
            Index index = new Index();
            this.Close();
        }
        NhanVien_BUS nvb = new NhanVien_BUS();

        private void QuanLyNhanVien_Load(object sender, System.EventArgs e)
        {
            LoadListNV();
            BindingData();
            
        }
        void LoadListNV()
        {
            dgrChiTietNV.DataSource = nvb.getNhanVien();
            dataGridView1.DataSource = nvb.getNhanVien();
        }
        private void btnThemNV_Click(object sender, System.EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
                MessageBox.Show("Mã nhân viên không được để trống !");
            else if (txtTenNV.Text.Trim() == "")
                MessageBox.Show("Tên nhân viên không được để trống !");
            else
                nvb.insertNV(txtMaNV.Text, txtTenNV.Text, txtDiaChi.Text, txtGioiTinh.Text, dtpNgaySinh.Value.ToString("yyyy-MM-dd"), txtChucVu.Text);
            QuanLyNhanVien_Load(sender, e);
        }

        private void btnSuaNV_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (txtMaNV.Text.Trim() == "")
                        MessageBox.Show("Mã nhân viên không được để trống !");
                    else if (txtTenNV.Text.Trim() == "")
                        MessageBox.Show("Tên nhân viên không được để trống !");
                    else
                    nvb.updateNV(txtMaNV.Text, txtTenNV.Text, txtDiaChi.Text, txtGioiTinh.Text, dtpNgaySinh.Value.ToString("yyyy-MM-dd"), txtChucVu.Text);
                    QuanLyNhanVien_Load(sender, e);
                }
            }
           catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi sửa!" + ex.Message);
            }
        }

        private void btnXoaNV_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    nvb.deleteNV(txtMaNV.Text);
                    QuanLyNhanVien_Load(sender, e);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xóa" + ex.Message);
            }
            
        }
        void BindingData()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add(new Binding("Text", dgrChiTietNV.DataSource, "sMaNV", true, DataSourceUpdateMode.Never));
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add(new Binding("Text", dgrChiTietNV.DataSource, "sTenNV", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add(new Binding("Text", dgrChiTietNV.DataSource, "sDiachi", true, DataSourceUpdateMode.Never));
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add(new Binding("Text", dgrChiTietNV.DataSource, "bGioitinh", true, DataSourceUpdateMode.Never));
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add(new Binding("Text", dgrChiTietNV.DataSource, "dNgaySinh", true, DataSourceUpdateMode.Never));
            txtChucVu.DataBindings.Clear();
            txtChucVu.DataBindings.Add(new Binding("Text", dgrChiTietNV.DataSource, "sChucVu", true, DataSourceUpdateMode.Never));

        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            txtTimTenNV.Text = " ";
            LoadListNV();
        }

        private void btnTimNV_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = nvb.Search(txtTimTenNV.Text);
        }

        private void btnRefreshNV_Click(object sender, System.EventArgs e)
        {
            txtMaNV.Text = " ";
            txtTenNV.Text = " ";
            txtDiaChi.Text = " ";
            txtGioiTinh.Text = " ";
            txtChucVu.Text = " ";
        }
        private void btnInNV_Click_1(object sender, EventArgs e)
        {
            rptNhanVien rptNhanVien = new rptNhanVien();
            rptNhanVien.SetDataSource(nvb.getNhanVien());
            frmReportNV f = new frmReportNV();
            f.crystalReportViewer1.ReportSource = rptNhanVien;
            f.ShowDialog();
        }
    }
}
