using System;

namespace Inheritance_vs_Interfaces
{
    public class SMSMessage : INotification
    {
        public void Message(MessageText text)
        {
            Console.WriteLine("SMS sending..");
        }
    }
}