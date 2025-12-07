using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFilterApp
{
    public static class NumberService
    {
        
        public static List<int> ReadNumbersFromUser()
        {
            List<int> numbers = new List<int>();
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
        public static List<int> FilterNumbers(List<int> numbers)
        {
          return  numbers.Where(n => n > 5).ToList();
        }

       public static void PrintNumbers(List<int> numbers)
        {
            ConsoleUserIO.Write(Messages.Result);

             foreach (int n in numbers)
                ConsoleUserIO.Write(n.ToString()); 
           
        }

    }
}
