using System;
using System.Collections.Generic;
using InventorySystem.Models;

namespace InventorySystem.Users
{
    public class Admin
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        private List<Product> Inventory { get; set; }
        private List<Supplier> Suppliers { get; set; }
        private List<Employee> Employees { get; set; }

        public Admin()
        {
            Inventory = new List<Product>();
            Suppliers = new List<Supplier>();
            Employees = new List<Employee>();
        }

        public void AddProduct(Product product)
        {
            if (IsAdmin())
            {
                Inventory.Add(product);
            }
            else
            {
                Console.WriteLine("Error: Only admin can add products.");
            }
        }

        public void UpdateInventory(Product product, int quantity)
        {
            if (IsAdmin())
            {
                product.StockQuantity += quantity;
            }
            else
            {
                Console.WriteLine("Error: Only admin can update inventory.");
            }
        }

        public void DeleteProduct(Product product)
        {
            if (IsAdmin())
            {
                Inventory.Remove(product);
            }
            else
            {
                Console.WriteLine("Error: Only admin can delete products.");
            }
        }

        public void AddSupplier(Supplier supplier)
        {
            if (IsAdmin())
            {
                Suppliers.Add(supplier);
            }
            else
            {
                Console.WriteLine("Error: Only admin can add suppliers.");
            }
        }

        public void DeleteSupplier(Supplier supplier)
        {
            if (IsAdmin())
            {
                Suppliers.Remove(supplier);
            }
                else
        {
            Console.WriteLine("Error: Only admin can delete suppliers.");
        }
    }

    public void AddEmployee(Employee employee)
    {
        if (IsAdmin())
        {
            Employees.Add(employee);
        }
        else
        {
            Console.WriteLine("Error: Only admin can add employees.");
        }
    }

    public void DeleteEmployee(Employee employee)
    {
        if (IsAdmin())
        {
            Employees.Remove(employee);
        }
        else
        {
            Console.WriteLine("Error: Only admin can delete employees.");
        }
    }

    private bool IsAdmin()
    {
        // Implement authentication logic here
        return Username == "admin" && Password == "password";
    }
}
}