using System;

namespace ProductionApp.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductIngredient
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int IngredientId { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime CreateOn { get; set; }
    }

    public class OrderProduct
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int TotalIngredients { get; set; }
    }

    public class OrderIngredient
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int IngredientId { get; set; }
        public int Total { get; set; }
    }

}
