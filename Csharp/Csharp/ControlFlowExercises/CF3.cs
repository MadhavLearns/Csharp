using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.ControlFlowExercises
{
    class CF3
    {
        public void RunProgram()
        {
            Console.WriteLine("Enter width: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Height: ");
            int y = int.Parse(Console.ReadLine());

            var ratio = (float)x / y;

            var image ="";
            if (ratio == 1)
                image = "square";
            else if (ratio > 1)
                image = "landscape";
            else if (ratio < 1)
                image = "potrait";
            Console.WriteLine("Image is : "+ image);
        }
    }
}
