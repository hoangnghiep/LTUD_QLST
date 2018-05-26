using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class SanPham_DAL : ConnectDB
    {

        public DataTable GetAllSanPham() {
            SqlCommand cmd = new SqlCommand("SP_SanPham_GetAllTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetSanPhamByID(int id) {
            SqlCommand cmd = new SqlCommand("SP_SanPham_GetByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public string AddSanPham(string maSP, string tenSP, int giaSP, int soLuong)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SanPham_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masp", maSP);
                cmd.Parameters.AddWithValue("@tensp", tenSP);
                cmd.Parameters.AddWithValue("@giasp", giaSP);
                cmd.Parameters.AddWithValue("@soluong", soLuong);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Thêm sản phẩm thành công!";
                }
                else
                {
                    return "Thêm sản phẩm thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Thêm sản phẩm thất bại! " + ex.Message;
            }
        }

        public string UpdateSanPham(int id, string maSP, string tenSP, int giaSP, int soLuong) {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SanPham_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@masp", maSP);
                cmd.Parameters.AddWithValue("@tensp", tenSP);
                cmd.Parameters.AddWithValue("@giasp", giaSP);
                cmd.Parameters.AddWithValue("@soluong", soLuong);

                if (cmd.ExecuteNonQuery() > 0) {
                    return "Câp nhật sản phẩm thành công!";
                }
                else {
                    return "Cập nhật sản phẩm thất bại!";
                }
            } catch (Exception ex)
            {
                return "Cập nhật sản phẩm thất bại! " + ex.Message;
            }
        }

        public string DeleteSanPham(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SanPham_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Xóa sản phẩm thành công!";
                }
                else
                {
                    return "Xóa sản phẩm thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Xóa sản phẩm thất bại! " + ex.Message;
            }
        }
    }
}
