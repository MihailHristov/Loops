using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculate3
{
    class Calculate3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger nkFactorial = 1;
            BigInteger result = 0;

            for (int i = 1; i < n + 1; i++)
            {
                nFactorial *= i;

                if (i <= k)
                {
                    kFactorial *= i;
                }
            }

            for (int nk = n - k; nk > 1; nk--)
            {
                nkFactorial *= nk;
            }

            result = (nFactorial / (kFactorial * nkFactorial));
            Console.WriteLine(result);//smqta 3.2.1/1.2 ..4*3*2*1/2*1...10!/6!*24
        }
    }
}
