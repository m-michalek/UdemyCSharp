using DesignADatabaseCommand.DbConnection;

namespace DesignADatabaseCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("localhost:123");
            
            var dbCommand = new DbCommand(sqlConnection, $"DROP TABLE Salary");
            
            dbCommand.Execute();
        }
    }
}