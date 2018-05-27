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
    public class ChiTietHoaDon_BUS
    {
        ChiTietHoaDon_DAL dal_ChiTietHoaDon = new ChiTietHoaDon_DAL();
        public DataTable GetAllChiTietHoaDon()
        {
            return dal_ChiTietHoaDon.GetAllChiTietHoaDon();
        }

        public DataTable GetHoaChiTietDonByID(int id)
        {
            return dal_ChiTietHoaDon.GetHoaChiTietDonByID(id);
        }

        public string AddChiTietHoaDon(ChiTietHoaDon_ET chiTietHoaDon)
        {
            return dal_ChiTietHoaDon.AddChiTietHoaDon(chiTietHoaDon);
        }

        public string UpdateChiTietHoaDon(ChiTietHoaDon_ET chiTietHoaDon)
        {
            return dal_ChiTietHoaDon.UpdateChiTietHoaDon(chiTietHoaDon);
        }

        public string DeleteChiTietHoaDon(ChiTietHoaDon_ET chiTietHoaDon)
        {
            return dal_ChiTietHoaDon.DeleteChiTietHoaDon(chiTietHoaDon);
        }
    }
}
