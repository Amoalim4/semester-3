using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCT
{
    class Part_Time : student
    {
        
        public override void print(string name, string Tell, int age, char gender, int marks, string option)
        {
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Gender : {0}", gender);
            Console.WriteLine("tell : {0}", Tell);
            Console.WriteLine("age : {0}", age);
            Console.WriteLine("Marks : {0}", marks);
            Console.WriteLine("Option : {0}", option);


        }
        public override void welcome()
        {
            Console.WriteLine("Welcome to UCT you are regisrted as Part Time student");
        }
    }
}
