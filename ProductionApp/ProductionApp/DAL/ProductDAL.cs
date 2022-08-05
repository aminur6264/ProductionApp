using Dapper;
using ProductionApp.Models;
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
    }
}
