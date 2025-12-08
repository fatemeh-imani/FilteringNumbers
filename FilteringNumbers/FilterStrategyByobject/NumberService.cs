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
            List<object> items = new List<object>();  // برای افزودن اعداد
            ConsoleUserIO.Write(Messages.EnterNumbers);

            while (true)
            {
                string input = ConsoleUserIO.Read();
                if (input.ToLower() == "done") break;

                if (int.TryParse(input, out int n))
                    items.Add(n);

                else if (double.TryParse(input, out double d))
                    items.Add(d);

                else
                    items.Add(input); // string
            }
            return items;
        }

        // کلاس استاتیک برای فیلتر کردن اعداد

        public static IEnumerable<object> FilterObjects(IEnumerable<object> items, Func<object, bool> filter)
        {
            return items.Where(filter).ToList();
        }

        public static void PrintItems(IEnumerable<object> items)
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
