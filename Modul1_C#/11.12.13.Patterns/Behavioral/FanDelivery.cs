using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral
{
    public class FanDelivery : IDeliverBuilder
    {
        const float deliveryPrice = 20;

        public void BuildDeliver()
        {
            Console.WriteLine($"Fan delivery strategy, cost {deliveryPrice}");
        }
    }
}
