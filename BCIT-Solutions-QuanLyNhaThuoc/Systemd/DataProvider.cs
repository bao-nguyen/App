using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace Systemd
{
    class DataProvider
    {
        public static OleDbConnection KetNoi()
        {
            //string chuoiKetNoi = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Data/Data.mdb; Persist Security Info=True; Jet OLEDB:Database Password=baochau!@#";
            string chuoiKetNoi = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Data/Data.mdb;";
            OleDbConnection cn = new OleDbConnection(chuoiKetNoi);
            cn.Open();
            return cn;
           
        }

        public static void DongKetNoi(OleDbConnection cn)
        {
            cn.Close();
        }
    }
}
