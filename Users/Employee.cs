using System.Collections.Generic;
using System.Linq;
using InventorySystem.Models;


namespace InventorySystem.Users
{
    public class Employee
    {
        public string? Username { get; set; }
        public string? Password { get; set; }

        public void PlaceOrder(Product product, int quantity)
        {
            product.StockQuantity -= quantity;
        }

        public List<Product> SearchProduct(string name)
{
    // In a real application, this would likely query a database or other data source
    if (InventorySystem.Inventory != null)
    {
        return InventorySystem.Inventory
            .Where(p => p.Name != null && p.Name.Contains(name))
            .ToList();
    }
    else
    {
        return new List<Product>();
    }
}

    }
}

