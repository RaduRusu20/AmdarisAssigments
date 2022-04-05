using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionsArrays
{
    public class StringC : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.Length == y.Length;
        }

        public int GetHashCode( string obj)
        {
                return obj.Length.GetHashCode();
        }
    }
}
