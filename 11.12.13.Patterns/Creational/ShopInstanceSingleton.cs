namespace Creational
{
    public class ShopInstanceSingleton
    {
        public string Name { get; }

        private static ShopInstanceSingleton instance;

        private ShopInstanceSingleton()
        {
            Console.WriteLine("Constructor called!");
        }

        public static ShopInstanceSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShopInstanceSingleton();
                }

                return instance;
            }
        }

    }
}