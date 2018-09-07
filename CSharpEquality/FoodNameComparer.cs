using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEquality
{
    class FoodNameComparer : Comparer<Food>
    {
        private FoodNameComparer()  //private ctor neleis niekur kitur kurti objecto pagal sita klase
        {

        }

        private static FoodNameComparer _instance = new FoodNameComparer();
        //Singleton instance

        public static FoodNameComparer Instance { get { return _instance; } }


        public override int Compare(Food x, Food y)
        {
            if (x==null&&y==null)
               return 0;

            if (x == null)
                return -1;

            if (y == null)
                return 1;

            var nameOrder = String.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
            if (nameOrder !=0)
            {
                return nameOrder;
            }

            return String.Compare(x.Group.ToString(), y.Group.ToString(), StringComparison.CurrentCulture);

        }
    }
}
