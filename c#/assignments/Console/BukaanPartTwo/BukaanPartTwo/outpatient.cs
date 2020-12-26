using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukaanPartTwo
{
    class outpatient : Patient
    {
        public override void list(string name, string tell, string pain)
        {
            Console.WriteLine(" Name : {0}",name );
            Console.WriteLine(" tell : {0}", tell);
            Console.WriteLine(" Name : {0}", pain);

        }
    }
}
