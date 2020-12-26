using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace savetofile
{
    class student
    {
        public void save(string name, string tell, string address, int age)
        {
            string path = @"E:\semester two\c#\student\save.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("name: {0}", name);
                sw.WriteLine("Age: {0}", age);
                sw.WriteLine("tell: {0}", tell);
                sw.WriteLine("Address: {0}", address);

            }
        }
        public string names { get; set; }

        public void read()
        {
            string path = @"E:\semester two\c#\student\save.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                names = sr.ReadToEnd();

            }


        }

        
    }
}
