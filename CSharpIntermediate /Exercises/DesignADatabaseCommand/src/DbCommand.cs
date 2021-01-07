using System;

namespace DesignADatabaseCommand
{
    public class DbCommand
    {
        private DbConnection.DbConnection _dbConnection;
        private string _instruction;

        public DbCommand(DbConnection.DbConnection dbConnection, string instruction)
        {
            _dbConnection = dbConnection ?? throw new InvalidOperationException(
                "DbConnection can not be null.");
            _instruction = instruction ?? throw new InvalidOperationException(
                "Instruction can not be null.");
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine($"Run instruction on DB: {_instruction}");
            _dbConnection.CloseConnection();
        }
    }
}