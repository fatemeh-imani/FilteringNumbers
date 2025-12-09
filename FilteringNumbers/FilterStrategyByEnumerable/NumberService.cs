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
            ConsoleUserIO.Write(Messages.EnterNumbers);
            
            while (true)
            {
                string input = ConsoleUserIO.Read();
                if (input.ToLower() == "done") yield break;

                if(int.TryParse(input,out int number))
                    yield return number;
                    
                else
                    ConsoleUserIO.Write(Messages.InvalidInput);
            }
        }

        // کلاس استاتیک برای فیلتر کردن اعداد
        public static IEnumerable<int> FilterNumbers(this IEnumerable<int> numbers, IFilter<int>  filter) 
        {
            foreach (var n in numbers)
            {
                if (filter.IsMatch(n))
                    yield return (int)n;
            }
         
        }

       public static void PrintNumbers(this IEnumerable<int> numbers)
        {
            ConsoleUserIO.Write("=== Printing numbers from Enumerable ===");
            ConsoleUserIO.Write(Messages.Result);

             foreach (int n in numbers)
                ConsoleUserIO.Write(n.ToString()); 
           
        }

    }
}
