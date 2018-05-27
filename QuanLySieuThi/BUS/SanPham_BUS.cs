using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class SanPham_BUS
    {
        SanPham_DAL dal_SanPham = new SanPham_DAL();
        public DataTable GetAllSanPham()
        {
            return dal_SanPham.GetAllSanPham();
        }
        public DataTable GetSanPhamByID(int id) {
            return dal_SanPham.GetSanPhamByID(id);
        }
        public bool AddSanPham(SanPham_ET sanPham) {
            return dal_SanPham.AddSanPham(sanPham);
        }
        public bool UpdateSanPham(SanPham_ET sanPham) {
            return dal_SanPham.UpdateSanPham(sanPham);
        }
        public bool DeleteSanPham(SanPham_ET sanPham) {
            return dal_SanPham.DeleteSanPham(sanPham);
        }
    }
}
