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
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetNhanVienByID(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_NhanVien_GetByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public string AddNhanVien(NhanVien_ET nhanVien)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_NhanVien_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hoten", nhanVien.HoTen);
                cmd.Parameters.AddWithValue("@gioitinh", nhanVien.GioiTinh);
                cmd.Parameters.AddWithValue("@diachi", nhanVien.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", nhanVien.SDT);
                cmd.Parameters.AddWithValue("@ngaysinh", nhanVien.NgaySinh);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Thêm nhân viên thành công!";
                }
                else
                {
                    return "Thêm nhân viên thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Thêm nhân viên thất bại! " + ex.Message;
            }
        }

        public string UpdateNhanVien(NhanVien_ET nhanVien)
        {
            try
            {
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
                    return "Câp nhật nhân viên thành công!";
                }
                else
                {
                    return "Cập nhật nhân viên thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Cập nhật nhân viên thất bại! " + ex.Message;
            }
        }

        public string DeleteNhanVien(NhanVien_ET nhanVien)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_NhanVien_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", nhanVien.ID);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "Xóa nhân viên thành công!";
                }
                else
                {
                    return "Xóa nhân viên thất bại!";
                }
            }
            catch (Exception ex)
            {
                return "Xóa nhân viên thất bại! " + ex.Message;
            }
        }
    }
}
