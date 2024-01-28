using Models;
using Services.Interfaces;

namespace Services
{
    internal class Salad : ISalad
    {
        private Vegetables[] vegetables;

        public Salad(Vegetables[] vegetables)
        {
            this.vegetables = vegetables;
        }

        public void GetVegetables()
        {
            foreach (var vegetables in vegetables)
            {
                Console.WriteLine($"Name: {vegetables.Name}, Caloris: {vegetables.Calories}");
            }
        }

        public void SortByCalories()
        {
            Array.Sort(vegetables, (c1, c2) => c1.Calories.CompareTo(c2.Calories));
        }

        public double GetTotalCalories()
        {
            double totalCalories = 0;
            foreach (var vegetables in vegetables)
            {
                totalCalories += vegetables.Calories;
            }
            return totalCalories;
        }

        public Vegetables GetVegetablesByParameter(string parameter)
        {
            foreach (var vegetables in vegetables)
            {
                if (vegetables.Name.Equals(parameter, StringComparison.OrdinalIgnoreCase) ||
                    (vegetables is Cucumber chocolateBar && chocolateBar.Weight.Equals(parameter, StringComparison.OrdinalIgnoreCase)) ||
                    (vegetables is Lettuce lollipop && lollipop.Type.Equals(parameter, StringComparison.OrdinalIgnoreCase)) ||
                    (vegetables is Tomato jellyBean && jellyBean.Color.Equals(parameter, StringComparison.OrdinalIgnoreCase)))
                {
                    return vegetables;
                }
            }
            return null;
        }
    }
}
