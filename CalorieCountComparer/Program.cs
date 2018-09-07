using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCountComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            CalorieCount cal300 = new CalorieCount(300.5f);
            CalorieCount cal400 = new CalorieCount(400);
            CalorieCount cal300b = new CalorieCount(300.5f);

            Console.WriteLine(cal300.Equals(cal300b));

            DisplayOrder(cal300, cal400);
            DisplayOrder(cal400, cal300);
            DisplayOrder(cal300, cal300);

            if (cal300 < cal400)
            {
                Console.WriteLine("cal300 < cal400");
            }

            if (cal300 == cal300)
            {
                Console.WriteLine("cal300 == cal300");
            }

            if (cal300 != cal400)
            {
                Console.WriteLine("cal300 != cal400");
            }


        }

        static void DisplayOrder<T>(T x, T y) where T : IComparable<T>
        {
            int result = x.CompareTo(y);
            if (result == 0)
            {
                Console.WriteLine($"{x,12} = {y}");
            }
            else if (result < 0)
            {
                Console.WriteLine($"{x,12} < {y}");
            }
            else
            {
                Console.WriteLine($"{x,12} > {y}");
            }

        }
    }
}
