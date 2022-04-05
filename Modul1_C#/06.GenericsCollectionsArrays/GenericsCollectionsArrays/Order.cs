using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionsArrays
{
    public class Order
    {

        public OrderStatus Status { get; set; }

        public enum OrderStatus
        {
            Canceled,
            Processing,
            Delivered
        };
    }
}
