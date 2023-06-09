using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_total
{
    internal class fharen_celsious
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.WriteLine("Enter the temperatire in fahrenheit");
            fahrenheit = Convert.ToInt32(Console.ReadLine());

            celsius = (fahrenheit - 32) * 0.55;

            Console.WriteLine(celsius);
        }
    }
}
