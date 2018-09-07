using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLastChapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringComparer.

            var names = new HashSet<string>(StringComparer.CurrentCultureIgnoreCase);

            names.Add("apple");
            names.Add("pear");
            names.Add("pineapple");
            names.Add("Apple");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }


        }
    }
}
