using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingDay_2
{
    internal class Calculator
    {
        //method without return type and with arguments
        public void add(int num1, int num2)
        {
            Console.WriteLine("addition of the two number is :"+ (num1 + num2));
        }
        public void sub(int num1, int num2)
        {
            Console.WriteLine("the subtraction of the two numbers is : "+ (num1 - num2));
        }
    }
}
