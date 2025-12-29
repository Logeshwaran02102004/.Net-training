using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    internal class Internalfeatures
    {
        // features ...net 2.0 3.0 3.5 4x...
        public void NullableDemo()
        {
            // feature : working with null
            // nullable types are achived using ? symbol
            // very widely used in database programming

            string name = null; // valid
            int? age = 21; // not valid

            if (age.HasValue)
            {
                // print this if its not null
                Console.WriteLine(age.Value);

            }
            else
            {// prints this if its null
                Console.WriteLine("age is null");
            }



        }


        public void GlobalNsDemo()
        {
            // feature : working with namespaces
            // how do u call hi method?
            // using global namespace u can call the class
            // which is present in outside the current namespace
            c1 ob = new c1();
            ob.Display();

            // search outside the namespace
            global::c1 ob2 = new global::c1();
            ob2.Hi();

        }

        public void inlinedemo()
        {
            // feature : working with warning message
            // how do i remove warning message?
#pragma warning disable // warning is disabled
            int x;
            int y;
#pragma warning restore // warning is restored
            int z;


        }
        public void ExtensionDemo()
        {
            // feature : creating custom method to built in types

            // string s = "Hello";
            // does it starts with h or not?
            // is it in uppercase or not?

            // condition : 1. class and method is static
            //             2. method has to take atleast 1 parameter
            int x = 11;
            Console.WriteLine(x.IsEven());

        }


        public void propertyDemo()
        {
            // feature: best way to initialize property
            // object initializer
            students s1 = new students()
            {
                studentid = 100,
                studentname = "Deepa",
                TotalMarks = 90
            };

            Console.WriteLine($"{s1.studentid} {s1.studentname}  {s1.TotalMarks}");

        }

        public void PartialDemo()
        {

            // features :  how to keep methods in sepereate files?
            //benefit:
            //team members can work simultenosly with there respective files



        }
        public void CollectionDemo()
        {
            // feature: easy and best way to initialise List

            //List<students> s1 = new List<students>();
            //students ob1 = new students();
            //ob1.studentid = 100;
            //ob1.studentname = "Ravi";
            //ob1.TotalMarks = 78;

            //students ob2 = new students();
            //ob2.studentid = 200;
            //ob2.studentname = "Pooja";
            //ob2.TotalMarks = 80;

            //students ob3 = new students()
            //{
            //    studentid = 300,
            //    studentname = "Deepa",
            //    TotalMarks = 90
            //};

            //s1.Add( ob1 );
            //s1.Add( ob2 );
            //s1.Add(ob3);
            //s1.Add(new students() { studentid=400, studentname="Karthik" , TotalMarks=93 });


            // collection initializer

            List<students> s1 = new List<students>()
            {
                new students() { studentid=100, studentname="Karthik" , TotalMarks=93 },
                new students() { studentid=200, studentname="Deepa" , TotalMarks=95 },
                new students() { studentid=300, studentname="Pooja" , TotalMarks=90 },
                new students() { studentid=400, studentname="Ravi" , TotalMarks=96 },
              };
            foreach (var item in s1)
            {
                Console.WriteLine($"{item.studentid} {item.studentname}  {item.TotalMarks}");
            }




        }

    }


    static class myclass
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;

        }

    }

    class students
    {
        public int studentid { get; set; }
        public string studentname { get; set; }
        public int TotalMarks { get; set; }


    }

}

