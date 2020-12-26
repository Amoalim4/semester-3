using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpecoursework
{
    class stuffClass : MainClass1
    {
        string path_staff = @"E:\semester two\c#\coursework\date\staff.txt";
        string path_staff_Names = @"E:\semester two\c#\coursework\date\staff Name.txt";

        public override void regester(string name, string gender, int age, string address, string tell, string passport)
        {
            throw new NotImplementedException();
        }

        public override void list_Customer(string name)
        {
            throw new NotImplementedException();
        }

        public override void regester(string name, string gender, string tell, int selery, int age)
        {
            using (StreamWriter streamStaff = File.AppendText(path_staff))
            {
                streamStaff.WriteLine("Name      : {0}", name);
                streamStaff.WriteLine("Gender    : {0}", gender);
                streamStaff.WriteLine("Age       : {0}", age);
                streamStaff.WriteLine("Tell      : {0}", tell);
                streamStaff.WriteLine("Salery    : {0}", selery);
                streamStaff.WriteLine("................................");

                using (StreamWriter sw = File.AppendText(path_staff_Names))
                {
                    sw.WriteLine(name);
                }
            }

            
        }
        public string staffInfo { get; set; }
        public override string list()
        {
            using (StreamReader readstaff = new StreamReader(path_staff))
            {
                staffInfo = readstaff.ReadToEnd();
            }
            return staffInfo;
        }

        public string StaffNamesOnly { get; set; }

        public string staffNames()
        {
            using (StreamReader readstaffnames = new StreamReader(path_staff_Names))
            {
                StaffNamesOnly = readstaffnames.ReadLine();
               
            }
            return StaffNamesOnly;
        }

        public void staffUpdate(string newInfo)
        {
            using (StreamWriter sw = new StreamWriter(path_staff))
            {
                sw.Write(newInfo);
            }
        }
    }
}
