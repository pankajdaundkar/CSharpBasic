using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_total
{
    internal class cal_CI
    {
        static void Main(string[] args)
        {
            int n, P, T, R;
            double CI;

            Console.WriteLine("Enter Value of n:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of Priciple amount:");
            P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of Rate:");
            R = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of Time period:");
            T = Convert.ToInt32(Console.ReadLine());

            CI = P * (1 + R / n) ^ (n * T);
            Console.WriteLine("Compound Interest is :" + CI);
        }
    }
}
