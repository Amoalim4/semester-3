using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceAccount
{
    class credit : Account
    {
        public string names { get; set; }
        public string tells { get; set; }
        public string address { get; set; }


        public void Ask1()
        {
            Console.WriteLine("name:");
            names = Console.ReadLine();
            Console.WriteLine("tell");
            tells = Console.ReadLine();
        }

 

        public void printout(string name, string tell)
        {
            Console.WriteLine("-----------one----------------");
            Console.WriteLine("name :" + name);
            Console.WriteLine("tell :" + tell);

        }
        public void Ask2()
        {
            Console.WriteLine("name:"); 
            names = Console.ReadLine(); 
            Console.WriteLine("tell"); 
            tells = Console.ReadLine(); 
            Console.WriteLine("address"); 
            address = Console.ReadLine(); 
        }
        public void printout(string name, string tell, string address) 
        {
            
            Console.WriteLine("----------two--------------"); 
            Console.WriteLine("name :" + name); 
            Console.WriteLine("tell :" + tell); 
            Console.WriteLine("address: "+address); 


        }
    }
    
}
