using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Variables
{
    class OverFlowing
    {
        public static void OverFlowTest()
        {
            //byte num = 255;
            //num = (byte)(num + 1);//0

            checked
            {
                try
                {
                    byte num = 255;
                    num = (byte)(num + 1);
                    Console.WriteLine(num);
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
    }
}
