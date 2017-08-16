using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_sum_of_even_terms
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            Int32 c = 0,sum = 2;
            while(a < 4000000)
            {
                if (c % 2 == 0)
                    sum += c;
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine("Fibonacci sum of even terms below 4 million is {0}",sum);
            Console.ReadKey();
        }
    }
}
