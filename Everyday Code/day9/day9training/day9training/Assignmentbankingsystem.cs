using day9training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace day9training
{

    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }

        public double AccountBalance { get; set; }

        public string DeatailsInfo = "";

       
        public BankAccount(string accountNumber, string customerName, double accountBalance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            AccountBalance = accountBalance;
        }

        public static BankAccount operator +(BankAccount b1, BankAccount b2)
        {
            double result = b1.AccountBalance+b2.AccountBalance;
            return new BankAccount(b1.AccountNumber,b1.CustomerName+ "&" +b2.CustomerName, result);
           
            
        }

        public static BankAccount operator -(BankAccount acc, double amount)
        {
            if (amount>acc.AccountBalance) 
                {
                    Console.WriteLine("transaction failed");
                    return acc;
                }
            acc.AccountBalance-=amount;
            return acc;
        }

        public static bool operator ==(BankAccount b1, BankAccount b2)
        {
            return (b1.AccountBalance==b2.AccountBalance);
        }
        public static bool operator !=(BankAccount b1, BankAccount b2)
        {
            return !(b1.AccountBalance == b2.AccountBalance);
        }


        public override string ToString()
        {
            return $"Accountnumber : {AccountNumber},Balance : {AccountBalance},AccountHolder : {CustomerName}";

        }

    }
    internal class Assignmentbankingsystem
    {
        public static void Main(string[] args)
        {
            BankAccount bank1 = new BankAccount("89890","logesh",25000);
            BankAccount bank2 = new BankAccount("12323", "prathess",40000);
            Console.WriteLine(bank1);
            Console.WriteLine(bank2);
            BankAccount sum = bank1 + bank2;
            Console.WriteLine(sum);
            bank1 = bank1 - 5000;
            Console.WriteLine("new balance of account 1 "+bank1);

            Console.WriteLine(bank1!=bank2);






            Console.ReadLine();




        }
    }
}

