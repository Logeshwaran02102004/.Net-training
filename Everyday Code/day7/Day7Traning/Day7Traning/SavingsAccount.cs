using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Traning
{

    public class savingAccount : Bankaccount
    {
        public savingAccount(string accountNumber,double initialBalance)
            : base(accountNumber, initialBalance)
        {

        }

        public override void calculateInterest()
        {
            double interest = Balance * 0.04;
            Balance += interest;
            Console.WriteLine($"Interest 0f {interest} added.New balance is {Balance}");
        }
    }
    internal class SavingsAccount
    {
    }
}
