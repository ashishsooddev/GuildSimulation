using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildSimulation.Entities;
using GuildSimulation.Inventory;
using GuildSimulation.Specializations;
using GuildSimulation.World;

namespace GuildSimulation.Controllers
{
    public class GameController
    {
        private List<ICharacter> _partyMembers;
        private InventoryFacade _inventoryFacade;
        private bool _isRunning;

        public GameController()
        {
            _partyMembers = new List<ICharacter>();
            _inventoryFacade = new InventoryFacade();
            _isRunning = true;
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the Hawkins Investigation Simulator!");

            while (_isRunning)
            {
                DisplayMenu();
                string input = Console.ReadLine();
                Console.WriteLine();

                HandleMenuChoice(input);

                if (_isRunning)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        private void DisplayMenu()
        {
            WorldState.Instance.DisplayWorldStatus();
            Console.WriteLine("\n HAWKINS CONTROL MENU");
            Console.WriteLine("1. View Hawkins Party Roster");
            Console.WriteLine("2. Recruit New Resident");
            Console.WriteLine("3. Assign Specialization (Decorator)");
            Console.WriteLine("4. Simulate Resident Actions");
            Console.WriteLine("5. Manage Supply Stash");
            Console.WriteLine("6. Advance Day (Increase Upside Down Threat)");
            Console.WriteLine("7. Exit Simulation");
            Console.Write("Select an option (1-7): ");
        }

        private void HandleMenuChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    ViewRoster();
                    break;
                case "2":
                    RecruitCharacter();
                    break;
                case "3":
                    AssignSpecialization();
                    break;
                case "4":
                    SimulateActions();
                    break;
                case "5":
                    ManageInventory();
                    break;
                case "6":
                    WorldState.Instance.AdvanceDay();
                    Console.WriteLine("A new day arrives in Hawkins. The Upside Down grows stronger.");
                    break;
                case "7":
                    _isRunning = false;
                    Console.WriteLine("Shutting down simulation. Stay safe in Hawkins!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 7.");
                    break;
            }
        }

    }
}
