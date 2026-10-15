using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildSimulation.Entities
{
    public interface ICharacter 
    {
        string Name { get; }
        string Archetype {  get; }
        int Health { get; set; }
        int Defense {  get; set; }
        int Speed {  get; set; }
        int Strength {  get; set; }
        int Intellect {  get; set; }
        int Agility {  get; set; }

    }

}
