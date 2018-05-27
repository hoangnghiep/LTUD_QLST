using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class HoaDon_DAL :ConnectDB
    {
        public DataTable GetAllHoaDon()
        {
            SqlCommand cmd = new SqlCommand("SP_HoaDon_GetAllTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetHoaDonByID(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_HoaDon_GetByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public string AddHoaDon(HoaDon_ET hoaDon)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_HoaDon_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_kh", hoaDon.ID_KhachHang);
                cmd.Parameters.AddWithValue("@id_nv", hoaDon.ID_NhanVien);
                cmd.Parameters.AddWithValue("@ngaylap", hoaDon.NgayLap);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Thêm hóa đơn thành công!";
                }
                else
                {
                    return "Thêm hóa đơn thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Thêm hóa đơn thất bại! " + ex.Message;
            }
        }

        public string UpdateHoaDon(HoaDon_ET hoaDon)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_HoaDon_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", hoaDon.ID);
                cmd.Parameters.AddWithValue("@id_kh", hoaDon.ID_KhachHang);
                cmd.Parameters.AddWithValue("@id_nv", hoaDon.ID_NhanVien);
                cmd.Parameters.AddWithValue("@ngaylap", hoaDon.NgayLap);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Câp nhật hóa đơn thành công!";
                }
                else
                {
                    return "Cập nhật hóa đơn thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Cập nhật hóa đơn thất bại! " + ex.Message;
            }
        }

        public string DeleteHoaDon(HoaDon_ET hoaDon)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_HoaDon_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", hoaDon.ID);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Xóa hóa đơn thành công!";
                }
                else
                {
                    return "Xóa hóa đơn thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Xóa hóa đơn thất bại! " + ex.Message;
            }
        }
    }
}
