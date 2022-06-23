using System;
using System.Collections.Generic;
using System.Text;
using TechicalTask.Model;

namespace TechicalTask.View
{
    class InventoryView
    {
        private Inventory _inventory;

        public InventoryView(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void ShowItemsInInventory()
        {
            foreach (var item in _inventory.ItemsInInventory)
                Console.WriteLine($"У вас есть {item.Name}");
        }
    }
}
