using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            for (int range = 3; range < 1000; range++)
                if (range % 3 == 0 || range % 5 == 0)
                    Sum += range;
            Console.WriteLine("Sum of multiples of 3 and 5 is {0}",Sum);
            Console.ReadKey();
        }
    }
}
