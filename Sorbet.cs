using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class Sorbet : Icecream
    {
        uint price;
        string taste;

        public Sorbet(uint _price, string _taste) 
        {
            price = _price;
            taste = _taste;
        }

        public override string show_ice() 
        {
            return ("Sorbet: " + taste + "\tPrice: " + price);
        }

        public override Icecream daily_special() { return new Sorbet(4, "lemon"); }
    }
}
