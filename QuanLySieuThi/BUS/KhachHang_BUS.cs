using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class KhachHang_BUS
    {
        KhachHang_DAL dal_KhachHang = new KhachHang_DAL();
        public DataTable GetAllKhachHang()
        {
            return dal_KhachHang.GetAllKhachHang();
        }

        public DataTable GetKhachHangByID(int id)
        {
            return dal_KhachHang.GetKhachHangByID(id);
        }

        public bool AddKhachHang(KhachHang_ET khachHang)
        {
            return dal_KhachHang.AddKhachHang(khachHang);
        }

        public bool UpdateKhachHang(KhachHang_ET khachHang)
        {
            return dal_KhachHang.UpdateKhachHang(khachHang);
        }

        public bool DeleteKhachHang(KhachHang_ET khachHang)
        {
            return dal_KhachHang.DeleteKhachHang(khachHang);
        }
    }
}
