using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLinq
{
    public class Lambda
    {
        List<Products> li = new List<Products>()
            {
               new Products() { pid = 100, pname = "book", price = 1000, qty = 5 },
                new Products() { pid = 200, pname = "cd", price = 2000, qty = 6 },
                new Products() { pid = 300, pname = "toys", price = 3000, qty = 5 },
                  new Products() { pid = 400, pname = "mobile", price = 8000, qty = 6 },
                new Products() { pid = 600, pname = "pen", price = 200, qty = 7 },
                new Products() { pid = 700, pname = "tv", price = 30000, qty = 7 },
             };


        public void secondlargestprice()
        {
            var res = li.OrderByDescending(p => p.price).Skip(1).First();
            Console.WriteLine($"{res.pname} , {res.price}");
           
        }

        public void topthreehighest()
        {
            var res = li.OrderByDescending(p => p.price).Take(3);
            foreach (var item in res)
                Console.WriteLine($"{item.pname} {item.price}");
        }

    public void sumofpriceproductO()
        {

        }





    }
}
