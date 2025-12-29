using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismdemo
{
    public class assignment2day8
    {
        public void Checkout(double price)
        {
            Console.WriteLine("the product price is : " + price);
        }
        public void Checkout(double price,int quantity)
        {
            Console.WriteLine("the total amount of the product is : " + (price * quantity));
        }
        public void Checkout(string couponcode)
        {
            Console.WriteLine("the coupopn code is : " + couponcode);
        }
        public void Checkout(double price, int quantity, string couponcode) 
        { 
            Console.WriteLine($"the coupon code and total amount is : {couponcode}: "+(price * quantity));
        }
    }
}
