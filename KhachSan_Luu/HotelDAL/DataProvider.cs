using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace HotelDAL
{
    public class DataProvider
    {
        string cnStr = "";
        SqlConnection cn;

        public void Connect()
        {
            try
            {
                if (cn != null && cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public void Disconnect()
        {
            try
            {
                if (cn != null && cn.State != System.Data.ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public DataProvider()
        {
            try
            {
                cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
            cn = new SqlConnection(cnStr);
        }

        public SqlDataReader ExecReader(string sql)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int ExecNonQuery(string sql, System.Data.CommandType type, List<SqlParameter> paras)
        {
            Connect();
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
                int id = -1;
                id = (int)cmd.Parameters["@Ma"].Value;
                return id;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }

        public int TimMa(int Ma, string Bang)
        {
            Connect();
            try
            {
                string sql = "Select * from " + Bang;
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.GetInt32(0) == Ma)
                        return Ma;
                }
                return -6;
            }
            catch (SqlException ex)
            {
                return -1;
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }

        public int ExecNonQuery(string sql)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                return 0;
            }
            catch (SqlException ex)
            {
                return -1;
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }

        public int Login(int MaNV, string MK)
        {
            Connect();
            try
            {
                string sql = "select * from TaiKhoan";
                SqlCommand cmd = new SqlCommand(sql,cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.GetInt32(0) == MaNV && dr.GetString(1) == MK)
                        return 1;
                }
                return 0;
            }
            catch (SqlException ex)
            {
                return -1;
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
