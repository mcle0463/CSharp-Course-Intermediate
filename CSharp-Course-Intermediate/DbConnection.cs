using System;

namespace CSharp_Course_Intermediate
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (connectionString is null) {
                throw new ArgumentNullException();
            }
            if (connectionString.Length == 0) {
                throw new ArgumentException();
            }
            this.ConnectionString = connectionString;
        }
        public abstract void OpenDBConnection();
        public abstract void CloseDBConnection();

    }
}
