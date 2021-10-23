using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DataProvider
    {
        SqlConnection sqlConnection = null;
        SqlDataAdapter SqlDataAdapter = null;
        SqlCommand SqlCommand = null;

        string strConnect = "Data Source=LAPTOP-0BUBP079\\SQLEXPRESS;Initial Catalog=DemoEntity;Integrated Security=True";

        public DAL_DataProvider()
        {
            sqlConnection = new SqlConnection(strConnect);
            SqlCommand = sqlConnection.CreateCommand();
        }

        public DataTable ExecuteQuery(string strSQL, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            sqlConnection.Open();
            SqlCommand.CommandText = strSQL;
            SqlCommand.CommandType = commandType;
            foreach (SqlParameter item in sqlParameters)
            {
                SqlCommand.Parameters.Add(item);
            }
            SqlDataAdapter = new SqlDataAdapter(SqlCommand);
            DataTable table = new DataTable();
            SqlDataAdapter.Fill(table);
            sqlConnection.Close();
            return table;
        }

        public void ExecuteNonQuery(string strSQL, CommandType commandType, params SqlParameter[] p)
        {
            sqlConnection.Open();
            SqlCommand.Parameters.Clear();
            SqlCommand.CommandText = strSQL;
            SqlCommand.CommandType = commandType;
            foreach (SqlParameter item in p)
                SqlCommand.Parameters.Add(item);
            SqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public string ExecuteScalar(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            sqlConnection.Open();
            SqlCommand.Parameters.Clear();
            SqlCommand.CommandText = strSQL;
            SqlCommand.CommandType = ct;
            foreach (SqlParameter p in param)
            {
                SqlCommand.Parameters.Add(p);
            }
            return SqlCommand.ExecuteScalar().ToString();
        }
    }
}
