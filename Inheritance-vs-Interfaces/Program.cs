using System;

namespace Inheritance_vs_Interfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            VideoEncoder vc = new VideoEncoder();
            vc.Subscribe(new Mailer());
            vc.Subscribe(new SMSMessage());
            vc.Message();
        }
    }
}
