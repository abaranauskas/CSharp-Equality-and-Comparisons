using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIntCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string apple = "apple";
            string pear = "pear";


            DisplayOrder(apple, pear);
            DisplayOrder(pear, apple);
            DisplayOrder(apple, apple);

            DisplayOrder(3,4);
            DisplayOrder(4,3);
            DisplayOrder(3,3);

            if ((3).CompareTo(4) > 0)
            {
                Console.WriteLine("4 < 3");
            } else
            {
                Console.WriteLine("4 > 3");
            }

            Console.WriteLine(apple.CompareTo(pear));
            Console.WriteLine(pear.CompareTo(apple));
            Console.WriteLine(apple.CompareTo(apple));
        }

        static void DisplayOrder<T>(T x, T y) where T: IComparable<T>
        {
            int result = x.CompareTo(y);
            if (result ==0)
            {
                Console.WriteLine($"{x,12} = {y}");
            } else if (result < 0)
            {
                Console.WriteLine($"{x,12} < {y}");
            } else
            {
                Console.WriteLine($"{x,12} > {y}");
            }

        }
    }
}
