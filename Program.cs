using System;
using System.Collections.Generic;
using InventorySystem.Models;
using InventorySystem.Users;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new admin
            Admin admin = new Admin
            {
                Username = "admin",
                Password = "password"
            };

            // Create a new supplier and add it to the inventory system
            Supplier supplier = new Supplier
            {
                Id = 1,
                Name = "ABC Supplier",
                Address = "123 Main St",
                Phone = "555-1234"
            };
            admin.AddSupplier(supplier);
            Console.WriteLine($"Added supplier: {supplier.Name}");

            // Create a new product and assign the supplier
            Product product = new Product
            {
                Id = 1,
                Name = "Widget",
                Price = 9.99M,
                StockQuantity = 100,
                Supplier = supplier
            };
            admin.AddProduct(product);
            Console.WriteLine($"Added product: {product.Name}");

            // Create a new employee and add it to the inventory system
            Employee employee = new Employee
            {
                Username = "Roy",
                Password = "password"
            };
            admin.AddEmployee(employee);
            Console.WriteLine($"Added employee: {employee.Username}");

            // The employee can search for a product by name
            // List<Product> searchResults = employee.SearchProduct("Widget");
            // Console.WriteLine("Search Results:");
            // foreach (Product p in searchResults)
            // {
            //     Console.WriteLine(p.Name);
            // }

            // The admin can update the inventory
            admin.UpdateInventory(product, 50);
            Console.WriteLine($"Updated inventory for product {product.Name} to {product.StockQuantity}");

            // The admin can delete a product from the inventory
            admin.DeleteProduct(product);
            Console.WriteLine($"Deleted product: {product.Name}");

            // The admin can delete a supplier from the inventory
            admin.DeleteSupplier(supplier);
            Console.WriteLine($"Deleted supplier: {supplier.Name}");

            // The admin can delete an employee from the inventory
            admin.DeleteEmployee(employee);
            Console.WriteLine($"Deleted employee: {employee.Username}");
        }
    }
}
