using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_total
{
    internal class divisible
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 5 == 0 && num1 % 11 == 0)
            {
                Console.WriteLine("Divisible");
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }
        }
    }
}
