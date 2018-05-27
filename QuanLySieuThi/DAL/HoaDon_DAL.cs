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
    public class HoaDon_DAL :ConnectDB
    {
        public DataTable GetAllHoaDon()
        {
            SqlCommand cmd = new SqlCommand("SP_HoaDon_GetAllTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetHoaDonByID(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_HoaDon_GetByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool AddHoaDon(HoaDon_ET hoaDon)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_HoaDon_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_kh", hoaDon.ID_KhachHang);
                cmd.Parameters.AddWithValue("@id_nv", hoaDon.ID_NhanVien);
                cmd.Parameters.AddWithValue("@ngaylap", hoaDon.NgayLap);

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

        public bool UpdateHoaDon(HoaDon_ET hoaDon)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_HoaDon_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", hoaDon.ID);
                cmd.Parameters.AddWithValue("@id_kh", hoaDon.ID_KhachHang);
                cmd.Parameters.AddWithValue("@id_nv", hoaDon.ID_NhanVien);
                cmd.Parameters.AddWithValue("@ngaylap", hoaDon.NgayLap);

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

        public bool DeleteHoaDon(HoaDon_ET hoaDon)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_HoaDon_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", hoaDon.ID);

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
