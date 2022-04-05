using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural
{
    public class SimpleProduct : IProduct
    {
        public int GetCost()
        {
            return 100;
        }

        public string GetDescription()
        {
            return "Simple procuct ";
        }
    }
}
