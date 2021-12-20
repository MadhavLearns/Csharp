using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.ControlFlowExercises
{
    class CF1
    {
        public void RunProgram()
        {
            Console.WriteLine("Enter Number between 1 - 10");
            int input = int.Parse(Console.ReadLine());

            if(input >= 1 && input <= 10)
            {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
