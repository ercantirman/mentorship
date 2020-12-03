using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();

            int? number2 = null;
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
