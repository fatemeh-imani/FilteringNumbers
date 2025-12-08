using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringNumbers.FilterStrategyByGeneric
{
    public static class FilterConditions
    {
        public static Func<int, bool> GreaterThan10 = n => n > 10;
        public static Func<double, bool> DoubleGreaterThan10 = d => d > 10.0;
        public static Func<string, bool> AnyString = s => true;

       
    }
}
