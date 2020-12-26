using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpecoursework
{
    class CarClass : MainClass1
    {
        ///////////////////////////    Paths    ////////////////////////////

       
        string path_car = @"E:\semester two\c#\coursework\date\cars.txt";

        string path_Resent_car = @"E:\semester two\c#\coursework\date\recently_cars.txt";

        //////////////////////////////////////////////////////////////////////////
        // object to the mainpage

        // Trim() method is used for when you want to cut the empty spaces from the both ends
        //if the user accidently press space bar then it will trim the spaces.
        

        

        public override void regester(string name, string gender, int age, string address, string tell, string passport)
        {
            throw new NotImplementedException();
        }

        public override void list_Customer(string name)
        {
            throw new NotImplementedException();
        }

        //////////////////////////////////////// Add new car   ///////////////////////////////////////////////////

        public override void regester(string name, string model, string color, string speed )
        {
            using (StreamWriter Stream_W_car = File.AppendText(path_car))
            {
                Stream_W_car.WriteLine("Car : {0}", name);
                Stream_W_car.WriteLine("Model : {0}", model);
                Stream_W_car.WriteLine("Color : {0}", color);
                Stream_W_car.WriteLine("Speed : {0}", speed + "Km / h");
                Stream_W_car.WriteLine("--------------------");

            }
            using (StreamWriter Stream_W_car = new StreamWriter(path_Resent_car))
            {
                Stream_W_car.WriteLine("Car : {0}", name);
                Stream_W_car.WriteLine("Model : {0}", model);
                Stream_W_car.WriteLine("Color : {0}", color);
                Stream_W_car.WriteLine("Speed : {0}", speed + "Km / h");
                

            }

            //if (main == null)
            //{
            //    main = new Mainpage();
            //    main.Show();
            //}
            //main.Activate();
            //main.FormClosed += main_FormClosed;

        }

        //void main_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        //{
        //    main = null;
        //}


        //////////////////////////////  Recently cars //////////////////////

        public string list_recently { get; set; }

        public override void recently(string recentlies)
        {
            using (StreamReader streamRecently = new StreamReader(path_Resent_car))
            {
                list_recently = streamRecently.ReadToEnd();

                recentlies = list_recently;
            }
        }
        //// ////////////////////////// /   List car  /////////////////////////////////////
        public string read_car { get; set; }

        public override string list()
        {
            using (StreamReader SreadCar = new StreamReader(path_car))
            {
                read_car = SreadCar.ReadToEnd();
            }
            return read_car;
        }


        public void updatecar(string info)
        {
            using (StreamWriter swUpdte = new StreamWriter(path_car))
            {
                swUpdte.Write(info);
            }
        }
    }
}
