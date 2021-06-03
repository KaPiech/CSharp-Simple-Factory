using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class Fruity : Icecream
    {
        uint price;
        string taste;
        bool waffle;
        string icing;

        public Fruity(uint _price, string _taste, bool _waffle, string _icing)
        {
            price = _price;
            taste = _taste;
            waffle = _waffle;
            icing = _icing;
        }
        public override string show_ice()
        {
            return ("Fruity: " + taste + "\tWaffle: " + waffle + "\tIcing: " + icing + "\tPrice: " + price);
        }

        public override Icecream daily_special() { return new Fruity(5, "orange", true, "chocolate"); }
    }
}
