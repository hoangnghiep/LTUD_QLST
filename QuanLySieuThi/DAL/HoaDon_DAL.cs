using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class HoaDon_DAL:ConnectDB
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

        public string AddHoaDon(int idKH, int idNV, DateTime ngayLap)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_HoaDon_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_kh", idKH);
                cmd.Parameters.AddWithValue("@id_nv", idNV);
                cmd.Parameters.AddWithValue("@ngaylap", ngayLap);

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

        public string UpdateHoaDon(int id, int idKH, int idNV, DateTime ngayLap)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_HoaDon_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@id_kh", idKH);
                cmd.Parameters.AddWithValue("@id_nv", idNV);
                cmd.Parameters.AddWithValue("@ngaylap", ngayLap);

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

        public string DeleteHoaDon(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_HoaDon_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

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
