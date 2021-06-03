using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class IcecreamSalesman : IcecreamFactory
    {
        public void propose_daily_special() 
        {
            Console.WriteLine("Recommended daily special:    " + daily_special().show_ice());        
        }
    }
}
