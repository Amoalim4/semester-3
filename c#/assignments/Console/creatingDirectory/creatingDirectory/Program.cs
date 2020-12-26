using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace creatingDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            // this if the path where my directory is and the subdirectoties and files will be created 

            string path = @"E:\semester two\c#\student\NewFolder\";
            string path2 = @"E:\semester two\c#\student\";


            // giving the system the direction to go in which the folders,subfolders and files are.
            DirectoryInfo folder = new DirectoryInfo(path);
            
            DirectoryInfo folder2 = new DirectoryInfo(path2);


            // creating a subFolder 

            //folder.CreateSubdirectory("NewFolder");
            
            if (folder.Exists)
            {
                 // inserting the info into an array called  info[]
                FileInfo[] info = folder.GetFiles();
                foreach (var data in info)

                    {

                    Console.WriteLine(data.CreationTime);
                    Console.WriteLine(data.Directory);

                    }
             
             
            }
            else
            {
                folder2.CreateSubdirectory("NewFolder");
                Console.WriteLine("folder created");

                FileInfo[] info = folder.GetFiles();
                foreach (var data in info)
                {

                    Console.WriteLine(data.CreationTime);
                    Console.WriteLine(data.Directory);

                }
             
                
               
            }

            Console.ReadKey();
        }
    }
}
