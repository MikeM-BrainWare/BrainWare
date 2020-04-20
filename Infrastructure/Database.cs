using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Infrastructure
{
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;

    public class Database
    {
        private readonly SqlConnection _connection;

        public Database()
        {
            _connection = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=BrainWAre;Integrated Security=SSPI;AttachDBFilename=C:\\BrainWare\\Web\\App_Data\\BrainWare.mdf");

            _connection.Open();
        }


        public DbDataReader ExecuteReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _connection); // use stored procedure to eliminate embedded SQL
            cmd.CommandType = CommandType.StoredProcedure;

            //var sqlQuery = new SqlCommand(query, _connection);

            return cmd.ExecuteReader();
        }

        public int ExecuteNonQuery(string query)
        {
            var sqlQuery = new SqlCommand(query, _connection);

            return sqlQuery.ExecuteNonQuery();
        }

    }
}