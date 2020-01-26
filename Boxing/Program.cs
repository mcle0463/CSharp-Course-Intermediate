using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("mosh");
            list.Add(new DateTime());

            var number = (int) list[1];
            var list2 = new List<int>();

        }
    }
}
