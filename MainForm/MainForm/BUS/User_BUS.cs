using QuanLyThuPhiCapNuocsach.DAO;
using QuanLyThuPhiCapNuocsach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuPhiCapNuocsach.BUS
{
    public class User_BUS
    {
        User_DTO U = new User_DTO();
        DataProvider da = new DataProvider();
        public DataTable getUser(String condition )
        {
            DataTable dt = null;
            String sql = "SELECT * FROM tbl_TaiKhoan WHERE " + condition;
            dt = da.GetTable(sql);
            return dt;
        }
        public void insertUser(String username, String pass, String manv)
        {
            String sql = "EXEC '@MaNV', '@TenDangNhap', '@MatKhau'";
            da.ExcuteNonQuery(sql);
        }
        
        public DataTable getUser2()
        {
            DataTable dt = null;
            String sql = "SELECT sMaNV FROM tbl_NhanVien";
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
