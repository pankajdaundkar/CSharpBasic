using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_total
{
    internal class leap_year
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Enter a year ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("it is a leap year");
            }
            else
            {
                Console.WriteLine("it is not a leap year");

            }
        }
    }
}