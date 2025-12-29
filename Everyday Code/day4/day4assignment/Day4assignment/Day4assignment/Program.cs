using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int customerId;
            string customerName;
            

            Console.WriteLine("======== Welcome to online billing system =========");
            Console.WriteLine("enter the number of customer:");
            int numberofcustomer=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberofcustomer; i++) 
            {
                Console.WriteLine($"Enter the deatails for customer {i + 1}");
                Console.WriteLine("Customer Id :");
                customerId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Customer Name:");
                customerName = Console.ReadLine();

                Console.WriteLine("Enter the montly usuage readings (in un  its) : ");
                int countofreadings=Convert.ToInt32(Console.ReadLine());
                double[] readings = new double[countofreadings];
                for (int j = 0; j < countofreadings; j++) {
                    readings[j]=Convert.ToDouble(Console.ReadLine());
                
                }

                double totalusage = Utilitybill.CalculateTotalUsage(readings);

                double rate = 6;

                
               Utilitybill utilitybill=new Utilitybill(customerId, customerName,totalusage,rate);



                Console.WriteLine("======= utility bill ========");
                utilitybill.DisplayBill();



                    
                    
            }
            Console.WriteLine("All customer bills proceed successfully");
            Console.ReadLine();
        }
    }
}
