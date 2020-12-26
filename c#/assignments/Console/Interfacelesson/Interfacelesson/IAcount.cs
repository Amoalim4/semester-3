using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacelesson
{
    interface IAcount
    {
        void register();
        void register(string name, string tell);
        void register(string name, string tell, int age);

    
    }
}
