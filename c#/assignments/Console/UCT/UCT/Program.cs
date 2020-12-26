using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCT
{
    class Program
    {
        static void Main(string[] args)
        {
            Full_Time FT = new Full_Time();

            Part_Time PT = new Part_Time();

            Soft_dip Soft = new Soft_dip();

            Net_dip net = new Net_dip();
            wecan:
            int option = 0;
            Console.WriteLine("Option type\n1.full time\n2.Part Time\n3.Softwere Diploma\n4.Networking Diploma");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                FT.option = "Full Time";
                FT.register();
                FT.print(FT.names, FT.tells, FT.age, FT.gender, FT.Marks, FT.option);

                FT.welcome();
            }
            else if (option == 2)
            {
                PT.option = "Part Time";

                PT.register();

                PT.print(PT.names, PT.tells, PT.age, PT.gender, PT.Marks, PT.option);

                PT.welcome();
            }
            else if (option == 3)
            {
                Soft.option = "Softwere Diploma";

                Soft.register();

                Soft.print(Soft.names, Soft.tells, Soft.age, Soft.gender, Soft.Marks, Soft.option);

                Soft.welcome();
            }
            else if (option == 4)
            {
                net.option = "Networking Diploma";

                net.register();

                net.print(net.names, net.tells, net.age, net.gender, net.Marks, net.option);

                net.welcome();
            }

            else
            {
                Console.WriteLine("Choose an option first ");
                goto wecan;
            }



            Console.ReadKey();
        }
    }
}
