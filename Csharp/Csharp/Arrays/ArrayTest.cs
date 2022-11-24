using Csharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Arrays
{
    public class ArrayTest
    {
        public void TestArrays()
        {
            int[] numbers = new int[3];
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            bool[] boolean = new bool[3];
            Console.WriteLine(boolean[0]);
            Console.WriteLine(boolean[1]);
            Console.WriteLine(boolean[2]);

            Person[] person = new Person[2];
            person[0] = new Person() { FirstName = "Madhav", LastName = "Sai" };
            Console.WriteLine(person[0].FirstName + " "+person[0].LastName);
            //Console.WriteLine(person[1].firstName + " " + person[1].lastName);
        }
    }
}
