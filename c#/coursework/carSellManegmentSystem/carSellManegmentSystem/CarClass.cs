using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace carSellManegmentSystem
{
    class CarClass : Isystem
    {
        public string list_car { get; set; }
        string path_car = @"E:\semester two\c#\coursework\date\car.txt";

        string path_user = @"E:\semester two\c#\coursework\date\user.txt";

        string path_pass = @"E:\semester two\c#\coursework\date\passwd.txt";

        public void check(string username , string password)
        {
            string user = "";
            using (StreamReader SrU = new StreamReader(path_user))
            {
                user = SrU.ReadLine();
            }
            
            string pass = "";
            using (StreamReader SrP = new StreamReader(path_pass))
            {
                pass = SrP.ReadLine();
            }
            if (username == user && pass ==password)
            {
                mainpage Main = new mainpage();
                Main.Show();
            }
        }

        public void list_Customer(string car)
        {
            using (StreamReader SrC = new StreamReader(path_car))
            {

                list_car = SrC.ReadToEnd();

                car = list_car;
            }
        }

    }
}
