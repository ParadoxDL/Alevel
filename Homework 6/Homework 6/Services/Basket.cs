using Models;

namespace Services
{
    public class Basket
    {
        private const int MaxProducts = 10;
        private Product[] products = new Product[MaxProducts];
        private int productsCount = 0;

        public void AddProduct(Product product)
        {
            if (productsCount < MaxProducts)
            {
                products[productsCount] = product;
                productsCount++;
            }
            else
            {
                Console.WriteLine("The basket is full");
            }
        }

        public Product[] GetItems()
        {
            return products;
        }
    }
}
