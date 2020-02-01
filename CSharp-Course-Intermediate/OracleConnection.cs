using System;

namespace CSharp_Course_Intermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseDBConnection()
        {
            Console.WriteLine("closed oracle connection");
        }

        public override void OpenDBConnection()
        {
            Console.WriteLine("opened oracle connection");
        }
    }
}
