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
    }
}
