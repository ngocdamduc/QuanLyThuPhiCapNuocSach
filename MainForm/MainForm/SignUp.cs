using QuanLyThuPhiCapNuocsach.BUS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuPhiCapNuocsach
{
    public partial class SignUp : Form
    {
        User_BUS ub = new User_BUS();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            signin.Show();
            this.Close();
        }
        private void btnDangky_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNhapLai.Text == txtMatKhau.Text)
                {
                    ub.insertUser(txtTaikhoan.Text, txtMaNv.Text, txtMatKhau.Text);
                    MessageBox.Show("Đăng ký tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn nhập sai cú pháp !");
            }
            catch (SqlException)
            {
                MessageBox.Show("Tài Khoản đã tồn tại!");
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            txtMaNv.DisplayMember = "sMaNV";
            txtMaNv.DataSource = ub.getUser2(); 
        }
    }
}


