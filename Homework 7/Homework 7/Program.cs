using Models;
using Services;
using Services.Interfaces;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sweets candy1 = new ChocolateBar("Milka", 90, "Milk");
            Sweets candy2 = new ChocolateBar("Crown", 100, "Dark");
            Sweets candy3 = new Lollipop("Bim-Bom", 30, "Fruits");
            Sweets candy4 = new Lollipop("Barberry", 35, "Barberrys");
            Sweets candy5 = new Jelly("Jelly", 20, "Orange");
            Sweets candy6 = new Jelly("Eclair", 15, "Brown");

            Sweets[] gift = { candy1, candy2, candy3, candy4, candy5, candy6 };

            IGift newyearGift = new Gift(gift);

            Console.WriteLine("Sweets in gift:");
            newyearGift.GetSweets();

            newyearGift.SortByWeight();

            Console.WriteLine("\nSorted sweets by weight:");
            newyearGift.GetSweets();

            Console.WriteLine($"\nTotal weight: {newyearGift.GetTotalWeight()}g");

            Console.Write("\nEnter a parameter to search for a sweet (for example, name, type, flavour, colour): ");
            string searchParameter = Console.ReadLine();

            Sweets foundSweet = newyearGift.GetSweetByParameter(searchParameter);

            if (foundSweet != null)
            {
                Console.WriteLine($"Found sweet: {foundSweet.Name}, Weight: {foundSweet.Weight}g");
            }
            else
            {
                Console.WriteLine($"Candy with the parameter {searchParameter} not found in the gift.");
            }
        }
    }
}
