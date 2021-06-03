using System;

namespace C5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in icecream Factory!");

            IcecreamFactory factory = new IcecreamFactory();
            IcecreamSalesman salesman = new IcecreamSalesman();

            for(int i = 1; i < 8; i++)      //SIMULATION FOR 7 DAYS
            {
                Console.WriteLine("Day " + i + ":");
                factory.set_production_mode(i);
                factory.daily_menu();
                salesman.propose_daily_special();
                salesman.propose_daily_special();
                salesman.propose_daily_special();
                Console.WriteLine("\n");
            }

        }
    }
}
