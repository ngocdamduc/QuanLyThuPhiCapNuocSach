using QuanLyThuPhiCapNuocsach.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuPhiCapNuocsach
{
    public partial class QuanLyCongTo : Form
    {
        public QuanLyCongTo()
        {
            InitializeComponent();
        }
        CongTo_BUS ctb = new CongTo_BUS();

        private void BindingData()
        {
            txtMaCT.DataBindings.Clear();
            txtMaCT.DataBindings.Add(new Binding("Text", dgrChiTietCT.DataSource, "sMaCT", true, DataSourceUpdateMode.Never));
            
            dtpNgayLapDat.DataBindings.Clear();
            dtpNgayLapDat.DataBindings.Add(new Binding("Text", dgrChiTietCT.DataSource, "dNgayLapDat", true, DataSourceUpdateMode.Never));
            
            txtHangSX.DataBindings.Clear();
            txtHangSX.DataBindings.Add(new Binding("Text", dgrChiTietCT.DataSource, "sHangSX", true, DataSourceUpdateMode.Never));
           
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add(new Binding("Text", dgrChiTietCT.DataSource, "sMaKH", true, DataSourceUpdateMode.Never));
           
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add(new Binding("Text", dgrChiTietCT.DataSource, "sMaNV", true, DataSourceUpdateMode.Never));
            
           
        }

        void LoadListCT()
        {
            dgrChiTietCT.DataSource = ctb.getCongTo();
            
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (txtMaCT.Text.Trim() == "")
                MessageBox.Show("Mã Công Tơ không được để trống !");
            else if (txtMaKH.Text.Trim() == "")
                MessageBox.Show("Mã Khách không được để trống !");
            else
                ctb.insertCT(txtMaCT.Text, dtpNgayLapDat.Value.ToString("yyyy/MM/dd"), txtHangSX.Text, txtMaKH.Text, txtMaNV.Text );
        }

       

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (txtMaCT.Text.Trim() == "")
                        MessageBox.Show("Mã nhân viên không được để trống !");
                    else if (txtMaKH.Text.Trim() == "")
                        MessageBox.Show("Tên nhân viên không được để trống !");
                    else
                        ctb.updateCT(txtMaCT.Text, dtpNgayLapDat.Value.ToString("yyyy-MM-dd"), txtHangSX.Text, txtMaKH.Text, txtMaNV.Text);
                    QuanLyCongTo_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi sửa!" + ex.Message);
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ctb.deleteCT(txtMaCT.Text);
                    QuanLyCongTo_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xóa" + ex.Message);
            }
        }

        private void btnRefreshCT_Click(object sender, EventArgs e)
        {
            txtMaCT.Text = " ";
            txtMaKH.Text = " ";
            txtHangSX.Text = " ";
            txtMaNV.Text = " ";
        }

        private void btnCloseCT_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            this.Close();
        }

        private void QuanLyCongTo_Load(object sender, EventArgs e)
        {
            LoadListCT();
            BindingData();
        }

        private void btnInCT_Click(object sender, EventArgs e)
        {
            rptCongTo rptCongTo = new rptCongTo();
            rptCongTo.SetDataSource(ctb.getCongTo());
            frmReportCT f = new frmReportCT();
            f.crystalReportViewer2.ReportSource = rptCongTo;
            f.ShowDialog();
        }
    }
}
