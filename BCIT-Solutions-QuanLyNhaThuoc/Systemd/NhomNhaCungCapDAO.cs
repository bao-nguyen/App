using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class NhomNhaCungCapDAO
    {       
        public BindingList<NhomNhaCungCapDTO> LayDanhSach()
        {
            BindingList<NhomNhaCungCapDTO> danhSach = new BindingList<NhomNhaCungCapDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucNhomNhaCungCap";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhomNhaCungCapDTO itemDTO = new NhomNhaCungCapDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaNhomNhaCungCap = (string)dr["MaNhomNhaCungCap"];
                itemDTO.TenNhomNhaCungCap = (string)dr["TenNhomNhaCungCap"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(NhomNhaCungCapDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into DanhMucNhomNhaCungCap (MaNhomNhaCungCap,TenNhomNhaCungCap,GhiChu) values (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaNhomNhaCungCap", OleDbType.WChar).Value = itemDTO.MaNhomNhaCungCap;
            cmd.Parameters.Add("@TenNhomNhaCungCap", OleDbType.WChar).Value = itemDTO.TenNhomNhaCungCap;            
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
                cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(NhomNhaCungCapDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update DanhMucNhomNhaCungCap Set MaNhomNhaCungCap = ?, TenNhomNhaCungCap = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaNhomNhaCungCap", OleDbType.WChar).Value = itemDTO.MaNhomNhaCungCap;
            cmd.Parameters.Add("@TenNhomNhaCungCap", OleDbType.WChar).Value = itemDTO.TenNhomNhaCungCap;            
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
            strSQL = "DELETE FROM DanhMucNhomNhaCungCap Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
