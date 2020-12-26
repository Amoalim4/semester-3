using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            INFO invoce = new INFO();
            Console.WriteLine("Product Name:");
            invoce.Pname = Console.ReadLine();

            Console.WriteLine("Product Quantity:");
            invoce.Pq= double.Parse( Console.ReadLine());

            Console.WriteLine("Price:");
            invoce.Pp = double.Parse( Console.ReadLine());

            invoce.Total = invoce.Pp * invoce.Pq;
            if (invoce.Total > 15)
            {
                Console.WriteLine("Name : {0}", invoce.Pname);
                Console.WriteLine("Quantity : {0}", invoce.Pq);
                Console.WriteLine("Price / each : {0}", invoce.Pp);
                Console.WriteLine("Total amount : {0}", invoce.Total);
            }
                
            
                
                
            
           



            Console.ReadKey();
        }
    }
}
