using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class LoaiHangHoaDAO
    {       
        public BindingList<LoaiHangHoaDTO> LayDanhSach()
        {
            BindingList<LoaiHangHoaDTO> danhSach = new BindingList<LoaiHangHoaDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucLoaiHangHoa";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoaiHangHoaDTO itemDTO = new LoaiHangHoaDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaLoaiHangHoa = (string)dr["MaLoaiHangHoa"];
                itemDTO.TenLoaiHangHoa = (string)dr["TenLoaiHangHoa"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(LoaiHangHoaDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into DanhMucLoaiHangHoa (MaLoaiHangHoa,TenLoaiHangHoa,GhiChu) values (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaLoaiHangHoa", OleDbType.WChar).Value = itemDTO.MaLoaiHangHoa;
            cmd.Parameters.Add("@TenLoaiHangHoa", OleDbType.WChar).Value = itemDTO.TenLoaiHangHoa;            
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
                cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(LoaiHangHoaDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update DanhMucLoaiHangHoa Set MaLoaiHangHoa = ?, TenLoaiHangHoa = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaBacSy", OleDbType.WChar).Value = itemDTO.MaLoaiHangHoa;
            cmd.Parameters.Add("@TenBacSy", OleDbType.WChar).Value = itemDTO.TenLoaiHangHoa;            
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
            strSQL = "DELETE FROM DanhMucLoaiHangHoa Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
