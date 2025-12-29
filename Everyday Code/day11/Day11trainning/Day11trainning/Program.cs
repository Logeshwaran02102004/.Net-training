using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11trainning
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("test");
            stack.Push(3.14);
            Console.WriteLine("Items in stack are");
            foreach (var item in stack) {
                Console.WriteLine(item);      
            }

            Console.WriteLine("top of the item in stack is :"+stack.Peek());

            stack.Pop();
            Console.WriteLine("items in stack after pop is :");
            foreach (var item in stack) { 
                  Console.WriteLine(item);
            }

            Console.WriteLine("test is there in stack or not " + stack.Contains("test"));
            Console.WriteLine("total count in the stack is :" + stack.Count);
            stack.Clear();
            Console.WriteLine("Total items in the stack is : " + stack.Count);

            Console.ReadLine();

        }
    }
}
