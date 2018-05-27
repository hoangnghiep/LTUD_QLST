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
    public class KhachHang_DAL :ConnectDB
    {
        public DataTable GetAllKhachHang()
        {
            SqlCommand cmd = new SqlCommand("SP_KhachHang_GetAllTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetKhachHangByID(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_KhachHang_GetByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public string AddKhachHang(KhachHang_ET khachHang)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_KhachHang_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hoten", khachHang.HoTen);
                cmd.Parameters.AddWithValue("@gioitinh", khachHang.GioiTinh);
                cmd.Parameters.AddWithValue("@diachi", khachHang.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", khachHang.SDT);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Thêm khách hàng thành công!";
                }
                else
                {
                    return "Thêm khách hàng thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Thêm khách hàng thất bại! " + ex.Message;
            }
        }

        public string UpdateKhachHang(KhachHang_ET khachHang)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_KhachHang_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", khachHang.ID);
                cmd.Parameters.AddWithValue("@hoten", khachHang.HoTen);
                cmd.Parameters.AddWithValue("@gioitinh", khachHang.GioiTinh);
                cmd.Parameters.AddWithValue("@diachi", khachHang.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", khachHang.SDT);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Câp nhật khách hàng thành công!";
                }
                else
                {
                    return "Cập nhật khách hàng thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Cập nhật khách hàng thất bại! " + ex.Message;
            }
        }

        public string DeleteKhachHang(KhachHang_ET khachHang)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_KhachHang_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", khachHang.ID);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Xóa khách hàng thành công!";
                }
                else
                {
                    return "Xóa khách hàng thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Xóa khách hàng thất bại! " + ex.Message;
            }
        }
    }
}
