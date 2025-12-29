using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6training
{
    public class person
    {
        public person()
        {
            Console.WriteLine("Person constructor called : ");
        }
        public string name;
        public void ShowName()=>Console.WriteLine($"name: {name}");
    }


    public class teacher : person
    {
        public teacher()
        {
            Console.WriteLine("teacher constructor called : ");
        }
        public string course;
        public void ShowCourse() => Console.WriteLine($"{name} teaches: {course}");

    }

    class professor : teacher
    {
        public professor()
        {
            Console.WriteLine("professor constructor called : ");
        }
        public string course;
        public void ConductReseach() => Console.WriteLine($"{name} is conducting : {course}");
    }
    internal class multilevelinheritance
    {
    }
}
