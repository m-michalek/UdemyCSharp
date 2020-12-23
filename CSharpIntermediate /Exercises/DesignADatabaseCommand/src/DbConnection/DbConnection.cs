using System;

namespace DesignADatabaseCommand.DbConnection
{
    public abstract class DbConnection
    {
        private string _connectionString;
        private TimeSpan _timeout;

        public DbConnection(string connectionString)
        {
            _connectionString = connectionString ??
                               throw new InvalidOperationException(
                                   "ConnectionString can not be null.");
        }
        
        public abstract void OpenConnection();
        
        public abstract void CloseConnection();
    }
}