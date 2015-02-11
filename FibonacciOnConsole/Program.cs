using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciOnConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var fib = new FibonacciCUI();
            fib.Calc(new FibonacciWithCache());
        }
    }
}
