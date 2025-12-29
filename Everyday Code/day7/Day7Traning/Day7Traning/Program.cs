using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Traning
{
    static class Mathhelper
    {
        public static double pi = 3.14159;
        public static int addition(int a,int b)
        {
            return a + b;
        }
        public static int subtraction(int a, int b)
        {
            return a - b;

        }
        public static int multiplication(int a, int b)
        {
            return a * b;
        }
        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot br zero");
                
            }
            return (double)a / b;

        }

    }
    



    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            // the above program
            int result = Mathhelper.addition(2, 4);
            Console.WriteLine("the Addition is :"+result);
            result=Mathhelper.subtraction(2,4);
            Console.WriteLine("The subtraction is : " + result);
            double divresult= Mathhelper.Division(2,4);
            Console.WriteLine("the division is :" + divresult);
            */



            /*
            // this main is for banking process current, saving, bankaccount 
            savingAccount mysavings = new savingAccount("edd",1000);
            mysavings.Deposit(500);
            mysavings.calculateInterest();

            CurrentAccount current = new CurrentAccount("sdfg",2000);
            current.Deposit(500);
            current.calculateInterest();
            */


            personDeatails persondeatail=new personDeatails();
            persondeatail.getPersonDeatails();

        }
    }
}
