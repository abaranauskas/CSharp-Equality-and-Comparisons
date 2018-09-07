using System;


namespace FoodEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Food banana = new Food("Banana");
            Food banana2 = new Food("Banana");
            Food chocolate = new Food("Chocolate");


            //Console.WriteLine(banana.Equals(null));
            //Console.WriteLine(Object.Equals(banana, null));
            //Console.WriteLine(Object.Equals(null, null));

            Console.WriteLine(banana.Equals(chocolate)); //false kai class
            Console.WriteLine(banana.Equals(banana2));  //bus false kai class
            //Console.WriteLine(banana == chocolate);
            
        }        
    }
}
