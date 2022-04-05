using System;
using System.Windows.Forms;

namespace QuanLyThuPhiCapNuocsach
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
        public static string s = "Phần Mềm Quản Lý Thu Phí Cấp Nước Sạch - Nhóm G20 ";
        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void toolQLKH_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang qlkh = new QuanLyKhachHang();
            qlkh.ShowDialog();
        }

        private void toolQLNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.ShowDialog();
        }

        private void toolQLCT_Click(object sender, EventArgs e)
        {
            QuanLyCongTo qlct = new QuanLyCongTo();
            qlct.ShowDialog();
        }

        private void toolQLHD_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon qlhd = new QuanLyHoaDon();
            qlhd.ShowDialog();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            lbnam.Text = "Ngày " + DateTime.Now.Day.ToString() + " Tháng " + DateTime.Now.Month.ToString() + " Năm " + DateTime.Now.Year.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHeading.Text = s;
            string tam = s[0].ToString();
            s = s.Substring(1, s.Length - 1) + tam;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbdongho.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
