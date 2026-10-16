using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildSimulation.Inventory
{
    public class InventoryFacade
    {
        private List<Item> _items;

        public InventoryFacade()
        {
            _items = new List<Item>
            {
                new Item("Walkie-Talkie", "Communication", 85),
                new Item("Wrist-Rocket Slingshot", "Weapon", 60),
                new Item("Box of Eggo Waffles", "Consumable", 50),
                new Item("Super-Powered Flashlight", "Tool", 70)
            };
        }

        public void AddItem(string name, string type, int utilityValue)
        {
            _items.Add(new Item(name, type, utilityValue));
            Console.WriteLine($"Successfully added {name} to Hawkins supply stash.");
        }

        public void RemoveItem(string name)
        {
            Item target = null;
            foreach (Item item in _items)
            {
                if (item.Name.ToLower() == name.ToLower())
                {
                    target = item;
                    break;
                }
            }

            if (target != null)
            {
                _items.Remove(target);
                Console.WriteLine($"Successfully removed {name} from supply stash.");
            }
            else
            {
                Console.WriteLine($"Item {name} was not found in stash.");
            }
        }

        public void SearchItem(string name)
        {
            Item target = null;

            foreach (Item item in _items)
            {
                if (item.Name.ToLower() == name.ToLower())
                {
                    target = item;
                    break;
                }
            }

            if (target != null)
            {
                Console.WriteLine($"Found Stash Item: {target.Name} | Type: {target.Type} | Utility Rating: {target.UtilityValue}");
            }
            else
            {
                Console.WriteLine($"Item {name} could not be located in the stash.");
            }
        }

        public void ListAllItems()
        {
            Console.WriteLine("HAWKINS PARTY SUPPLY STASH");
            if (_items.Count == 0)
            {
                Console.WriteLine("The supply stash is completely empty.");
            }
            else
            {
                foreach (var item in _items)
                {
                    item.DisplayItem();
                }
            }
            Console.WriteLine();
        }
    }
}
