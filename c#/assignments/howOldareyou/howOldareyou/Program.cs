using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace howOldareyou
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            int month = 0;

            int Brith_year = 0;
            int Brith_month = 0;

            int this_year = 2020;
            int days=0;
            int c = 0;

            start:
            Console.WriteLine("brith year ");
            Brith_year = int.Parse(Console.ReadLine());
            Console.WriteLine("brith month ?");
            Brith_month = int.Parse(Console.ReadLine());
            Console.WriteLine("date :");
            int date = int.Parse(Console.ReadLine());

            if (Brith_year > 2020 || Brith_month > 12 || date > 31)
            {
                Console.WriteLine("invalid");
                goto start;
            }
            else
            {
                days = (this_year - Brith_year) * 365 + ((12 - Brith_month) * 30) + (30 - date);

                c = days;

                for (int i = 0; i < c; i++)
                {
                    if (days >= 30)
                    {
                        month++;
                        days -= 30;
                    }
                    if (month >= 12)
                    {
                        year++;
                        month -= 12;
                    }


                }
            }
            
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("you are : {0} years, {1} months, {2} days Old ",year,month,days);
            Console.WriteLine(" all {0}" ,c);
            


            Console.ReadKey();

        }
    }
}
