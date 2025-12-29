using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismdemo
{
    public class credictcardpayment : paymentmethod
    {
        public override string Provider => "Credict card provider";

        public override bool processpayment(double amount)
        {
            base.processpayment(788);
            if (amount > 0 && amount <= 5000)
            {
                Console.WriteLine($"processing credict payment {amount} through {Provider}");
                return true;
            }
            else
            {
                Console.WriteLine("the payment failed:Amount exceeds limit or invalid");
                return false;
            }


        }
    }
}
