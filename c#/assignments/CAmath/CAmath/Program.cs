using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAmath
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            xisaab math = new xisaab("Welcome to","CASIO 3.7");
            Console.WriteLine("calaamada : ");
            string calaamadda = Console.ReadLine();

            if (calaamadda == "+")
            {
                math.addition();
            }
            else if (calaamadda == "-")
            {
                math.subtruction();
            }
            else if (calaamadda == "*")
            {
                math.multiplication();

            }
            else if (calaamadda == "/")
            {
                math.division();
            }
            else
            {
                goto start;
            }
            optional:
            Console.WriteLine("do you want to calculate more (yes or no)" );
            String more = Console.ReadLine();
            if (more == "YES" || more == "yes")
            {
                goto start;
            }
            else if (more == "NO" || more == "no")
            {
                Console.WriteLine("thank you ");
            }
            else
            {
                goto optional;
            }
            Console.ReadKey();
        }
    }
}
