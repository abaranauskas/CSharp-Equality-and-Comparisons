using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaschCode
{
    class FoodNameEqualityComparer : EqualityComparer<FoodItem>
    {
        private FoodNameEqualityComparer()
        {

        }

        private static FoodNameEqualityComparer _instace = new FoodNameEqualityComparer();

        public static FoodNameEqualityComparer Instance { get { return _instace; } }

        


        public override bool Equals(FoodItem x, FoodItem y)
        {
            return x.Name == y.Name;
        }

        public override int GetHashCode(FoodItem obj)
        {
            //return obj.Name.GetHashCode() ^ obj.Group.GetHashCode();
            return obj.Name.GetHashCode();
        }
    }
}
