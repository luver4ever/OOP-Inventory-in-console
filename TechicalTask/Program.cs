using System;
using TechicalTask.DataBase;
using TechicalTask.Model;
using TechicalTask.View;

namespace TechicalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemBase itemBase = new ItemBase();

            Inventory inventory = new Inventory();
            Player player = new Player(inventory);

            Table table = new Table(itemBase.GetAllItems);

            TableView _tableView = new TableView(table);
            InventoryView inventoryView = new InventoryView(player.playerInventory);

            while(true)
            {
                Console.WriteLine("1. посмотреть стол");
                Console.WriteLine("2. посмотреть инвентарь");

                var choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        _tableView.ShowAllItemsOnTable();

                        if (table.ItemsOnTable.Count != 0)
                            Console.WriteLine("Желаете что-то взять?");
                        else
                            break;

                        var itemId = Convert.ToInt32(Console.ReadLine());

                        if (itemId <= table.ItemsOnTable.Count && itemId >= 0)
                            player.TakeItem(table, itemId - 1);
                        else
                            Console.WriteLine("Такого выбора нет!");

                        break;
                    case 2:
                        inventoryView.ShowItemsInInventory();
                        break;
                    default:
                        Console.WriteLine("Такого выбора нет!");
                        break;
                }

            }

        }
    }
}
