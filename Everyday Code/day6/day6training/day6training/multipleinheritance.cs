using day6training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6training
{
    interface IProduct
    {

        void getproductInfo();
        void DisplayInfo();
     }
    interface IReview
    {
        void getReviews();
        void DisplayReviews();
    }


    public class customer : IProduct,IReview
    {

        public int productId { get; set; }
        public string productName { get; set; }
        public double Price { get; set; }
        public int ReviewId { get; set; }
        
        public string comments { get; set; }
        public int Ratings { get; set; }
        public int ProductId { get; set; }


    public void getproductInfo()
    {
        Console.WriteLine("enter the productID,ProductName,price ");
        productId = Convert.ToInt32(Console.ReadLine());
        productName = Console.ReadLine();
        Price = Convert.ToDouble(Console.ReadLine());
    }


    public void DisplayInfo()
    {
        Console.WriteLine("product Id :" + productId);
        Console.WriteLine("product name :" + productName);
        Console.WriteLine("price :" + Price);
    }


    public void getReviews()
    {
        Console.WriteLine("enter the productId,rating,comments");
        ProductId=Convert.ToInt32(Console.ReadLine());
        Ratings = Convert.ToInt32(Console.ReadLine());
        comments = Console.ReadLine();
        
        ReviewId++;

    }
    

    public void DisplayReviews()
    {
        Console.WriteLine("Review Id :" + ReviewId);
        Console.WriteLine("product Id : " + ProductId);
        Console.WriteLine("comments : " + comments);
        Console.WriteLine("Rating : " + Ratings);
    }
        internal class multipleinheritance
        {
        }
    }
}
