using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6training
{

    public class Employee
    {
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public string Gender { get; set; }
    }

    internal class employeelist_indexdemo
    {
        List<Employee> employee = new List<Employee>() {
        new Employee() {employeeId = 1,employeeName="logesh",Gender="male" },
        new Employee() {employeeId = 2,employeeName="prathess",Gender="male" },
        new Employee() {employeeId = 3,employeeName="isma",Gender="Female" }
        };

        public string this[int empId]
        {
            get
            {
                return employee.FirstOrDefault(e => e.employeeId == empId)?.employeeName;
            }
            set
            {
                employee.FirstOrDefault(e => e.employeeId == empId).employeeName = value;
            }
        }
    }
}

