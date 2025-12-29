using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11trainning
{
    internal class Sortedlistdemo
    {
        public static void Main(string[] args)
        {
            SortedList<int, string> inventory = new SortedList<int, string>();
            inventory.Add(2001, "wheat -50kg");
            inventory.Add(2004, "rice -25kg");
            inventory.Add(2005, "ghee -2lr");
            inventory.Add(2002, "sugar -2kg");
            inventory.Add(2003, "salt -2kg");

            //foreach (var item in inventory) { 
            //        Console.WriteLine("keys: "+item.Key+" values: "+item.Value); 
            //}
            Console.WriteLine("inventory deatails");
            Console.WriteLine("first item code " + inventory.Keys[0]);
            Console.WriteLine("Last item code is : " + inventory.Values[inventory.Count - 1]);
            foreach (var item in inventory) {
                Console.WriteLine("items: " + item.Key + " values: " + item.Value);
            }

            // search by key 
            Console.WriteLine("Enter the key to seach ");
            int keytosearch = Convert.ToInt32(Console.ReadLine());
            if (inventory.ContainsKey(keytosearch))
            {
                Console.WriteLine("item found: " + inventory[keytosearch]);
            }
            else
            {
                Console.WriteLine("item not found");
            }

            //search  by value
            Console.WriteLine("Enter the value to search : ");
            string valuetosearch = Console.ReadLine();
            if (inventory.ContainsValue(valuetosearch)) 
            { 
                 Console.WriteLine("value found :"+inventory.IndexOfValue(valuetosearch));
            }
            else
            {
                Console.WriteLine("Item not found");
            }

            Console.WriteLine("enter the value to update : ");
            int keytoupdate = Convert.ToInt32(Console.ReadLine());
            string newValue=Console.ReadLine();
            inventory[keytoupdate]=newValue;
            Console.WriteLine("updated value : " + inventory[keytoupdate]);

            //update value
            Console.WriteLine("Enter the key to update the value");
            int keyToUpdate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a new value: ");
            string newValue1 = Console.ReadLine();
            inventory[keyToUpdate] = newValue1;
            Console.WriteLine("Updated Inventory:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"Item Key: {item.Key}, New Item Value: {item.Value}");
            }

            Console.WriteLine($"Updated Value: {inventory[keyToUpdate]}");

            //Remove by key
            Console.WriteLine("Remove item code 2004");
            inventory.Remove(2004);
            Console.WriteLine("Inventory after removal:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"Item Key: {item.Key}, Item Value: {item.Value}");
            }

            //Remove by index
            inventory.RemoveAt(0);
            Console.WriteLine("Inventory after removing item at index 0:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"Item Key: {item.Key}, Item Value: {item.Value}");
            }

            //get index of key
            Console.WriteLine("Index of key 2003: " + inventory.IndexOfKey(2003));

            inventory.Clear();
            Console.WriteLine("Inventory cleared. Count: " + inventory.Count);




            Console.ReadLine();

            

        }
    }
}
