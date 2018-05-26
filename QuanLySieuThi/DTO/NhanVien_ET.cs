﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NhanVien_ET
    {
        private string _HoTen;
        private string _GioiTinh;
        private string _DiaChi;
        private string _SDT;
        private DateTime _NgaySinh;

        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }

        public NhanVien_ET(string hoTen, string gioiTinh, string diaChi, string soDT, DateTime ngaySinh)
        {
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.SDT = soDT;
            this.NgaySinh = ngaySinh;
        }
    }
}
