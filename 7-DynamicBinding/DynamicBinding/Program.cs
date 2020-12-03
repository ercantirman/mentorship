
using System;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic value = 1234;
            Console.WriteLine(value);
            value = "ercan";
            Console.WriteLine(value);
            value = DateTime.Today;
            Console.WriteLine(value);

            Console.ReadKey();
        }
    }
}
