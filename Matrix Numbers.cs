using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int counter = 1; counter <= n; counter++)
            {
                int num = 0;
                num = num + counter; 
                for (int row = 0; row <=n; row++)
                {
                    Console.Write("{ 0} ",num + row);
                }
                Console.WriteLine();// pri n=2 prinitra s na4alo 1 1.2.2.3 pri n =3 1.2.3 2.3.4. 3.4.5 trqba da ima n i spored stoinosta mu zaema razli4ni mesta
            }
        }
    }
}
