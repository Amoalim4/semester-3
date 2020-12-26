using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionBinaryDecimal
{
    class calculate
    {
        public string toBinary(int decimail)
        {

            string result = "";
           
            int rem = 0;
            while (decimail >0)
            {
                rem = decimail % 2;

                decimail = decimail / 2;

                result = rem.ToString() + result;
               
            }

            return result;
        }
        /// <summary>
        /// the below method
        /// </summary>
        /// <param name="binary"></param>
        /// <returns></returns>

        public String toDecimal(int binary)
        {
            // binary can be 0 or 1 so we need to have those two numbers 
            int bi = 0;
            int bi1 = 1;

            int remainer = 0;
            // looping the input number while it is not equel to 0
            while (binary !=0)
            {
                // remain 
                remainer = binary % 10;

                bi = bi + (remainer * bi1);

                binary = binary / 10;

                bi1 = bi1 * 2;
            }

            return bi.ToString();
        }
    }
}
