using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural
{
    public class BirthdayPackedProduct : BaseDecorator
    {
        public BirthdayPackedProduct(IProduct product) : base(product)
        {
        }

        public override int GetCost()
        {
            return Product.GetCost() + 50;
        }

        public override string GetDescription()
        {
            return Product.GetDescription() + " birthday packed ";
        }
    }
}
