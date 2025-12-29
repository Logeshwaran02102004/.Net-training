using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismdemo
{
    public class paymentmethod
    {
        public virtual string Provider => "Genderic payment provider";

        public virtual bool processpayment(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"proceesing payment of amount {amount} through {Provider}");
                return true;
            }
            else
            {
                return false;
            }
            }
            public void samplePayment()
            {
                Console.WriteLine("this is sample payment");
            }
    }
}
