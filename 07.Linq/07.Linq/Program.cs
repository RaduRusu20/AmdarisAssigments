using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using _07Linq;

namespace _07.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Id = 1, PName = "Lenovo Legion", Price = 4000, ManufactererId = 4 },
                new Product { Id = 2, PName = "iPhone 12 Pro Max", Price = 6500, ManufactererId = 1 },
                new Product { Id = 1, PName = "Lenovo Legion", Price = 4000, ManufactererId = 4 },
                new Product { Id = 3, PName = "Samsung S21", Price = 4500, ManufactererId = 2 },
                new Product { Id = 4, PName = "Huawei Mate P40 Pro", Price = 4200, ManufactererId = 3 },
                new Product { Id = 1, PName = "Lenovo Legion", Price = 4000, ManufactererId = 4 },
                new Product { Id = 5, PName = "Macbook Pro 13' 2021", Price = 7500, ManufactererId = 1 },
                new Product { Id = 6, PName = "Lenovo Thinkpad T15", Price = 9200, ManufactererId = 4 },
                new Product { Id = 6, PName = "Lenovo Thinkpad T15", Price = 9200, ManufactererId = 4 },
                new Product { Id = 7, PName = "Apple Watch Series 6", Price = 2400, ManufactererId = 1 },
                new Product { Id = 8, PName = "iPad Pro", Price = 5500, ManufactererId = 1 },
                new Product { Id = 8, PName = "iPad Pro", Price = 5500, ManufactererId = 1 },
                new Product { Id = 8, PName = "iPad Pro", Price = 5500, ManufactererId = 1 },
            };

            var manufacturers = new List<Manufacturer>
            {
                new Manufacturer {Id = 1, Name = "Apple" },
                new Manufacturer {Id = 2, Name = "Samsung" },
                new Manufacturer {Id = 3, Name = "Huawei" },
                new Manufacturer {Id = 4, Name = "Lenovo" },
            };


            var filtredProducts = products.Where(x => x.Price > 5000);

            var takeFirstProducts = products.Take(3);

            var takeProductsRange = products.Take(new Range(4, 8));

            var skipProducts = products.Skip(5);

            var takeWhile = products.TakeWhile(x => x.Price < 7000);

            var skipWhile = products.SkipWhile(x => { return x.PName.Contains('L') || x.PName.Contains('1') || x.PName.Contains('4'); });

            var distinctProducts = products.DistinctBy(x => x.Id);

            var distinctProducts1 = products.Distinct(new ProductComparer());

            var selectProducts = products.Select(x => x.PName);

            var selectManyProducts = products.SelectMany(x => x.Features);

            var joinResult = from product in products
                             join manufacterer in manufacturers on product.ManufactererId equals manufacterer.Id
                             select new
                             {
                                 product.PName,
                                 manufacterer.Name
                             };

            var order = products.OrderBy(x => x.PName).ThenBy(x => x.Price).ThenByDescending(x => x.ManufactererId);

            products.Reverse();

            var groupByProducts = products.GroupBy(x => x.ManufactererId);

            foreach(var group in groupByProducts)
            {
                Console.WriteLine($"{group.Key} : ");

                foreach(var product in group)
                {
                    Console.WriteLine($"{product.PName}");
                }
            }

            var filteredProducts = products.Filter<Product>(x => x.PName.StartsWith("i"))
                .Filter<Product>(x => x.ManufactererId < 3)
                .Filter<Product>(x => x.Price < 6000);

            //groupJoin

            var productsByManufacter = from manufacterer in manufacturers
                                       join product in products on manufacterer.Id equals product.ManufactererId into groupedProducts
                                       select new { manufacterer.Name, groupedProducts };

            foreach(var manufactererGroup in productsByManufacter)
            {
                Console.WriteLine($"{manufactererGroup.Name} : ");

                foreach(var product in manufactererGroup.groupedProducts)
                {
                    Console.WriteLine(product);
                }
            }

            //zip

            int[] a = { 1, 2, 3, 4, 5 , 5, 1, 3};
            int[] c = { 2, 3, 4, 5, 9, 10, 20 };
            string[] b = { "ab", "cd", "ef", "gh", "ij" };

            var zipResult = products.Zip(a, b);

            var zipResult1 = a.Zip(b, (first, second) => (first*100) + " : " + second);

            //union, intersect, except, distinct

            var unionResult = a.Union(c);
            var distinctResult = a.Distinct();
            var exceptResult = c.Except(a);
            var intersectResult = a.Intersect(c);

            //OfType

            List<object> list = new List<object> { "1", 1, "da", 2, "doi", 3, 4, 5, "cinci", "5"};

            var resultOfType = list.OfType<int>().ToList();
            var resultOfType1 = list.OfType<string>().ToList();

            //cast

            List<object> list1 = new List<object>() { 1, 2, 3, 4 };

            var castResult = list1.Cast<int>();

            //toDictionary

            var toDictionaryResult = manufacturers.ToDictionary(x => x.Id, x => x.Name);

            //single

            var product1 = products.Single(x => x.Price == 6500); //arunca exceptie daca nu exista, sau apare de mai multe ori

            //singleOrDefault

            var product2 = products.SingleOrDefault(x => x.Price == 0);
            //returneaza null daca nu exista, si obiectul daca e unic
            //altfel arunca exceptie

            //agregate

            var agregateResult = a.Aggregate((x, sum) => sum + x);

            //all

            var allResult = a.All(x => x >= 0);

            //any

            var anyResult = a.Any(x => x < 0);

            int x = 100;

            var result = x.ParityChecker();
            Console.WriteLine(result);

            var result1 = a.Addder();
            Console.WriteLine(result1);
        }

        
    }

   public enum Parity
    {
        Odd,
        Even
    };

    public static class ParityExtension
    {
        public static Parity ParityChecker(this int x)
        {
            if (x % 2 == 0)
            {
                return Parity.Even;
            }
            return Parity.Odd;
        }
    }

    public static class AdderExtension
    {
        public static int Addder(this int[] x)
        {
            int sum = 0;

            foreach(var item in x)
            {
                sum += item;
            }
            return sum;
        }
    }



public static class FilterExtension
    {
        public static List<T> Filter<T>(this List<T> items, Func<T, bool> predicate)
        {
            var result = new List<T>();

            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result.ToList();
        }
    }
}