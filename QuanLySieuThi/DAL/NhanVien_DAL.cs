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
    public class NhanVien_DAL :ConnectDB
    {
        public DataTable GetAllNhanVien()
        {
            SqlCommand cmd = new SqlCommand("SP_NhanVien_GetAllTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetNhanVienByID(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_NhanVien_GetByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool AddNhanVien(NhanVien_ET nhanVien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_NhanVien_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hoten", nhanVien.HoTen);
                cmd.Parameters.AddWithValue("@gioitinh", nhanVien.GioiTinh);
                cmd.Parameters.AddWithValue("@diachi", nhanVien.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", nhanVien.SDT);
                cmd.Parameters.AddWithValue("@ngaysinh", nhanVien.NgaySinh);

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

        public bool UpdateNhanVien(NhanVien_ET nhanVien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_NhanVien_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", nhanVien.ID);
                cmd.Parameters.AddWithValue("@hoten", nhanVien.HoTen);
                cmd.Parameters.AddWithValue("@gioitinh", nhanVien.GioiTinh);
                cmd.Parameters.AddWithValue("@diachi", nhanVien.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", nhanVien.SDT);
                cmd.Parameters.AddWithValue("@ngaysinh", nhanVien.NgaySinh);

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

        public bool DeleteNhanVien(NhanVien_ET nhanVien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_NhanVien_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", nhanVien.ID);

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
    }
}
