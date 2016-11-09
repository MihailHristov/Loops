using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            while (n - k >= 1)
            {
                result *= n;
                n--;
            }
            Console.WriteLine(result);//smqta faktoriel 1/2...1.2.3.4.5/1.2
        }
    }
 }

    

