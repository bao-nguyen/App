using System;
using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class NhaCungCapDAO
    {       
        public BindingList<NhaCungCapDTO> LayDanhSach()
        {
            BindingList<NhaCungCapDTO> danhSach = new BindingList<NhaCungCapDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucNhaCungCap";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhaCungCapDTO itemDTO = new NhaCungCapDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaNhaCungCap = (string)dr["MaNhaCungCap"];                
                itemDTO.TenNhaCungCap = (string)dr["TenNhaCungCap"];                
                itemDTO.IdNhomNhaCungCap = (int)dr["IdNhomNhaCungCap"];
                itemDTO.DiaChi = (string)dr["DiaChi"];
                itemDTO.DienThoai = (string)dr["DienThoai"];                
                itemDTO.Email = (string)dr["Email"];
                itemDTO.SoTaiKhoan = (string)dr["SoTaiKhoan"];
                itemDTO.TenNganHang = (string)dr["TenNganHang"];
                itemDTO.TenChiNhanh = (string)dr["TenChiNhanh"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(NhaCungCapDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into DanhMucNhaCungCap (MaNhaCungCap, TenNhaCungCap, IdNhomNhaCungCap, DiaChi, DienThoai, Email, SoTaiKhoan, TenNganHang, TenChiNhanh, GhiChu) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaNhaCungCap", OleDbType.WChar).Value = itemDTO.MaNhaCungCap;            
            cmd.Parameters.Add("@TenNhaCungCap", OleDbType.WChar).Value = itemDTO.TenNhaCungCap;            
            cmd.Parameters.Add("@IdNhomNhaCungCap", OleDbType.Numeric).Value = itemDTO.IdNhomNhaCungCap;
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar).Value = itemDTO.DiaChi;
            cmd.Parameters.Add("@DienThoai", OleDbType.WChar).Value = itemDTO.DienThoai;            
            cmd.Parameters.Add("@Email", OleDbType.WChar).Value = itemDTO.Email;
            cmd.Parameters.Add("@SoTaiKhoan", OleDbType.WChar).Value = itemDTO.SoTaiKhoan;
            cmd.Parameters.Add("@TenNganHang", OleDbType.WChar).Value = itemDTO.TenNganHang;
            cmd.Parameters.Add("@TenChiNhanh", OleDbType.WChar).Value = itemDTO.TenChiNhanh;
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
            cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(NhaCungCapDTO itemDTO)
        {
            try
            {
                OleDbConnection cn;
                cn = DataProvider.KetNoi();

                string strSQL;
                strSQL = "Update DanhMucNhaCungCap Set MaNhaCungCap = ?, TenNhaCungCap = ?, IdNhomNhaCungCap = ?, DiaChi = ?, DienThoai = ?, Email = ?, SoTaiKhoan = ?, TenNganHang = ?, TenChiNhanh = ?, GhiChu = ? Where Id = ?";

                OleDbCommand cmd = new OleDbCommand(strSQL, cn);
                cmd.Parameters.Add("@MaNhaCungCap", OleDbType.WChar).Value = itemDTO.MaNhaCungCap;
                cmd.Parameters.Add("@TenNhaCungCap", OleDbType.WChar).Value = itemDTO.TenNhaCungCap;
                cmd.Parameters.Add("@IdNhomNhaCungCap", OleDbType.Numeric).Value = itemDTO.IdNhomNhaCungCap;
                cmd.Parameters.Add("@DiaChi", OleDbType.WChar).Value = itemDTO.DiaChi;
                cmd.Parameters.Add("@DienThoai", OleDbType.WChar).Value = itemDTO.DienThoai;
                cmd.Parameters.Add("@Email", OleDbType.WChar).Value = itemDTO.Email;
                cmd.Parameters.Add("@SoTaiKhoan", OleDbType.WChar).Value = itemDTO.SoTaiKhoan;
                cmd.Parameters.Add("@TenNganHang", OleDbType.WChar).Value = itemDTO.TenNganHang;
                cmd.Parameters.Add("@TenChiNhanh", OleDbType.WChar).Value = itemDTO.TenChiNhanh;
                cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;
                cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = itemDTO.Id;

                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch(Exception )
            {
                return;
            }
            

        }
        public void Xoa(int ma)
        {
            OleDbConnection cn;
            cn = DataProvider.KetNoi();

            string strSQL;
            strSQL = "DELETE FROM DanhMucNhaCungCap Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }        
    }
}
