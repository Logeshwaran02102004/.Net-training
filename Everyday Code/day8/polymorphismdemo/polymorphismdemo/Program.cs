using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            // this is for polymorphism demo 
            Deatails deatails = new Deatails();
            deatails.getemployeeInfo(12);
            deatails.getemployeeInfo("logesh");
            deatails.getemployeeInfo(12,"isma");
            deatails.getemployeeInfo("prathees",124);
            */

            /*
            //this is for cashondelivery , credictcardpayment, paymentmethods ...
            paymentmethod credictpayment = new credictcardpayment();
            credictpayment.processpayment(3000);
            credictpayment.samplePayment();
            Console.WriteLine(credictpayment.Provider);
            paymentmethod cashdeliver = new cashondeliver();
            cashdeliver.processpayment(7000);
            */


            /*
            // this is for sealedclass 
            electriccar electric = new electriccar();
            electric.start();
            */

            /*
            //this is for assignment simple interest 
            assignmentday8 assign = new assignmentday8();
            assign.Calculateinterest(3000, 5);
            assign.Calculateinterest(3000, 5,2);
            assign.Calculateinterest(3000, 5,2,2);
            */

            /*
            //this is for assignment 2
            assignment2day8 assign = new assignment2day8();
            assign.Checkout(100);
            assign.Checkout(100, 2);
            assign.Checkout("ASDF123");
            assign.Checkout(100, 2, "ASDF123");
            */

            Assignment3day8 assig=new Assignment3day8();
            assig.Logmessage("logesh");
            assig.Logmessage("prathees", 2);
            assig.Logmessage("waseef", "02-10-2025 12:00");
            assig.Logmessage("logg", 5,"03-10-2025 1:00");

            Console.ReadLine();
        }
    }
}
