using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts acc = new Accounts();

            acc.employee();

            string names = "Ali";
            string tells = "56";
            int ages = 22;
            Console.WriteLine("---------------- two ()-------------------");
            acc.employee(names,tells);
            Console.WriteLine("------------- three () --------------------");
            acc.employee(names, tells,ages);

            Console.ReadKey();
        }
    }
}
