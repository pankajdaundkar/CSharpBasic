using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_total
{
    internal class celcious_Fahr
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            Console.WriteLine("Enter the temperature in Celsius");
            celsius = Convert.ToInt32(Console.ReadLine());



            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine(fahrenheit);
        }
    }
}
