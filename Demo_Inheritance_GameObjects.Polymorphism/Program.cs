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
    //              with Polymorphism
    // Application Type: Console
    // Author: Velis, John
    // Dated Created: 3/8/2021
    // Last Modified: 
    //
    // **************************************************
    class Program
    {
        static void Main(string[] args)
        {
            List<GameObject> gameObjects = DataGameObjects.IntializeGameObjects();

            //
            // use LINQ lambda to generate filtered lists
            //
            List<GameObject> gameObjectFoodAndDrinks = gameObjects.Where(go => go is FoodAndDrink).ToList();
            List<GameObject> gameObjectWeapons = gameObjects.Where(go => go is Weapon).ToList();

            DisplayGameObjects(gameObjectFoodAndDrinks);
            DisplayGameObjects(gameObjectWeapons);

            UseGameObject(gameObjectFoodAndDrinks);
            UseGameObject(gameObjectWeapons);
        }

        private static void UseGameObject(List<GameObject> gameObjects)
        {
            string headerText = "";
            string hitHealthText = "";
            int hitHealthPoints = 0;

            if (gameObjects != null)
            {
                //
                // set header and point type text
                //
                if (gameObjects[0] is Weapon)
                {
                    headerText = "Use Weapon";
                    hitHealthText = "Hit points: ";
                }
                else if (gameObjects[0] is FoodAndDrink)
                {
                    headerText = "Use Food and Drink";
                    hitHealthText = "Health points: ";
                }
                else
                {
                    headerText = "Unknown Game Object Type";
                    hitHealthText = "Unknown point type: ";
                }

                //
                // display header
                //
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t\t" + headerText);
                Console.WriteLine();


                foreach (GameObject gameObject in gameObjects)
                {
                    //
                    // set hit and health points
                    //
                    if (gameObjects[0] is Weapon)
                    {
                        Weapon weaponGameObject = (Weapon)gameObject;
                        hitHealthPoints = weaponGameObject.HitPoints;
                    }
                    else if (gameObjects[0] is FoodAndDrink)
                    {
                        FoodAndDrink foodAndDrinkGameObject = (FoodAndDrink)gameObject;
                        hitHealthPoints = foodAndDrinkGameObject.HealthPoints;
                    }
                    else
                    {
                        hitHealthPoints = 0;
                    }

                    //
                    // display game object use info
                    //
                    Console.WriteLine();
                    Console.WriteLine("\t" + gameObject.Message());
                    Console.WriteLine("\t" + gameObject.Use());
                    Console.WriteLine("\t" + hitHealthText + hitHealthPoints);
                }
            }
            else
            {
                Console.WriteLine("It appears there are no game objects to use.");
            }

            Console.WriteLine();
            Console.WriteLine("\t\tPress any key to continue.");
            Console.ReadKey();
        }

        private static void DisplayGameObjects(List<GameObject> gameObjects)
        {
            string headerText = "";
            string hitHealthText = "";
            int hitHealthPoints = 0;

            //
            // set header and point type text
            //
            if (gameObjects != null)
            {
                //
                // set header and point type text
                //
                if (gameObjects[0] is Weapon)
                {
                    headerText = "Use Weapon";
                    hitHealthText = "Hit Points";
                }
                else if (gameObjects[0] is FoodAndDrink)
                {
                    headerText = "Use Food and Drink";
                    hitHealthText = "Health Points";
                }
                else
                {
                    headerText = "Unknown Game Object Type";
                    hitHealthText = "Unknown";
                }

                //
                // display header
                //
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t\t" + headerText);
                Console.WriteLine();


                Console.WriteLine(
                    "\t" +
                    "Id".PadLeft(5) +
                    "Name".PadLeft(25) +
                    "Consumable".PadLeft(15) +
                    hitHealthText.PadLeft(15)
                    );
                Console.WriteLine(
                    "\t" +
                    "----".PadLeft(5) +
                    "--------------".PadLeft(25) +
                    "--------------".PadLeft(15) +
                    "--------------".PadLeft(15)
                    );

                foreach (GameObject gameObject in gameObjects)
                {
                    //
                    // set hit and health points
                    //
                    if (gameObjects[0] is Weapon)
                    {
                        Weapon weaponGameObject = (Weapon)gameObject;
                        hitHealthPoints = weaponGameObject.HitPoints;
                    }
                    else if (gameObjects[0] is FoodAndDrink)
                    {
                        FoodAndDrink foodAndDrinkGameObject = (FoodAndDrink)gameObject;
                        hitHealthPoints = foodAndDrinkGameObject.HealthPoints;
                    }
                    else
                    {
                        hitHealthPoints = 0;
                    }

                    //
                    // display table info
                    //
                    Console.WriteLine(
                        "\t" +
                        gameObject.Id.ToString().PadLeft(5) +
                        gameObject.Name.PadLeft(25) +
                        (gameObject.Consumable ? "Yes" : "No").PadLeft(15) +
                        hitHealthPoints.ToString().PadLeft(15)
                        );
                }
            }
            else
            {
                Console.WriteLine("It appears there are no game objects to display.");
            }

            Console.WriteLine();
            Console.WriteLine("\t\tPress any key to continue.");
            Console.ReadKey();
        }
    }
}
