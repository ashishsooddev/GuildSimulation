using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildSimulation.Entities
{
    public static class CharacterFactory
    {
        public static ICharacter CreateCharacter(string choice, string name)
        {
            switch (choice.ToUpper())
            {
                case "PARTY MEMBER":
                case "PARTY":
                    return new Character(name, "Party Member", 90, 10, 12, 8, 14, 12);

                case "HAWKINS POLICE":
                case "POLICE":
                    return new Character(name, "Hawkins Police", 120, 14, 8, 14, 8, 8);

                case "EXPERIMENT":
                case "LAB EXPERIMENT":
                    return new Character(name, "Lab Experiment", 80, 6, 10, 6, 16, 10);

                default:
                    return new Character(name, "Hawkins Local", 100, 10, 10, 10, 10, 10);
            }
        }
    }
}