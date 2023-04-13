using System.Collections.Generic;
using InventorySystem.Models;

namespace InventorySystem
{
    public static class InventorySystem
    {
        public static List<Product> Inventory { get; set; }

        static InventorySystem()
        {
            Inventory = new List<Product>();
        }
    }
}
