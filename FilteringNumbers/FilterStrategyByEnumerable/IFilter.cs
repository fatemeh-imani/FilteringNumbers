using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringNumbers.FilterStrategyByEnumerable
{
    public interface IFilter
    {
        bool IsMatch(int number);
    }
}
