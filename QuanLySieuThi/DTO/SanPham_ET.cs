﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class SanPham_ET
    {
        private string _MaSP;
        private string _TenSP;
        private int _GiaSP;
        private int _SoLuong;

        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public int GiaSP { get => _GiaSP; set => _GiaSP = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }

        public SanPham_ET(string maSP, string tenSP, int giaSP, int soLuong) {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.GiaSP = giaSP;
            this.SoLuong = soLuong;
        }
    }
}
