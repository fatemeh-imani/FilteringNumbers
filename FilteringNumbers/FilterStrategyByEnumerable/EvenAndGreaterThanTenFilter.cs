using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringNumbers.FilterStrategyByEnumerable
{
    public class EvenAndGreaterThanTenFilter
    {
        public static bool IsMatch(int number)
        {
            return number % 2 == 0 && number > 10;
        }
    }
}
