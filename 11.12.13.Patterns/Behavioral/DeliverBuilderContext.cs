using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral
{
    public class DeliverBuilderContext
    {
        private IDeliverBuilder _builder;

        public void SetStrategy(IDeliverBuilder deliverBuilder)
        {
            _builder = deliverBuilder;
        }

        public void BuildDeliver()
        {
            if (_builder == null)
            {
                Console.WriteLine("No strategy selected");
            }
            else _builder.BuildDeliver();
        }
    }
}
