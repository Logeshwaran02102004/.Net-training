using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10trainning
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
    }
    internal class Assignmentday10
    {
        public static void Main(string[] args)
        {
            ArrayList orderList = new ArrayList()
            {
                new Order { OrderID = 101, CustomerName = "logesh", TotalAmount = 2500},
                new Order { OrderID = 102, CustomerName = "prathess", TotalAmount = 4555 },
                new Order { OrderID = 103, CustomerName = "adhi", TotalAmount = 3000 },
                new Order { OrderID = 104, CustomerName = "dileep", TotalAmount = 15000 },
                new Order { OrderID = 105, CustomerName = "jegan", TotalAmount = 12000 }
            };

            Console.WriteLine("Welcome to Foodify - Restaurant Order Management System");
            

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add New Order");
                Console.WriteLine("2. Display All Orders");
                Console.WriteLine("3. Search Order by ID");
                Console.WriteLine("4. Remove Order by ID");
                Console.WriteLine("5. Show Total Number of Orders");
                Console.WriteLine("6. Sort Orders by Amount");
                Console.WriteLine("7. Reverse Orders List");
                Console.WriteLine("8. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Add new order
                        Order newOrder = new Order();
                        Console.WriteLine("Enter Order ID: ");
                        newOrder.OrderID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Customer Name: ");
                        newOrder.CustomerName = Console.ReadLine();
                        Console.WriteLine("Enter Total Amount: ");
                        newOrder.TotalAmount = Convert.ToDecimal(Console.ReadLine());
                        orderList.Add(newOrder);
                        Console.WriteLine("Order added successfully!");
                        break;

                    case 2:
                        // Display all orders
                        Console.WriteLine("\nDisplaying all orders: ");
                        foreach (Order order in orderList)
                        {
                            Console.WriteLine($"Order ID: {order.OrderID}\nCustomer: {order.CustomerName}\nAmount: {order.TotalAmount:C}\n");
                        }
                        break;

                    case 3:
                        // Search order by ID
                        Console.WriteLine("Enter Order ID to Search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        Order foundOrder = null;
                        foreach (Order order in orderList)
                        {
                            if (order.OrderID == searchId)
                            {
                                foundOrder = order;
                                break;
                            }
                        }
                        if (foundOrder != null)
                        {
                            Console.WriteLine($"Found Order: \nOrder ID: {foundOrder.OrderID}\nCustomer: {foundOrder.CustomerName}\nAmount: {foundOrder.TotalAmount:C}");
                        }
                        else
                        {
                            Console.WriteLine("Order not found.");
                        }
                        break;

                    case 4:
                        // Remove order by ID
                        Console.WriteLine("Enter Order ID to Remove: ");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        Order orderToRemove = null;
                        foreach (Order order in orderList)
                        {
                            if (order.OrderID == removeId)
                            {
                                orderToRemove = order;
                                break;
                            }
                        }
                        if (orderToRemove != null)
                        {
                            orderList.Remove(orderToRemove);
                            Console.WriteLine("Order removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Order not found.");
                        }
                        break;

                    case 5:
                        // Show total number of orders
                        Console.WriteLine($"Total number of orders: {orderList.Count}");
                        break;

                    case 6:
                        // Sort orders by amount
                        orderList.Sort(new AmountComparer());
                        Console.WriteLine("\nOrders sorted by amount: ");
                        foreach (Order order in orderList)
                        {
                            Console.WriteLine($"Order ID: {order.OrderID}\nCustomer: {order.CustomerName}\nAmount: {order.TotalAmount:C}\n");
                        }
                        break;

                    case 7:
                        // Reverse the list
                        orderList.Reverse();
                        Console.WriteLine("\nOrders reversed: ");
                        foreach (Order order in orderList)
                        {
                            Console.WriteLine($"Order ID: {order.OrderID}\nCustomer: {order.CustomerName}\nAmount: {order.TotalAmount:C}\n");
                        }
                        break;

                    case 8:
                        // Exit the program
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid selection! Please try again.");
                        break;
                }
            }
        }

        // Custom comparer to sort orders by total amount
        public class AmountComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                return ((Order)x).TotalAmount.CompareTo(((Order)y).TotalAmount);
            }
        }
    }
}
