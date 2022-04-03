using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuPhiCapNuocsach.DTO
{
    public class KhachHang_DTO
    {
        String maKH;
        String tenKH;
        String diachi;
        DateTime ngaysinh;
        String loaiKH;
        public String MaKH
        {
            get
            {
                return maKH;
            }
            set { maKH = value; }
        }
        public String TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public String DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public String LoaiKH
        {
            get { return loaiKH; }
            set { loaiKH = value; }
        }
    }
}
