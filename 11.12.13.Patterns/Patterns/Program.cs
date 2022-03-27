using Behavioral;
using Creational;
using Structural;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decorator pattern

            IProduct product = new SimpleProduct();

            product = new PackedProduct(product);
            product = new BirthdayPackedProduct(product);
            product = new WithCongratLetterProduct(product);

            Console.WriteLine($"Price: {product.GetCost()}, Description: {product.GetDescription()}");

            //Singleton pattern

            ShopInstanceSingleton shopInstanceSingleton = ShopInstanceSingleton.Instance;
            Console.WriteLine(shopInstanceSingleton);

            ShopInstanceSingleton shopInstanceSingleton1 = ShopInstanceSingleton.Instance;
            Console.WriteLine(shopInstanceSingleton1);

            //Strategy pattern

            Console.WriteLine("Please select delivery option! 1 -> Post; 2 -> Memo; 3 -> Fan");
            var selection = Convert.ToInt32(Console.ReadLine());

            var context = new DeliverBuilderContext();

            switch (selection)
            {
                case 1:
                    context.SetStrategy(new PostDelivery());
                    context.BuildDeliver();
                    break;

                case 2:
                    context.SetStrategy(new MemoDelivery());
                    context.BuildDeliver();
                    break;

                case 3:
                    context.SetStrategy(new FanDelivery());
                    context.BuildDeliver();
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }
}