using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAO
{
    public class DataProvider
    {
        string str = "";
        SqlConnection cn;
        public DataProvider()
        {
            str = "Server=. ; Database = KSHoangThienAn ; Integrated Security = true;";
            cn = new SqlConnection(str);
        }
        public void connect()
        {

            if (cn != null && cn.State != ConnectionState.Open)
            {
                cn.Open();
            }

        }
        public void disconnect()
        {
            if (cn != null && cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }
        public SqlDataReader ExecuteReader(string sql)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                return (cmd.ExecuteReader());
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }
        public int ExcuteNonQuery(string sql, CommandType type, List<SqlParameter> paras)
        {
            connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                if (paras != null)
                {
                    foreach (SqlParameter para in paras)
                    {
                        cmd.Parameters.Add(para);
                    }
                }
                cmd.ExecuteNonQuery();
                return 1;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally { disconnect(); }
        }
    }
}
