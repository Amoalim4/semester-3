using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlaptopclasses
{
    class customers
    {
        public String name;
        public String tell;

        public void customer_info()
        {
            Console.WriteLine("what is your name ?");
            name = Console.ReadLine();
            Console.WriteLine("Tell ?");
            tell = Console.ReadLine();
        }

        public void print_customer()
        {
            Console.WriteLine( "customer name : " + name);
            Console.WriteLine(" tell : " + tell);
        }
    }
}
