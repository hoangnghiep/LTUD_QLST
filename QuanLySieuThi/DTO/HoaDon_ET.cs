using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_ET
    {
        private int _ID;
        private int _ID_KhachHang;
        private int _ID_NhanVien;
        private DateTime _NgayLap;

        public int ID_KhachHang { get => _ID_KhachHang; set => _ID_KhachHang = value; }
        public int ID_NhanVien { get => _ID_NhanVien; set => _ID_NhanVien = value; }
        public DateTime NgayLap { get => _NgayLap; set => _NgayLap = value; }
        public int ID { get => _ID; set => _ID = value; }

        public HoaDon_ET(int id, int idKhachHang, int idNhanVien, DateTime ngayLap) {
            this.ID = id;
            this.ID_KhachHang = idKhachHang;
            this.ID_NhanVien = idNhanVien;
            this.NgayLap = ngayLap;
        }
        public HoaDon_ET(int idKhachHang, int idNhanVien, DateTime ngayLap)
        {
            this.ID_KhachHang = idKhachHang;
            this.ID_NhanVien = idNhanVien;
            this.NgayLap = ngayLap;
        }
    }
}
