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
    public class CongTo_BUS
    {
        DataProvider dt = new DataProvider();
        public DataTable getCongTo()
        {
            DataTable da = null;
            String sql = "SELECT * FROM tbl_CongTo";
            da = dt.GetTable(sql);
            return da;
        }
        public void insertCT(string mact, string ngaylapdat, string hangsx, string makh, string manv )
        {
            String sql = " INSERT INTO tbl_CongTo VALUES('" + mact + "','" + ngaylapdat + "',N'" + hangsx + "',N'" + makh + "','" + manv +  "')";
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

        public void updateCT(string mact, string ngaylapdat, string hangsx, string makh, string manv)
        {
            String sql = "UPDATE tbl_CongTo SET sMaCT = '" + mact + "',dNgayLapDat='" + ngaylapdat + "',sHangSX=N'" + hangsx + "',sMaKH='" + makh + "',sMaNV='" + manv + "' where sMaCT='" + mact + "'";
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
        public void deleteCT(string mact)
        {
            String sql = "DELETE tbl_CongTo where sMaCT='" + mact + "'";
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
            String sql = "SELECT * FROM tbl_CongTo WHERE sMaCT LIKE N'%" + condition + "%' OR sMaKH LIKE N'%" + condition + "%'";
            da = dt.GetTable(sql);
            return da;
        }
        public DataTable getMaNV()
        {
            DataTable da = null;
            String sql = "SELECT sMaNV FROM tbl_NhanVien";
            da = dt.GetTable(sql);
            return da;
        }
        public DataTable getKH()
        {
            DataTable da = null;
            String sql = "SELECT sMaKH FROM tbl_KhachHang";
            da = dt.GetTable(sql);
            return da;
        }
    }
}
