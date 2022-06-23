using System;
using System.Collections.Generic;
using System.Text;
using TechicalTask.Model;

namespace TechicalTask.View
{
    class TableView
    {
        private Table _table;

        public TableView(Table table)
        {
            _table = table;
        }

        public void ShowAllItemsOnTable()
        {
            if (_table.ItemsOnTable.Count == 0)
                Console.WriteLine("На столе ничего нет!");

            int i = 1;
            foreach (var item in _table.ItemsOnTable)
                Console.WriteLine($"На столе есть {i++}. {item.Name}");
        }
    }
}
