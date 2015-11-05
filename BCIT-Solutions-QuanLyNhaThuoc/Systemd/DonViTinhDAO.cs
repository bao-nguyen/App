using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class DonViTinhDAO
    {       
        public BindingList<DonViTinhDTO> LayDanhSach()
        {
            BindingList<DonViTinhDTO> danhSach = new BindingList<DonViTinhDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucDonViTinh";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DonViTinhDTO itemDTO = new DonViTinhDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaDonViTinh = (string)dr["MaDonViTinh"];
                itemDTO.TenDonViTinh = (string)dr["TenDonViTinh"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(DonViTinhDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into DanhMucDonViTinh (MaDonViTinh,TenDonViTinh,GhiChu) values (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaDonViTinh", OleDbType.WChar).Value = itemDTO.MaDonViTinh;
            cmd.Parameters.Add("@TenDonViTinh", OleDbType.WChar).Value = itemDTO.TenDonViTinh;            
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
                cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(DonViTinhDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update DanhMucDonViTinh Set MaDonViTinh = ?, TenDonViTinh = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaBacSy", OleDbType.WChar).Value = itemDTO.MaDonViTinh;
            cmd.Parameters.Add("@TenBacSy", OleDbType.WChar).Value = itemDTO.TenDonViTinh;            
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
            strSQL = "DELETE FROM DanhMucDonViTinh Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
