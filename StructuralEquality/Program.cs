using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = {"apple", "pear", "pineapple" };
            string[] arr2 = { "apple", "orange", "pineapple" };

            Console.WriteLine(arr1 == arr2);
            Console.WriteLine(arr1.Equals(arr2));
            Console.WriteLine(Array.Equals(arr1,arr2));
            Console.WriteLine(ReferenceEquals(arr1,arr2));

            //IStructuralEquatable
            var arrEq = (IStructuralEquatable)arr1;
            bool structEqual = arrEq.Equals(arr1, StringComparer.Ordinal);
            bool structEqual2 = arrEq.Equals(arr2, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(structEqual);
            Console.WriteLine(structEqual2);

            //IStructuralComparable
            var arrComp = (IStructuralComparable)arr2;

            int structCompare = arrComp.CompareTo(arr1, StringComparer.Ordinal);
            Console.WriteLine(structCompare);


        }
    }
}
