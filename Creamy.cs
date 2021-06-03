using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class Creamy : Icecream 
    {
        uint price;
        string taste;
        bool waffle;
        string icing;
        bool sprinkles;

        public Creamy(uint _price, bool _waffle, string _icing, bool _sprinkles) 
        {
            price = _price;
            taste = "creamy";
            waffle = _waffle;
            icing = _icing;
            sprinkles = _sprinkles;
        }
        public override string show_ice()
        {
            return ("Creamy: " + taste + "\tWaffle: " + waffle + "\tIcing: " + icing + "\tSprinkles: " + sprinkles + "\tPrice: " + price);
        }

        public override Icecream daily_special() { return new Creamy(4, true, "fruity", false); }
    }
}
