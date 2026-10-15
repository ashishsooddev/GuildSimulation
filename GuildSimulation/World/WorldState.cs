using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildSimulation.World
{
    public class WorldState
    {
        private static readonly WorldState _instance = new WorldState();
        public int Day { get; set; }
        public int GuildGold { get; set; }
        public string ActiveQuest { get; set; }

        private WorldState()
        {
            Day = 1;
            GuildGold = 500;
            ActiveQuest = "Strange Magnetic Interference at Hawkins Lab";
        }
        public static WorldState Instance => _instance;

        public void AdvanceDay()
        {
            Day++;
            GuildGold += 100;
        }
        public void DisplayWorldStatus()
        {
            Console.WriteLine("Hawkins World State");
            Console.WriteLine($"Current Guild Day: {Day}");
            Console.WriteLine($"Guild Treasury: {GuildGold} Gold");
            Console.WriteLine($"Active Quest: {ActiveQuest}");
        }
    }
}
