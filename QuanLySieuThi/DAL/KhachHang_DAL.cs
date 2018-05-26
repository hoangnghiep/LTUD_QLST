using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class KhachHang_DAL:ConnectDB
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

        public string AddKhachHang(string hoTen, string gioiTinh, string diaChi, string soDT)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_KhachHang_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hoten", hoTen);
                cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);
                cmd.Parameters.AddWithValue("@diachi", diaChi);
                cmd.Parameters.AddWithValue("@sdt", soDT);

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

        public string UpdateKhachHang(int id, string hoTen, string gioiTinh, string diaChi, string soDT)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_KhachHang_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@hoten", hoTen);
                cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);
                cmd.Parameters.AddWithValue("@diachi", diaChi);
                cmd.Parameters.AddWithValue("@sdt", soDT);

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

        public string DeleteKhachHang(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_KhachHang_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

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
