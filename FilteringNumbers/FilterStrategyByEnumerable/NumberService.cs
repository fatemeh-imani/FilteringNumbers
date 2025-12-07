using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FilteringNumbers.FilterStrategyByEnumerable
{
    public static class NumberService
    {
        
        public static IEnumerable<int> ReadNumbersFromUser()
        {
            List<int> numbers = new List<int>();  // برای افزودن اعداد
            ConsoleUserIO.Write(Messages.EnterNumbers);
            
            while (true)
            {
                string input = ConsoleUserIO.Read();
                if (input.ToLower() == "done") break;

                if(int.TryParse(input,out int number))
                    numbers.Add(number);
                else
                    ConsoleUserIO.Write(Messages.InvalidInput);
            }
            return numbers;
        }

        // کلاس استاتیک برای فیلتر کردن اعداد
        public static IEnumerable<int> FilterNumbers(IEnumerable<int> numbers, IFilter  filter)
        {
          return  numbers.Where(n => filter.IsMatch(n)).ToList();
        }

       public static void PrintNumbers(IEnumerable<int> numbers)
        {
            ConsoleUserIO.Write("=== Printing numbers from Enumerable ===");
            ConsoleUserIO.Write(Messages.Result);

             foreach (int n in numbers)
                ConsoleUserIO.Write(n.ToString()); 
           
        }

    }
}
