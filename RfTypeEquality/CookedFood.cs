using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfTypeEquality
{
    public sealed class CookedFood : Food
    {
        public CookedFood(string cookingMethod, string name, FoodGroup group)
            :base(name, group)
        {
            _cookingMethod = cookingMethod;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this._cookingMethod.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
            {
                return false;
            }

            CookedFood rhs = obj as CookedFood;
            return this.CookingMethod == rhs.CookingMethod;
        }

        public static bool operator ==(CookedFood obj1, CookedFood obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(CookedFood obj1, CookedFood obj2)
        {
            return !Object.Equals(obj1, obj2);
        }



        public override string ToString()
        {
            return $"{_cookingMethod} {Name}";
        }



        public string _cookingMethod;
        public string CookingMethod { get { return _cookingMethod; } }
    }
}
