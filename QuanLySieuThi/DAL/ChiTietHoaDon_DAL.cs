using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class ChiTietHoaDon_DAL:ConnectDB
    {
        public DataTable GetAllChiTietHoaDon()
        {
            SqlCommand cmd = new SqlCommand("SP_ChiTietHoaDon_GetAllTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetHoaChiTietDonByID(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_ChiTietHoaDon_GetByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public string AddChiTietHoaDon(int idHD, int idSP, int soLuong)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ChiTietHoaDon_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_hoadon", idHD);
                cmd.Parameters.AddWithValue("@id_sanpham", idSP);
                cmd.Parameters.AddWithValue("@soluong", soLuong);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Thêm chi tiết hóa đơn thành công!";
                }
                else
                {
                    return "Thêm chi tiết hóa đơn thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Thêm chi tiết hóa đơn thất bại! " + ex.Message;
            }
        }

        public string UpdateChiTietHoaDon(int id, int idHD, int idSP, int soLuong)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ChiTietHoaDon_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@id_hoadon", idHD);
                cmd.Parameters.AddWithValue("@id_sanpham", idSP);
                cmd.Parameters.AddWithValue("@soluong", soLuong);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Câp nhật chi tiết hóa đơn thành công!";
                }
                else
                {
                    return "Cập nhật chi tiết hóa đơn thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Cập nhật chi tiết hóa đơn thất bại! " + ex.Message;
            }
        }

        public string DeleteChiTietHoaDon(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ChiTietHoaDon_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Xóa chi tiết hóa đơn thành công!";
                }
                else
                {
                    return "Xóa chi tiết hóa đơn thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Xóa chi tiết hóa đơn thất bại! " + ex.Message;
            }
        }
    }
}
