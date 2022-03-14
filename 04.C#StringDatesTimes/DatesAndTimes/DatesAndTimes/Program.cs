using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string format
            var currentDateTime = string.Format("Current DateTime: {0}. Age: {1}", DateTime.Now, 21);
            Console.WriteLine(currentDateTime);

            //string interpolation
            var currentDateTime1 = $"Current DateTime: {DateTime.Now}. Age {21}";
            Console.WriteLine(currentDateTime1);

            //string split
            var list = "Barcelona, Real, Atletico, Juventus".Split(',');
            Console.WriteLine(list[0]); // => Barcelona

            //string replace
            var replace = "Azi e luni.".Replace("luni", "marti");
            Console.WriteLine(replace);

            //contains string
            var contains = "Radu e aici".Contains("aici");
            Console.WriteLine(contains);

            //string compare
            var compare = string.Compare("da", "nu");
            Console.WriteLine(compare);
            compare = string.Compare("a", "A", StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(compare);

            //time span
            var time = new TimeSpan(0, 30, 45);
            Console.WriteLine(time);

            var startTime = DateTime.Now.Add(time);
            Console.WriteLine(startTime);

            var endTime = DateTime.Now.Subtract(time);
            Console.WriteLine(endTime);

            //utc
            var utcTime = DateTime.UtcNow;
            Console.WriteLine(utcTime);

            var utcOffset = DateTimeOffset.Now;
            Console.WriteLine(utcOffset);

            //date
            var date = new DateTime(2020, 09, 12);
            var formatedDate = date.ToString("yyyy/M/d");
            Console.WriteLine(formatedDate);

            var romDate = date.ToString("MMMM dddd", CultureInfo.CreateSpecificCulture("ro-RO"));
            Console.WriteLine(romDate);

            var numberCulture = 10.ToString("C", new CultureInfo("ro-Ro"));
            Console.WriteLine(numberCulture);
        }
    }
}