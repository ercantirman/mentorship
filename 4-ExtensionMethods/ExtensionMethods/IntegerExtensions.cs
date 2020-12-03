using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class IntegerExtensions
    {
        public static int MultiplyWithTwo(this int number)
        {
            return number * 2;
        }
    }
}
