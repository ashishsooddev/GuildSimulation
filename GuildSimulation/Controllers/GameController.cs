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

    }
}
