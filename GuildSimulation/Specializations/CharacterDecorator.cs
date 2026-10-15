using GuildSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildSimulation.Specializations
{
    public abstract class CharacterDecorator : ICharacter
    {
        protected ICharacter _character;
        protected CharacterDecorator(ICharacter character)
        {
            _character = character;
        }
        public virtual string Name => _character.Name;
        public virtual string Archetype => _character.Archetype;

        public virtual int Health
        {
            get => _character.Health;
            set => _character.Health = value;
        }
        public virtual int Defense
        {
            get => _character.Defense;
            set => _character.Defense = value;
        }
        public virtual int Speed
        {
            get => _character.Speed;
            set => _character.Speed = value;
        }
        public virtual int Strength
        {
            get => _character.Strength;
            set => _character.Strength = value;
        }
        public virtual int Intellect
        {
            get => _character.Intellect;
            set => _character.Intellect = value;
        }
        public virtual int Agility
        {
            get => _character.Agility;
            set => _character.Agility = value;
        }
        public virtual void Act()
        {
            _character.Act();
        }

        public virtual void Speak()
        {
            _character.Speak();
        }

        public virtual void PrintDetails()
        {
            _character.PrintDetails();
        }
    }

        public class TelekineticDecorator : CharacterDecorator
        {
            public TelekineticDecorator(ICharacter character) : base(character)
            {
                Intellect += 20;
                PsychicEnergy = 100;
            }

            public int PsychicEnergy { get; private set; }

            public override void Act()
            {
                Console.WriteLine($"{Name} focuses their mind, levitating objects with telekinetic power!");
            }

            public override void Speak()
            {
                Console.WriteLine($"{Name} whispers: 'I can move things with my mind.'");
            }

            public override void PrintDetails()
            {
                base.PrintDetails();
                Console.WriteLine($"[Specialization: Telekinetic -> Psychic Boost Applied -> Psychic Energy: {PsychicEnergy}]");
            }
        }
}
