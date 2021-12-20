using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Arrays
{
    class ArrayTest1
    {
        public void RunProgram()
        {
            var numbers = new int[] { 3, 6, 8, 11, 14 };

            //Length
            Console.WriteLine("Length :"+numbers.Length);

            //IndexOf()
            //These are all static methods and only accessible through Array class
            //gets you the index of a number thats available in a 1D array
            var index = Array.IndexOf(numbers, 8);
            Console.WriteLine("Index of 8: "+index);

            //clear()
            //set the values to zero of the indexes
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of clear");
            foreach (var item in numbers)
                Console.WriteLine(item);

            //Copy()
            //Copies the values of an array to another array
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of copy");
            foreach(var item in another)
                Console.WriteLine(item);

            //sort()
            //Sorts the array
            Array.Sort(numbers);
            Console.WriteLine("Effect of sort");
            foreach (var item in numbers)
                Console.WriteLine(item);

            //Reverse
            //Reverses the items of an array
            Array.Reverse(numbers);
            Console.WriteLine("Effect of reverse");
            foreach (var item in numbers)
                Console.WriteLine(item);
        }
    }
}
