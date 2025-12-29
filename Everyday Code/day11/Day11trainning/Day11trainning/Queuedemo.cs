using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11trainning
{
    internal class Queuedemo
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("logesh");
            queue.Enqueue(3.14);

            foreach (object item in queue) { 
                Console.WriteLine(item+ " ");
            }

            queue.Dequeue();
            Console.WriteLine("the values after deque :");
            foreach (object item in queue) { 
                  Console.WriteLine(item + " ");         
            }

            Console.WriteLine("Aftyer deque : " + queue.Count);
            Console.WriteLine("top of the item in the queue :"+queue.Peek());
            Console.ReadLine();


            




        }
    }
}
