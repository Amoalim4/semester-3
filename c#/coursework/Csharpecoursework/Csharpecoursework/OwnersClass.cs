using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpecoursework
{
    class OwnersClass : MainClass1, I_Owner
    {
        string path_owner = @"E:\semester two\c#\coursework\date\owners.txt";

        public override void regester(string name, string gender, int age, string address, string tell, string passport)
        {
            throw new NotImplementedException();
        }

        public override void list_Customer(string name)
        {
            throw new NotImplementedException();
        }
        // 


         //this method is to register a new owner 
         //unlike the other rgister methods this method is inherited from an Interface (I_Owner.cs)


        public void regesterOwner(string name, string gender, string tell, int age, int shered_precent, string bankAcountNO)
        {
            using (StreamWriter streamOwner = File.AppendText(path_owner))
            {
                streamOwner.WriteLine("Name      : {0}", name);
                streamOwner.WriteLine("Age       : {0}", age);
                streamOwner.WriteLine("Gender    : {0}", gender);
                streamOwner.WriteLine("Telphone  : {0}", tell);
                streamOwner.WriteLine("share     : {0}", shered_precent + " % ");
                streamOwner.WriteLine("Acc No    : {0}", bankAcountNO);
                streamOwner.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            }
        }
        // this method is inherited from a class (mainClass1.cs)
        public string owenrsInfo { get; set; }
        public override string list()
        {
            using (StreamReader readOwner = new StreamReader(path_owner))
            {
                owenrsInfo = readOwner.ReadToEnd();
            }
            return owenrsInfo;
        }

        //void I_Owner.regesterOwner(string name, string gender, string tell, int age, int shered_precent, string bankAcountNO)
        //{
        //    using (StreamWriter streamOwner = File.AppendText(path_owner))
        //    {
        //        streamOwner.WriteLine("Name      : {0}", name);
        //        streamOwner.WriteLine("Age       : {0}", age);
        //        streamOwner.WriteLine("Gender    : {0}", gender);
        //        streamOwner.WriteLine("Telphone  : {0}", tell);
        //        streamOwner.WriteLine("share     : {0}", shered_precent);
        //        streamOwner.WriteLine("Acc No    : {0}", bankAcountNO);
        //        streamOwner.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        //    }
        //}
        public void OwnerUpdate(string details)
        {
            using (StreamWriter updateOwner = new StreamWriter(path_owner))
            {
                updateOwner.Write(details);
            }
        }
    }
}
