using Dapper;
using ProductionApp.Models;
using ProductionApp.ViewModels;
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

        internal List<IngredientListVM> GetIngredientsByPdorductid(int productid)
        {
            List<IngredientListVM> result = new List<IngredientListVM>();
            using (var connection = new SqlConnection(Connections.GetConnectionString()))
            {
                var sql = @"SELECT 
	                             ROW_NUMBER() OVER(ORDER BY PIS.Id) SL
	                            ,PIS.[Id] IngredientId
                                ,PIS.[ProductId] ProductId
                                ,IGS.Name IngredientName
	                            ,PS.Name ProductName
                            FROM [ProductIngredients] PIS
                            JOIN Ingredients IGS ON IGS.Id = PIS.IngredientId
                            JOIN Products PS ON PS.Id = PIS.ProductId
                            WHERE ProductId = '"+ productid + "'";
                result = connection.Query<IngredientListVM>(sql).ToList();
            }

            return result;
        }
    }
}
