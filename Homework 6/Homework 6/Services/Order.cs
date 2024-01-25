using Models;

namespace Services
{
    public class Order
    {
        private readonly Basket _cart;

        public Order(Basket cart)
        {
            _cart = cart;
        }

        public void GetBill()
        {
            int orderId = GetOrderID();
            var orderDate = DateTime.Now;
            var products = _cart.GetItems();
            double totalPrice = GetTotalPrice(products);

            Console.WriteLine();
            Console.WriteLine("Bill:");
            Console.WriteLine($"Order ID: {orderId}");
            Console.WriteLine($"Store Name: Clothing store");
            Console.WriteLine($"Date: {orderDate}");
            Console.WriteLine("Products:");

            foreach (var product in products)
            {
                if (product != null)
                {
                    Console.WriteLine($"- {product.Name} (${product.Price})");
                }
            }

            Console.WriteLine($"Total Price: ${totalPrice}");
        }

        private int GetOrderID()
        {
            return new Random().Next(1000, 9999);
        }

        private double GetTotalPrice(Product[] products)
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                if (product != null)
                {
                    totalPrice += product.Price;
                }
            }
            return totalPrice;
        }
    }
}
