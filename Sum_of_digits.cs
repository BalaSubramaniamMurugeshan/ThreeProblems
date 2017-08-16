using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger value = BigInteger.Pow(2,1000);
            char [] array = value.ToString().ToCharArray();
            double sum = 0;
            for(int i=0;i<array.Length;i++)
                sum += char.GetNumericValue(array[i]);
            Console.WriteLine("The sum of digits of 2^1000 is "+sum);
            Console.ReadKey();
        }
    }
}
