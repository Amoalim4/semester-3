using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacelesson
{
    class Program
    {
        static void Main(string[] args)
        {
            acount Acc = new acount();
            Console.WriteLine("---------------------zero-------------------------");

            Acc.register();
            
            Console.WriteLine("---------------------two-------------------------");
            Acc.register("hasan", "445");
            Console.WriteLine("------------------three----------------------------");
            Acc.register("hana", "444", 30);

            Console.ReadKey();


        }
    }
}
