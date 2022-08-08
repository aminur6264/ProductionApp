using ProductionApp.Models;
using System.Collections.Generic;

namespace ProductionApp.ViewModels
{
    public class ProductEntryVM
    {
        public Product Product { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
