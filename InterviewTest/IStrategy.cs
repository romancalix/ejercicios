using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest
{
    public interface IStrategy<T>
    {
        void Execute();
        public T Response { get; }
    }
}
