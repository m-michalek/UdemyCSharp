using System;

namespace DesignADatabaseConnection
{
    public abstract class DbConnection
    {
        private string ConnectionString;
        private TimeSpan Timeout;

        public DbConnection(string connectionString)
        {
            ConnectionString = connectionString ??
                               throw new InvalidOperationException(
                                   "ConnectionString can not be null.");
        }
        
        public abstract void OpenConnection();
        
        public abstract void CloseConnection();
    }
}