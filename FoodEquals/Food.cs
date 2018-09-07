using System;
using System.Text;


namespace FoodEquals
{
    public struct Food //: IEquatable<Food>
    {
        public Food(string name)
        {
            this._name = name;
        }


        private string _name;
        public string Name
        {
            get { return _name; }           
        }

        public override string ToString()
        {
            return _name;
        }

        //public bool Equals(Food other)
        //{
        //    //throw new NotImplementedException();
        //    return true;
        //}
    }
}
