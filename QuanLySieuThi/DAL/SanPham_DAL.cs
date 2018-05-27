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
