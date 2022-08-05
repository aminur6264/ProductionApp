using ProductionApp.DAL;
using ProductionApp.Models;
using System;
using System.Collections.Generic;

namespace ProductionApp.BLL
{
    public class IngredientBLL
    {
        internal List<Ingredient> GetAll()
        {
            return new IngredientDAL().GetAll();
        }
    }
}
