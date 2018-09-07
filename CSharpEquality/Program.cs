using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            //String[] list = {
            //    "orange",
            //    "banana",
            //    "pear",
            //    "apple"
            //};

            Food[] list =
            {
                new Food("Orange", FoodGroup.Fruit),
                new Food("banana", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit),
                new Food("apple", FoodGroup.Fruit)
            };
           // SortAndShowList(list);


            Food[] list1 =
            {
                
                new Food("apple", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit),
                new CookedFood("baked", "apple", FoodGroup.Fruit)

            };
            SortAndShowList(list1);

            Console.WriteLine();
            Food[] list2 = 
            {
                new CookedFood("baked", "apple", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit),
                new Food("apple", FoodGroup.Fruit)

            };
            SortAndShowList(list2);


        }

        private static void SortAndShowList(Food[] list)
        {
            Array.Sort(list, FoodNameComparer.Instance);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
