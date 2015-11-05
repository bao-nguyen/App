using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class ViTriDAO
    {       
        public BindingList<ViTriDTO> LayDanhSach()
        {
            BindingList<ViTriDTO> danhSach = new BindingList<ViTriDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucViTri";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ViTriDTO itemDTO = new ViTriDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaViTri = (string)dr["MaViTri"];
                itemDTO.TenViTri = (string)dr["TenViTri"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(ViTriDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into DanhMucViTri (MaViTri,TenViTri,GhiChu) values (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaViTri", OleDbType.WChar).Value = itemDTO.MaViTri;
            cmd.Parameters.Add("@TenViTri", OleDbType.WChar).Value = itemDTO.TenViTri;            
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
                cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(ViTriDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update DanhMucViTri Set MaViTri = ?, TenViTri = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaBacSy", OleDbType.WChar).Value = itemDTO.MaViTri;
            cmd.Parameters.Add("@TenBacSy", OleDbType.WChar).Value = itemDTO.TenViTri;            
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
            strSQL = "DELETE FROM DanhMucViTri Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
