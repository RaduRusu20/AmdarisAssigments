using System.Collections.Generic;

namespace _07Linq
{
    public class Product
    {
        public int Id { get; set; }
        public string PName { get; set; }
        public float Price { get; set; }
        public int ManufactererId { get; set; }
        public IEnumerable<string> Features { get; set; } = new List<string> { "Good", "Cheap" };

        public override string ToString() => $"({Id}, {PName}, {Price})";
    }
}