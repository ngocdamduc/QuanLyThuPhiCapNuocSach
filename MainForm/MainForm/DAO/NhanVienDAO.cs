namespace QuanLyThuPhiCapNuocsach.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }
        private NhanVienDAO() { }
        public bool InsertNV(string maNV, string tenNV, string DiaChi, string GioiTinh, string NgaySinh, string ChucVu)
        {
            string query = "EXEC InsertNhanVIen MaNV, TenNV, Diachi, GioiTinh, NgaySinh, ChucVu";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
