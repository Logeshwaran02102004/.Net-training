using System.Linq;
using System.Web.Http;

namespace OrdersWebApi.Controllers
{

    public class OrdersController : ApiController
    {
        NorthwindDbEntities db = new NorthwindDbEntities();

        // id 5 deatails
        public IHttpActionResult GetOrdersByEmployee()
        {
            var orders = db.Orders.Where(o => o.EmployeeID == 5).
                Select(o => new { o.OrderID, o.OrderDate }).ToList();
            return Ok(orders);
        }
    }
}
