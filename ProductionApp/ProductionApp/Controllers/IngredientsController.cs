using Microsoft.AspNetCore.Mvc;
using ProductionApp.BLL;
using ProductionApp.Models;
using ProductionApp.ViewModels;
using System.Collections.Generic;
using System.Linq;

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

        [HttpGet]
        public IActionResult GetIngredientsByName(string name)
        {
            List<Ingredient> allIngredients = new IngredientBLL().GetAll();
            if (name != null && name.Trim().Length > 0)
                allIngredients = allIngredients.Where(x => x.Name.Contains(name)).ToList();
            var result = allIngredients.Select(x => new
            {
                Label = x.Name,
                Id = x.Id
            }).ToList();
            return Json(result);
        }

        public IActionResult GetAllIngredientsById(int productid)
        {
            List<IngredientListVM> ingredients = new IngredientBLL().GetIngredientsByPdorductid(productid);
            return Json(ingredients);
        }

    }
}
