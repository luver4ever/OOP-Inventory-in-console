using System;
using System.Collections.Generic;
using System.Text;

namespace TechicalTask.Model
{
    class Table
    {
        private List<Item> _itemsOnTable = new List<Item>();

        public Table(List<Item> itemsOnTable)
        {
            _itemsOnTable = itemsOnTable;
        }

        public List<Item> ItemsOnTable => _itemsOnTable;

        public void RemoveItem(int index)
        {
            _itemsOnTable.Remove(_itemsOnTable[index]);
        }
    }
}
