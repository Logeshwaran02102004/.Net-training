using MvcApplicationPrj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationPrj.Controllers
{
    public class CodeController : Controller
    {
        NorthwindDbEntities db = new NorthwindDbEntities();


        // 1️ Action method to return all customers residing in Germany
        public ActionResult GermanCustomers()
        {
            var customers = db.Customers
                              .Where(c => c.Country == "Germany")
                              .ToList();

            return View(customers);
        }

        // 2️ Action method to return customer details with an orderId==10248
        public ActionResult CustomerByOrder()
        {
            var customer = (from o in db.Orders
                            where o.OrderID == 10248
                            select o.Customer)
                            .FirstOrDefault();

            return View(customer);
        }
    }
}
   