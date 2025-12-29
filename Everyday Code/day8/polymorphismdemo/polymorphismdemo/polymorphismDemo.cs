using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismdemo
{
    class Deatails
    {
        public void getemployeeInfo(int id)
        {
            Console.WriteLine("the employee id is : " + id);
        }
        public void getemployeeInfo(string name)
        {
            Console.WriteLine("the employee name is : " + name);
        }
        public void getemployeeInfo(int id ,string name)
        {
            Console.WriteLine("the employee id is : " + id+",the employee name is : "+name);
        }
        public void getemployeeInfo(string name,int id)
        {
            Console.WriteLine("the employee name is : " + name+",the employee id is : "+id);
        }

    }
    internal class polymorphismDemo
    {
    }
}
