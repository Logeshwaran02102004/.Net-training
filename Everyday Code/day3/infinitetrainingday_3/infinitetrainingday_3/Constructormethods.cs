using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitetrainingday_3
{
    internal class Constructormethods
    {
        int dept_Id;
        string departmentName, departmentLocation;

        static  Constructormethods()
        {
            Console.WriteLine("welcome \n ");
        }
        public Constructormethods()
        {
            dept_Id = 101;
            departmentName = "unknown";
            departmentLocation = "unknown";
            Console.WriteLine("default or parameter constructor called "); 
        }

        public Constructormethods(int dept_Id, string departmentName, string departmentLocation)
        {
            this.dept_Id = dept_Id;
            this.departmentName = departmentName;   
            this.departmentLocation = departmentLocation;   
                
        }

        //default constructor or parameters
        // parameter less or default construcor
        /*
        public Constructormethods()
        {
            dept_Id = 101;
            departmentName = "unknown";
            departmentLocation = "unknown";
        }
        
        public void  getDepartmentInfo() 
        {
            Console.WriteLine("enter the deptId : ");
            dept_Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the department name : ");
            departmentName=Console.ReadLine();
            Console.WriteLine("enter the department location : ");
            departmentLocation=Console.ReadLine();

        }
        */

        public void getDepartmentInfo() // parameter constrictor
        {
            Console.WriteLine("enter the deptId : ");
            dept_Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the department name : ");
            departmentName = Console.ReadLine();
            Console.WriteLine("enter the department location : ");
            departmentLocation = Console.ReadLine();

        }


        public void displaydepartmentinfo()
        {
            Console.WriteLine("****department deatails****");
            Console.WriteLine("department id : " + dept_Id);
            Console.WriteLine("department name : " + departmentName);
            Console.WriteLine("department location : "+ departmentLocation);
        }
    }
}
