using System;
using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class ChucNangDAO
    {
        public BindingList<ChucNangDTO> LayDanhSach()
        {
            BindingList<ChucNangDTO> danhSach = new BindingList<ChucNangDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From SysDanhMucChucNang";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ChucNangDTO itemDTO = new ChucNangDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaChucNang = (string)dr["MaChucNang"];
                itemDTO.TenChucNang = (string)dr["TenChucNang"];                
                itemDTO.IdPhanHe = (int)dr["IdPhanHe"];               
                itemDTO.TenForm = (string)dr["TenForm"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(ChucNangDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into SysDanhMucChucNang (MaChucNang, TenChucNang, IdPhanHe, TenForm) values (?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);


            cmd.Parameters.Add("@MaChucNang", OleDbType.WChar).Value = itemDTO.MaChucNang;
            cmd.Parameters.Add("@TenChucNang", OleDbType.WChar).Value = itemDTO.TenChucNang;            
            cmd.Parameters.Add("@IdPhanHe", OleDbType.Numeric).Value = itemDTO.IdPhanHe;
            cmd.Parameters.Add("@TenForm", OleDbType.WChar).Value = itemDTO.TenForm;            
            
            cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(ChucNangDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update SysDanhMucChucNang Set MaChucNang = ?, TenChucNang = ?, IdPhanHe = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaChucNang", OleDbType.WChar).Value = itemDTO.MaChucNang;
            cmd.Parameters.Add("@TenChucNang", OleDbType.WChar).Value = itemDTO.TenChucNang;
            cmd.Parameters.Add("@IdPhanHe", OleDbType.Numeric).Value = itemDTO.IdPhanHe;              
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = itemDTO.Id;
            
            cmd.ExecuteNonQuery();            
            cn.Close();

        }

        public void Xoa(int ma)
        {
            OleDbConnection cn;
            cn = DataProvider.KetNoi();

            string strSQL;
            strSQL = "DELETE FROM SysDanhMucChucNang Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        /*
        public NguoiDungDTO LayThongTinNguoiDungByMa(string tenDangNhap)
        {
            NguoiDungDTO nguoiDungDTO = new NguoiDungDTO();
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "SELECT * FROM SysDanhMucNguoiDung WHERE MaNguoiDung = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaNguoiDung", OleDbType.WChar).Value = tenDangNhap;            
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nguoiDungDTO.Id = (int)dr["Id"];
                nguoiDungDTO.MaNguoiDung = (string)dr["MaNguoiDung"];
                nguoiDungDTO.TenNguoiDung = (string)dr["TenNguoiDung"];
                nguoiDungDTO.MatKhau = (string)dr["MatKhau"];
                nguoiDungDTO.VoHieu = (bool)dr["VoHieu"];
                nguoiDungDTO.IdChucDanh = (int)dr["IdChucDanh"];
                nguoiDungDTO.DiaChi = (string)dr["DiaChi"];
                nguoiDungDTO.DienThoai = (string)dr["DienThoai"];
                nguoiDungDTO.NgayBatDau = (DateTime)dr["NgayBatDau"];
                nguoiDungDTO.NgayKetThuc = (DateTime)dr["NgayKetThuc"];
                nguoiDungDTO.GhiChu = (string)dr["GhiChu"];
            }
            return nguoiDungDTO;
        }
        */ 
    }
}
