using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismdemo
{
    public class vehicle
    {
        public virtual void start()
        {
            Console.WriteLine("vehicle : runs for pre run checks");

        }

    }
    public class car : vehicle
    {
        public override void start()
        {
            base.start();
            Console.WriteLine("car : starts with key");
        }
    }
    public class electriccar : car
    {
        public sealed override void start()
        {
            base.start();
            Console.WriteLine("Electric car : starts with button");
        }
    }
}
