using Microsoft.AspNetCore.Mvc;

namespace ProductionApp.Controllers
{
    public class DatatableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
