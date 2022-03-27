using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural
{
    public class WithCongratLetterProduct : BaseDecorator
    {
        public WithCongratLetterProduct(IProduct product) : base(product)
        {
        }

        public override int GetCost()
        {
            return Product.GetCost() + 20;
        }

        public override string GetDescription()
        {
            return Product.GetDescription() + " with congrats letter ";
        }
    }
}
