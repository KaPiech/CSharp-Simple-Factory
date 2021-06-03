using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    abstract class Icecream
    {
        public abstract Icecream daily_special();
        public virtual string show_ice(){ return ""; }
    }
}
