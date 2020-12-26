using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCT
{
   public abstract class student
    {
       public string names { get; set; }
       public string tells { get; set; }
       public int age { get; set; }
       public char gender { get; set; }
       public int Marks { get; set; }
       public string option { get; set; }

       public void register()
       {
           Console.WriteLine("name :");
           names = Console.ReadLine();
           Console.WriteLine("Gender :");
           gender = char.Parse(Console.ReadLine());
           Console.WriteLine("tell :");
           tells = Console.ReadLine();
           Console.WriteLine("age :");
           age = int.Parse(Console.ReadLine());
           Console.WriteLine("marks :");
           Marks = int.Parse(Console.ReadLine());
       }

       public abstract void print(string name, string Tell, int age, char gender, int marks, string option);

       public virtual void welcome(){
           
       }
      


    }

}
