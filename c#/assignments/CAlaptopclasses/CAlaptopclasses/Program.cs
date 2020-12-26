using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlaptopclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            customers customers = new customers();
            customers.customer_info();
            customers.print_customer();


            laptop item = new laptop();
            item.laptop_info();
            item.printlaptop();

            

            Console.ReadKey();
        }
    }
}
