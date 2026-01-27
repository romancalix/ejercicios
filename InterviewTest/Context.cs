using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest
{
    public class Context
    {
        private readonly IStrategy _strategy;
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void ExecuteStrategy()
        {
            _strategy.Execute();
        }
    }
}
