using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Inheritance_GameObjects
{
    public abstract class GameObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Consumable { get; set; }

        public GameObject()
        {

        }

        public GameObject(int id, string name, string description, bool consumable = false)
        {
            Id = id;
            Name = name;
            Description = description;
            Consumable = consumable;
        }

        //
        // abstract methods 'must' be overriden in child class making it a requirement
        //
        public abstract string Use();

        //
        // virtual methods 'may' be overriden in the child class making the parent method a default
        //
        public virtual string Message()
        {
            StringBuilder sb = new StringBuilder();
            sb.Clear();

            sb.Append($"The {Name}: {Description} it is ");
            sb.Append(Consumable ? "consumable" : "is not consumable");

            return sb.ToString();
        }
    }
}
