using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCountComparer
{
    public struct CalorieCount : IComparable<CalorieCount>, IEquatable<CalorieCount>, IComparable
    {
        public CalorieCount(float value)
        {
            _value = value;
        }

        private float _value;
        public float Value { get { return _value; } }

        public override string ToString()
        {
            return _value + "cal";
        }

        public int CompareTo(CalorieCount other)
        {
            if (this.Value < other.Value)
            {
                return -1;
            }else if (this.Value > other.Value)
            {
                return 1;
            }
            else
            {
                return 0;
            }


            //cia butu lengvesnis budas nes float jau turi CompareTo()
            //return this.Value.CompareTo(other.Value);
        }

        public int CompareTo(object obj)  //seno Icopareble overidinimas, jis beveik nenaudojamas
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Null");
            }

            if (!(obj is CalorieCount))
            {
                throw new ArgumentException("Turi buti CalorieCount objektas");
            }

            return this.CompareTo((CalorieCount)obj);
            
        }

        public override bool Equals(object obj)
        {
            if (this ==null)
            {
                return false;
            }
            if (!(obj is CalorieCount))
            {
                return false;
            }
            return _value == ((CalorieCount)obj)._value;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public bool Equals(CalorieCount other)
        {
            return this.Value == other.Value;
        }

       

        public static bool operator <(CalorieCount x, CalorieCount y)
        {
            return x.Value < y.Value;
        }

        public static bool operator <=(CalorieCount x, CalorieCount y)
        {
            return x.Value <= y.Value;
        }

        public static bool operator >(CalorieCount x, CalorieCount y)
        {
            return x.Value > y.Value;
        }

        public static bool operator >=(CalorieCount x, CalorieCount y)
        {
            return x.Value >= y.Value;
        }

        public static bool operator ==(CalorieCount x, CalorieCount y)
        {
            return x.Value==y.Value;
        }

        public static bool operator !=(CalorieCount x, CalorieCount y)
        {
            return x.Value != y.Value;
        }
    }
}
