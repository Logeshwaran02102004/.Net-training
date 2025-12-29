using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6training
{
    interface IPaymentMethods 
    {
        void getcreditCard();
        void DisplayCreditCardDeatails();
        void getUpiDeatails();
        void DiaplayUpiDeatails();
        void getWalletDeatails();
        void DisplayWalletDeatails();
    }

    public class Payment : IPaymentMethods
    {
        public int Credictcardnumber;
        public string Bankname;
        private int CredictPassword;
        public int Upinumber;
        private int UPIpassword;
        public string Wallet;

        public void getcreditCard()
        {
            Console.WriteLine("Enter the credict card number : ");
            Credictcardnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the bank Name : ");
            Bankname= Console.ReadLine();
            Console.WriteLine("Enter The Password : ");
            CredictPassword= Convert.ToInt32(Console.ReadLine());   
        }

        public void DisplayCreditCardDeatails()
        {
            Console.WriteLine("The credict Card number is : " + Credictcardnumber);
            Console.WriteLine("The bank Name is : " + Bankname);
            Console.WriteLine("The Password is : " + CredictPassword);
        }

        public void getUpiDeatails()
        {
            Console.WriteLine("Enter the Upi Number : ");
            Upinumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Password : ");
            UPIpassword = Convert.ToInt32(Console.ReadLine());
        }

        public void DiaplayUpiDeatails()
        {
            Console.WriteLine("The upi number is : " + Upinumber);
            Console.WriteLine("The password is : " + UPIpassword);
        }

        public void getWalletDeatails()
        {
            Console.WriteLine("Please enter Cash on delivery ");
            Wallet = Console.ReadLine();
        }

        public void DisplayWalletDeatails()
        {
            Console.WriteLine("The enetred deatails is : " + Wallet);
        }

    }
    internal class assesmentday6
    {
    }
}
