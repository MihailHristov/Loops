using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1;
            double currentFactioriel = 1;//factorielite i proizvedeniqta se zadavt sus stoinost po defaullt =1
            double currentPow = 1;

            for (int i = 1; i <= n; i++)
            {
                currentFactioriel *= i;
                currentPow *= x;
                sum += currentFactioriel / currentPow;
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
