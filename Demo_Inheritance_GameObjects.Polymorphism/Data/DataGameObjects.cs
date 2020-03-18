using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Inheritance_GameObjects.Models;

namespace Demo_Inheritance_GameObjects.Data
{
    public static class DataGameObjects
    {
        public static List<GameObject> IntializeGameObjects()
        {
            return new List<GameObject>()
            {
                new FoodAndDrink()
                {
                    Id = 1,
                    Name = "hard tack bread",
                    Description = "Dry, compressed whole wheat bread wrapped in a cloth.",
                    Consumable = true,
                    HealthPoints = 10
                },

                new FoodAndDrink()
                {
                    Id = 2,
                    Name = "flagon of ale",
                    Description = "Small container of Marnuvian ale, brewed from the hides of the Rancorian rat.",
                    Consumable = true,
                    HealthPoints = 5
                },

                new FoodAndDrink()
                {
                    Id = 3,
                    Name = "bottle of ripe vinegar",
                    Description = "Small bottle of plum vinegar.",
                    Consumable = false,
                    HealthPoints = 0
                },

                new Weapon()
                {
                    Id = 11,
                    Name = "bronze shield",
                    Description = "Large, rectangular bronze shield with leather strapping on the back.",
                    WeaponTypeName = Weapon.WeaponType.DEFENSIVE,
                    Consumable = false,
                    HitPoints = 0
                },

                new Weapon()
                {
                    Id = 12,
                    Name = "silver backed slug",
                    Description = "Wrapped in damp parchment, the Bandorian tree slug covers you with a thick slime preventing any weapon for striking full force, head on.",
                    WeaponTypeName = Weapon.WeaponType.DEFENSIVE,
                    Consumable = true,
                    HitPoints = 0
                },

                new Weapon()
                {
                    Id = 13,
                    Name = "long sword",
                    Description = "Large, Scottish, double edged blade with brass hilt.",
                    WeaponTypeName = Weapon.WeaponType.MELEE,
                    Consumable = false,
                    HitPoints = 20
                }
            };
        }
    }
}
