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
    public class NhanVien_BUS
    {
        NhanVien_DAL dal_NhanVien = new NhanVien_DAL();
        public DataTable GetAllNhanVien()
        {
            return dal_NhanVien.GetAllNhanVien();
        }

        public DataTable GetNhanVienByID(int id)
        {
            return dal_NhanVien.GetNhanVienByID(id);
        }

        public bool AddNhanVien(NhanVien_ET nhanVien)
        {
            return dal_NhanVien.AddNhanVien(nhanVien);
        }

        public bool UpdateNhanVien(NhanVien_ET nhanVien)
        {
            return dal_NhanVien.UpdateNhanVien(nhanVien);           
        }

        public bool DeleteNhanVien(NhanVien_ET nhanVien)
        {
            return dal_NhanVien.DeleteNhanVien(nhanVien);
        }
    }
}
