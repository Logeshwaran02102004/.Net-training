using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10trainning
{
    internal class HashTableDemo
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Mahe");
            ht.Add(2, "rishi");
            ht.Add("eid", 109);
            ht.Add("dept", "BT");
            ht.Add("Location", "Bangalore");
            ht["email"] = "Smaple@mail.com";
            ht[56] = "test Value";

            Console.WriteLine("Hash Table values are");
            Console.WriteLine("First value:" + ht[1]);
            Console.WriteLine("Count of hash table: " + ht.Count);
            Console.WriteLine("the key 56 is availabe or not :" + ht.ContainsKey(56));
            Console.WriteLine("the value sample@mail.com is available or not: " + ht.ContainsKey("email"));

            ht.Remove("eid");
            Console.WriteLine("\n After removing Key eid Hash table values are: ");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine($"Key: {item}");
            }

            Console.WriteLine($"\n hash table values are");
            foreach (var item in ht.Values)
            {
                Console.WriteLine($"Values: {item}");
            }

            Console.WriteLine("Hash table keys and values are");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }

            object[] keysArray = new object[ht.Keys.Count];
            ht.Keys.CopyTo(keysArray, 0);
            Console.WriteLine("\n after copying all keys into keyarray:\n");
            foreach (var item in keysArray)

            {
                Console.WriteLine(item);
            }


            


            Hashtable ht2 = new Hashtable();
            foreach (DictionaryEntry item in ht)
            {
                ht2[item.Key] = item.Value;
            }

            Console.WriteLine("printing h2 hash table values");
            foreach (DictionaryEntry item in ht2)
            {
                Console.WriteLine(item.Key + "-"+item.Value);
            }
            ht.Clear(); //is used to clear all the hash table
            Console.WriteLine("after clearing the hash table :"+ht.Count);
        }
    }
}
