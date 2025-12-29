using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstDemo
{
    internal class Class
    {
        Model1Container ob = new Model1Container();
        public void Addpizza()
        {

            Entity1 p = new Entity1()
            {
                PizzaId = 200,
                PizzaName = "cheese veg",
                Description = "made with cheese",
                Price = 200,
                Type = "veg"
            };

            ob.Entity1.Add(p);
            int i = ob.SaveChanges();
            Console.WriteLine("total record inserted is " + i);

            foreach (var item in ob.Entity1)
            {
                Console.WriteLine($"{item.PizzaId}  {item.PizzaName}  {item.Description}  {item.Price}  {item.Type}");
            }

        }


        // extenstion methods

        public void EvenODD()
        {
            int x = 11;
            Console.WriteLine(x.IsEven());


        }

    }


    static class myclass
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }


    }
}

