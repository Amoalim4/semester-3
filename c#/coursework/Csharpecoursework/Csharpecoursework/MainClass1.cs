using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpecoursework
{
    abstract class MainClass1
    {
        //                       Checking method

        //abstract public void Log_in_checking(string username, string password);
        //                       Register new customer

        abstract public void regester(string name, string gender, int age, string address, string tell, string passport);
        //                       list the customers list

        abstract public void list_Customer(string name);
        ///////////////////////////////////             CAR        // ////////////////////////////////////////////////////
        //                           Add new car
        virtual public void regester(string name, string model, string color, string speed)
        {

        }
        //                 car list
        virtual public string list()
        {
            return " emty";
        }
        //              Recently cars
        virtual public void recently(string recently)
        {

        }
        //  / /////////////////////////// register new booking /  ///////////////////////////////////
        virtual public void regester(string dateAndtime, string Customer_name, int age, string gender, string address, string customer_tell, string passport, string car_name, string car_model, string licence, int Taking_time, int returnig_time)
        {

        }

        // ////////              register New sells
        virtual public void register_Newsells(string CustomerName, string customerTell, string customerAdress, string CarName, string CarModel, string color, string seller, int CarPrice, string date)
        {

        }

       
        // /////////////// /               register stuff              ///////////////////////////////
        virtual public void regester(string name, string gender, string tell, int selery, int age)
        {

        }
        
        //                             car returned                              /////

        virtual public void carReturned(string CustomerName, string date, string carName, string model)
        {

        }
    }
}
