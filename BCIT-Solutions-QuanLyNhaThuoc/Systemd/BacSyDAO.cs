using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class BacSyDAO
    {       
        public BindingList<BacSyDTO> LayDanhSach()
        {
            BindingList<BacSyDTO> danhSach = new BindingList<BacSyDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucBacSy";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                BacSyDTO itemDTO = new BacSyDTO();

                itemDTO.IdBacSy = (int)dr["Id"];
                itemDTO.MaBacSy = (string)dr["MaBacSy"];
                itemDTO.TenBacSy = (string)dr["TenBacSy"];
                itemDTO.DiaChi = (string)dr["DiaChi"];
                itemDTO.DienThoai = (string)dr["DienThoai"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(BacSyDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into DanhMucBacSy (MaBacSy,TenBacSy,DiaChi,DienThoai,GhiChu) values (?, ?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);


            cmd.Parameters.Add("@MaBacSy", OleDbType.WChar).Value = itemDTO.MaBacSy;
            cmd.Parameters.Add("@TenBacSy", OleDbType.WChar).Value = itemDTO.TenBacSy;
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar).Value = itemDTO.DiaChi;
            cmd.Parameters.Add("@DienThoai", OleDbType.WChar).Value = itemDTO.DienThoai;
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
                cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(BacSyDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update DanhMucBacSy Set MaBacSy = ?, TenBacSy = ?, DiaChi = ?, DienThoai = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaBacSy", OleDbType.WChar).Value = itemDTO.MaBacSy;
            cmd.Parameters.Add("@TenBacSy", OleDbType.WChar).Value = itemDTO.TenBacSy;
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar).Value = itemDTO.DiaChi;
            cmd.Parameters.Add("@DienThoai", OleDbType.WChar).Value = itemDTO.DienThoai;
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = itemDTO.IdBacSy;
            
            cmd.ExecuteNonQuery();            
            cn.Close();

        }

        public void Xoa(int ma)
        {
            OleDbConnection cn;
            cn = DataProvider.KetNoi();

            string strSQL;
            strSQL = "DELETE FROM DanhMucBacSy Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
