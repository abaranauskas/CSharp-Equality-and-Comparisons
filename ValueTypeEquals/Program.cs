using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            var banana = new FoodItem("Banana", FoodGroup.Fruit);
            var banana2 = new FoodItem("Banana", FoodGroup.Fruit);
            var chocolate = new FoodItem("Chocolate", FoodGroup.Sweets);


            Console.WriteLine($"banana == bnana2 : {banana==banana2}");
            Console.WriteLine($"banana == chocolate : {banana == chocolate}");
            Console.WriteLine($"banana2 == chocolate : {banana2 == chocolate}");



            /*var group1 = new FoodItem("Kopustas", FoodGroup.Vegetables);
            var group2 = new FoodItem("Kopustas", FoodGroup.Vegetables);
            var group3 = new FoodItem("Kepsnys", FoodGroup.Meat);
            //var group4 = new FoodItem();

            Console.WriteLine( group1.Equals(group2));
            Console.WriteLine(group1.Equals(group3));
            Console.WriteLine(group1.GetHashCode());
            Console.WriteLine(group3.GetHashCode());
            Console.WriteLine(group2.GetHashCode());*/
        }
    }
}
