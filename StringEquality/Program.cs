using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areEqual = string.Equals("Apple", "Pineapple", StringComparison.CurrentCultureIgnoreCase);

            int cmpResult = string.Compare("Apple", "apple",
                                    CultureInfo.GetCultureInfo("fr-FR"),
                                    CompareOptions.IgnoreCase);
            var areEqual2 = (cmpResult == 0);

            bool areEqual3 = "Apple" == "Apple"; //bus pagal ordinar case sansitive comparison


            //Console.WriteLine(areEqual);
            //Console.WriteLine(areEqual2);
            //Console.WriteLine(areEqual3); 

            string apple1 = "Apple";
            string apple2 = "Ap" + "ple";
            //nors cia yra tarsi du nauji objektai sukuriami taciau kompiletorius mato kad tai vienodos
            //reiksmes ir del to sukuriamas vinas objektas o kintamiejo 
            //laiko pointerius i ta objekta. bet jei per compy padarysim
            string apple3 = string.Copy(apple1); 
            //tokiu atveju jau pointeriai skirsi ir ReferenceEquals(); bus false
            //bet lyginant pagal value == visi 3 kint bus lygys
             

            Console.WriteLine($"Strings are {apple1} and {apple2}");

            Console.WriteLine(apple1 == apple2);
            Console.WriteLine(ReferenceEquals(apple1, apple2));

        }
    }
}
