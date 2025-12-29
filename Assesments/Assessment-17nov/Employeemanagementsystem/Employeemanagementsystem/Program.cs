using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeemanagementsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>()
        {
            new Employee{ EmpId=1, Name="Logesh",     Department="IT",        Salary=50000, Experience=6 },
            new Employee{ EmpId=2, Name="prathess",       Department="HR",        Salary=48000, Experience=3 },
            new Employee{ EmpId=3, Name="sakthi",      Department="Finance",   Salary=55000, Experience=8 },
            new Employee{ EmpId=4, Name="waseef",    Department="IT",        Salary=91000, Experience=10 },
            new Employee{ EmpId=5, Name="prem",     Department="Sales",     Salary=45000, Experience=2 },
            new Employee{ EmpId=6, Name="nivi",     Department="Marketing", Salary=51000, Experience=5 },
            new Employee{ EmpId=7, Name="isma",   Department="IT",        Salary=70000, Experience=7 },
            new Employee{ EmpId=8, Name="harini",     Department="Finance",   Salary=15000, Experience=9 },
            new Employee{ EmpId=9, Name="Asif",    Department="HR",        Salary=52000, Experience=4 },
            new Employee{ EmpId=10,Name="keerthik",      Department="Sales",     Salary=76000, Experience=6 }
        };
            
            Console.WriteLine("The Complete Employee Details\n");
            foreach (var e in emps)
                Console.WriteLine($"EmpId: {e.EmpId}, Name: {e.Name}, Dept: {e.Department}, Salary: {e.Salary}, Exp: {e.Experience}");



            var highSalary = emps.Where(e => e.Salary > 50000).ToList();
            Console.WriteLine("\nEmployee salary greater than 50000\n");
            foreach (var e in highSalary)
                Console.WriteLine($"EmpId: {e.EmpId}, Name: {e.Name}, Dept: {e.Department}, Salary: {e.Salary}, Exp: {e.Experience}");
            


            var experienced = emps.Where(e => e.Experience > 5).ToList();
            Console.WriteLine("\nEmployees with experience more than 5 years\n");
            foreach (var e in experienced)
                Console.WriteLine($"EmpId: {e.EmpId}, Name: {e.Name}, Dept: {e.Department}, Salary: {e.Salary}, Exp: {e.Experience}");



            var startsWithA = emps.Where(e => e.Name.StartsWith("A")).ToList();
            Console.WriteLine("\nEmployees whose Names start with A\n");
            foreach (var e in startsWithA)
                Console.WriteLine($"EmpId: {e.EmpId}, Name: {e.Name}, Dept: {e.Department}, Salary: {e.Salary}, Exp: {e.Experience}");



            var itDept = emps.Where(e => e.Department == "IT").ToList();
            Console.WriteLine("\nEmployees from IT Department\n");
            foreach (var e in itDept)
                Console.WriteLine($"EmpId: {e.EmpId}, Name: {e.Name}, Dept: {e.Department}, Salary: {e.Salary}, Exp: {e.Experience}");



            var sortedByName = emps.OrderBy(e => e.Name).ToList();
            Console.WriteLine("\nEmployees sorted by Name\n");
            foreach (var e in sortedByName)
                Console.WriteLine($"EmpId: {e.EmpId}, Name: {e.Name}, Dept: {e.Department}, Salary: {e.Salary}, Exp: {e.Experience}");



            var sortedBySalary = emps.OrderByDescending(e => e.Salary).ToList();
            Console.WriteLine("\nEmployees sorted by Salary\n");
            foreach (var e in sortedBySalary)
                Console.WriteLine($"EmpId: {e.EmpId}, Name: {e.Name}, Dept: {e.Department}, Salary: {e.Salary}, Exp: {e.Experience}");



            var sortedByExperience = emps.OrderBy(e => e.Experience).ToList();
            Console.WriteLine("\nEmployees sorted by experience\n");
            foreach (var e in sortedByExperience)
                Console.WriteLine($"EmpId: {e.EmpId}, Name: {e.Name}, Dept: {e.Department}, Salary: {e.Salary}, Exp: {e.Experience}");
        }
    }
}


