using System;
using System.Data;
using System.Data.SqlClient;

namespace QL_NhanVien
{
    internal class Database
    {
        private SqlConnection conn;

        public Database()
        {
            conn = new SqlConnection(GlobalState.ConnectionString);
        }

        private void Open()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable ExecuteQuery(string sql, SqlParameter[] param = null)
        {
            DataTable dt = new DataTable();
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (param != null)
                    cmd.Parameters.AddRange(param);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                Close();
            }
            return dt;
        }

        public int ExecuteNonQuery(string sql, SqlParameter[] param = null)
        {
            int rows = 0;
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (param != null)
                    cmd.Parameters.AddRange(param);
                rows = cmd.ExecuteNonQuery();
            }
            finally
            {
                Close();
            }
            return rows;
        }

        public int ExecuteStoredProc(string procName, SqlParameter[] param = null)
        {
            int rows = 0;
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand(procName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param != null)
                    cmd.Parameters.AddRange(param);
                rows = cmd.ExecuteNonQuery();
            }
            finally
            {
                Close();
            }
            return rows;
        }

        public DataTable ExecuteProcToTable(string procName, SqlParameter[] param = null)
        {
            DataTable dt = new DataTable();
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand(procName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param != null)
                    cmd.Parameters.AddRange(param);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                Close();
            }
            return dt;
        }
    }
}
