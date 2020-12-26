using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpecoursework
{
    class CustomerClass : MainClass1
    {

        ///////////////////////////        Paths    ////////////////////////////

        //string path_user = @"E:\semester two\c#\coursework\date\user.txt";

        //string path_passwd = @"E:\semester two\c#\coursework\date\passwd.txt";

        string path_customer = @"E:\semester two\c#\coursework\date\customer.txt";


        //////////////////////////////////////////////////////////////////////////
        
        
        /////////////////////////////////////      CHECKING       //////////////////////////////////////////
        /*Here in this method I checked if the user's input in the same as 
          the saved files ( user.txt and passwd.txt) 
        */
        //public override void Log_in_checking(string username, string password)
        //{
            
        //    string user = "";
        //    using (StreamReader streamUser = new StreamReader(path_user))
        //    {
        //        user = streamUser.ReadLine();
        //    }
        //    string pass = "";
        //    using (StreamReader streampassword = new StreamReader(path_passwd))
        //    {
        //        pass = streampassword.ReadLine();
        //    }
        //    if (username == user && password == pass)
        //    {
        //        Mainpage main = new Mainpage();
        //        main.Show();
        //    }
        //    else
        //    {

        //    }
        //}
        ///////////////////////////////////  RGISTER NEW CUSTOMER  ////////////////////////////////////////////////////
        /// <summary>
        /// this method is for registernig the new customer
        /// </summary>


        public override void regester(string name, string gender, int age, string address, string tell, string passport)
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

        ///////////////////////////////////   LIST THE CUSTOMER //////////////////////////////////////////////////
        
        /// <summary>
        // Method kan waxa uu infometion ka soo aqrinaa file 
        //wuxu ku daawacaa form ka List_customer.cs asoo u maraayo prameter
        /// </summary>
        public string listcustomerinfo { get; set; }
       

        public override void list_Customer(string name)
        {
            using (StreamReader SrC = new StreamReader(path_customer))
            {

                listcustomerinfo = SrC.ReadToEnd();

                name = listcustomerinfo;
            }
        }

        public void UpdateCustomer(string new_info)
        {
            using (StreamWriter swUpdate = new StreamWriter(path_customer))
            {
                swUpdate.Write(new_info);
            }
        }


        
    }
}
