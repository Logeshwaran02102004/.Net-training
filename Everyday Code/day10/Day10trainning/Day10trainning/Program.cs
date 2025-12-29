using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10trainning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();
            Console.WriteLine("Initial Capacity", arraylist.Capacity); // it will print the array capacity

            arraylist.Add(10);
            Console.WriteLine("Capacity after adding the first item is :",arraylist.Capacity);

            arraylist.Add("Test item 1");
            arraylist.Add(true);
            arraylist.Add(15.5);

            Console.WriteLine("Capacity after adding the four items :",arraylist.Capacity);
            Console.WriteLine("Items in the arraylist are :");
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }

            arraylist.Remove(true); //used to remove the item in arrar list
            Console.WriteLine("After removinf the true");
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("after removing the true the capacity is ",arraylist.Capacity);

            arraylist.Add("logesh");
            arraylist.Add("prathees");
            arraylist.Add("dileep");
            arraylist.Insert(1, "adhi is inserting at 1");
            Console.WriteLine("after adding the seven value :",arraylist.Capacity);
            foreach ( var item in arraylist)
            {
                Console.WriteLine(item);
            }

            ArrayList arraylist2 = new ArrayList();
            arraylist2.Add("first item in array list 2");
            arraylist2.Add("second item in array list 2");
            arraylist.AddRange(arraylist2);   //add range is used to add the first list in the second list

            Console.WriteLine("Adding 9 value in the capacit :", arraylist.Capacity);



            ArrayList deptList=new ArrayList(){"It","Hr","admin","Finance" }; // creating new arralist with value and adding in the array list index which we give
            arraylist.InsertRange(2, deptList);
            Console.WriteLine("afer inserted dept list in the array list :");

            foreach( var item in arraylist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After adding the 13 values in the array list ",arraylist.Capacity);

            Console.WriteLine($"hr is contains in the array list or not{ arraylist.Contains("Hr")}");

            Console.WriteLine("Total count :",arraylist.Count);

            Console.WriteLine($"arrlist[4] is : {arraylist[4]}");


            // get range 

            ArrayList arraylist3 = arraylist.GetRange(3, 5);
            Console.WriteLine("array list 3 values are ");
            foreach ( var item in arraylist3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("reverse an arraylist 3 is");
            arraylist3.Reverse();
            foreach ( var item in arraylist3)
            {
                Console.WriteLine(item);
            }



            //remove range
            Console.WriteLine("after remove range (2,2) arraylist 3");
            arraylist3.RemoveRange(2, 2);// from index 2 remove 2 elements
            
            foreach ( var item in arraylist3)
            {
                Console.WriteLine(item);
            }


            //removeAt
            Console.WriteLine("remove the element at the index 1 is");
            arraylist3.RemoveAt(1);
            foreach(var item in arraylist3)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();




        }
    }
}
