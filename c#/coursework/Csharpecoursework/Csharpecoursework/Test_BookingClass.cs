using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpecoursework
{
    class Test_BookingClass : MainClass1
    {
        // //////   paths

        string path_newTest_booking = @"E:\semester two\c#\coursework\date\New test Booking.txt";
        string path_car_returned = @"E:\semester two\c#\coursework\date\car returned.txt";

        // /// ///////////// /////// /////////   
        

       

        public override void regester(string name, string gender, int age, string address, string tell, string passport)
        {
            throw new NotImplementedException();
        }

        public override void list_Customer(string name)
        {
            throw new NotImplementedException();
        }
//// //////////////////// ////////////////////////////////// //////////////////////////////// ////////////////////////////////// ///////////// /////////////////////////
        /// <summary>
        ///  the method below is to register A new Test car Booking
        ///  it uses 12 Parameters 
        /// </summary>
        /// these are the parameters 
        /// <param name="Date"></param>
        /// <param name="Customer_name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="customer_address"></param>
        /// <param name="customer_tell"></param>
        /// <param name="passport"></param>
        /// <param name="carName"></param>
        /// <param name="Modal"></param>
        /// <param name="license"></param>
        /// <param name="timeTaken"></param>
        /// <param name="timeReturn"></param>

        public override void regester(string Date, string Customer_name, int age, string gender, string customer_address, string customer_tell, string passport, string carName, string Modal, string license, int timeTaken, int timeReturn)
        {
            using (StreamWriter Snew_test_Booking = File.AppendText(path_newTest_booking))
            {
                Snew_test_Booking.WriteLine("Date                            :{0}", Date);

                Snew_test_Booking.WriteLine(" ------- Customer -------------");
                Snew_test_Booking.WriteLine("Name        : {0}", Customer_name);
                Snew_test_Booking.WriteLine("Age         : {0}", age);
                Snew_test_Booking.WriteLine("Gender      : {0}", gender);
                Snew_test_Booking.WriteLine("Address     : {0}", customer_address);
                Snew_test_Booking.WriteLine("Tell        : {0}", customer_tell);
                Snew_test_Booking.WriteLine("Passport No : {0}", passport);
                Snew_test_Booking.WriteLine("License No     : {0} ", license);
                Snew_test_Booking.WriteLine("-------- Car ------------");
                Snew_test_Booking.WriteLine("Car name       : {0} ", carName);
                Snew_test_Booking.WriteLine("Car model      : {0} ", Modal);
                Snew_test_Booking.WriteLine("Taken Time     : {0}", timeTaken + " Oclock");
                Snew_test_Booking.WriteLine("Returning Time : {0}", timeReturn + " Oclock");
                Snew_test_Booking.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            }
        }
  ////////////////////////////// /////////////////Read the file   /////////////////////////////////// ///////
        public string information { get; set; }
        public override string list()
        {
            using (StreamReader SreadBooking = new StreamReader(path_newTest_booking))
            {
                information = SreadBooking.ReadToEnd();
                
            }
            return information;
        }
        // /////////////////////////////////  Car return method ////////////////////////////////////////////////////////////////
        public string Comments { get; set; }
        public override void carReturned(string CustomerName, string date, string carName, string model)
        {
            using (StreamWriter streamCar = File.AppendText(path_car_returned))
            {
                streamCar.WriteLine("Customer name  :  {0}", CustomerName);
                streamCar.WriteLine("car name       :  {0}", carName);
                streamCar.WriteLine("Model          :  {0}", model);
                streamCar.WriteLine(" tested Date   :  {0}", date);
                streamCar.WriteLine("Comment        :  {0}", Comments);
                streamCar.WriteLine("..................................");
            }
        }
       
    }
}
