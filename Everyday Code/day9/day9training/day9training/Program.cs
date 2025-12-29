
using day9training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9training
{


    public class EmployeeDirectory
    {
        private string[] Empname = { "logesh", "prathees", "sakthi", "hari" };
        private int[] Empids = { 1, 2, 3, 4 };

        public string this[int index]
        {
            get { return Empname[index]; }
            set { Empname[index] = value; }
        }

        public string this[string Empid]
        {
            get
            {
                for (int i = 0; i < Empids.Length; i++)
                {
                    if (Empids[i].ToString() == Empid)
                        return Empname[i];
                }
                return "Employee not found";
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // this is called index overloading
            EmployeeDirectory empdir = new EmployeeDirectory();
            Console.WriteLine(empdir[2]);
            Console.WriteLine(empdir[3]);
            Console.WriteLine(empdir[1]);
            Console.ReadLine();
        }
    }
}

