using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class Gelato : Icecream
    {
        uint price;
        string taste;
        bool waffle;
        bool sprinkles;

        public Gelato(uint _price, string _taste, bool _waffle, bool _sprinkles) 
        {
            price = _price;
            taste = _taste;
            waffle = _waffle;
            sprinkles = _sprinkles;
        }
        public override string show_ice()
        {
            return ("Gelato: " + taste + "\tWaffle: " + waffle + "\tSprinkles: " + sprinkles + "\tPrice: " + price);
        }

        public override Icecream daily_special() { return new Gelato(6, "creamy", true, false); }
    }
}
