using System;

namespace Inheritance_vs_Interfaces
{
    public class Mailer : INotification
    {
        // public void Messsage()
        // {
        //     Console.WriteLine("Sending mail notification...");
        // }

        public void Message(MessageText text)
        {
            Console.WriteLine("Mail sendings");
        }
    }
}