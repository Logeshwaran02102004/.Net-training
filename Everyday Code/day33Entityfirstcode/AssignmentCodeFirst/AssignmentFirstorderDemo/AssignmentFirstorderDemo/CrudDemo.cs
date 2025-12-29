using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFirstorderDemo
{
    internal class CrudDemo
    {
        Model1 emp = new Model1();
        public void insertEmployees()
        {
            try
            {
                Employee ex = new Employee()
                {
                    EmpId = "E100",
                    EmpName = "Logesh",
                    Department = "Hr",
                    Salary = 50000,
                    YearOfJoining = 2025
                };

                emp.Employees.Add(ex);
                int res = emp.SaveChanges();
                Console.WriteLine(res);


            }
            catch (Exception ex) 
            {
                var result = emp.GetValidationErrors();
                Console.WriteLine(result);

                foreach (var item in result)
                {
                    if (item.ValidationErrors.Count > 0)
                    {
                        foreach (var error in item.ValidationErrors)
                        {
                            Console.WriteLine(error.ErrorMessage);
                        }
                    }
                }
            }
        }
    }
}
