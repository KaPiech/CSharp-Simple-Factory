using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class IcecreamFactory : Icecream
    {
        List<Icecream> menu = new List<Icecream>();
        private int day;

        public override Icecream daily_special()
        {   if( day < 7)
            {
                day++;
            }else { day = 1; }
            
            if(day == 1) 
                { return new Fruity(5, "mango", true, "white chocolate"); }
            else if(day == 2)
                { return new Creamy(4, true, "dark chocolate", false); }
            else if (day == 3)
                { return new Gelato(6, "coffe", true, true); }
            else if (day == 4)
                { return new Fruity(5, "orange", true, "chocolate"); }
            else if (day == 5)
                { return new Gelato(6, "creamy", true, true); }
            else if (day == 6)
                { return new Sorbet(4, "peach"); }
            else if (day == 7)
                { return new Sorbet(4, "orange"); }
            else 
                { return new Sorbet(4, "watermelmon"); }  
        }

        public void daily_menu()
        {
            Console.WriteLine("---------------------Menu---------------------");
            foreach (Icecream ice in menu) 
            { 
                Console.WriteLine(ice.show_ice());
            }
            Console.WriteLine("----------------------------------------------");
        }   

        public void set_production_mode(int i) 
        {  
            switch (i)
            { 
                case 1:
                    menu.Clear();
                    menu.Add(new Sorbet(4, "lemon"));
                    menu.Add(new Gelato(6, "creamy", true, true));
                    menu.Add(new Fruity(5, "orange", true, "chocolate"));
                    menu.Add(new Creamy(4, true, "fruity", false));
                    break;
                case 2:
                    menu.Clear();
                    menu.Add(new Gelato(6, "creamy", true, false));
                    menu.Add(new Sorbet(4, "orange"));
                    menu.Add(new Fruity(5, "raspberry", true, "white chocolate"));
                    menu.Add(new Creamy(4, true, "dark chocolate", false));
                    break;
                case 3:
                    menu.Clear();
                    menu.Add(new Fruity(5, "mango", true, "white chocolate"));
                    menu.Add(new Sorbet(4, "peach"));
                    menu.Add(new Gelato(6, "creamy", true, true));
                    menu.Add(new Creamy(4, true, "dark chocolate", false));
                    break;
                case 4:
                    menu.Clear();
                    menu.Add(new Creamy(4, true, "dark chocolate", false));
                    menu.Add(new Fruity(5, "mango", true, "white chocolate"));
                    menu.Add(new Sorbet(4, "peach"));
                    menu.Add(new Gelato(6, "creamy", true, true));
                    break;
                case 5:
                    menu.Clear();
                    menu.Add(new Sorbet(4, "watermelmon"));
                    menu.Add(new Gelato(6, "creamy", true, true));
                    menu.Add(new Fruity(5, "peach", true, "white chocolate"));
                    menu.Add(new Creamy(4, true, "chocolate", false));
                    break;
                case 6:
                    menu.Clear();
                    menu.Add(new Gelato(6, "creamy", true, false));
                    menu.Add(new Sorbet(4, "orange"));
                    menu.Add(new Fruity(5, "coconut", true, "white chocolate"));
                    menu.Add(new Creamy(4, true, "coffe", false));
                    break;
                case 7:
                    menu.Clear();
                    menu.Add(new Creamy(4, true, "dark chocolate", false));
                    menu.Add(new Fruity(5, "grapes", true, "none"));
                    menu.Add(new Sorbet(4, "lemon"));
                    menu.Add(new Gelato(6, "coffe", true, true));
                    break;
                default:
                    Console.WriteLine("Factory closed !");
                    break;
            }
        }
    }
}
