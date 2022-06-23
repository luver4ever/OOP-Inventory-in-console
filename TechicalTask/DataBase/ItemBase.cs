using System;
using System.Collections.Generic;
using System.Text;
using TechicalTask.Model;

namespace TechicalTask.DataBase
{
    class ItemBase
    {
        private readonly List<Item> _allItems = new List<Item>();

        public ItemBase()
        {
            // Не стал допиливать чтение из файла! В Юнити бы сделал это через ScriptableObject
            Item amulet = new Item("Амулет");
            Item coins = new Item("33 Монеты");
            Item book = new Item("Книга");
            _allItems.Add(amulet);
            _allItems.Add(coins);
            _allItems.Add(book);
        }
        public List<Item> GetAllItems => _allItems;
    }
}
