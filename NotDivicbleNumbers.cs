using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivicibleNumbers
{
    class NotDivicbleNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)//pri n =10 izkarva vsi4ki 4isla v redicata koito ne se delqt na 3 i 7../1,2,4,5,8,10
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
                Console.WriteLine();
        }
    }
}
