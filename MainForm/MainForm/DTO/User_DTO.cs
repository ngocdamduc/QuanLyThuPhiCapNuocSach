using System;
namespace QuanLyThuPhiCapNuocsach.DTO
{
    public class User_DTO
    {
        String username;
        String password;
        String maNV;
        public String Usernamae
        {
            get { return username; }
            set { username = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
    }
}
