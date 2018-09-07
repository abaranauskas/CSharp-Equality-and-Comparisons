using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            Button button1 = new Button();
            button1.Text = "Click me now!";

            Button button2 = new Button();
            button2.Text = "Click me now!";

            //Console.WriteLine(button1==button2);

            string str1 = "Click me now!";
            string str2 = String.Copy(str1);

            //Console.WriteLine($"str1 == {str1}");
            //Console.WriteLine($"str2 == {str2}");
            // Console.WriteLine(str1==str2);


            // ------------------------------------------------------------

            int three = 3;
            int threeAgain = 3;
            bool intComp = (three == threeAgain);
            Console.WriteLine($"Compares ints:   {intComp}");

            bool objComp = ((object)three == (object)threeAgain);
            Console.WriteLine($"Compares Objects:   {objComp}");

            bool interfaceComp = ((IComparable<int>)three == (IComparable<int>)threeAgain);
            Console.WriteLine($"Compares Interfaces:   {interfaceComp}");

            // ------------------------------------------------------------
            float six = 6.000000000f;
            float nearlySix = 6.000000001f;

            Console.WriteLine(six == nearlySix); //rodo true


            float x = 5.05f;
            float y = 0.95f;

            Console.WriteLine(x+y); //rodo 6
            Console.WriteLine("x + y == 6? " + (x + y == 6.0f)); //bet cia rodo false

            // ------------------------------------------------------------
           
        }
    }
}
