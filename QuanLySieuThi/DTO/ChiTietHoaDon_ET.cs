using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ChiTietHoaDon_ET
    {
        private int _ID_HoaDon;
        private int _ID_SanPham;
        private int _SoLuong;

        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public int ID_SanPham { get => _ID_SanPham; set => _ID_SanPham = value; }
        public int ID_HoaDon { get => _ID_HoaDon; set => _ID_HoaDon = value; }

        public ChiTietHoaDon_ET(int idHoaDon, int idSanPham, int soLuong) {
            this.ID_HoaDon = idHoaDon;
            this.ID_SanPham = idSanPham;
            this.SoLuong = soLuong;
        }
    }
}
