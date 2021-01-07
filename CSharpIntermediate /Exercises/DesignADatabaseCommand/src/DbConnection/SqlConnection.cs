using System;

namespace DesignADatabaseCommand.DbConnection
{
    public class SqlConnection: DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open SQL connection.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close SQL connection.");
        }
    }
}