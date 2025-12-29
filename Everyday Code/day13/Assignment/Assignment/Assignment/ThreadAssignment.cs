using System;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ThreadAssignment
    {
        static void Main(string[] args)
        {
         
            Task printTask1 = Task.Run(() =>
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(300);
                }
            });

            Task printTask2 = Task.Run(() =>
            {
                for (int i = 6; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(300);
                }
            });

            Task printMessage = Task.Run(() =>
            {
                Console.WriteLine("All numbers printed!");
            });

            Task.WaitAll(printTask1, printTask2, printMessage);

            Console.WriteLine("Done Printing Numbers\n");


           

            Random rnd = new Random();

            Task<int> random1 = Task.Run(() => rnd.Next(1, 101));
            Task<int> random2 = Task.Run(() => rnd.Next(1, 101));
            Task<int> random3 = Task.Run(() => rnd.Next(1, 101));

            Task.WhenAll(random1, random2, random3).ContinueWith(t =>
            {
                int sum = random1.Result + random2.Result + random3.Result;

                Console.WriteLine($"Random numbers: {random1.Result}, {random2.Result}, {random3.Result}");
                Console.WriteLine($"Sum of all numbers: {sum}\n");
            }).Wait();



            // Change to calculate factorial of another number
            int number = 5; 

            Task<int> factorialTask = Task.Run(() =>
            {
                int result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            });

            int factorial = factorialTask.Result;

            Console.WriteLine($"Factorial of {number} is {factorial}");

            Console.ReadLine();
        }
    }
}
