using System;
using System.Linq;
using AbstractSearch.Models;

namespace AbstractSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate holding class
            PetStoreManager manager = new PetStoreManager();
            
            // Create our Pets
            Pet bird1 = new Bird("Polly");
            Pet bird2 = new Bird("Twiggy");

            Pet dog1 = new Dog("Rover");
            Pet dog2 = new Dog("Polly");
                    
            Pet cat1 = new Cat("Muffins");
            Pet cat2 = new Cat("Twiggy");
        
            // Add created Pets to the Manager List<Pet>
            manager.Pets.Add(bird1);
            manager.Pets.Add(bird2);
            manager.Pets.Add(dog1);
            manager.Pets.Add(dog2);
            manager.Pets.Add(cat1);
            manager.Pets.Add(cat2);

            // Output the search results with a single ".Where()"
            System.Console.Write("Enter your search string: ");
            var searchString = Console.ReadLine();
            var results = manager.Pets.Where(x=>x.Name == searchString);
            results.ToList().ForEach(x=>x.Display());
        }
    }
}
