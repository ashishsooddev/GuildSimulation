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

        void Act();
        void PrintDetails();
        void Speak();
    }

    public class Character : ICharacter
    {
        public string Name { get; private set; }
        public string Archetype { get; private set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Strength { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }
        public Character(string name, string archetype, int health, int defense, int speed, int strength, int intellect, int agility)
        {
            Name = name;
            Archetype = archetype;
            Health = health;
            Defense = defense;
            Speed = speed;
            Strength = strength;
            Intellect = intellect;
            Agility = agility;
        }
        public virtual void Act()
        {
            Console.WriteLine($"{Name} investigates strange lights around Hawkkins.");
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} says: Friends Don't Lie. ");
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Hawkins Character Profile");
            Console.WriteLine($"Name: {Name} [{Archetype}]");
            Console.WriteLine($"Health: {Health} | Defense: {Defense} | Speed: {Speed}");
            Console.WriteLine($"Strength: {Strength} | Intellect: {Intellect} | Agility: {Agility}");
        }
    }
 }
