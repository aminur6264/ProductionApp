using Microsoft.AspNetCore.Mvc;
using ProductionApp.BLL;
using ProductionApp.Models;
using ProductionApp.ViewModels;
using System.Collections.Generic;
using System.Linq;

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
            ProductEntryVM product = new ProductEntryVM();
            return View(product);
        }

        [HttpPost]
        public IActionResult AddOrUpdate(ProductEntryVM productEntry)
        {
            new ProductBLL().AddrUpdate(productEntry);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetProductsByName(string name)
        {
            List<Product> products = new ProductBLL().GetAll();
            if (name != null && name.Trim().Length > 0)
                products = products.Where(x => x.Name.Contains(name)).ToList();
            var result = products.Select(x => new
            {
                Label = x.Name,
                Id = x.Id
            }).ToList();
            return Json(result);
        }
    }
}
