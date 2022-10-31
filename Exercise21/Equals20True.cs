using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    internal class Equals20True
    {
        static void Main(string[] args)
        {
            int x, y;
            int result;

            Console.WriteLine("\nInput an integer:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another integer:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || (x + y == 20));
        }
    }
}
