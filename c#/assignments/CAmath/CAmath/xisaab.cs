using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAmath
{
    
    public class xisaab
    {
       public int second_number = 0;
       public int first_number = 0;

       public xisaab(string welcome, string name)
       {
           Console.WriteLine(welcome + " " + name);
       }
        public void addition()
        {
            Console.WriteLine("frist number : ");
            first_number = int.Parse(Console.ReadLine());
            Console.WriteLine("second number : ");
            second_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Equels : " + (first_number + second_number));
            
        }

        public void subtruction()
        {
           
            Console.WriteLine("frist number : ");
            first_number = int.Parse(Console.ReadLine());
            Console.WriteLine("second number : ");
            second_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Equels : " + (first_number - second_number));
        }
        public void multiplication()
        {
            
            Console.WriteLine("frist number : ");
            first_number = int.Parse(Console.ReadLine());
            Console.WriteLine("second number : ");
            second_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Equels : " + (first_number * second_number));
        }
        public void division()
        {
            
            Console.WriteLine("frist number : ");
            first_number = int.Parse(Console.ReadLine());
            Console.WriteLine("second number : ");
            second_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Equels : " + (first_number / second_number));
        }

    }
}
