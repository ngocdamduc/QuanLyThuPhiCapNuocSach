using QuanLyThuPhiCapNuocsach.BUS;
using System;
using System.Windows.Forms;

namespace QuanLyThuPhiCapNuocsach
{
    public partial class QuanLyHoaDon : Form
    {
        HoaDon_BUS hdb = new HoaDon_BUS();
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {

            if (txtMaHD.Text.Trim() == "")
                MessageBox.Show("Mã Hóa Đơn không được để trống !");
            else if (txtCSC.Text.Trim() == "")
                MessageBox.Show("Chỉ số cũ không được để trống !");
            else if (txtCSM.Text.Trim() == "")
                MessageBox.Show("Chỉ số mới không được để trống! ");
            else
                hdb.insertHD(txtMaHD.Text, cbMaCT.Text, txtCSC.Text, txtCSM.Text, dtpNgayLap.Value.ToString("dd/MM/yyyy"), cbMaKH.Text, cbMaNV.Text, cbLoaiKH.Text);
            QuanLyHoaDon_Load(sender, e);
        }

        private void btnCloseHD_Click(object sender, EventArgs e)
        {

            Index index = new Index();
            this.Close();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadListHD();
            BindingData();
            cbMaNV.DisplayMember = "sMaNV";
            cbMaNV.DataSource = hdb.getMaNV();
            cbMaKH.DisplayMember = "sMaKH";
            cbMaKH.DataSource = hdb.getKH();
            cbMaCT.DisplayMember = "sMaCT";
            cbMaCT.DataSource = hdb.getCT();
            cbLoaiKH.DisplayMember = "sLoaiKH";
            cbLoaiKH.DataSource = hdb.getLoaiKH();
        }
        void LoadListHD()
        {
            dgrChiTietHD.DataSource = hdb.getHoaDon();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (txtMaHD.Text.Trim() == "")
                        MessageBox.Show("Mã Hóa Đơn không được để trống !");
                    else if (txtCSC.Text.Trim() == "")
                        MessageBox.Show("Chỉ số cũ không được để trống !");
                    else if (txtCSM.Text.Trim() == "")
                        MessageBox.Show("Chỉ số mới không được để trống! ");
                    else
                        hdb.updateHD(txtMaHD.Text, cbMaCT.Text, txtCSC.Text, txtCSM.Text, dtpNgayLap.Value.ToString("yyyy-MM-dd"), cbMaKH.Text, cbMaNV.Text, cbLoaiKH.Text);
                    QuanLyHoaDon_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi sửa!" + ex.Message);
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    hdb.deleteHD(txtMaHD.Text);
                    QuanLyHoaDon_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xóa" + ex.Message);
            }
        }

        private void btnRefreshHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtCSC.Text = "";
            txtCSM.Text = "";
        }

        private void btnTimKiemHD_Click(object sender, EventArgs e)
        {
            dgrChiTietHD.DataSource = hdb.Search(txtMaHD.Text); 
        }
        void BindingData()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add(new Binding("Text", dgrChiTietHD.DataSource, "sMaHD", true, DataSourceUpdateMode.Never));
            cbMaNV.DataBindings.Clear();
            cbMaNV.DataBindings.Add(new Binding("Text", dgrChiTietHD.DataSource, "sMaNV", true, DataSourceUpdateMode.Never));
            cbMaKH.DataBindings.Clear();
            cbMaKH.DataBindings.Add(new Binding("Text", dgrChiTietHD.DataSource, "sMaKH", true, DataSourceUpdateMode.Never));
            cbMaCT.DataBindings.Clear();
            cbMaCT.DataBindings.Add(new Binding("Text", dgrChiTietHD.DataSource, "sMaCT", true, DataSourceUpdateMode.Never));
            dtpNgayLap.DataBindings.Clear();
            dtpNgayLap.DataBindings.Add(new Binding("Text", dgrChiTietHD.DataSource, "dNgayLap", true, DataSourceUpdateMode.Never));
            cbLoaiKH.DataBindings.Clear();
            cbLoaiKH.DataBindings.Add(new Binding("Text", dgrChiTietHD.DataSource, "sLoaiKH", true, DataSourceUpdateMode.Never));
            txtCSC.DataBindings.Clear();
            txtCSC.DataBindings.Add(new Binding("Text", dgrChiTietHD.DataSource, "bChiSoCu", true, DataSourceUpdateMode.Never));
            txtCSM.DataBindings.Clear();
            txtCSM.DataBindings.Add(new Binding("Text", dgrChiTietHD.DataSource, "bChiSoMoi", true, DataSourceUpdateMode.Never));
        }
    }
}
