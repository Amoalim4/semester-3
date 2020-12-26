using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVCpluse
{
    class Options
    {
        public double lacagta { get; set; }
        public int hubi { get; set; }
        public string Number { get; set; }

        public double itusHaraga(double Balance)
        {
            return Balance;
        }

        public double Kaara(double Balance)
        {
            Console.WriteLine("1.Kushubo \n2.Ugu shubo");
            int kaar = int.Parse(Console.ReadLine());
            if (kaar == 1)
            {
                Console.WriteLine("geli lacagta");
                lacagta = double.Parse(Console.ReadLine());
                if (lacagta <= Balance)
                {
                    Console.WriteLine("Mahubtaa \n1.Haa \n2.Maya");
                    hubi = int.Parse(Console.ReadLine());
                    switch (hubi)
                    {
                        case 1 :
                            Console.WriteLine("waxaad ku shubatay {0} $ \nHaraagagu waa {1}",lacagta,(Balance-lacagta));
                            break;
                        case 2 :
                            Console.WriteLine("Dhaqdhaqaaqi waa laga noqday \nMAHADSANID !!!");
                            break;
                        default:
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("Haraagaaga Kugu ma filna \nHaagaagu waa {0}",Balance);
                }
            }
            else if (kaar == 2)
            {
                Console.WriteLine("fadlan Geli Number:");
                Number = Console.ReadLine();
                Console.WriteLine("geli lacagta");
                lacagta = double.Parse(Console.ReadLine());
                if (lacagta <= Balance)
                {
                    Console.WriteLine("Mahubtaa \n1.Haa \n2.Maya");
                    hubi = int.Parse(Console.ReadLine());
                    switch (hubi)
                    {
                        case 1:
                            Console.WriteLine("waxaad numberka {0} ugu shubatay {1} $ \n Haraagagu waa {2}",Number ,lacagta, (Balance - lacagta));
                            break;
                        case 2:
                            Console.WriteLine("Dhaqdhaqaaqi waa laga noqday \nMAHADSANID !!!");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Haraagaaga Kugu ma filna \nHaagaagu waa {0}", Balance);
                }
                
            }

            return 0;
        }

        public double BixiBiilasha()
        {
            Console.WriteLine("not yet");
            return 0;
        }

        public double Uwareeji(double Balance)
        {
            Console.WriteLine("fadlan Geli Number:");
            Number = Console.ReadLine();
            Console.WriteLine("geli lacagta");
            lacagta = double.Parse(Console.ReadLine());
            if (lacagta <= Balance)
            {
                Console.WriteLine("Mahubtaa \n1.Haa \n2.Maya");
                hubi = int.Parse(Console.ReadLine());
                switch (hubi)
                {
                    case 1:
                        Console.WriteLine("waxaad numberka {0} ugu shubatay {1} $ \nHaraagagu waa {2} $", Number, lacagta, (Balance - lacagta));
                        break;
                    case 2:
                        Console.WriteLine("Dhaqdhaqaaqi waa laga noqday \nMAHADSANID !!!");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Haraagaaga Kugu ma filna \nHaagaagu waa {0}", Balance);
            }
            return Balance;
        }

        public void Warbixin()
        {
            Console.WriteLine("Not yet");
        }

        public double salaamBank(double Balance)
        {
            Console.WriteLine("lagataada wax bank la dhigo maba dhamee maxaa rabtaa");
            return 0;
        }

    }
}
