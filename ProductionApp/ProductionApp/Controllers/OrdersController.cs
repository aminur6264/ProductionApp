using Microsoft.AspNetCore.Mvc;
using ProductionApp.Models;
using System.Collections.Generic;

namespace ProductionApp.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            List<Order> orders = new List<Order>()
            {
                new Order(){Id = 1,CustomerAddress = "Dhaka",CustomerName = "Aminur",CreateOn=System.DateTime.UtcNow},
                new Order(){Id = 1,CustomerAddress = "Nilphamari",CustomerName = "Ratul",CreateOn=System.DateTime.UtcNow},
                new Order(){Id = 1,CustomerAddress = "Kurigram",CustomerName = "Habib",CreateOn=System.DateTime.UtcNow},
                new Order(){Id = 1,CustomerAddress = "Dinajpur",CustomerName = "Khushi",CreateOn=System.DateTime.UtcNow}
            };
            return View(orders);
        }
        public IActionResult AddOrUpdate()
        {
            return View();
        }
    }
}
