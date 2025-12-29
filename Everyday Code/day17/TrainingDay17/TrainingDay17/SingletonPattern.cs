using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDay17
{
    internal sealed class Singleton
    {
        private Singleton() { }

        private static Singleton s = null;

        public static Singleton GetInstance
        {
            get
            {
                if (s == null)
                {
                    s = new Singleton();
                }
                return s;
            }
        }

        public void Method()
        {
            Console.WriteLine("database code triggered");
        }
    }



}
