using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outkey
{
    internal class Program
    {

        static void Calculation(int a, int b, out int sum, out int sub, out int multiply)
        {
            sum = a + b;
            sub = a - b;
            multiply = a * b;
        }
        static void Main(string[] args)
        {
            int a = 20, b = 10, sum, sub, multiply;
            Calculation(a, b, out sum, out sub, out multiply);
            Console.WriteLine($"sum={sum} sub={sub} multiply={multiply}");
        }
    }
}
    

