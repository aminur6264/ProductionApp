using Microsoft.AspNetCore.Mvc;

namespace ProductionApp.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
