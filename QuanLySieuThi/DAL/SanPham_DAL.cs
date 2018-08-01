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
        /// <summary>
        /// Hàm lấy tất cả sản phẩm trong database
        /// </summary>
        /// <returns>Trả về bảng sản phẩm</returns>
        public DataTable GetAllSanPham() {
            SqlCommand cmd = new SqlCommand("SP_SanPham_GetAllTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        /// <summary>
        /// Lấy sản phẩm theo ID
        /// </summary>
        /// <param name="id">ID của sảm phẩm</param>
        /// <returns>Trả về 1 sản phẩm trong bảng sản phẩm</returns>
        public DataTable GetSanPhamByID(int id) {
            SqlCommand cmd = new SqlCommand("SP_SanPham_GetByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        /// <summary>
        /// Hàm thêm sản phẩm vào database
        /// </summary>
        /// <param name="sanPham">Đối tượng sản phẩm</param>
        /// <returns>trả vè true nếu thêm thành công, false nếu thêm không thành công</returns>
        public bool AddSanPham(SanPham_ET sanPham)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_SanPham_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masp", sanPham.MaSP);
                cmd.Parameters.AddWithValue("@tensp", sanPham.TenSP);
                cmd.Parameters.AddWithValue("@giasp", sanPham.GiaSP);
                cmd.Parameters.AddWithValue("@soluong", sanPham.SoLuong);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Hàm sửa sản phẩm
        /// </summary>
        /// <param name="sanPham">Truyền đối tượng sản phẩm</param>
        /// <returns>trả vè true nếu sửa thành công, false nếu sửa không thành công</returns>
        public bool UpdateSanPham(SanPham_ET sanPham) {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_SanPham_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", sanPham.ID);
                cmd.Parameters.AddWithValue("@masp", sanPham.MaSP);
                cmd.Parameters.AddWithValue("@tensp", sanPham.TenSP);
                cmd.Parameters.AddWithValue("@giasp", sanPham.GiaSP);
                cmd.Parameters.AddWithValue("@soluong", sanPham.SoLuong);

                if (cmd.ExecuteNonQuery() > 0) {
                    return true;
                }
                else {
                    return false;
                }
            } catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Hàm xóa sản phẩm
        /// </summary>
        /// <param name="sanPham">Đối tượng sản phẩm</param>
        /// <returns>trả vè true nếu xóa thành công, false nếu Xóa không thành công</returns>
        public bool DeleteSanPham(SanPham_ET sanPham)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_SanPham_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", sanPham.ID);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally {
                conn.Close();
            }
        }
    }
}
