using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEquals
{
    class Program
    {
        static void Main(string[] args)
        {

            string banana = "banana";
            
            string banana1 = string.Copy(banana);
            string bababa = "banana";

            /*Console.WriteLine(banana);
            Console.WriteLine(banana1);
            Console.WriteLine(banana.Equals((object)banana1));
            Console.WriteLine(Object.ReferenceEquals(banana, banana1));
            Console.WriteLine(Object.ReferenceEquals(banana, bababa));*/


            string str1 = "Click me now!";
            string str2 = string.Copy(str1);
            

            Console.WriteLine(
               "Method String.ReferenceEquals();  : " + String.ReferenceEquals(str1, str2));

            Console.WriteLine(
                "Operator ==   : " + AreStringEqualOp(str1, str2));

            Console.WriteLine(
                "Method string.Equals(); ==   : " + AreStringEqualMethod(str1, str2));
           
        }

        static bool AreStringEqualOp(string x, string y)
        {
            return x == y;
        }

        static bool AreStringEqualMethod(string x, string y)
        {
            return x.Equals(y);
        }
    }
}
