using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FilteringNumbers.FilterStrategyByobject
{
    public static class NumberService
    {

        public static IEnumerable<object> ReadItemsFromUser()
        {
            ConsoleUserIO.Write(Messages.EnterItems);

            while (true)
            {
                string input = ConsoleUserIO.Read();
                if (input.ToLower() == "done") yield break;

                if (int.TryParse(input, out int n))
                    yield return n;

                else if (double.TryParse(input, out double d))
                    yield return d;

                else
                    yield return input;
            }
            
        }

        // کلاس استاتیک برای فیلتر کردن اعداد

        public static IEnumerable<object> FilterObjects(this IEnumerable<object> items, Func<object, bool> filter)
        {
            foreach (object item in items)
            {
                if(filter(item)) yield return item;
            }
        }

        public static void PrintItems(this IEnumerable<object> items)
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
