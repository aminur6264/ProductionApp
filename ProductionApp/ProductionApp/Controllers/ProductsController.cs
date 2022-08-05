using Microsoft.AspNetCore.Mvc;
using ProductionApp.BLL;
using ProductionApp.Models;
using System.Collections.Generic;

namespace ProductionApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new ProductBLL().GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult AddOrUpdate()
        {

            return View();
        }
    }
}
