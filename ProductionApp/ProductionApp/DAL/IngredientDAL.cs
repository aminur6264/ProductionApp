using Dapper;
using ProductionApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ProductionApp.DAL
{
    public class IngredientDAL
    {
        internal List<Ingredient> GetAll()
        {
            List<Ingredient> result = new List<Ingredient>();
            using (var connection = new SqlConnection(Connections.GetConnectionString()))
            {
                var sql = @"SELECT [Id] ,[Name] FROM [Ingredients]";
                result = connection.Query<Ingredient>(sql).ToList();
            }

            return result;
        }
    }
}
