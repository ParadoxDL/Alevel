using Models;
using Services.Interfaces;

namespace Services
{
    internal class Gift : IGift
    {
        private Sweets[] sweets;

        public Gift(Sweets[] sweets)
        {
            this.sweets = sweets;
        }

        public void GetSweets()
        {
            foreach (var sweet in sweets)
            {
                Console.WriteLine($"Name: {sweet.Name}, Weight: {sweet.Weight} g");
            }
        }

        public void SortByWeight()
        {
            Array.Sort(sweets, (c1, c2) => c1.Weight.CompareTo(c2.Weight));
        }

        public double GetTotalWeight()
        {
            double totalWeight = 0;
            foreach (var sweet in sweets)
            {
                totalWeight += sweet.Weight;
            }
            return totalWeight;
        }

        public Sweets GetSweetByParameter(string parameter)
        {
            foreach (var sweet in sweets)
            {
                if (sweet.Name.Equals(parameter, StringComparison.OrdinalIgnoreCase) ||
                    (sweet is ChocolateBar chocolateBar && chocolateBar.Type.Equals(parameter, StringComparison.OrdinalIgnoreCase)) ||
                    (sweet is Lollipop lollipop && lollipop.Flavor.Equals(parameter, StringComparison.OrdinalIgnoreCase)) ||
                    (sweet is Jelly jellyBean && jellyBean.Color.Equals(parameter, StringComparison.OrdinalIgnoreCase)))
                {
                    return sweet;
                }
            }
            return null;
        }
    }
}
