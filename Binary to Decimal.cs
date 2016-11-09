using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace Binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();
            string[] binArray = Regex.Split(bin, "");
            BigInteger counter = 1;
            BigInteger sum = 0;
            BigInteger finalSum = 0;

            for (int i = binArray.Length - 2; i > 0; i--)
            {
                sum = counter * Int32.Parse(binArray[i]);
                finalSum += sum;
                counter *= 2;
            }
            Console.WriteLine(finalSum);
        }
    }
}
