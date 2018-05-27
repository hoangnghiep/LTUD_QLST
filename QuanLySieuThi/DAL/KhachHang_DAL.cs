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
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetKhachHangByID(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_KhachHang_GetByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool AddKhachHang(KhachHang_ET khachHang)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_KhachHang_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hoten", khachHang.HoTen);
                cmd.Parameters.AddWithValue("@gioitinh", khachHang.GioiTinh);
                cmd.Parameters.AddWithValue("@diachi", khachHang.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", khachHang.SDT);

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

        public bool UpdateKhachHang(KhachHang_ET khachHang)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_KhachHang_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", khachHang.ID);
                cmd.Parameters.AddWithValue("@hoten", khachHang.HoTen);
                cmd.Parameters.AddWithValue("@gioitinh", khachHang.GioiTinh);
                cmd.Parameters.AddWithValue("@diachi", khachHang.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", khachHang.SDT);

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

        public bool DeleteKhachHang(KhachHang_ET khachHang)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_KhachHang_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", khachHang.ID);

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
