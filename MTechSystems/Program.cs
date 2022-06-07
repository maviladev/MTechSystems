using MTechSystems.Entities;

namespace MTechSystems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item() { Name = "Product 1", Amount = 5, Price = 13.5};
            Item item2 = new Item() { Name = "Producto 2", Amount = 3, Price = 17 };
            Item item3 = new Item() { Name = "Item 3", Amount = 1, Price = 2.5 };
            Item item4 = new Item() { Name = "Parapapa 4", Amount = 2, Price = 7.8 };

            ShoppingCart cart = new ShoppingCart();
            cart.AddItem(item);
            cart.AddItem(item2);
            cart.AddItem(item3);
            cart.AddItem(item4);

            Console.WriteLine(cart.PurchaseDate);
            Console.WriteLine(cart.PurchaseTotal);

            cart.DoPurchase();
        }
    }
}