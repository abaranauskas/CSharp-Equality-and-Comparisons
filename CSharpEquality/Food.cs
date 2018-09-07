using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEquality
{
    public enum FoodGroup
    {
        Meat, Fruit, Vegetables, Sweets
    }

    public class Food
    {
        public Food(string name, FoodGroup group)
        {
            _name = name;
            _group = group;
        }


        public override string ToString()
        {
            return string.Format($"{_name} ({_group})"); ;
        }

        private readonly string _name;
        private readonly FoodGroup _group;


        public string Name { get { return _name; } }
        public FoodGroup Group { get { return _group; } }




        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (ReferenceEquals(obj, this))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Food rhs = obj as Food;
            return this._name == rhs._name && this._group == rhs._group;
        }

        public static bool operator ==(Food obj1, Food obj2)
        {
            return Object.Equals(obj1, obj2); //teisingas budas


            //return obj1.Name == obj1.Name && obj1.Group == obj2.Group;
            //sis budas atrodo teisingas, bet istikruju NE. nes perduodant i metoda parametru
            //jie buvo pazymeti kaip food. ir kompiletorius lyginas kai FOO nors jie yra cookedfood
        }

        public static bool operator !=(Food obj1, Food obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return this._name.GetHashCode() ^ this._group.GetHashCode();
        }


        
    }

}
