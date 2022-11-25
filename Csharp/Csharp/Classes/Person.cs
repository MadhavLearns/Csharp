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

        public DateTime BirthDate { get; private set; }

        public int AgeNew
        {
            get { var timespan = DateTime.Today - BirthDate;
                var years = timespan.Days / 365;
                return years;
                }
        }

        public Person()
        {

        }

        public Person(DateTime datetime)
        {
            BirthDate = datetime;
        }

        public void Initialize()
        {
            Console.WriteLine("My Name is "+ FirstName+" "+ LastName);
        }
    }
}
