using System;

namespace MinMaxSumAverageofNNumbers
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// ot n na broi 4isla se izkarvat nai malko,golqmo,sumata ot 2+min+max i srednoto na sum/n
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            double number = 0;
            for (int i = 0; i < n; i++)
            {
                 number = double.Parse(Console.ReadLine());
                sum += number;
                if(number<min)
                {
                    min = number;
                }
                if(number>max)
                {
                    max = number;
                }
            }
            Console.WriteLine("min={0:F2}" , min);
            Console.WriteLine("max={0:F2}" , max);
            Console.WriteLine("sum={0:F2}" , sum);
            Console.WriteLine("avg={0:F2}", sum/n);
        }
    }
}
