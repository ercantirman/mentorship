
using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;

            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            DateTime date4 = date.GetValueOrDefault();

            int? integer = null;
            int integer2 = integer.GetValueOrDefault(-1);



            Console.WriteLine(date4);

            Console.ReadKey();

        }
    }
}
