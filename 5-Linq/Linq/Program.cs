using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func<int, int, int> add = (a, b) => a + b;

            Func<string, int, string> format = (a, b) => a.Substring(b);

            Func<double, double> calculateDiscount = (a) => a * 0.75;

            Console.WriteLine(add(2, 3));

            Console.WriteLine(format("hdaslkdasdasdasd", 3));

            Console.WriteLine(calculateDiscount(200));

            Console.ReadKey();
        }

        private static double CalculateDiscount(double price)
        {
            return price * 0.75;
        }

    
    }
}
