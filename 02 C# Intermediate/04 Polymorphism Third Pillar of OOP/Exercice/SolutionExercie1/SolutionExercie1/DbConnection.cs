using System;

namespace SolutionExercie1
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }
        public DbConnection(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("connectionString should not null or empty");
            }
            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
