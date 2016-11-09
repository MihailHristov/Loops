using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] sequence = Console.ReadLine().Split();
            int[] number = new int[n];
            BigInteger odd = 1;
            BigInteger even = 1;
            for (int i = 0; i < sequence.Length; i++)
            {
                number[i] = Convert.ToInt32(sequence[i]);
            }
            for (int i = 0; i < number.Length; i += 2)
            {
                even *= number[i];
            }
            for (int i = 1; i < number.Length; i += 2)
            {
                odd *= number[i];
            }
            if (even == odd)
            {
                Console.WriteLine("yes {0}", odd);
            }
            else
            {
                Console.WriteLine("no {0} {1}", even, odd);
            }
        }
    }
}
