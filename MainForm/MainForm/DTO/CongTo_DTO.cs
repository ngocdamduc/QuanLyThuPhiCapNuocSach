using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuPhiCapNuocsach.DTO
{
    public class CongTo_DTO
    {
        String maCT;
        DateTime ngayLapDat;
        String hangSX;
        String maKH;
        String maNV;
       
        public String MaCT
        {
            get
            {
                return maCT;
            }
            set { maCT = value; }
        }
        public DateTime NgayLapDat
        {
            get { return ngayLapDat; }
            set { ngayLapDat = value; }
        }
        public String HangSX
        {
            get { return hangSX; }
            set { hangSX = value; }
        }
        public String MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        
        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
    }
}
