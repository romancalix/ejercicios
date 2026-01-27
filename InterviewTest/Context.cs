using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest
{
    public class Context <T>
    {
        private readonly IStrategy<T> _strategy;
        
        public Context(IStrategy<T> strategy)
        {
            _strategy = strategy;
        }
        public void ExecuteStrategy()
        {
            _strategy.Execute();
        }

        public T GetResponse()
        {
            return _strategy.Response;
        }
    }
}
