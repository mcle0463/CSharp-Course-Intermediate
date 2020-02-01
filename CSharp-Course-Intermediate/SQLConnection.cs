using System;

namespace CSharp_Course_Intermediate
{
    public class SQLConnection : DbConnection
    {
        public SQLConnection(string connectionString): base(connectionString)
        {

        }
        public override void CloseDBConnection()
        {
            Console.WriteLine("closed SQL connection");
        }

        public override void OpenDBConnection()
        {
            Console.WriteLine("opened SQL connection");
        }
    }
}
