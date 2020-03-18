using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Inheritance_GameObjects
{
    public class Weapon : GameObject
    {
        public enum WeaponType
        {
            NONE,
            MELEE,
            RANGED,
            DEFENSIVE
        }

        public WeaponType WeaponTypeName { get; set; }


        public Weapon()
        {

        }

        public Weapon(int id, string name, string description, bool consumable) :
            base(id, name, description, consumable)
        {
            Id = id;
            Name = name;
            Description = description;
            Consumable = consumable;
        }

        public override string Use()
        {
            switch (WeaponTypeName)
            {
                case WeaponType.NONE:
                    return "You are using a weapon of unknown type.";

                case WeaponType.MELEE:
                    return $"You swing the {Name} with all of your might.";

                case WeaponType.RANGED:
                    return $"You step back and unleash the {Name}.";

                case WeaponType.DEFENSIVE:
                    return $"Bringing up the {}, you defend yourself gallantly.";
                default:
                    return "You are using a weapon of unknown type.";
            }
        }
    }
}
