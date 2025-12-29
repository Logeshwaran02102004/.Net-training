using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10trainning
{
    namespace CollectionsDemo
    {
        public class Employee
        {
            public int EmpID { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }

            public decimal salary { get; set; }
        }
        internal class ArrayList_ComplexType
        {
            static void Main(string[] args)
            {
                Employee employee = new Employee();
                //Console.WriteLine("Enter the employee id, name and department: ");
                //employee.EmpID = Convert.ToInt32(Console.ReadLine());
                //employee.Name = Console.ReadLine();
                //employee.Dept = Console.ReadLine();

                ArrayList employeeList = new ArrayList()
            {
                new Employee { EmpID=1, Name="Mahe",Dept="IT",salary=50000},
                new Employee { EmpID=2,Name="Rishi", Dept="Automation",salary=60000},
                new Employee{ EmpID=3,Name="Sowmiya",Dept="Data Analyst",salary=45000},
                new Employee{ EmpID=4,Name="Kandoskar",Dept="Manufacturing",salary=30000},
                new Employee{ EmpID=5,Name="Vijay",Dept="Finance",salary=64000 }
            };


                Console.WriteLine("\n Employee portal");
                Console.WriteLine("1.Add new Employee");
                Console.WriteLine("2.Display all Employees");
                Console.WriteLine("3. Search by Id");
                Console.WriteLine("4.Remove Employee");
                Console.WriteLine("5.Sort employees by salary");
                Console.WriteLine("6.Reverse Employee List");
                Console.WriteLine("7.Exit");

                Console.WriteLine("Enter your service:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the employee id, name , dept and salary: ");
                        employee.EmpID = Convert.ToInt32(Console.ReadLine());
                        employee.Name = Console.ReadLine();
                        employee.Dept = Console.ReadLine();
                        employee.salary = Convert.ToDecimal(Console.ReadLine());
                        employeeList.Add(employee);
                        break;

                    case 2:

                        Console.WriteLine("Displaying all employee details: ");
                        foreach (Employee emp in employeeList)
                        {
                            Console.WriteLine($"Id: {emp.EmpID}\nName: {emp.Name}\n Department: {emp.Dept}\n Salary: {emp.salary}");

                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Employee Id to Search");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        Employee foundEmp = null;
                        foreach (Employee emp in employeeList)
                        {
                            if (emp.EmpID == searchId)
                            {
                                foundEmp = emp;
                                break;
                            }
                        }
                        if (foundEmp != null)
                        {
                            Console.WriteLine($"Found employee: Id:{foundEmp.EmpID}\nName: {foundEmp.Name}\nDepartment: {foundEmp.Dept}\nSalary: {foundEmp.salary}");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter employee id to remove: ");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        Employee empToRemove = null;
                        foreach (Employee emp in employeeList)
                        {
                            if (emp.EmpID == removeId)
                            {
                                empToRemove = emp;
                                break;
                            }
                        }

                        if (empToRemove != null)
                        {
                            employeeList.Remove(empToRemove);
                            Console.WriteLine("Employee removed Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found");
                        }
                        break;


                    case 5:
                        employeeList.Sort(new SalaryComparer());
                        Console.WriteLine("\nEmployees sorted by salary: ");
                        foreach (Employee emp in employeeList)
                        {
                            Console.WriteLine($"Id: {emp.EmpID}\nName: {emp.Name}\nDepartment: {emp.Dept}\nSalary: {emp.salary}");
                        }
                        break;
                    case 6:
                        employeeList.Reverse();
                        foreach (Employee emp in employeeList)
                        {
                            Console.WriteLine($"Id: {emp.EmpID}\nName: {emp.Name}\nDepartment: {emp.Dept}\nSalary: {emp.salary}");
                        }
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Entry!");
                        break;

                }




            }

            public class SalaryComparer : IComparer
            {
                public int Compare(object x, object y)
                {
                    return((Employee)x).salary.CompareTo(((Employee)y).salary);
                }
            }


        }
    }
}
