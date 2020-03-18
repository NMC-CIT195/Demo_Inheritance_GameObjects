using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Inheritance_GameObjects.Data;
using Demo_Inheritance_GameObjects.Models;

namespace Demo_Inheritance_GameObjects
{
    // **************************************************
    //
    // Title: CIT 195 - Demo - Inheritance
    // Description: Demonstration of inheritance with 'abstract', 'virtual', 'override'
    // Application Type: Console
    // Author: Velis, John
    // Dated Created: 3/16/2020
    // Last Modified: 
    //
    // **************************************************
    class Program
    {
        static void Main(string[] args)
        {
            List<FoodAndDrink> foodsAndDrinks = DataGameObjects.IntializeFoodAndDrink();
            List<Weapon> weapons = DataGameObjects.InitializeWeapons();

            DisplayWeapons(weapons);
            DisplayFoodAndDrink(foodsAndDrinks);

            UseWeapons(weapons);
            UseFoodAndDrink(foodsAndDrinks);
        }

        private static void UseFoodAndDrink(List<FoodAndDrink> foodsAndDrinks)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tUse Food and Drink");
            Console.WriteLine();

            foreach (FoodAndDrink foodAndDrink in foodsAndDrinks)
            {
                Console.WriteLine();
                Console.WriteLine("\t" + foodAndDrink.Message());
                Console.WriteLine("\t" + foodAndDrink.Use());
                Console.WriteLine("\t" + "Health points: " + foodAndDrink.HealthPoints);
            }

            Console.WriteLine();
            Console.WriteLine("\t\tPress any key to continue.");
            Console.ReadKey();
        }

        private static void UseWeapons(List<Weapon> weapons)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tUse Weapons");
            Console.WriteLine();

            foreach (Weapon weapon in weapons)
            {
                Console.WriteLine();
                Console.WriteLine("\t" + weapon.Message());
                Console.WriteLine("\t" + weapon.Use());
                Console.WriteLine("\t" + "Hit points: " + weapon.HitPoints);
            }

            Console.WriteLine();
            Console.WriteLine("\t\tPress any key to continue.");
            Console.ReadKey();
        }

        static void DisplayFoodAndDrink(List<FoodAndDrink> foodsAndDrinks)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFood and Drink List");
            Console.WriteLine();

            Console.WriteLine(
                "\t" +
                "Id".PadLeft(5) +
                "Name".PadLeft(25) +
                "Consumable".PadLeft(15) +
                "Health Points".PadLeft(15)
                );
            Console.WriteLine(
                "\t" +
                "----".PadLeft(5) +
                "--------------".PadLeft(25) +
                "--------------".PadLeft(15) +
                "--------------".PadLeft(15)
                );

            foreach (FoodAndDrink foodAndDrink in foodsAndDrinks)
            {
                Console.WriteLine(
                    "\t" +
                    foodAndDrink.Id.ToString().PadLeft(5) +
                    foodAndDrink.Name.PadLeft(25) +
                    (foodAndDrink.Consumable ? "Yes" : "No").PadLeft(15) +
                    foodAndDrink.HealthPoints.ToString().PadLeft(15)
                    );
            }

            Console.WriteLine();
            Console.WriteLine("\t\tPress any key to continue.");
            Console.ReadKey();
        }

        static void DisplayWeapons(List<Weapon> weapons)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tWeapons List");
            Console.WriteLine();

            Console.WriteLine(
                "\t" +
                "Id".PadLeft(5) +
                "Name".PadLeft(25) +
                "Consumable".PadLeft(15) +
                "Hit Points".PadLeft(15)
                );
            Console.WriteLine(
                "\t" +
                "----".PadLeft(5) +
                "--------------".PadLeft(25) +
                "--------------".PadLeft(15) +
                "--------------".PadLeft(15)
                );

            foreach (Weapon weapon in weapons)
            {
                Console.WriteLine(
                    "\t" +
                    weapon.Id.ToString().PadLeft(5) +
                    weapon.Name.PadLeft(25) +
                    (weapon.Consumable ? "Yes" : "No").PadLeft(15) +
                    weapon.HitPoints.ToString().PadLeft(15)
                    );
            }

            Console.WriteLine();
            Console.WriteLine("\t\tPress any key to continue.");
            Console.ReadKey();
        }
    }
}
