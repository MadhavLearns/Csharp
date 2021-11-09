using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Variables
{
    class TypeConversions
    {

        public static void Conversions()
        {
            //implicit conversion
            byte b1 = 1;
            int i1 = b1;
            Console.WriteLine(i1);

            //explicit conversion
            int i = 1;
            byte b = (byte)i;
            Console.WriteLine(b);

            int i3 = 1234;
            byte b3 = (byte)i; // this converts the given no into byte with data loss.
            //b3 = Convert.ToByte(i3); //this conversion throws OverFlowException at runtime.
            Console.WriteLine(b);

            string s = "1234";
            //int i2 = s;
            int i2 = int.Parse(s);
            Console.WriteLine(i2);

            string s1 = "true";
            bool b2 = Convert.ToBoolean(s1);
            Console.WriteLine(b2);
        }
    }
}
