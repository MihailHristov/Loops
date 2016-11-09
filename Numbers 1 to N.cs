using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)//pri n=4 izkarva 1,2,3,3 i t.n
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
