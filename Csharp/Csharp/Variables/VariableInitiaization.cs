using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Variables
{
    public class VariableInitiaization
    {
        public static int i;
        public static string str;
        public static byte b;
        public static short s;
        public static long l;
        public static float f;
        public static double d;
        public static decimal dc;
        public static bool bl;
        public static char c;

        public static void Run()
        {
            i = new int();
            int i1 = new int();
            Console.WriteLine("int i1 :" + i1);
            Console.WriteLine("int :" + i);
            Console.WriteLine("string :" + str + ": " + string.IsNullOrEmpty(str));
            Console.WriteLine("byte :" + b);
            Console.WriteLine("short :" + s);
            Console.WriteLine("long :" + l);
            Console.WriteLine("float :" + f);
            Console.WriteLine("double :" + d);
            Console.WriteLine("decimal :" + dc);
            Console.WriteLine("bool :" + bl);
            Console.WriteLine("char :" + c);
            int a = new int();
            Console.WriteLine(a);
            //int b;
            //Console.WriteLine(b);
            Console.Read();
        }
    }
}
