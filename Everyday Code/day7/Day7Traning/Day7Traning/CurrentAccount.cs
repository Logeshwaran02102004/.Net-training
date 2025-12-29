using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Traning
{
    public class CurrentAccount: Bankaccount
    {
        public CurrentAccount(string accountNumber, double initialBalance)
            : base(accountNumber, initialBalance) 
        { 
        }
        public abstract class Bankaccount
        {
            public abstract void calculateInterest();
        }


        public override void calculateInterest()

        {
            Console.WriteLine("current donot earn interst.");
        }
    }
   
}
