using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitetrainingday_3
{
    internal class Static_Nonstatic
    {
        public static void Main(string[] args)
        {
            x = 10;
            Static_Nonstatic staticnonstatic=new Static_Nonstatic();
            staticnonstatic.y = 30;

            Console.WriteLine("static variable witout accessing object "+x);
            Console.WriteLine("non static variable access through object " + staticnonstatic.y);
            Staticmethod();
            staticnonstatic.nonStaticmethod();

            Console.ReadLine();
        }

        static int x;
        int y;

        void nonStaticmethod()
        {
            Console.WriteLine("Non static method ");
        }
        static void Staticmethod()
        {
            Console.WriteLine("this is Static method");
        }
    }
}
