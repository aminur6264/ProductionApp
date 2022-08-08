using Dapper;
using ProductionApp.Models;
using ProductionApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ProductionApp.DAL
{
    public class ProductDAL
    {
        internal List<Product> GetAll()
        {
            List<Product> result = new List<Product>();
            using (var connection = new SqlConnection(Connections.GetConnectionString()))
            {
                var sql = @"SELECT [Id] ,[Name] FROM [Products]";
                result = connection.Query<Product>(sql).ToList();
            }

            return result;
        }

        internal void AddrUpdate(ProductEntryVM product)
        {
            int productId = 0;

            if (product.Product != null && product.Product.Id == 0)
            {
                
                try
                {
                    var sql = @"INSERT INTO [Products](Name) VALUES(@Name); SELECT SCOPE_IDENTITY()";
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Name", product.Product.Name.Trim());
                    using (var connection = new SqlConnection(Connections.GetConnectionString()))
                    {
                        productId = connection.Query<int>(sql, parameters).FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {

                }

            }

            if (product.Ingredients != null && product.Ingredients.Count > 0)
            {
                foreach (var item in product.Ingredients)
                {
                    var sql = @"INSERT INTO [dbo].[ProductIngredients] ([ProductId] ,[IngredientId]) VALUES (@ProductId, @IngredientId)";
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@ProductId", productId);
                    parameters.Add("@IngredientId", item.Id);

                    using (var connection = new SqlConnection(Connections.GetConnectionString()))
                    {
                        connection.Execute(sql, parameters);
                    }
                }
               
            }
        }
    }
}
