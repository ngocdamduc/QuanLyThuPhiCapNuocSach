using System;

namespace QuanLyThuPhiCapNuocsach.DTO
{
    public class NhanVien_DTO
    {
        String maNV;
        String tenNV;
        String diachi;
        String gioitinh;
        DateTime ngaysinh;
        String chucvu;
        public String MaNV
        {
            get
            {
                return maNV;
            }
            set { maNV = value; }
        }
        public String TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public String DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public String GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public String ChucVu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
    }
   
}
