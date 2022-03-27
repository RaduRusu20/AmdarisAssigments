using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural
{
    public class PackedProduct : BaseDecorator
    {
        public PackedProduct(IProduct product) : base(product)
        {
        }

        public override int GetCost()
        {
            return Product.GetCost() + 30;
        }

        public override string GetDescription()
        {
            return Product.GetDescription() + " packed ";
        }
    }
}
