using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharpecoursework
{
    class SellsClass : MainClass1
    {
        //   //        Paths
        string path_Newsells = @"E:\semester two\c#\coursework\date\Naw sells.txt";

        //    //    //     //      //     //
   
        public override void regester(string name, string gender, int age, string address, string tell, string passport)
        {
            throw new NotImplementedException();
        }

        public override void list_Customer(string name)
        {
            throw new NotImplementedException();
        }
        //     ////////////        RECORD the New sells
        public override void register_Newsells(string CustomerName, string customerTell, string customerAdress, string CarName, string CarModel, string color, string seller, int CarPrice, string date)
        {
            using (StreamWriter streamNewSells = File.AppendText(path_Newsells))
            {
                streamNewSells.WriteLine("Date               : {0}", date);
                streamNewSells.WriteLine("---------   Payer -----------------");
                streamNewSells.WriteLine("Name         : {0} ", CustomerName);
                streamNewSells.WriteLine("Tell        : {0} ", customerTell);
                streamNewSells.WriteLine("Address     : {0} " ,customerAdress);
                streamNewSells.WriteLine("--------- Car -----------------------");
                streamNewSells.WriteLine("Car name    : {0}", CarName);
                streamNewSells.WriteLine("Model       : {0} ", CarModel);
                streamNewSells.WriteLine("Color       : {0}",color);
                streamNewSells.WriteLine("Final Price : {0}", CarPrice);
                streamNewSells.WriteLine(".................................");
                streamNewSells.WriteLine(" Selles man : {0}", seller);
                streamNewSells.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");



            }
        }
        public string sellsInfo { get; set; }
        public override string list()
        {
            using (StreamReader readsells = new StreamReader(path_Newsells))
            {
                sellsInfo = readsells.ReadToEnd();
            }
            return sellsInfo;
        }
    }
}
