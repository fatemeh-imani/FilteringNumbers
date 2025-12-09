using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FilteringNumbers.FilterStrategyByGeneric
{
    public static class NumberService
    {

        public static IEnumerable<T> ReadItemsFromUserList<T>(Func<string, (bool Success, T Value)> parser)
        {
            ConsoleUserIO.Write(Messages.EnterItems);

            while (true)
            {
                string input = ConsoleUserIO.Read();
                if (input.ToLower() == "done") yield break;

                var result = parser(input);
                if (result.Success)
                    yield return result.Value;
                 
                else
                    ConsoleUserIO.Write(Messages.InvalidInput);

            }
         
        }

      
        // کلاس استاتیک برای فیلتر کردن اعداد
        public static IEnumerable<T> FilterObjects<T>(this IEnumerable<T> items, Func<T, bool> filter)
        {
            foreach (var item in items)
                if (filter(item))
                    yield return item;
        }

       
        public static void PrintItems<T>(this IEnumerable<T> items)
        {
            
            ConsoleUserIO.Write(Messages.Result);

            foreach (var item in items)
            {
                if (item is double d)
                    ConsoleUserIO.Write(d.ToString(System.Globalization.CultureInfo.InvariantCulture));
                else
                    ConsoleUserIO.Write(item.ToString());
            }

        }

    }
}
