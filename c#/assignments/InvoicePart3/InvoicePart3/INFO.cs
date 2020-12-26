using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicePart3
{
    struct summery
    {
        public string name;
        public double quantity;
        public double price;


    }
    class INFO
    {
        int ask;
        public int Ask
        {

           get { return ask;}
           set { ask = value; }

        }
        summery invoive = new summery();

        summery[] info = new summery[20];
    }
}
