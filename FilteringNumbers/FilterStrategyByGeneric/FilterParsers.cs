using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringNumbers.FilterStrategyByGeneric
{
    public static class FilterParsers
    {
        public static Func<string, (bool Success, int Value)> IntParser = s =>
        int.TryParse(s, out int n) ? (true, n) : (false, 0);

        public static Func<string, (bool Success, string Value)> StringParser = s =>
            (!string.IsNullOrEmpty(s)) ? (true, s) : (false, "");

        public static Func<string, (bool Success, double Value)> DoubleParser = s =>
        {
            bool success = double.TryParse(
                s,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out double value);
            return (success, value);
        };

    }
}
