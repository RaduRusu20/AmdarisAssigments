using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral
{
    public class MemoDelivery : IDeliverBuilder
    {
        const float deliveryPrice = 25;

        public void BuildDeliver()
        {
            Console.WriteLine($"Memo delivery strategy, price {deliveryPrice}");
        }
    }
}
