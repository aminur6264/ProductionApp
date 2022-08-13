using ProductionApp.DAL;
using ProductionApp.Models;
using ProductionApp.ViewModels;
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

        internal List<IngredientListVM> GetIngredientsByPdorductid(int productid)
        {
            return new IngredientDAL().GetIngredientsByPdorductid(productid);
        }
    }
}
