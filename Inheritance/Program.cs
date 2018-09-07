using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            object str1 = "apple";            
            object str2 = string.Copy((string)str1);

            Console.WriteLine("ReferenceEquals();  : " + ReferenceEquals(str1, str2));
            Console.WriteLine("Method string.Equals(str); ==   : " + str1.Equals(str2));
            Console.WriteLine("Operator ==   : " + (str1 == str2));
            Console.WriteLine("Static Equals()   : " + object.Equals(str1, str1));

        }
    }
}
