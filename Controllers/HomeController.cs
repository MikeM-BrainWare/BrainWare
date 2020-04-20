using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View(GetOrders());
        }

        public IEnumerable<Order> GetOrders(int id = 1)
        {
            var data = new OrderContext();

            return data.GetOrdersForCompany(id);
        }
    }
}
