using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class PhanHeDAO
    {       
        public BindingList<PhanHeDTO> LayDanhSach()
        {
            BindingList<PhanHeDTO> danhSach = new BindingList<PhanHeDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From SysDanhMucPhanHe";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PhanHeDTO itemDTO = new PhanHeDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaPhanHe = (string)dr["MaPhanHe"];
                itemDTO.TenPhanHe = (string)dr["TenPhanHe"];                
                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(PhanHeDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into SysDanhMucPhanHe (MaPhanHe,TenPhanHe) values (?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaPhanHe", OleDbType.WChar).Value = itemDTO.MaPhanHe;
            cmd.Parameters.Add("@TenPhanHe", OleDbType.WChar).Value = itemDTO.TenPhanHe;                                        
            
            cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(PhanHeDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update SysDanhMucPhanHe Set MaPhanHe = ?, TenPhanHe = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaPhanHe", OleDbType.WChar).Value = itemDTO.MaPhanHe;
            cmd.Parameters.Add("@TenPhanHe", OleDbType.WChar).Value = itemDTO.TenPhanHe;                        
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = itemDTO.Id;
            
            cmd.ExecuteNonQuery();            
            cn.Close();

        }

        public void Xoa(int ma)
        {
            OleDbConnection cn;
            cn = DataProvider.KetNoi();

            string strSQL;
            strSQL = "DELETE FROM SysDanhMucPhanHe Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
