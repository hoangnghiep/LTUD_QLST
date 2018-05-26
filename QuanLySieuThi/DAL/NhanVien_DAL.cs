using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class NhanVien_DAL:ConnectDB
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

        public string AddNhanVien(string hoTen, string gioiTinh, string diaChi, string soDT, DateTime ngaySinh)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_NhanVien_Add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hoten", hoTen);
                cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);
                cmd.Parameters.AddWithValue("@diachi", diaChi);
                cmd.Parameters.AddWithValue("@sdt", soDT);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaySinh);

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

        public string UpdateNhanVien(int id, string hoTen, string gioiTinh, string diaChi, string soDT, DateTime ngaySinh)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_NhanVien_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@hoten", hoTen);
                cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);
                cmd.Parameters.AddWithValue("@diachi", diaChi);
                cmd.Parameters.AddWithValue("@sdt", soDT);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaySinh);

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

        public string DeleteNhanVien(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_NhanVien_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

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
