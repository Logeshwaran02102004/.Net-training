using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstcodeDemo.Migrations
{
    internal class CrudDemoStudents
    {
        Model1 stu = new Model1();

        public void InsertNewStudent()
        {
            try
            {
                Student s = new Student()
                {
                    StudentId = 1,
                    StudentName = "Logesh",
                    DOB = DateTime.Now,
                    Class = 7,
                    Email = "logesh@gmail.com"

                };
                stu.Students.Add(s);
                int res = stu.SaveChanges();
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                
                    var result = stu.GetValidationErrors();
                    Console.WriteLine(result);

                foreach (var item in result) 
                {
                    if (item.ValidationErrors.Count>0)
                    {
                        foreach(var error in item.ValidationErrors)
                        {
                            Console.WriteLine(error.ErrorMessage);
                        }
                    }
                }
                
            }
        }
    }
}
