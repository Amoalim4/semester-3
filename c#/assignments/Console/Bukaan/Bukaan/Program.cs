using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukaan
{
    class Program
    {
        static void Main(string[] args)
        {
            Bukan_socod Socod = new Bukan_socod();
            
            Console.Write("bukaan socod ka");
            Socod.Register();
            Console.Write("bukaan socod ka");
            Socod.list();
            Console.Write("bukaan socod ka");
            Socod.prescription();

            Console.WriteLine("----------------------------------_---------");
            Bukan_jiif jiif = new Bukan_jiif();
            Console.Write("bukaan jiif ka");
            jiif.Register();
            Console.Write("bukaan jiif ka");
            jiif.list();
            Console.Write("bukaan jiif ka");
            jiif.prescription();



            Console.ReadKey(); 
        }
    }
}
