using QuanLyThuPhiCapNuocsach.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuPhiCapNuocsach.BUS
{
    public class KhachHang_BUS
    {
        DataProvider dt = new DataProvider();
        public DataTable getKhachHang()
        {
            DataTable da = null;
            String sql = "SELECT * FROM tbl_KhachHang";
            da = dt.GetTable(sql);
            return da;
        }
        public void insertKH(String makh, String tenkh, String diachi, String ngaysinh, String loaiKH)
        {
            String sql = " INSERT INTO tbl_KhachHang VALUES('" + makh + "',N'" + tenkh + "',N'" + diachi + "',N'"  + "','" + ngaysinh + "',N'" + loaiKH + "')";
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
        public void updateKH(String makh, String tenkh, String diachi, String ngaysinh, String loaiKH)
        {
            String sql = "UPDATE tbl_KhachHang SET sMaKH = '" + makh + "',sTenKH=N'" + tenkh + "',sDiachi=N'" + diachi + "',dNgaySinh='" + ngaysinh + "',sLoaiKH=N'" + loaiKH + "' where sMaKH='" + makh + "'";
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
        public void deleteKH(String makh)
        {
            String sql = "DELETE tbl_NhanVien where sMaKH='" + makh + "'";
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
        public DataTable Search(String condition)
        {
            DataTable da = null;
            String sql = "SELECT * FROM tbl_KhachHang WHERE sMaKH LIKE N'%" + condition + "%' OR sTenKH LIKE N'%" + condition + "%'";
            da = dt.GetTable(sql);
            return da;
        }
    }
}
