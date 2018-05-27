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
    public class SanPham_DAL : ConnectDB
    {

        public DataTable GetAllSanPham() {
            SqlCommand cmd = new SqlCommand("SP_SanPham_GetAllTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetSanPhamByID(int id) {
            SqlCommand cmd = new SqlCommand("SP_SanPham_GetByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public string AddSanPham(SanPham_ET sanPham)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SanPham_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masp", sanPham.MaSP);
                cmd.Parameters.AddWithValue("@tensp", sanPham.TenSP);
                cmd.Parameters.AddWithValue("@giasp", sanPham.GiaSP);
                cmd.Parameters.AddWithValue("@soluong", sanPham.SoLuong);

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

        public string UpdateSanPham(SanPham_ET sanPham) {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SanPham_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", sanPham.ID);
                cmd.Parameters.AddWithValue("@masp", sanPham.MaSP);
                cmd.Parameters.AddWithValue("@tensp", sanPham.TenSP);
                cmd.Parameters.AddWithValue("@giasp", sanPham.GiaSP);
                cmd.Parameters.AddWithValue("@soluong", sanPham.SoLuong);

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

        public string DeleteSanPham(SanPham_ET sanPham)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SanPham_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", sanPham.ID);

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
