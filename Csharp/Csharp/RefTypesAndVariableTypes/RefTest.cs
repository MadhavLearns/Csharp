using Csharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.RefTypesAndVariableTypes
{
    public class RefTest
    {
        public void TestRefAndVarTypes()
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0} and b: {1}",a,b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("a[0]: {0} and b[0]: {1}", array1[0], array2[0]));

            var number = 1; // this scope is different from number in Increment method so will have different copy of memory
            Increment(number);
            Console.WriteLine("number: " + number);

            Person p = new Person(); // since its a ref type it will have memory address mapped to p variable and its the same address sent to MakeOld Method as well
            MakeOld(p);
            Console.WriteLine("Person Age: "+Person.Age);
        }

        public void Increment(int number)
        {
            number += 10;// this scope is different from number in Main method so will have different copy of memory
            Console.WriteLine("number in method: "+number);
        }

        public void MakeOld(Person person)
        {
            Person.Age += 10;
        }
    }
}
