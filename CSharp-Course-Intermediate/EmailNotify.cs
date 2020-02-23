using System;

namespace CSharp_Course_Intermediate
{
    public class EmailNotify : IActivity
    {
        public void execute()
        {
            Console.WriteLine("Notifying by Email...");
        }
    }
}