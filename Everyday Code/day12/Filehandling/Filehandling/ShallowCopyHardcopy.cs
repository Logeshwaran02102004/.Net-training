using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filehandling
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public Address DeepCopy()
        {
            return new Address
            {
                City = this.City,
                Street = this.Street
            };
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address HomeAddress { get; set; } //reference

        //public Employee ShallowCopy()
        //{
        //    return (Employee)this.MemberwiseClone();
        //}

        public Employee DeepCopy()
        {
            Employee clonedEmployee = (Employee)this.MemberwiseClone(); //shallw first
            clonedEmployee.HomeAddress = this.HomeAddress.DeepCopy(); // fix reference
            return clonedEmployee;
        }
    }
    internal class ShallowCopyHardcopy
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee { Name = "John", Age = 30, HomeAddress = new Address { City = "New York", Street = "5th Avenue" } };
            Employee emp2 = emp1.DeepCopy();

            emp2.Name = "Doe";
            emp2.HomeAddress.City = "Los Angeles";

            Console.WriteLine("emp1.name" + emp1.Name);
            Console.WriteLine($"emp1.Home address" + emp1.HomeAddress.City);

            Console.WriteLine("emp2.name" + emp2.Name);
            Console.WriteLine($"emp2.Home address" + emp2.HomeAddress.City);
        }
    }
}
