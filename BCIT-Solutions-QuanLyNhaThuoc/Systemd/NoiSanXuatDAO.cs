using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class NoiSanXuatDAO
    {       
        public BindingList<NoiSanXuatDTO> LayDanhSach()
        {
            BindingList<NoiSanXuatDTO> danhSach = new BindingList<NoiSanXuatDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucNoiSanXuat";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NoiSanXuatDTO itemDTO = new NoiSanXuatDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaNoiSanXuat = (string)dr["MaNoiSanXuat"];
                itemDTO.TenNoiSanXuat = (string)dr["TenNoiSanXuat"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(NoiSanXuatDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into DanhMucNoiSanXuat (MaNoiSanXuat,TenNoiSanXuat,GhiChu) values (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaNoiSanXuat", OleDbType.WChar).Value = itemDTO.MaNoiSanXuat;
            cmd.Parameters.Add("@TenNoiSanXuat", OleDbType.WChar).Value = itemDTO.TenNoiSanXuat;            
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
                cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(NoiSanXuatDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update DanhMucNoiSanXuat Set MaNoiSanXuat = ?, TenNoiSanXuat = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaBacSy", OleDbType.WChar).Value = itemDTO.MaNoiSanXuat;
            cmd.Parameters.Add("@TenBacSy", OleDbType.WChar).Value = itemDTO.TenNoiSanXuat;            
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
            strSQL = "DELETE FROM DanhMucNoiSanXuat Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
