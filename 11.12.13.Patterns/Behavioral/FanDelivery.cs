using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral
{
    public class FanDelivery : IDeliverBuilder
    {
        public void BuildDeliver()
        {
            Console.WriteLine("Fan delivery strategy");
        }
    }
}
