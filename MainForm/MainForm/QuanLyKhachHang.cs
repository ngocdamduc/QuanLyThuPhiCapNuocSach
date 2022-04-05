using QuanLyThuPhiCapNuocsach.BUS;
using System;
using System.Windows.Forms;

namespace QuanLyThuPhiCapNuocsach
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

            private void btnCloseKH_Click(object sender, System.EventArgs e)
            {
                Index index = new Index();
                this.Close();
            }
            KhachHang_BUS nvb = new KhachHang_BUS();
        void LoadListKH()
            {
                dgrChiTietKH.DataSource = nvb.getKhachHang();
            }
        private void btnThemKH_Click(object sender, System.EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "")
                MessageBox.Show("Mã khách hàng không được để trống !");
            else if (txtTenKH.Text.Trim() == "")
                MessageBox.Show("Tên khách hàng không được để trống !");
            else
                nvb.insertKH(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, dtpNgaySinh.Value.ToString("dd/MM/yyyy"), txtLoaiKH.Text);
                QuanLyKhachHang_Load_1(sender, e);
        }

        private void btnSuaKH_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (txtMaKH.Text.Trim() == "")
                        MessageBox.Show("Mã khách hàng không được để trống !");
                    else if (txtTenKH.Text.Trim() == "")
                        MessageBox.Show("Tên khách hàng không được để trống !");
                    else
                        nvb.updateKH(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, dtpNgaySinh.Value.ToString("dd/MM/yyyy"), txtLoaiKH.Text);
                    QuanLyKhachHang_Load_1(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi sửa!" + ex.Message);
            }
        }

        private void btnXoaKH_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    nvb.deleteKH(txtMaKH.Text);
                    QuanLyKhachHang_Load_1(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xóa" + ex.Message);
            }

        }
        void BindingData()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add(new Binding("Text", dgrChiTietKH.DataSource, "sMaKH", true, DataSourceUpdateMode.Never));
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add(new Binding("Text", dgrChiTietKH.DataSource, "sTenKH", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add(new Binding("Text", dgrChiTietKH.DataSource, "sDiachi", true, DataSourceUpdateMode.Never));
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add(new Binding("Text", dgrChiTietKH.DataSource, "dNgaySinh", true, DataSourceUpdateMode.Never));
            txtLoaiKH.DataBindings.Clear();
            txtLoaiKH.DataBindings.Add(new Binding("Text", dgrChiTietKH.DataSource, "sLoaiKH", true, DataSourceUpdateMode.Never));

        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            LoadListKH();
        }
         private void btnTimKiemKH_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = nvb.Search(txtMaKH.Text);
        }
        private void btnRefreshNV_Click(object sender, System.EventArgs e)
        {
            txtMaKH.Text = " ";
            txtTenKH.Text = " ";
            txtDiaChi.Text = " ";
            dtpNgaySinh.Text = " ";
            txtLoaiKH.Text = " ";
        }

        private void QuanLyKhachHang_Load_1(object sender, EventArgs e)
        {
            LoadListKH();
            BindingData();
        }
    }
    }
