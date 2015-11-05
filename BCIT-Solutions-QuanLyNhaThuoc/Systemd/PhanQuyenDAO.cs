using System;
using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class PhanQuyenDAO
    {       
        public BindingList<PhanQuyenDTO> LayDanhSach()
        {
            BindingList<PhanQuyenDTO> danhSach = new BindingList<PhanQuyenDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From SysDanhMucPhanQuyen";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PhanQuyenDTO itemDTO = new PhanQuyenDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.IdNguoiDung = (int)dr["IdNguoiDung"];
                itemDTO.IdChucNang = (int)dr["IdChucNang"];
                itemDTO.IdPhanHe = (int)dr["IdPhanHe"];                
                itemDTO.Doc = (bool)dr["Doc"];
                itemDTO.Them = (bool)dr["Them"];
                itemDTO.Sua = (bool)dr["Sua"];
                itemDTO.Xoa = (bool)dr["Xoa"];                

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(PhanQuyenDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into SysDanhMucPhanQuyen (IdNguoiDung, IdChucNang, IdPhanHe, Doc, Them, Sua, Xoa) values (?, ?, ?, ?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@IdNguoiDung", OleDbType.Numeric).Value = itemDTO.IdNguoiDung;
            cmd.Parameters.Add("@IdChucNang", OleDbType.Numeric).Value = itemDTO.IdChucNang;
            cmd.Parameters.Add("@IdPhanHe", OleDbType.Numeric).Value = itemDTO.IdPhanHe;
            cmd.Parameters.Add("@Doc", OleDbType.Boolean).Value = itemDTO.Doc;
            cmd.Parameters.Add("@Them", OleDbType.Boolean).Value = itemDTO.Them;
            cmd.Parameters.Add("@Sua", OleDbType.Boolean).Value = itemDTO.Sua;
            cmd.Parameters.Add("@Xoa", OleDbType.Boolean).Value = itemDTO.Xoa;            
            
            cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(PhanQuyenDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update SysDanhMucPhanQuyen Set Doc = ?, Them = ?, Sua = ?, Xoa = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);            
            cmd.Parameters.Add("@Doc", OleDbType.Boolean).Value = itemDTO.Doc;
            cmd.Parameters.Add("@Them", OleDbType.Boolean).Value = itemDTO.Them;
            cmd.Parameters.Add("@Sua", OleDbType.Boolean).Value = itemDTO.Sua;
            cmd.Parameters.Add("@Xoa", OleDbType.Boolean).Value = itemDTO.Xoa;            
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = itemDTO.Id;
            
            cmd.ExecuteNonQuery();            
            cn.Close();

        }

        public void Xoa(int ma)
        {
            OleDbConnection cn;
            cn = DataProvider.KetNoi();

            string strSQL;
            strSQL = "DELETE FROM SysDanhMucPhanQuyen Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }


        public BindingList<PhanQuyenCTO> LayDanhSachCTO(int maND)
        {
            BindingList<PhanQuyenCTO> danhSach = new BindingList<PhanQuyenCTO>();
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select pq.Id,pq.IdNguoiDung,pq.Doc,pq.Them,pq.Sua,pq.Xoa,cn.TenChucNang,ph.TenPhanHe From SysDanhMucPhanQuyen as pq, SysDanhMucPhanHe as ph, SysDanhMucChucNang as cn Where pq.IdNguoiDung = " + maND + " and pq.IdChucNang = cn.Id and pq.IdPhanHe = ph.Id";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PhanQuyenCTO itemCTO = new PhanQuyenCTO();

                itemCTO.Id = (int)dr["Id"];
                itemCTO.IdNguoiDung = (int)dr["IdNguoiDung"];
                itemCTO.ChucNang = (string)dr["TenChucNang"];
                itemCTO.PhanHe = (string)dr["TenPhanHe"];
                itemCTO.Doc = (bool)dr["Doc"];
                itemCTO.Them = (bool)dr["Them"];
                itemCTO.Sua = (bool)dr["Sua"];
                itemCTO.Xoa = (bool)dr["Xoa"];

                danhSach.Add(itemCTO);
            }
            return danhSach;
        }
    }
}
