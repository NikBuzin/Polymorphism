using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class FirstClass
    {
        
        public string _name;
        public int _cost;
        public int _count;
        public int _q;
        public FirstClass(string name, int cost, int count)
        {
            _name = name;
            _cost = cost;
            _count = count;
        }
       /*public void AddItem(FirstClass item)
        {
            _item.Add(item);
        }*/
        public virtual void Quality()
        {
            _q = _cost / _count;
        }
        public string ShowInf(List<FirstClass> _item)
        {
            StringBuilder builder = new StringBuilder();
            string delimeter = " ";
            for(int i = 0; i < _item.Count; i++)
            {
                builder.Append(_item[i]._name);
                builder.Append(delimeter);
                builder.Append(_item[i]._cost);
                builder.Append(delimeter);
                builder.Append(_item[i]._count);
                builder.Append(delimeter);
                builder.Append(_item[i]._q);
            }
            return builder.ToString();
        }
    }
}
