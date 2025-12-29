using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4assignment
{
    internal class Utilitybill
    {
        // Static fields for global values
    private static double taxRate = 0.1;  
    private static double serviceCharge = 20.00;  

    
    private int customerId;
    private string customerName;
    private double usage;
    private double rate;

    
    public Utilitybill(int customerId,string name, double usage, double rate)
    {
        this.customerId = customerId;
        this.customerName = name;
        this.usage = usage;
        this.rate = rate;
    }



        // Method to calculate total usage from multiple readings using params method
        public static double CalculateTotalUsage(params double[] readings)
        {
            double totalUsage = 0;
            foreach (var reading in readings)
            {
                totalUsage += reading;
            }
            return totalUsage;
        }




        
        public void CalculateBillDetails(out double total, out double tax, out double netPayable)
        {
            total = usage * rate;
            tax = total * taxRate;
            netPayable = total + tax + serviceCharge;
        }


        
        public void DisplayBill()
        {
            double total, tax, netPayable;
            CalculateBillDetails(out total, out tax, out netPayable);

            Console.WriteLine($"Customer Id :{customerId}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Usage: {usage} ");
            Console.WriteLine($"Rate: {rate:C} per kWh");
            Console.WriteLine($"Total: {total:C}");
            Console.WriteLine($"Tax: {tax:C}");
            Console.WriteLine($"Net Payable (Including Service Charge): {netPayable:C}");
        }

    }
}





    

   

  

    

    

    


