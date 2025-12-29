using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitetrainingday_3
{
    internal class Callingtypes
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10; b = 20;
            Console.WriteLine("\n Calling by value demo ");
            Console.WriteLine("value of before calling method "+ a);
            Methoodvalue(a);
            Console.WriteLine("after calling method value a : " + a);


            Console.WriteLine("\n \n  calling by reference demo");
            Console.WriteLine("value of b before calling method ref " + a);
            Methodref(ref b);
            Console.WriteLine("after calling methiod b value : " + b);

        }

        static void Methoodvalue(int a) {
            a = a + 10;
            Console.WriteLine("value of a in method value : "+a);
        }

        static void Methodref(ref int b) {
            b = b + 10;
            Console.WriteLine("value of b in method ref : " + b);
        }
    }



}
