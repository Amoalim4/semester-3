using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InH_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Haj_Account haj = new Haj_Account();
            Guur_Account guur = new Guur_Account();
            Console.Write("Haj ");
            haj.createAcoount();
            Console.Write("guur ");
            guur.createAcoount();




            Console.ReadKey();
        }
    }
}
