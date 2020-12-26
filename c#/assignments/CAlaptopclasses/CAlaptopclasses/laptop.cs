using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlaptopclasses
{
    class laptop
    {
        public String laptopname;
        public String core;
        public String color;
        public Double price;

        public void laptop_info() 
        {
            Console.WriteLine("what is the name of the computer?");
            laptopname = Console.ReadLine();
            Console.WriteLine("which icore ");
            core = Console.ReadLine();
            Console.WriteLine("what is the color ");
            color = Console.ReadLine();
            Console.WriteLine("the price");
            price = Double.Parse(Console.ReadLine());
        }
        public void printlaptop()
        {
            Console.WriteLine("laptop:" +laptopname);
            Console.WriteLine("Icore :"+core);
            Console.WriteLine("color :"+color);
            Console.WriteLine("price :"+price + " $");

        }

    }
}
