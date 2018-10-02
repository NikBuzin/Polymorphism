using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class SecondClass : FirstClass
    {
        public int _p { get; set; }
        public int _t { get; set; }

        public SecondClass(string name, int cost, int count, int p, int t) : base(name, cost, count) 
        {
            _p = p;
            _t = t;
        }

        public override void Quality()
        {
            base.Quality();
            _q = (int)(_q + 0.5 * (_t - _p));

        }
    }
}
