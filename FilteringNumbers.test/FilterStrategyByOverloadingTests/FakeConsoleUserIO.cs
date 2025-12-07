using FilteringNumbers.FilterStrategyByOverloading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringNumbers.tests.FilterStrategyByOverloadingTests
{
    // کلاس شبیه‌ساز I/O برای Unit Test
    public class FakeConsoleUserIO :IUserIO
    {
        private Queue<string> _inputs;
        public List<string> outputs { get; private set; } = new List<string>();

        public FakeConsoleUserIO(IEnumerable<string> inputs)
        {
            //مثل list باید  new  شود
            _inputs = new Queue<string>(inputs);
        }
        public string Read()
        {
            return _inputs.Count > 0 ? _inputs.Dequeue() : "done";
        }
        public void Write(string message)
        {
            outputs.Add(message);
        }
    }
}
