using QuanLyThuPhiCapNuocsach.DAO;
using QuanLyThuPhiCapNuocsach.DTO;
using System;
using System.Data;

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
        public void insertUser(String manv, String username, String pass)
        {
            String sql = " INSERT INTO tbl_TaiKhoan VALUES('" + username + "','" + manv + "','" + pass + "')";
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
