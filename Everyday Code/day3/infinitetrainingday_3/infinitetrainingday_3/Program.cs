using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitetrainingday_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //addition();

            


            /*
            // for constructor method 
            Constructormethods constructmethod=new Constructormethods();
            constructmethod.getDepartmentInfo();
            constructmethod.displaydepartmentinfo();
            */

            Copyconstructor copyconstructor = new Copyconstructor (201,"hr","mumbai");
            copyconstructor.displaydepartmentinfo();

            Copyconstructor copyconstructor1 = new Copyconstructor(copyconstructor);
            copyconstructor1.displaydepartmentinfo();
            Console.ReadLine();

        }

        static void addition()// without return type without arguments
        {
            Console.WriteLine("enter the first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("the addition of the two numbers is : " + sum);
        }
    }
}
