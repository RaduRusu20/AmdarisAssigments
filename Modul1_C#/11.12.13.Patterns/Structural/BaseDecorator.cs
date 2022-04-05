using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural
{
    public abstract class BaseDecorator : IProduct
    {
        protected IProduct Product { get; set; }

        protected BaseDecorator(IProduct product)
        {
            Product = product;
        }

        public abstract int GetCost();
        public abstract string GetDescription();
        
    }
}
