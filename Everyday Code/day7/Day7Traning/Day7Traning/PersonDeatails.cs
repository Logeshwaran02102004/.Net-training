using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Day7Traning
{

    public sealed class personDeatails
    {
        public string Email {  get; set; }
        public string lockNumber {  get; set; }
        public string gendricPassword {  get; set; }

        public void getPersonDeatails()
        {
            Console.WriteLine("enter the email , locknumber , gendricpassword");
            Email=Console.ReadLine();
            lockNumber=Console.ReadLine();
            gendricPassword=Console.ReadLine();
            Console.WriteLine("Email :" + Email);
            Console.WriteLine("Lock number :" + lockNumber);
            Console.WriteLine("gendric password :"+gendricPassword);
        }
    }   
    internal class PersonDeatails
    {
    }
}
