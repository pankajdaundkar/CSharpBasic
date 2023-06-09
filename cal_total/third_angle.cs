using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_total
{
    internal class third_angle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("angle one");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("angle two");

            int b = Convert.ToInt32(Console.ReadLine());

            int c = (a + b) - 180;

            Console.WriteLine(c);
        }
    }
}
