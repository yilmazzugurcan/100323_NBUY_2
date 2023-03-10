using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100323_NBUY_2
{
   internal class binek:arac
    {
      public string sz1()
        {
            
            string m = "";
            Console.WriteLine("Sansziman Tipi Seçin:" + "\n" + "1-oto" + "\n" + "2-düz");
            int sza =int.Parse(Console.ReadLine());
            if (sza == 1)
            {
                m = "oto";
            }
            else
            {
                 m = "düz";
            }Console.WriteLine();
            return m;
            
        }
       
    } 
}
