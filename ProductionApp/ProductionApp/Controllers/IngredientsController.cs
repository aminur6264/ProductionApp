using Microsoft.AspNetCore.Mvc;
using ProductionApp.BLL;
using ProductionApp.Models;
using System.Collections.Generic;

namespace ProductionApp.Controllers
{
    public class IngredientsController : Controller
    {
        public IActionResult Index()
        {
            List<Ingredient> allIngredients = new IngredientBLL().GetAll();
            return View(allIngredients);
        }

        [HttpGet]
        public IActionResult AddOrUpdate()
        {

            return View();
        }
    }
}
