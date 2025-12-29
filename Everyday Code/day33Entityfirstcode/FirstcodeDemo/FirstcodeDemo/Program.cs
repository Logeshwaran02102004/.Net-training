using FirstcodeDemo.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstcodeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CrudDemoStudents student = new CrudDemoStudents();
            student.InsertNewStudent();
        }
    }
}
