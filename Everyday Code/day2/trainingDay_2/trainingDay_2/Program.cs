using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingDay_2;

namespace trainingDay_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            //array initialization and declaration
            int[] numArray = new int[5] { 1, 2, 3, 4, 5, };

            // arr declaration
            int[] arr = new int[5];
            Console.WriteLine("enter the {arr.length} numbers");
            //for loop
            for (int i = 0; i < numArray.Length; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("the entered elements are:");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            */

            //initialization of two dimentional array



            /*
            // 2 dimentional array initialization in the runtime
            int rowsize, colsize;
            Console.WriteLine("enter the number of students");
            rowsize=Convert.ToInt32( Console.ReadLine() );
            colsize = 5;//the coloum size is fixed
            int[,] studentMarks = new int[rowsize, colsize];
            for (int i = 0; i < rowsize; i++)
            {
                Console.WriteLine($"enter the marks for student:{i + 1}");
                for (int j = 0; j < colsize; j++)
                {
                    Console.WriteLine($"enter the marks of the student:{j + 1}");
                    studentMarks[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            int count = 0;
                Console.WriteLine("displaying the marks of the student:");
                for (int i = 0; i < rowsize; i++)
                {
                    Console.WriteLine($"\n studnts marks of the student {i+1} : \n");
                    for (int j = 0; j < colsize; j++)
                    {
                        Console.WriteLine(studentMarks[i, j] + "\t");
                        count = count + studentMarks[i,j];
                    }
                Console.WriteLine($"the total marks is : {count}");
                    count = 0;
                }
                */

            /*
            // example for array reverse

            int[] arr = new int[5] { 1, 2, 3, 4, 5, };
            foreach (int item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("after reversed is :");
            Array.Reverse(arr);
            foreach (int item in arr)
            {
                Console.Write(item + "\t");
            }
            */

            /*
            //jagged array -> the length of the each array can be differ; 
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2] { 1, 2 };
            jaggedArray[1] = new int[3] { 3, 4, 5 };
            jaggedArray[2] = new int[4] { 4, 5, 6, 7 };

            Console.WriteLine("\nJagged Array Output : \n");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(" " + jaggedArray[i][j]);
                }
            }


            // same using the string
            string[][] Members = new string[3][] {
            new string[] { "logesh","waseef","kones"},
            new string[] { "logesh","waseef","kones","sakthi"},
            new string[] { "logesh","waseef","kones","mano"}
            
        };
             
            for(int i = 0;i < Members.Length; i++)
            {
                Console.Write("name list({0}):" ,i+1 );
                for (int j = 0; j < Members[i].Length; j++)
                {
                    Console.Write(Members[i][j] + " \t");
                }
                Console.WriteLine();
            }
            */


            /*
            // by creating a new class we can call it from main function 
            int num1, num2;
            Console.WriteLine("enter the num1 value : ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num2 value : ");
            num2=Convert.ToInt32(Console.ReadLine());

            Calculator calculator = new Calculator(); // instance or object declaration and initialization
            calculator.add(num1, num2);
            calculator.sub(num1, num2);
            */


            //directly paasing the value in the funtion
            //EmployeeDeatails employeedeatails = new EmployeeDeatails();
            //employeedeatails.acceptempdeatails(2133, "logesh", "udumalpet");
            //employeedeatails.displayempdeatails();

            // input getting in the compile time
            /*
            Console.WriteLine("enter the employee id : ");
            int empId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the emploee name :");
            string name = Console.ReadLine();
            Console.WriteLine("enter the employee destination : ");
            string destination = Console.ReadLine();
            EmployeeDeatails employeeDeatails = new EmployeeDeatails();
            employeeDeatails.acceptempdeatails(empId, name, destination);
            employeeDeatails.displayempdeatails();
            */


            // return type 


            //int num1 = 22;
            //int num2 = 25;
            //EmployeeDeatails employedeatails = new EmployeeDeatails();
            //int result=employedeatails.addition(num1, num2);
            //Console.WriteLine(result);


            // optional executes auromatically
            /*
            EmployeeDeatails employeeDeatails = new EmployeeDeatails();
            employeeDeatails.acceptempdeatails(100, "logesh");
            employeeDeatails.displayempdeatails();

            employeeDeatails.acceptempdeatails(101, "prathees","Manager");
            employeeDeatails.displayempdeatails();

            */

            // assessment 1 to print the students marks average and grade;
            
            Console.WriteLine("enter the number of students : ");
            int numberofStudents=Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[3];
            string name = "";
            for (int i = 0; i < numberofStudents; i++)
            {
                Console.WriteLine($"enter the studen {i} name : ");
                name = Console.ReadLine();

                for (int j = 0; j < marks.Length; j++)
                {
                    Console.WriteLine($"enter the marks of subject {j + 1}:");
                    marks[j] = Convert.ToInt32(Console.ReadLine());
                }
                
                EmployeeDetails employeeDetails = new EmployeeDetails();
                employeeDetails.StudentReport(marks, name);
                employeeDetails.Calculate();
                employeeDetails.Display();


            }


            // assessment for grocery billing 

            //Console.WriteLine("****** Welcome to grocery billing *****");



            //Console.ReadLine();
        }

    }
}
