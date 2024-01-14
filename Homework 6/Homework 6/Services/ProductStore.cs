using Models;

namespace Services
{
    public class ProductStore
    {
        private readonly Product[] products;

        public ProductStore()
        {
            products =
            [
            new Product { Id = 1, Name = "t-short", Price = 100 },
            new Product { Id = 2, Name = "dress", Price = 110 },
            new Product { Id = 3, Name = "sweatshirt", Price = 120 },
            new Product { Id = 4, Name = "sweater", Price = 130 },
            new Product { Id = 5, Name = "shirt", Price = 140 },
            new Product { Id = 6, Name = "shorts", Price = 150 },
            new Product { Id = 7, Name = "jeans", Price = 160 },
            new Product { Id = 8, Name = "coat", Price = 170 },
            new Product { Id = 9, Name = "socks", Price = 180 },
            new Product { Id = 10, Name = "jacket", Price = 190 },
            new Product { Id = 11, Name = "hat", Price = 200 }
            ];
        }

        public Product[] GetProducts()
        {
            return products;
        }
    }
}
