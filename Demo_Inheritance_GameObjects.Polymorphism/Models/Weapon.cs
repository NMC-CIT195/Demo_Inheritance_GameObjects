using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Inheritance_GameObjects.Models
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
        public int HitPoints { get; set; }

        public Weapon()
        {

        }

        public Weapon(int id, string name, string description, bool consumable, int hitPoints) :
            base(id, name, description, consumable)
        {
            HitPoints = hitPoints;
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
                    return $"Bringing up the {Name}, you defend yourself gallantly.";
                default:
                    return "You are using a weapon of unknown type.";
            }
        }

        public override string Message()
        {
            return $"The {Name}: {Description}. It is a {WeaponTypeName.ToString().ToLower()} type of weapon. ";
        }
    }
}
