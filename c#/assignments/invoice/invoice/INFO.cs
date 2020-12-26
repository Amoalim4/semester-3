using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice
{
    class INFO
    {
        String pname;
        public string Pname
        {
            get { return pname; }
            set { pname = value; }
        }
        double pq;
        public double Pq
        {
            get { return pq; }
            set { pq = value; }
        }
        double pprice;
        public double Pp
        {
            get { return pprice; }
            set { pprice = value; }
        }
        double total;
        public double Total
        {
            get { return total; }
            set
            {
                total = value;

                if (total > 15)
                {
                    total = value;
                }
                else
                {
                    Console.WriteLine("too bad");
                }
            }
        }
    }
}
