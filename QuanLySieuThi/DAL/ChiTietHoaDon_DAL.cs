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
    public class ChiTietHoaDon_DAL :ConnectDB
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

        public string AddChiTietHoaDon(ChiTietHoaDon_ET chiTietHoaDon)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ChiTietHoaDon_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_hoadon", chiTietHoaDon.ID_HoaDon);
                cmd.Parameters.AddWithValue("@id_sanpham", chiTietHoaDon.ID_SanPham);
                cmd.Parameters.AddWithValue("@soluong", chiTietHoaDon.SoLuong);

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

        public string UpdateChiTietHoaDon(ChiTietHoaDon_ET chiTietHoaDon)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ChiTietHoaDon_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", chiTietHoaDon.ID);
                cmd.Parameters.AddWithValue("@id_hoadon", chiTietHoaDon.ID_HoaDon);
                cmd.Parameters.AddWithValue("@id_sanpham", chiTietHoaDon.ID_SanPham);
                cmd.Parameters.AddWithValue("@soluong", chiTietHoaDon.SoLuong);

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

        public string DeleteChiTietHoaDon(ChiTietHoaDon_ET chiTietHoaDon)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ChiTietHoaDon_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", chiTietHoaDon.ID);

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
