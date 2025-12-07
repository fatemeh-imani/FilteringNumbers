using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FilteringNumbers.FilterStrategyByOverloading
{
    public static class NumberService
    {

        public static List<int> ReadNumbersFromUserList()
        {
            List<int> numbers = new List<int>();  // برای افزودن اعداد
            ConsoleUserIO.Write(Messages.EnterNumbers);

            while (true)
            {
                string input = ConsoleUserIO.Read();
                if (input.ToLower() == "done") break;

                if (int.TryParse(input, out int number))
                    numbers.Add(number);
                else
                    ConsoleUserIO.Write(Messages.InvalidInput);
            }
            return numbers;
        }

        public static int[] ReadNumbersFromUserArray()
        {
            List<int> numbers = new List<int>();  // برای افزودن اعداد
            ConsoleUserIO.Write(Messages.EnterNumbers);

            while (true)
            {
                string input = ConsoleUserIO.Read();
                if (input.ToLower() == "done") break;

                if (int.TryParse(input, out int number))
                    numbers.Add(number);
                else
                    ConsoleUserIO.Write(Messages.InvalidInput);
            }
            return [.. numbers];
        }
        // کلاس استاتیک برای فیلتر کردن اعداد
        public static List<int> FilterNumbers(List<int> numbers)
        {
            return numbers.Where(n => n > 5).ToList();
        }

        public static int[] FilterNumbers(int[] numbers)
        {
            return numbers.Where(n => n > 5).ToArray();
        }

        public static void PrintNumbers(List<int> numbers)
        {
            ConsoleUserIO.Write("=== Printing numbers from List ===");
            ConsoleUserIO.Write(Messages.Result);

             foreach (int n in numbers)
                ConsoleUserIO.Write(n.ToString()); 
           
        }

        public static void PrintNumbers(int[] numbers)
        {
            ConsoleUserIO.Write("=== Printing numbers from Array ===");
            ConsoleUserIO.Write(Messages.Result);

            foreach (int n in numbers)
                ConsoleUserIO.Write(n.ToString());

        }

    }
}
