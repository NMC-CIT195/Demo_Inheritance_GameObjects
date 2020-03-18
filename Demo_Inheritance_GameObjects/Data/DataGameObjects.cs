using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Inheritance_GameObjects.Models;

namespace Demo_Inheritance_GameObjects.Data
{
    static class DataGameObjects
    {
        static List<FoodAndDrink> IntializeFoodAndDrink()
        {
            return new List<FoodAndDrink>()
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
            };
        }

        static List<Weapon> InitializeWeapons()
        {
            return new List<Weapon>()
            {
                new Weapon()
                {
                    Id = 11,
                    Name = "bronze shield",
                    Description = "Large, rectangular bronze shield with leather strapping on the back.",
                    WeaponTypeName = Weapon.WeaponType.DEFENSIVE,
                    Consumable = false,
                    HitPoints = 0
                }

            };
        }

    }
}
