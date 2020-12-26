using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account
{
    class Accounts
    {
       public void employee()
       {
           Console.WriteLine("registred");
       }
       public void employee(string name, string tell)
       {
           Console.WriteLine("name : {0} " ,name);
           Console.WriteLine("Tell : {0} " ,tell);
           Console.WriteLine("is registred");
       }
       public void employee(string name, string tell,int age)
       {
           Console.WriteLine("name : {0} ", name);
           Console.WriteLine("Tell : {0} ", tell);
           Console.WriteLine("age {0} " ,age);
           Console.WriteLine("is registred");
       }
    }
}
