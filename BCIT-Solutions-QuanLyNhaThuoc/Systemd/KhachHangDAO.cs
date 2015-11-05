using System;
using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class KhachHangDAO
    {       
        public BindingList<KhachHangDTO> LayDanhSach()
        {
            BindingList<KhachHangDTO> danhSach = new BindingList<KhachHangDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucKhachHang";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KhachHangDTO itemDTO = new KhachHangDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaKhachHang = (string)dr["MaKhachHang"];
                itemDTO.HoKhachHang = (string)dr["HoKhachHang"];
                itemDTO.TenKhachHang = (string)dr["TenKhachHang"];                
                itemDTO.IdNhomKhachHang = (int)dr["IdNhomKhachHang"];
                itemDTO.DiaChi = (string)dr["DiaChi"];
                itemDTO.DienThoai = (string)dr["DienThoai"];
                itemDTO.NgaySinh = (DateTime)dr["NgaySinh"];
                itemDTO.Email = (string)dr["Email"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(KhachHangDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into DanhMucKhachHang (MaKhachHang, HoKhachHang, TenKhachHang, IdNhomKhachHang, DiaChi, DienThoai, NgaySinh, Email, GhiChu) values (?, ?, ?, ?, ?, ?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaKhachHang", OleDbType.WChar).Value = itemDTO.MaKhachHang;
            cmd.Parameters.Add("@HoKhachHang", OleDbType.WChar).Value = itemDTO.HoKhachHang;
            cmd.Parameters.Add("@TenKhachHang", OleDbType.WChar).Value = itemDTO.TenKhachHang;            
            cmd.Parameters.Add("@IdNhomKhachHang", OleDbType.Numeric).Value = itemDTO.IdNhomKhachHang;
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar).Value = itemDTO.DiaChi;
            cmd.Parameters.Add("@DienThoai", OleDbType.WChar).Value = itemDTO.DienThoai;
            cmd.Parameters.Add("@NgaySinh", OleDbType.DBDate).Value = itemDTO.NgaySinh;
            cmd.Parameters.Add("@Email", OleDbType.WChar).Value = itemDTO.Email;
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
            cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(KhachHangDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update DanhMucKhachHang Set MaKhachHang = ?, HoKhachHang = ?, TenKhachHang = ?, IdNhomKhachHang = ?, DiaChi = ?, DienThoai = ?, NgaySinh = ?, Email = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaKhachHang", OleDbType.WChar).Value = itemDTO.MaKhachHang;
            cmd.Parameters.Add("@HoKhachHang", OleDbType.WChar).Value = itemDTO.HoKhachHang;
            cmd.Parameters.Add("@TenKhachHang", OleDbType.WChar).Value = itemDTO.TenKhachHang;            
            cmd.Parameters.Add("@IdNhomKhachHang", OleDbType.Numeric).Value = itemDTO.IdNhomKhachHang;
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar).Value = itemDTO.DiaChi;
            cmd.Parameters.Add("@DienThoai", OleDbType.WChar).Value = itemDTO.DienThoai;
            cmd.Parameters.Add("@NgaySinh", OleDbType.DBDate).Value = itemDTO.NgaySinh;
            cmd.Parameters.Add("@Email", OleDbType.WChar).Value = itemDTO.Email;
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;          
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = itemDTO.Id;
            
            cmd.ExecuteNonQuery();            
            cn.Close();

        }
        public void Xoa(int ma)
        {
            OleDbConnection cn;
            cn = DataProvider.KetNoi();

            string strSQL;
            strSQL = "DELETE FROM DanhMucKhachHang Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }        
    }
}
