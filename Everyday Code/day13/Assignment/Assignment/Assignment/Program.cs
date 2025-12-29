using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Assignment
{

    public partial class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public partial class Student
    {
        public void DisplayDetails()
        {
            WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // extension method to check uppercase
    public static class StringExtensions
    {
        
        public static bool IsUpper(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return input.All(char.IsUpper);
        }
    }



    //this is for sum of squares
    public static class NumberExtensions
    {
        public static int SumOfSquares(this IEnumerable<int> numbers)
        {
            return numbers.Sum(n => n * n);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Logesh";
            s.Age = 22;
            s.DisplayDetails();


            // to check whether it is upper or not
            string str1 = "WELCOME";
            string str2 = "Hello";
            WriteLine(str1.IsUpper());
            WriteLine(str2.IsUpper());

            // for sum of all squares
            List<int> nums = new List<int> { 2, 3, 4 };
            WriteLine(nums.SumOfSquares());

        }
    }
}






