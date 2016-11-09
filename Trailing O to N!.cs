using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Trailing_0_to_N_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int addFactor = 0;
            int devide = 0;
            int counter = 1;

            while (true)
            {
                devide = (int)Math.Pow(5, counter);
                addFactor += n / devide;
                if ((n / devide) < 1)
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(addFactor);
        }
    }
}
