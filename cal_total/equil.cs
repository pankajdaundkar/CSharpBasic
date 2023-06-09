using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_total
{
    internal class equil
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of an equivalent triangle");

            int a = Convert.ToInt32(Console.ReadLine());

            double area = 1.73 / 4 * (a) * 2;

            Console.WriteLine(area);
        }
    }
}
