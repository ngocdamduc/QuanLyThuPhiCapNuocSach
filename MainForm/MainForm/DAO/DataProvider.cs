using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuPhiCapNuocsach.DAO
{
    public class DataProvider
    {
        public SqlConnection getConnect()
        {
            String strConn = @"Data Source=ZENBOOK14-TRANN;Initial Catalog=QuanLyNuocSach;Integrated Security=True";
            return new SqlConnection(strConn);
        }
        public DataTable GetTable(String sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = getConnect();
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void ExcuteNonQuery(String sql)
        {
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
            conn.Close();
        }
        public String ExecuteScalar(String sql)
        {
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            String kq = cmd.ExecuteScalar().ToString();
            conn.Close();
            return kq;
        }    
    }
}
