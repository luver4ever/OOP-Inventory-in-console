using System;
using System.Collections.Generic;
using System.Text;

namespace TechicalTask.Model
{
    class Inventory
    {
        private List<Item> _items = new List<Item>();

        public List<Item> ItemsInInventory => _items;

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

    }
}
