
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFilterApp
{
    public static class ConsoleUserIO
    {
        private static IUserIO? _testOverride;
        public static void OverrideForTest(IUserIO fake) => _testOverride = fake;

        public static string Read()
        {
            if (_testOverride != null)
                return _testOverride.Read();

            return Console.ReadLine();
        }

        public static void Write(string message)
        {
            if (_testOverride != null)
            {
                _testOverride.Write(message);
                return;
            }

            Console.WriteLine(message);
        }


    }
}
