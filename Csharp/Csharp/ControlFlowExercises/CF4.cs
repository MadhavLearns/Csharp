using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.ControlFlowExercises
{
    class CF4
    {
        public void RunProgram()
        {
            Console.WriteLine("Enter Speed Limit: ");
            int splimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Car Speed: ");
            int crspeed = int.Parse(Console.ReadLine());

            if (crspeed < splimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var delimiterpoints = (crspeed - splimit) / 5;

                if(delimiterpoints>12)
                    Console.WriteLine("License Suspended!");
                else
                    Console.WriteLine("Delimiter Points: " + delimiterpoints);
            }
        }
    }
}
