using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukaanPartTwo
{
    public abstract class Patient
    {
        public string names { get; set; }
        public string tell { get; set; }
        public string xanuun { get; set; }

        public void registeration()
        {
            Console.WriteLine("what is your name");
            names = Console.ReadLine();
            Console.WriteLine("Tell");
            tell = Console.ReadLine();
            Console.WriteLine("INtee laga haya");
            xanuun = Console.ReadLine();
        }
        public abstract void list(string name,string tell, string pain);
    }
}
