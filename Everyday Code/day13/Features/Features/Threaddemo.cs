using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Features
{
    internal class Threaddemo
    {
        public void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method1 Called");
                Thread.Sleep(1000);
            }
        }


        public void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method2 Called");
                Thread.Sleep(1000);
            }
        }

        public void Method3()
        {
            Task t1 = new Task(Method1);//insert record to db
            t1.Start();
            Task t2 = new Task(Method2);// update record to db
            t2.Start();

        }

        public void Method4()
        {// unlike threads ,to work with task class, u are not foreced to create methods

            var t1 = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method1 Called");
                    Thread.Sleep(1000);
                }
            });

            t1.Wait();
            var t2 = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Method2 Called");
                    Thread.Sleep(1000);
                }

            });

            //Task.WaitAll(t1,t2);//dont continue with next line until t1 and t2 are done with job
            //Task.WaitAny(t1,t2);// continue next line , if any 1 task completed
            Console.WriteLine("Both The task Completed successfully");
        }

        public void Method5()
        {
            //Task can be continued using continue with method
            var t1 = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("part1 Called");
                    Thread.Sleep(1000);
                }
            }).ContinueWith(t =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Part2 Called");
                    Thread.Sleep(1000);
                }
            });







        }

    }
}
