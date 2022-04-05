using QuanLyThuPhiCapNuocsach.DAO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuPhiCapNuocsach.BUS
{
    public class HoaDon_BUS
    {
        DataProvider da = new DataProvider();
        public DataTable getHoaDon()
        {
            DataTable dt = null;
            String sql = "SELECT * FROM tbl_HoaDon";
            dt = da.GetTable(sql);
            return dt;
        }
        public void insertHD(string mahd, string mact, string csc, string csm, string ngaylap, string makh, string manv, string loaikh)
        {
            string sql = " INSERT INTO tbl_HoaDon VALUES('" + mahd + "','" + mact + "','" + csc + "','" + csm + "','" + ngaylap + "', '" + makh + "' , '" + manv + "', N'" + loaikh + "')";
            try
            {
                da.ExcuteNonQuery(sql);
                MessageBox.Show("Thêm thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi khi kết nối tới hệ thống !");
                MessageBox.Show(ex.Message);
            }
        }
        public void updateHD(string mahd, string mact, string csc, string csm, string ngaylap, string makh, string manv, string loaikh)
        {
            String sql = "UPDATE tbl_HoaDon SET sMaHD = '" + mahd + "',sMaCT='" + mact + "',bChiSoCu='" + csc + "',bChiSoMoi='" + csm + "',dNgaylap='" + ngaylap + "',sMaKH='" + makh + "',sMaNV='" + manv + "',sLoaiKH=N'" + loaikh + "' where sMaHD='" + mahd + "'";
            try
            {
                da.ExcuteNonQuery(sql);
                MessageBox.Show("Sửa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi khi kết nối tới hệ thống !");
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteHD(string mahd)
        {
            String sql = "DELETE tbl_HoaDon where sMaHD='" + mahd + "'";
            try
            {
                da.ExcuteNonQuery(sql);
                MessageBox.Show("Xóa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi khi kết nối tới hệ thống !" + ex.Message);
            }
        }
        public DataTable Search(string condition)
        {
            DataTable dt = null;
            String sql = "SELECT * FROM tbl_HoaDon WHERE sMaHD LIKE N'%" + condition + "%' OR sMaKH LIKE N'%" + condition + "%' OR sMaNV LIKE N'%" + condition + "%'";
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable getMaNV()
        {
            DataTable dt = null;
            String sql = "SELECT sMaNV FROM tbl_NhanVien";
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable getKH()
        {
            DataTable dt = null;
            String sql = "SELECT sMaKH FROM tbl_KhachHang";
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable getCT()
        {
            DataTable dt = null;
            String sql = "SELECT sMaCT FROM tbl_CongTo";
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable getLoaiKH()
        {
            DataTable dt = null;
            String sql = "SELECT sLoaiKH FROM tbl_LoaiKH";
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable reportHD(string condition)
        {
            DataTable dt = null;
            String sql = "SELECT * FROM view_thanhtien WHERE sTenKH LIKE N'%" + condition + "' ORDER BY MONTH(dNgayLap)";
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
