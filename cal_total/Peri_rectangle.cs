using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_total
{
    internal class Peri_rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the length and breadth of rectangle");

            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length of a rectangle");

            int breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle");

            int P = 2 * (length + breadth);

            Console.WriteLine(P);
        }
    }
}
