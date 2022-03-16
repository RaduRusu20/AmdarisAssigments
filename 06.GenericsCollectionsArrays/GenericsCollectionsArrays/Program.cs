using System;
using GenericsCollectionsArrays;
using static GenericsCollectionsArrays.Order;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GenericArray<int> genericArray = new GenericArray<int>(new int[100]);

            genericArray.SetItem(0, 10);
            genericArray.SetItem(1, 20);
            genericArray.SetItem(2, 30);

            Console.WriteLine(genericArray.GetElement(0));
            Console.WriteLine(genericArray.GetElement(1));
            Console.WriteLine(genericArray.GetElement(2));
            Console.WriteLine("");

            genericArray.SwapElements(0, 2);

            Console.WriteLine(genericArray.GetElement(0));
            Console.WriteLine(genericArray.GetElement(1));
            Console.WriteLine(genericArray.GetElement(2));
            Console.WriteLine("");

            genericArray.SwapElements<int>(10, 20);
            Console.WriteLine(genericArray.GetElement(0));
            Console.WriteLine(genericArray.GetElement(1));
            Console.WriteLine(genericArray.GetElement(2));
            Console.WriteLine("");

            Order order = new Order();

            order.Status = OrderStatus.Delivered;


            switch (order.Status)
            {
                case OrderStatus.Canceled:
                    Console.WriteLine("Canceled");
                    break;

                case OrderStatus.Delivered:
                    Console.WriteLine("Delivered");
                    break;

                case OrderStatus.Processing:
                    Console.WriteLine("Still processing");
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }


            List<int> list = new List<int>();
            int[] a = {1,2,3,4,5,6};

           
            list.AddRange(a);
            list.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(list.Any(x => x > 3));

            //toate elementele trebuie sa fie distincte
            HashSet<string> vs = new(new StringC());
            
            vs.Add("a");
            vs.Add("bb");
            vs.Add("Baa");
            vs.Add("Ab");
            vs.Add("Cc");
            foreach (var item in vs)
            {
                Console.WriteLine(item);    
            }
            
    
           

        }
    }

}