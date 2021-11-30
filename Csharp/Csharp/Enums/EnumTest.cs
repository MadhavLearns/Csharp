using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Enums
{
    public class EnumTest
    {
        public enum ShippingMethod
        {
            RegularAirTypeMail = 1,
            StandardAirTypeMail = 2,
            Express =3
        }
        
        public void TestEnum()
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            var testMail = (ShippingMethod)methodId;
            Console.WriteLine(testMail);

            var methodName = "Express";
            var EnumName = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(EnumName);
        }
    }
    
}
