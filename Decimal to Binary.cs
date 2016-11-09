using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Decimal_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            string result = null;

            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    list.Add("0");
                }
                else
                {
                    list.Add("1");
                }
                n = n / 2;
            }
            result = string.Join("", list.ToArray());
            Console.WriteLine(StringHelper.ReverseString(result));
        }
        static class StringHelper
        {
            public static string ReverseString(string s)
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }
        }
    }
}
