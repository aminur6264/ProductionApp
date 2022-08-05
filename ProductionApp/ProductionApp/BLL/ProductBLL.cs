using ProductionApp.DAL;
using ProductionApp.Models;
using System;
using System.Collections.Generic;

namespace ProductionApp.BLL
{
    public class ProductBLL
    {
        internal List<Product> GetAll()
        {
            return new ProductDAL().GetAll();
        }
    }
}
