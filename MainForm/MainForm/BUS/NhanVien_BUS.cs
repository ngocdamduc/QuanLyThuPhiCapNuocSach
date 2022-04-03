using QuanLyThuPhiCapNuocsach.DAO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuPhiCapNuocsach.BUS
{
    public class NhanVien_BUS
    {
        DataProvider dt = new DataProvider();
        public DataTable getNhanVien()
        {
            DataTable da = null;
            String sql = "SELECT * FROM tbl_NhanVien";
            da = dt.GetTable(sql);
            return da;
        }
        public void insertNV(string manv, string tennv, string diachi, string gioitinh, string ngaysinh, string chucvu)
        {
            String sql = " INSERT INTO tbl_NhanVien VALUES('" + manv + "',N'" + tennv + "',N'" + diachi + "',N'" + gioitinh + "','" + ngaysinh + "',N'" + chucvu + "')";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Thêm thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi khi kết nối tới hệ thống !");
                MessageBox.Show(ex.Message);
            }
        }
        public void updateNV(string manv, string tennv, string diachi, string gioitinh, string ngaysinh, string chucvu)
        {
            String sql = "UPDATE tbl_NhanVien SET sMaNV = '" + manv + "',sTenNV=N'" + tennv + "',sDiachi=N'" + diachi + "',bGioitinh=N'" + gioitinh + "',dNgaySinh='" + ngaysinh + "',sChucVu=N'" + chucvu + "' where sMaNV='" + manv + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Sửa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi khi kết nối tới hệ thống !");
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteNV(string manv)
        {
            String sql = "DELETE tbl_NhanVien where sMaNV='" + manv + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Xóa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi khi kết nối tới hệ thống !" + ex.Message);
            }
        }
        public DataTable Search(string condition)
        {
            DataTable da = null;
            String sql = "SELECT * FROM tbl_NhanVien WHERE sMaNV LIKE N'%" + condition + "%' OR sTenNV LIKE N'%" + condition + "%'";
            da = dt.GetTable(sql);
            return da;
        }
    }
}
