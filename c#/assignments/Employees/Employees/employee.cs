using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{

    class employee
    {
        public String name;
        public String tell;
        public String address;
        public int brith_year;
        public String damiin;

        public void info(string ename,string etell,string eaddress, string edamiin)
        {
            name = ename;
            tell = etell;
            address = eaddress;
            damiin = edamiin;
        }

        public int age(int brith_year)
        {
            return (2020 - brith_year);
        }
        public void pinfo(string pname, string ptell, string paddress, string pdamiin)
        {
            pname = name;
            ptell = tell;
            paddress = address;
            pdamiin = damiin;
        }

    }
}
