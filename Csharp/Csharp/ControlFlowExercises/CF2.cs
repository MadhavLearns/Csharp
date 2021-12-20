using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.ControlFlowExercises
{
    class CF2
    {
        public void RunProgram()
        {
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("First no is greater");
            }
            else
            {
                Console.WriteLine("Second no is greater");
            }
        }
    }
}
