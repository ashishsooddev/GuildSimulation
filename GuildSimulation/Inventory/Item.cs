using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildSimulation.Inventory
{
    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int UtilityValue { get; set; }

        public Item(string name, string type, int utilityValue)
        {
            Name = name;
            Type = type;
            UtilityValue = utilityValue;
        }

        public void DisplayItem()
        {
            Console.WriteLine($"{Name} ({Type}) Utility Rating: {UtilityValue}");
        }
    }
}
