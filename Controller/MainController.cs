using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdrætterstation.Model;
using Opdrætterstation.Model.Created_Animals;
using Opdrætterstation.View;

namespace Opdrætterstation.Controller
{
    internal class MainController : IController
    {
        public void Start() 
        {
            // adding the different type of options for our animals
            AnimalSex male = new AnimalSex("Male");
            AnimalSex female = new AnimalSex("Female");
            AnimalFur shortHair = new AnimalFur("Short Hair");
            AnimalFur longHair = new AnimalFur("Long Hair");
            AnimalFur feathers = new AnimalFur("Feathers");
            AnimalFur nullFur = new AnimalFur(null);

            // Addings dogs
            Animal labrador1 = new Dog(male, 4, shortHair, 1);
            Animal labrador2 = new Dog(female, 4, longHair, 1);
            Animal labrador3 = new Dog(male, 4, shortHair, 3);
            Animal labrador4 = new Dog(female, 4, longHair, 4);
            Animal labrador5 = new Dog(male, 4, shortHair, 5);
            Animal sadlabrador = new Dog(male, 2, nullFur, 4);

            // Adding Rabbits
            Animal rabbit1 = new Rabbit(male, 4, shortHair, 1);
            Animal rabbit2 = new Rabbit(female, 4, longHair, 1);
            Animal rabbit3 = new Rabbit(male, 4, shortHair, 3);
            Animal rabbit4 = new Rabbit(female, 4, longHair, 4);
            Animal rabbit5 = new Rabbit(male, 4, shortHair, 5);
            Animal rabbit6 = new Rabbit(female, 4, longHair, 4);

            // Adding Chickens
            Animal chicken1 = new Chicken(male, 2, feathers, 1);
            Animal chicken2 = new Chicken(female, 2, feathers, 1);
            Animal chicken3 = new Chicken(male, 2, feathers, 3);
            Animal chicken4 = new Chicken(female, 2, feathers, 4);
            Animal chicken5 = new Chicken(male, 2, feathers, 5);
            Animal sadChicken = new Chicken(female, 1, nullFur, 4);

            // Creating the list of the animals that left the farm (If an animal is more than one year old it is added.)

            List<Animal> animals = new List<Animal>()
            {
                labrador3, labrador4, labrador5, sadlabrador, rabbit3, rabbit4, rabbit5, rabbit6, chicken3, chicken4, chicken5, sadChicken
            };
            PrintList(animals);
            Console.ReadLine();
        }
        // Implementing method.
        public void PrintList(List<Animal> animals)
        {
            Console.WriteLine("These are all the animals that have left the farm: \n");
            foreach (Animal animal in animals) 
            {
                Console.WriteLine(animal.Print());
            }
        }
    }
}
