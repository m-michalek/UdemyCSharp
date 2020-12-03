using System;

namespace DesignADatabaseCommand.DbConnection
{
    public class OracleConnection: DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open Orace connection.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close SQL connection.");
        }
    }
}