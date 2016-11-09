using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CatalanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result;

            result = (Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n));
            Console.WriteLine(result);//2n!/(n+1)!n!
        }

        public static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = n; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
       