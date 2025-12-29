using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the basic data types
            //int num = 10;
            //float fnum = 1.0f;
            //double dnum = 1.00;
            //decimal denum = 341312;
            //char grade = 'A';
            //string message = "hey bro you are learning .dot framework";
            //string name = "logesh waran";
            //int age = 15;

            // Printing Output in the terminal
            //Console.WriteLine("Integer : " + num);
            //Console.WriteLine("Float : " + fnum);
            //Console.WriteLine("Double : " + dnum);
            //Console.WriteLine("Decimal : " + denum);
            //Console.WriteLine("Character : " + grade);
            //Console.WriteLine("String : " + message);
            //Console.WriteLine($"The integer value is {num}, The fload value is {fnum}");
            //Console.WriteLine("Name : {0}\n Age : {1}", name, age);


            //string firstName,lastName, gender;
            //int age;
            //char grade;
            //int score1, score2, score3;
            //Console.WriteLine("write the firstName, lastName, gender, age, grade, score1, score2, score3");
            //firstName = Console.ReadLine();
            //lastName = Console.ReadLine();
            //gender = Console.ReadLine();
            //age = Convert.ToInt16(Console.ReadLine());
            //grade = Convert.ToChar(Console.ReadLine());
            //score1 = Convert.ToInt32(Console.ReadLine());
            //score2 = Convert.ToInt32(Console.ReadLine());
            //score3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Students info................");
            //Console.WriteLine($"fullName = {firstName} {lastName}");

            //int a = 100;
            //int b = a;
            //Console.WriteLine($"A value is  {a} \n B value is {b}");
            //b = 120;
            //Console.WriteLine($"A value is  {a} \n B value is {b}");

            //string[] names = { "logesh", "kones" };
            //string[] copynames = names;
            //Console.WriteLine($" name[0] {names[0]} \t name[1] {names[1]}");


            //Console.WriteLine("choose 1 for add, 2 for sub, 3 for mul, 4 for div");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the num1");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the num2");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("addition " + (num1 + num2));
            //        break;
            //    case 2:
            //        Console.WriteLine("subtraction " + (num1 - num2));
            //        break;
            //    case 3:
            //        Console.WriteLine("multiplication " + (num1 * num2));
            //        break;
            //    case 4:
            //        Console.WriteLine("dicition " + (num1 / num2));
            //        break;


            //}


            // code for bonus

            /*
            Console.WriteLine("enter the year of experience");
            int year=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            if (year > 10)
            {
                Console.WriteLine("total salary + 20% of bonus");
                Console.WriteLine($"the total salary is :" + ((salary * 0.20) + salary));
            }
            else if (year >=5 && year <= 10)
            {
                Console.WriteLine("total salary + 10% of bonus");
                Console.WriteLine($"the total salary is :" + ((salary * 0.10)+salary));
            }
            else
            {
                Console.WriteLine("total salary + 5% of bonus");
                Console.WriteLine($"the total salary is :" + ((salary * 0.05) + salary));
            }
            */


            // code for checking password strong
            /*
            Console.WriteLine("enter the password:");
            string password= Console.ReadLine();
            int length = password.Length;

            if (length < 6)
            {
                Console.WriteLine("weak");
            }
            else if (length >= 6 && length <= 10)
            {
                Console.WriteLine("medium");
            }
            else
            {
                Console.WriteLine("hard");
            }
            */

            // code for predicting the grade
            /*
            Console.WriteLine("enter the marks:");
            int mark=Convert.ToInt32(Console.ReadLine());
            if (mark >= 90)
            {
                Console.WriteLine("A+");
            }
            else if(mark >80 && mark < 90)
            {
                Console.WriteLine('A');
            }
            else if (mark > 70 && mark < 80)
            {
                Console.WriteLine('B');
            }
            else if (mark > 60 && mark < 70)
            {
                Console.WriteLine('C');
            }
            else if (mark > 50 && mark < 60)
            {
                Console.WriteLine('D');
            }
            else
            {
                Console.WriteLine("Fail");
            }

            */


            // code for online shopping discount
            /*
            Console.WriteLine("enter the purchased amount ");
            int amount = Convert.ToInt32(Console.ReadLine());
            
            if (amount < 1000)
            {
                Console.WriteLine("No Discount");
            }
            else if (amount>=1000 && amount<=5000)
            {
                Console.WriteLine("total amount and 10% discount");
                Console.WriteLine($"the total amount after discount is :" + (amount-(amount * 0.10) ));
            }
            else
            {
                Console.WriteLine("total amount 20% discount");
                Console.WriteLine($"the total amount after discount is :" + (amount - (amount * 0.20)));
            }


            */


            // code for traffic signal

            /*
            Console.WriteLine("enter the light color ");
            string color= Console.ReadLine();
            if (color == "Red")
            {
                Console.WriteLine("Action : Stop");
            }
            else if (color == "Yellow")
            {
                Console.WriteLine("Action : Get Ready");
            }
            else if (color == "Green")
            {
                Console.WriteLine("Action : Go");
            }

            */
            // code for paying restaurent amount by spiliting
            /*
            Console.WriteLine("enter the total amount");
            int amount=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of persons ");
            int persons=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("each person have to pay the amount of rupees :" + (amount / persons));
            */

            Console.WriteLine("enter the age of the person :");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the time :");
            int time = Convert.ToInt32(Console.ReadLine());

            if (age < 12)
            {
                Console.WriteLine("price : 150 rupees");
            }
            else if(age >=12 && time <= 6)
            {
                Console.WriteLine("price : 250 rupees");
            }
            else if(age>=12 && time > 6)
            {
                Console.WriteLine("price : 300 rupees");
            }
        }
    }
}
