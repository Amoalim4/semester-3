using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAmathprameters
{
    class Program
    {
        static void Main(string[] args)
        {
            xisaab math = new xisaab();

        start:
            Console.Write("calaamadda ( + , - , * or /) : ");
            String calaamadda = Console.ReadLine();

            

            if (calaamadda == "+")
            {
                double n1, n2, n3 = 0;
                Console.Write("1st number :");
                n1 = Double.Parse(Console.ReadLine());
                Console.Write("2ed number :");
                n2 = Double.Parse(Console.ReadLine());
                Console.Write("3rd number :");
                n3 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Result : " + math.iskudar(n1, n2, n3));
            }
            else if (calaamadda == "-")
            {
                double n1, n2 = 0;
                Console.Write("1st number :");
                n1 = Double.Parse(Console.ReadLine());
                Console.Write("2ed number :");
                n2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Result : " + math.kalajar(n1, n2));
            }
            else if (calaamadda == "/")
            {
                double n1, n2 = 0;
                Console.Write("1st number :");
                n1 = Double.Parse(Console.ReadLine());
                Console.Write("2ed number :");
                n2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Result : " + math.isu_qeybi(n1, n2));
            }

            else if (calaamadda == "*")
            {
                double n1, n2, n3, n4 = 0;
                Console.Write("1st number :");
                n1 = Double.Parse(Console.ReadLine());
                Console.Write("2ed number :");
                n2 = Double.Parse(Console.ReadLine());
                Console.Write("3rd number :");
                n3 = Double.Parse(Console.ReadLine());
                Console.Write("4th number :");
                n4 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Result : " + math.iskudhufo(n1, n2, n3, n4));
            }
            else
            {
                Console.Write("fadlan iska hubi ");
                goto start;
            }
            Console.Write("do you wish to continue the calculatinon ... (yes or no) :");
            continue_or_not:

            String option = Console.ReadLine();

            if (option == "YES" || option == "yes")
            {
                goto start;
            }
            else if (option == "NO" || option == "no")
            {
                Console.WriteLine("thank you \npress any key to exit......... ");
            }
            else
            {
                Console.WriteLine("please say( yes or no ) do you wish to continue the calculatinon or not ");
                goto continue_or_not;
            }





            Console.ReadKey();
        }
    }
}
