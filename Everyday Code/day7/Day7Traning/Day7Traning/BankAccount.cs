using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Traning
{
    public abstract class Bankaccount
    {
        public string AccountNumber {  get; set; }  
        public double Balance { get; set; }
        public Bankaccount(string accountNumber ,double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;   
        }

        public abstract void calculateInterest();

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited amount{amount}.New balance is {Balance}");

           
        }
    }
    internal class BankAccount
    {
    }
}
