using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismdemo
{
    public class assignmentday8
    {
        public void Calculateinterest(double principal,double rate)
        {
            Console.WriteLine("the interest is for one year: " + (principal * rate * 1) / 100);
        }
        public void Calculateinterest(double principal, double rate,int year)
        {
            Console.WriteLine($"The interst {year} year is : " + (principal * rate * year) / 100);
        }
        public void Calculateinterest(double principal, double rate, int year,int n)
        {
            double amount = principal * Math.Pow((1 + rate / n), (n * year));
            Console.WriteLine("the compound interest is : " + (amount - principal));
        }
    }
}
