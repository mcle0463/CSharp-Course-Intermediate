using System;
using System.Runtime.CompilerServices;

namespace CSharp_Course_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLConnection sql = new SQLConnection("connectstring");
            Dbcommand command = new Dbcommand(sql, "my command");
            command.Execute();
        }

    }
}
