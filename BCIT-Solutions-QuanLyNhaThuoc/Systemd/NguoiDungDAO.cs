using System;
using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class NguoiDungDAO
    {       
        public BindingList<NguoiDungDTO> LayDanhSach()
        {
            BindingList<NguoiDungDTO> danhSach = new BindingList<NguoiDungDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From SysDanhMucNguoiDung";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NguoiDungDTO itemDTO = new NguoiDungDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaNguoiDung = (string)dr["MaNguoiDung"];
                itemDTO.TenNguoiDung = (string)dr["TenNguoiDung"];
                itemDTO.MatKhau = (string)dr["MatKhau"];
                itemDTO.VoHieu = (bool)dr["VoHieu"];
                itemDTO.IdChucDanh = (int)dr["IdChucDanh"];
                itemDTO.DiaChi = (string)dr["DiaChi"];
                itemDTO.DienThoai = (string)dr["DienThoai"];
                itemDTO.NgayBatDau = (DateTime)dr["NgayBatDau"];
                itemDTO.NgayKetThuc = (DateTime)dr["NgayKetThuc"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(NguoiDungDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into SysDanhMucNguoiDung (MaNguoiDung, TenNguoiDung, MatKhau, VoHieu, IdChucDanh, DiaChi, DienThoai, NgayBatDau, NgayKetThuc, GhiChu) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);


            cmd.Parameters.Add("@MaNguoiDung", OleDbType.WChar).Value = itemDTO.MaNguoiDung;
            cmd.Parameters.Add("@TenNguoiDung", OleDbType.WChar).Value = itemDTO.TenNguoiDung;
            cmd.Parameters.Add("@MatKhau", OleDbType.WChar).Value = itemDTO.MatKhau;
            cmd.Parameters.Add("@VoHieu", OleDbType.Boolean).Value = itemDTO.VoHieu;
            cmd.Parameters.Add("@IdChucDanh", OleDbType.Numeric).Value = itemDTO.IdChucDanh;
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar).Value = itemDTO.DiaChi;
            cmd.Parameters.Add("@DienThoai", OleDbType.WChar).Value = itemDTO.DienThoai;
            cmd.Parameters.Add("@NgayBatDau", OleDbType.DBDate).Value = itemDTO.NgayBatDau;
            cmd.Parameters.Add("@NgayKetThuc", OleDbType.DBDate).Value = itemDTO.NgayKetThuc;
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
                cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(NguoiDungDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update SysDanhMucNguoiDung Set MaNguoiDung = ?, TenNguoiDung = ?, MatKhau = ?, VoHieu = ?, IdChucDanh = ?, DiaChi = ?, DienThoai = ?, NgayBatDau = ?, NgayKetThuc = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaNguoiDung", OleDbType.WChar).Value = itemDTO.MaNguoiDung;
            cmd.Parameters.Add("@TenNguoiDung", OleDbType.WChar).Value = itemDTO.TenNguoiDung;
            cmd.Parameters.Add("@MatKhau", OleDbType.WChar).Value = itemDTO.MatKhau;
            cmd.Parameters.Add("@VoHieu", OleDbType.Boolean).Value = itemDTO.VoHieu;
            cmd.Parameters.Add("@IdChucDanh", OleDbType.Numeric).Value = itemDTO.IdChucDanh;
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar).Value = itemDTO.DiaChi;
            cmd.Parameters.Add("@DienThoai", OleDbType.WChar).Value = itemDTO.DienThoai;
            cmd.Parameters.Add("@NgayBatDau", OleDbType.DBDate).Value = itemDTO.NgayBatDau;
            cmd.Parameters.Add("@NgayKetThuc", OleDbType.DBDate).Value = itemDTO.NgayKetThuc;
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
            strSQL = "DELETE FROM SysDanhMucNguoiDung Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
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
        public NguoiDungDTO KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            NguoiDungDTO nguoiDungDTO = new NguoiDungDTO();
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "SELECT * FROM SysDanhMucNguoiDung WHERE MaNguoiDung = ? AND MatKhau = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaNguoiDung", OleDbType.WChar).Value = tenDangNhap;
            cmd.Parameters.Add("@MatKhau", OleDbType.WChar).Value = matKhau;
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
    }
}
