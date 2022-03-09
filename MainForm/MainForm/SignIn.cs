using QuanLyThuPhiCapNuocsach.BUS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuPhiCapNuocsach
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void DangKy_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void Index_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        User_BUS ub = new User_BUS();

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            String condition;
            condition = "sTenDangNhap ='" + txtUsername.Text + "' AND sMatKhau ='" + txtPassword.Text + "'";
            DataTable dt = new DataTable();
            try
            {
                dt = ub.getUser(condition);
                if(dt.Rows.Count>0)
                {
                    MessageBox.Show("Chào mừng " + txtUsername.Text + " đến với hệ thống!");
                    Index index = new Index();
                    index.FormClosed += new FormClosedEventHandler(Index_Closed);
                    index.Show();
                    this.Hide();
                    txtUsername.Text = " ";
                    txtPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                    txtUsername.Text = " ";
                    txtPassword.Text = "";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai cú pháp!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi khi kết nối đến hệ thống!");
            }
        }
            private void btnDangky_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.FormClosed += new FormClosedEventHandler(DangKy_Closed);
            signup.Show();
            this.Hide();
        }
    }
}
