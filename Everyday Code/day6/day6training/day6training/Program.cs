using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6training
{

    class StudentMarks
    {
        private int[] marks = new int[5];
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= marks.Length)
                {
                    Console.WriteLine("invalid index returning:");
                    return -1;
                }
                return marks[index];
            }
            set
            {
                if (index < 0 || index >= marks.Length)
                {
                    Console.WriteLine("invalid index cannot set value   ");
                }
                else
                {
                    marks[index] = value;
                }
            }
        }

            public void DisplayMarks()
        {
            Console.WriteLine("Marks od students are :");
            for(int i = 0; i < marks.Length; i++) {
                Console.WriteLine($"student {i + 1}:{marks[i]}");
        }
        }
    }

   
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   // this is for executing the above one
            StudentMarks studentMarks = new StudentMarks();
            //Console.WriteLine(studentMarks[1]);
            studentMarks[0] = 100;
            studentMarks[1] = 90;
            studentMarks[2] = 98;
            studentMarks[3] = 73;
            studentMarks[4] = 93;
            studentMarks[5] = 83;//should display an error message

            studentMarks.DisplayMarks();
            */
            /* // employee list deatails 
            employeelist_indexdemo employeelist = new employeelist_indexdemo();
            Console.WriteLine($"the eployee name:{employeelist[1]}");
            employeelist[2] = "dileep";
            Console.WriteLine("the employee name :"+employeelist[2]);
            */




            /*
            //this is for multilevel inheritance 
            professor profess = new professor();
            profess.name = "logesh";
            profess.course = "Java";
            profess.ShowName();
            profess.ShowCourse();
            profess.ConductReseach();
            //Console.WriteLine(studentMarks[1]);
            */

            /*
            // this is for multiple inheritance
            customer cus= new customer();
            cus.getproductInfo();
            cus.getReviews();
            Console.WriteLine("========product deatails and customer reviews======");
            cus.DisplayInfo();
            cus.DisplayReviews();
            */

            Payment payment = new Payment();
            payment.getcreditCard();
            payment.DisplayCreditCardDeatails();
            payment.getUpiDeatails();
            //payment.

        }
    }
}
