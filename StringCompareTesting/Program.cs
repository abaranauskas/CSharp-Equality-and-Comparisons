using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompareTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            //int result = string.Compare("lemon", "lime", StringComparison.Ordinal);
            //bus -4 nes e is lemon yra 101 o i is lime yra 105 taip lyginamos string pagal jose esancius char
            //atrodo pirma nesutapima

            //int result = string.Compare("lemon", "LEMON", StringComparison.Ordinal);
            //bus 32 nes l(108) yra 32 pozicijom auksciaunei L(76) todel lemon >LEMON

            //int result = string.Compare("lemon", "LEMON", StringComparison.OrdinalIgnoreCase);
            // bus 0 nes ignoruojama Case

            int result = string.Compare("lemon", "LEMON", StringComparison.Ordinal);

            Console.WriteLine($"Copare result is: {result}");
        }
    }
}
