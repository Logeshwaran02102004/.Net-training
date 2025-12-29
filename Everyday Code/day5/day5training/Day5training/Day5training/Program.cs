using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day5training
{
    class student
    {
        private int age;
        private string name;
        private double salary = 45000;
        private string password = "admin123";


        public int Age
        {
            get { return age; } //read only property
            set {
                if (value < 0 || value > 120)
                    throw new Exception("age should be 0 to 120");

                age = value;
                    
             }//write only property
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return Salary; }// read only property
        }
        public string Password
        {
            set { Password = value; }    // write only property
        }
    }







    /*
    class person
    {
        string name;
        int age;
        string location;

        public person(string name,int age,string location)
        {
            this.name = name;
            this.age = age;
            this.location = location;
            Console.WriteLine("this is base class");
        }


        public void getPersondeatails()
        {
            Console.WriteLine("write the name of the person : ");
            name=Console.ReadLine();
            Console.WriteLine("enter the age of the person : ");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the location of the employee");
            location=Console.ReadLine();
        }

        protected void displayPersonDeatails()
        {
            Console.WriteLine("***person deatails***");
            Console.WriteLine("Name :" + name);
            Console.WriteLine("age : " + age);
            Console.WriteLine("location : " + location);
        }
      
    }   

    class employeeDeatails:person
    {
        int employeeId;
        string employeeName;
        double employeesalary;
        string designation;

        public employeeDeatails(int Id,string Name,double salary,string designation,string name,int age,string location):base(name,age,location)
        {
            this.employeeId = Id;
            this.employeeName = Name;
            this.employeesalary = salary;
            this.designation = designation;
            Console.WriteLine("this is derived class");
        }
        public void getEmployeedeatails()
        {
            getPersondeatails();
            Console.WriteLine("Employee Id : ");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name of the employee : ");
            employeeName = Console.ReadLine();
            Console.WriteLine("Enter the salary of the employee : ");
            employeesalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the designation of the employee : ");
            designation = Console.ReadLine();
            
        }

        public void display()
        {
            displayPersonDeatails();
            Console.WriteLine("********Employee deatails are ******* ");
            Console.WriteLine($"\n ID : {employeeId} \n Name : {employeeName} \n Salary : {employeesalary} \n Designation : {designation}");
        }
    }*/



    internal class Program
    {
        
        static void Main(string[] args)
        {  /*single inheritance method
            employeeDeatails employedeatails = new employeeDeatails(122,"logesh",234234,"ceo","poiuhn",23,"chennai");
           // employedeatails.getEmployeedeatails();
            employedeatails.display();
            //employedeatails.displayPersonDeatails();
            */
            student student = new student();
            student.Age = 12;
            student.Name = "logesh";

            Console.WriteLine("========the student deatails=========");
            Console.WriteLine("the student age is :" + student.Age);
            Console.WriteLine("the student name :" + student.Name);
            //  Console.WriteLine("the stiphend is :" + student.Salary);
            

            Console.ReadLine();

        }
    }   
}
