using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfTypeEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            Food apple = new Food("apple", FoodGroup.Fruit);
            CookedFood strewdApple = new CookedFood("Strewed", "apple", FoodGroup.Fruit);
            CookedFood bakedApple = new CookedFood("Baked", "apple", FoodGroup.Fruit);
            CookedFood strewdApple2 = new CookedFood("Strewed", "apple", FoodGroup.Fruit);
            Food apple2 = new Food("apple", FoodGroup.Fruit);
                        

            DisplayWhetherEqual(apple, strewdApple);
            DisplayWhetherEqual(strewdApple, bakedApple);
            DisplayWhetherEqual(strewdApple, strewdApple2);
            DisplayWhetherEqual(apple, apple2);
            DisplayWhetherEqual(apple, apple);
            

            //Console.WriteLine(apple);
            //Console.WriteLine(strewdApple);

        }

        static void DisplayWhetherEqual(Food food1, Food food2)
        {
            if (food1==food2)
            {
                Console.WriteLine($"{food1,13} == {food2}");
            }
            else
            {
                Console.WriteLine($"{food1, 13} != {food2}");
            }
        }
    }
}
