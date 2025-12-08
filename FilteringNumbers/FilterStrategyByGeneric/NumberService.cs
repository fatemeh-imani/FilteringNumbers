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

        public static List<T> ReadItemsFromUserList<T>(Func<string, (bool Success, T Value)> parser)
        {
            List<T> items = new List<T>();  // برای افزودن اعداد
            ConsoleUserIO.Write(Messages.EnterNumbers);

            while (true)
            {
                string input = ConsoleUserIO.Read();
                if (input.ToLower() == "done") break;

                var result = parser(input);
                if (result.Success)
                    items.Add(result.Value);
                else
                    ConsoleUserIO.Write(Messages.InvalidInput);

            }
            return items;
        }

      
        // کلاس استاتیک برای فیلتر کردن اعداد
        public static IEnumerable<T> FilterObjects<T>(IEnumerable<T> items, Func<T, bool> filter)
        {
            return items.Where(filter).ToList();
        }

       
        public static void PrintItems<T>(IEnumerable<T> items)
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
