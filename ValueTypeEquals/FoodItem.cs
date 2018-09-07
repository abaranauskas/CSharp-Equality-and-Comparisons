using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeEquals
{
    public enum FoodGroup
    {
        Meat, Fruit, Vegetables, Sweets
    }

    public class FoodItem : IEquatable<FoodItem>
    {
        public FoodItem(string name, FoodGroup group)
        {
            _name = name;
            _group = group;
        }


        public override string ToString()
        {
            return _name;
        }

        public bool Equals(FoodItem other)
        {
            return this.Name == other.Name && this.Group == other.Group;
        }

        public override bool Equals(object obj)
        {
            if (obj is FoodItem)
            {
                return Equals((FoodItem)obj);
            } else
                return false;
        }

        public static bool operator ==(FoodItem lhs, FoodItem rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(FoodItem lhs, FoodItem rhs)
        {
            return !lhs.Equals(rhs);
        }

        public override int GetHashCode()
        {
            return Group.GetHashCode() ^ Name.GetHashCode();
        }




        private readonly string _name;
        private readonly FoodGroup _group;

        
        public string Name { get { return _name; } }
        public FoodGroup Group { get { return _group; } }
    }
}
