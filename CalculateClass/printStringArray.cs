using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateClass
{
    internal class printStringArray
    {

        /*=== PrintStringarray=====
           string[] strnames = { "ibrahem", "Donia", "Amal", "Khaled" };
          printStringArray psa = new printStringArray(strnames);
          psa.PrtintStringArray1("\n");*/

        string[] Content;

        public printStringArray(string[] Content)
        { 
            this.Content = Content;
        }
        public string getStringArray(string separator)
        {
            string stringArray = "";
            foreach (string s  in Content)
            {
                stringArray += s + separator;
            }
            return stringArray;
        }

        public void PrtintStringArray1(string spearator)
        {
            Console.WriteLine(getStringArray(spearator));
        }
    }
}
