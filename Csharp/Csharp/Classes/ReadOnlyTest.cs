using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Classes
{
    public class ReadOnlyTest
    {
        public static readonly string variable = "Madhav";
        static ReadOnlyTest()
        {
            Console.WriteLine("ReadOnlyTest class static constructor");
            variable += " Sai";
        }

        public ReadOnlyTest()
        {
            Console.WriteLine("ReadOnlyTest class No param constructor");
        }

        public string displayVar()
        {
            return variable;
        }
    }
}
