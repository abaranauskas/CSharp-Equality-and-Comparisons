using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaschCode
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodItem beetRoot = new FoodItem("beetroot", FoodGroup.Vegetables);
            FoodItem pickledBeetRoot = new FoodItem("beetroot", FoodGroup.Sweets);

            var eqComparer = FoodNameEqualityComparer.Instance;

            bool equals = eqComparer.Equals(beetRoot, pickledBeetRoot);

            Console.WriteLine($"equals ? {equals}");
            Console.WriteLine(eqComparer.GetHashCode(beetRoot));
            Console.WriteLine(eqComparer.GetHashCode(pickledBeetRoot));
        }
    }
}
