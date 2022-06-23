using System;
using System.Collections.Generic;
using System.Text;

namespace TechicalTask.Model
{
    class Player
    {
        private Inventory _inventory;

        public Player(Inventory inventory)
        {
            _inventory = inventory;
        }

        public Inventory playerInventory => _inventory;

        public void TakeItem(Table table, int ID)
        {
            _inventory.AddItem(table.ItemsOnTable[ID]);
            table.RemoveItem(ID);
            
        }

    }
}
