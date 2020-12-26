using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacelesson
{
    class acount : IAcount
    {
        public void register()
        {
            Console.WriteLine("registred!!");
        }

        public void register(string name, string tell)
        {
            Console.WriteLine("{0} whose tell {1} registred!!",name,tell);
        }

        public void register(string name, string tell, int age)
        {
            Console.WriteLine("{0} whose tell {1} and age {2} registred!!", name, tell,age);
        }
    }
}
