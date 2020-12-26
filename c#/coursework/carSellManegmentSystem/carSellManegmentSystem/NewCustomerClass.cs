using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace carSellManegmentSystem
{
    class NewCustomerClass : Isystem
    {

        public string listcustomerinfo { get; set; }


        string path_customer = @"E:\semester two\c#\coursework\date\customer.txt";

        public void regesterNewCustomer(string name,string gender, int age ,string address,string tell,string passport)
        {
            using (StreamWriter SwnewCustomer = File.AppendText(path_customer))
            {
                SwnewCustomer.WriteLine("Name : {0}", name);
                SwnewCustomer.WriteLine("gende: {0}", gender);
                SwnewCustomer.WriteLine("age : {0}", age);
                SwnewCustomer.WriteLine("Address : {0}", address);
                SwnewCustomer.WriteLine("Tellphone : {0}", tell);
                SwnewCustomer.WriteLine("Passport : {0}", passport);
                SwnewCustomer.WriteLine("-----------------------------");
            }
        }
        // Method kan waxa uu infometion ka soo aqrinaa file 
        //wuxu ku daawacaa form ka List_customerD.cs asoo u maraayo prameter
        public void list_Customer(string name)
        {
            using (StreamReader SrC = new StreamReader(path_customer))
            {

                listcustomerinfo = SrC.ReadToEnd();

                name = listcustomerinfo;
            }
        }
    }
}
