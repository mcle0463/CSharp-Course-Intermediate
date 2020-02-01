using System;
using System.Data;
namespace CSharp_Course_Intermediate
{
    public class Dbcommand {
        private DbConnection Connection = null;
        private string command { get; set; }
        public Dbcommand(DbConnection connection, string command)
        {
            if (connection == null || command == null) {
                throw new NoNullAllowedException();
            }
            this.Connection = connection;
        }
        public void Execute() {
            Connection.OpenDBConnection();
            Console.WriteLine("running {0}", command);
            Connection.CloseDBConnection();

        }
    }
}
