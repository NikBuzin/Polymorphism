using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class FirstClass
    {     
        public string _name { get; set; }
        public int _cost { get; set; }
        public int _count { get; set; }
        public double _q { get; set; }

        public FirstClass(string name, int cost, int count)
        {
            _name = name;
            _cost = cost;
            _count = count;
        }

        public virtual void Quality()
        {
            _q = _cost / _count;
        }

        public string ShowInf()
        {
            StringBuilder builder = new StringBuilder();
            string delimeter = " ";
                builder.Append(_name);
                builder.Append(delimeter);
                builder.Append(_cost);
                builder.Append(delimeter);
                builder.Append(_count);
                builder.Append(delimeter);
                builder.Append(_q);
            return builder.ToString();
        }
    }
}
