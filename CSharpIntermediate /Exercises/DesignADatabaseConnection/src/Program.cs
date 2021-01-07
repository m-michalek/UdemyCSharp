using System;

namespace DesignADatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("localhost:123");
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();
            
            var oracleConnection = new OracleConnection("localhost:456");
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();
        }
    }
}