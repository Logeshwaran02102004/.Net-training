using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace infinitetrainingday_3
{

    internal class Day3training
    {
        static void Main(string[] args)
        {
            /*
            //with return without arguments 
            Console.WriteLine("with return without arguments:");
            Console.WriteLine("addition result : " + Addition());
            int result = Addition();
            Console.WriteLine("Addition result :" + result);
            */

            /*
            addition(10,20);// with argument without return type;
            int a, b;
            Console.WriteLine("enter the value of a and b : ");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            addition(a,b);
            */


            //out keyword discard
            addition(20, 30, out int sum, out _, out _);
            Console.WriteLine($"sum-{sum} \n");

            Console.ReadLine();
        }
        /*
        static int  Addition()// with return type without argument;
        {
            Console.WriteLine("enter the first number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            return sum;
        }
        */

        /*
        static void addition(int x,int y)
        {
            int res = x + y;
            Console.WriteLine("the sum is : " + res);
        }
        */


        //out keyword discard
        static  void addition(int num1, int num2, out int sum, out int difference, out int product)
        {
            sum=num1+num2;
            difference=num1-num2;
            product = num1 * num2;

        }

    }
}
