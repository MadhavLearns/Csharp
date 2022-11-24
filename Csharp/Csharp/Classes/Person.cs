using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static int Age = 20;

        public void Initialize()
        {
            Console.WriteLine("My Name is "+ FirstName+" "+ LastName);
        }
    }
}
