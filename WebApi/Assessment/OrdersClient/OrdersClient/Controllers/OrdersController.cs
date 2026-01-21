using Newtonsoft.Json;
using OrdersClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace OrdersClient.Controllers
{
    public class OrdersController : Controller
    {
        public ActionResult DisplayOrders()
        {
            IEnumerable<Order> orderList = null;

            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44305//api/");
                var responsetalk = webclient.GetAsync("Orders");
                responsetalk.Wait();

                var result = responsetalk.Result;
                if (result.IsSuccessStatusCode)
                {
                    var resultdata = result.Content.ReadAsStringAsync().Result;
                    orderList = JsonConvert.DeserializeObject<List<Order>>(resultdata);
                }
                else
                {
                    orderList = Enumerable.Empty<Order>();
                }

                return View(orderList);
            }
        }
    }
}