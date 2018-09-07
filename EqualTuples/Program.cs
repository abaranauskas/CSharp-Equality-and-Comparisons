using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int> tuple1 = Tuple.Create(1, 3);
            Tuple<int, int> tuple2 = Tuple.Create(1, 3);

            Console.WriteLine(
              "Method Tuple.ReferenceEquals();  : " + Tuple.ReferenceEquals(tuple1, tuple2));
            Console.WriteLine(
                "Method Tuple.Equals(); ==   : " + tuple1.Equals(tuple2));

            Console.WriteLine(
                "Operator == for Tuple  : " + (tuple1==tuple2));            
        }
    }
}
