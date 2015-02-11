
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
