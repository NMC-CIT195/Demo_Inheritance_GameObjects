using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Inheritance_GameObjects.Models
{
    public class FoodAndDrink : GameObject
    {
        public int HealthPoints { get; set; }

        public FoodAndDrink()
        {

        }

        public FoodAndDrink(int id, string name, string description, bool consumable, int healthPoints) :
            base(id, name, description, consumable)
        {
            Id = id;
            Name = name;
            Description = description;
            Consumable = consumable;
            HealthPoints = healthPoints;
        }

        public override string Use()
        {
            if (Consumable)
                return $"You raise the {} to your mouth and finish it quickly.";
            else
                return $"It appears that you are unable to consume the {Name} for some unknown reason.";
        }
    }
}
