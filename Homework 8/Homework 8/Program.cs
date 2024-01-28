using Models;
using Services;
using Services.Interfaces;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vegetables vegetable1 = new Cucumber("Cucumber", 50, "500g");
            Vegetables vegetable2 = new Lettuce("Lettuce", 30, "Salad");
            Vegetables vegetable3 = new Tomato("Tomato", 45, "Red");

            Vegetables[] gift = { vegetable1, vegetable2, vegetable3 };

            ISalad newSalad = new Salad(gift);

            Console.WriteLine("Vegetable in salad:");
            newSalad.GetVegetables();

            newSalad.SortByCalories();

            Console.WriteLine("\nSorted vegetable by calories:");
            newSalad.GetVegetables();

            Console.WriteLine($"\nTotal calories: {newSalad.GetTotalCalories()}");

            Console.Write("\nEnter a parameter to search for a vegetables (for example, name, type, flavour, colour): ");
            string searchParameter = Console.ReadLine();

            Vegetables foundVegetables = newSalad.GetVegetablesByParameter(searchParameter);

            if (foundVegetables != null)
            {
                Console.WriteLine($"Found vegetable: {foundVegetables.Name}, Calories: {foundVegetables.Calories}");
            }
            else
            {
                Console.WriteLine($"Vegetable with the parameter {searchParameter} not found in the salad.");
            }
        }
    }
}
