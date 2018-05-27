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
    public class HoaDon_BUS
    {
        HoaDon_DAL dal_HoaDon = new HoaDon_DAL();
        public DataTable GetAllHoaDon()
        {
            return dal_HoaDon.GetAllHoaDon();
        }

        public DataTable GetHoaDonByID(int id)
        {
            return dal_HoaDon.GetHoaDonByID(id);
        }

        public string AddHoaDon(HoaDon_ET hoaDon)
        {
            return dal_HoaDon.AddHoaDon(hoaDon);
        }

        public string UpdateHoaDon(HoaDon_ET hoaDon)
        {
            return dal_HoaDon.UpdateHoaDon(hoaDon);
        }

        public string DeleteHoaDon(HoaDon_ET hoaDon)
        {
            return dal_HoaDon.DeleteHoaDon(hoaDon);
        }
    }
}
