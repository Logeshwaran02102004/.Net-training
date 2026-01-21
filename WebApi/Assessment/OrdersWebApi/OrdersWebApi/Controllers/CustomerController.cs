using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace OrdersWebApi.Controllers
{
    public class CustomerController : ApiController
    {
        NorthwindDbEntities db = new NorthwindDbEntities();

        public IHttpActionResult GetCustomersByCountry(string country)
        {
            var customers = db.GetCustomersByCountry(country).ToList();
            return Ok(customers);
        }
    }
}