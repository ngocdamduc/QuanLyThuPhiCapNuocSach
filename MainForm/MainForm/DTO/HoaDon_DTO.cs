using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuPhiCapNuocsach.DTO
{
   public class HoaDon_DTO
    {
        string mahd; string mact; int csc; int csm; string ngaylap; string makh; string manv; string loaikh;
        public string MaHD        {
            get { return mahd; }
            set { mahd = value; }
        }
        public string MaCT
        {
            get { return mact; }
            set { mact = value; }
        }
        public int CSC
        {
            get { return csc; }
            set { csc = value; }
        }
        public int CSM
        {
            get { return csm; }
            set { csm = value; }
        }
        public string NgayLap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
        public string MaKH
        {
            get { return makh; }
            set { makh = value; }
        }
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        public string LoaiKH
        {
            get { return loaikh; }
            set { loaikh = value; }
        }
    }
}
