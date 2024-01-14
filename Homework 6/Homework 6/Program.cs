using Services;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productStore = new ProductStore();
            var productInStore = productStore.GetProducts();
            var basket = new Basket();
            var order = new Order(basket);

            Console.WriteLine("Products in store:");
            for (int i = 0; i < productInStore.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {productInStore[i].Name} (${productInStore[i].Price})");
            }

            Console.WriteLine("Select products to add to basket (enter with a space):");
            string inputProductsId = Console.ReadLine();
            string[] selectedProducts = inputProductsId.Split(' ');

            foreach (var selectedId in selectedProducts)
            {
                if (int.TryParse(selectedId, out int index) && index > 0 && index <= productInStore.Length)
                {
                    basket.AddProduct(productInStore[index - 1]);
                }
            }

            order.GetBill();
        }
    }
}
