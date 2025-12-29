using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitetrainingday_3
{
    internal class Paramsmethod
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sumofintegers(10,20));
            Console.WriteLine(Sumofintegers(10,20,30,40));
            Console.WriteLine(Sumofintegers(30,40,50,60,60));
            Console.WriteLine(Sumofintegers(45,56,56,57,57,56,45));

            Console. ReadLine();
        }

        static int Sumofintegers(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum=sum+num;
            }
            return sum;
        }
    }
}
