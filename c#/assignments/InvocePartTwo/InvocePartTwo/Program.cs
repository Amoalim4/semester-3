using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvocePartTwo
{
    struct products
    {
        public string pName;
        public double pPrice;
        public double pQuantity;
    }
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("how many products you need to puy : ");
            int How = int.Parse( Console.ReadLine());
            products PR = new products();
            products[] pro_info = new products[How];
            int j = 1;
            for (int i = 0; i < How; i++)
            {
                Console.WriteLine("Product name {0} : ",j);
                PR.pName = Console.ReadLine();
                Console.WriteLine("Product Quantity : ");
                PR.pQuantity = double.Parse(Console.ReadLine());
                Console.WriteLine("Product Price : ");
                PR.pPrice = double.Parse(Console.ReadLine());
                j++;
                total += PR.pQuantity * PR.pPrice;

                pro_info[i] = PR;
                

            }

            for (int i = 0; i < How; i++)
            {
                Console.WriteLine("Product Name : {0}",pro_info[i].pName);
                Console.WriteLine("Product Quantity : {0}", pro_info[i].pQuantity);
                Console.WriteLine("Product Price : {0}", pro_info[i].pPrice);
                Console.WriteLine("---------------------------------");
            }
            Console.WriteLine("Total : {0}",total);












            Console.ReadKey();
        }
    }
}
