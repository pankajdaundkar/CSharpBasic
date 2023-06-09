using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_total
{
    internal class area_circle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of circle");

            double Radius = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radius * Radius;

            Console.WriteLine("Area of circle: " + Area);

            Console.ReadLine();
        }
    }
}
