using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    internal class Utilities
    {



        public static bool CheckIsNum(string num)     //Checks to see if the string can be converted to a double, and thus essentially any number
        {
            double temp = 0.0;
            if (double.TryParse(num, out temp))
            {
                return true;
            }

            return false;
        }

        public static List<Invoices> ToList(Invoices[] myArray)
        {
            List<Invoices> list = new List<Invoices>();

            for(int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i] != null)
                {
                    list.Add(myArray[i]);
                }
            }

            return list;
        }

    }
}
