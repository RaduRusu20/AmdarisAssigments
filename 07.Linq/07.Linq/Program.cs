using System;
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