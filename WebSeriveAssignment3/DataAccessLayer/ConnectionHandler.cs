using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebSeriveAssignment3.DataAccessLayer
{
    public class ConnectionHandler
    {
        public static SqlConnection GetSqlServerConnection()
        {
    string connectionString = ConfigurationManager.ConnectionStrings["ICAStoreDBConnectionString"].ConnectionString; var builder = new SqlConnectionStringBuilder(connectionString);
    var connection = new SqlConnection(builder.ConnectionString);
return connection;
    }
       
        }
    }





