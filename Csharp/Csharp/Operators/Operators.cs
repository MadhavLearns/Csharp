using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Operators
{
    public class OperatorsTest
    {
        public static void OperatorTest()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = a++;
            int e = ++b;
            Console.WriteLine(d);
            Console.WriteLine(a);
            Console.WriteLine(e);
            Console.WriteLine(b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a * b);
            Console.WriteLine((a==b) && (b==c));
            Console.WriteLine(a / b);
            Console.WriteLine((a == b) || (b == c));
            Console.WriteLine(!(a>b));
        }
    }
}
