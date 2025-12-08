using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringNumbers.FilterStrategyByobject
{
    public static class FilterConditions
    {
        public static Func<object, bool> DefaultFilter = item =>
        {
            if (item is int n) return n > 10;
            if (item is double d) return d > 10;
            if (item is string) return true;
            return false;
        };
    }
}
