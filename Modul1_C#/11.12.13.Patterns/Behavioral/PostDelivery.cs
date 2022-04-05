using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral
{
    public class PostDelivery : IDeliverBuilder
    {
        const float deliveryPrice = 15;

        public void BuildDeliver()
        {
            Console.WriteLine($"Post delivery strategy, price {deliveryPrice}");
        }
    }
}
