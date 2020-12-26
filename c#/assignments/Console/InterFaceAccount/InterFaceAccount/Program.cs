using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            credit C_credit = new credit();

            //C_credit.register();

            C_credit.Ask1();
            C_credit.printout(C_credit.names, C_credit.tells);
            Console.WriteLine("-----------part two_---------");
            C_credit.Ask2();            
            C_credit.printout(C_credit.names, C_credit.tells, C_credit.address);


            Console.ReadKey();
        }
    }
}
